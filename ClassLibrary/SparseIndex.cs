using System.Diagnostics;
using System.Text;

namespace ClassLibrary
{
    public class SparseIndex
    {
        private const int _blocks = 10;
        private const int _blockSize = 30*1024;
        private const string _filesFolder = "files/";
        private const string _blockTemplateName = "block.txt";
        private const string _tempPath = $"{_filesFolder}temp.txt";
        private const string _extendedBlockPath = $"{_filesFolder}extended_block.txt";

        public SparseIndex()
        {
            FileInit();
        }

        private void FileInit()
        {
            if (!Directory.Exists(_filesFolder))
            {
                Directory.CreateDirectory(_filesFolder);
            }

            for (int i = 1; i <= _blocks; i++)
            {
                string path = GetBlockPath(i);

                if (!File.Exists(path))
                {
                    using (File.Create(path)) ;
                }
            }

            if (!File.Exists(_extendedBlockPath))
            {
                using (File.Create(_extendedBlockPath)) ;
            }
        }

        public (string, int) Search(int pk)
        {
            int blockNumber = GetBlockNumber(pk);
            List<string> rows = ReadBlock(blockNumber);
            (string, int) result = BinarySearch(pk, rows);

            int comparisons = result.Item2;

            if (result.Item1 is not null)
            {
                return (GetData(result.Item1), comparisons);
            }

            rows = ReadBlock(-1);
            result = BinarySearch(pk, rows);

            comparisons += result.Item2;

            if (result.Item1 is not null)
            {
                return (GetData(result.Item1), comparisons);
            }

            return (null, comparisons);
        }

        public bool Add(int pk, string data)
        {
            int blockNumber = GetBlockNumber(pk);
            string path = GetBlockPath(blockNumber);
            string newRow = BuildRow(pk, data);

            List<string> rows = ReadBlock(blockNumber);
            rows.AddRange(ReadBlock(-1));

            if (rows.Exists(row => GetPk(row) == pk))
            {
                return false;
            }

            if (_blockSize - new FileInfo(path).Length > newRow.Length)
            {
                rows = ReadBlock(blockNumber);
            }
            else
            {
                path = _extendedBlockPath;
                rows = ReadBlock(-1);
            }

            rows.Add(newRow);
            rows = rows.OrderBy(GetPk).ToList();

            using (StreamWriter file = new StreamWriter(_tempPath))
            {
                foreach (string row in rows)
                {
                    file.Write(row);
                }
            }

            File.Delete(path);
            File.Move(_tempPath, path);

            return true;
        }

        public int Edit(int pk, int newPk, string newData)
        {
            if (newData is null || newData == "")
            {
                newData = Search(pk).Item1;

                if (newData is null)
                {
                    return -1;
                }
            }

            if (!Remove(pk))
            {
                return -1;
            }

            if (!Add(newPk, newData))
            {
                Add(pk, newData);

                return 0;
            }

            return 1;
        }

        public bool Remove(int pk)
        {
            int blockNumber = GetBlockNumber(pk);
            string path = GetBlockPath(blockNumber);
            bool found = false;
            List<string> rows = ReadBlock(blockNumber);

            found = rows.Any(row => GetPk(row) == pk);

            if (!found)
            {
                path = _extendedBlockPath;
                rows = ReadBlock(-1);
                found = rows.Any(row => GetPk(row) == pk);

                if (!found)
                {
                    return false;
                }
            }

            using (StreamWriter file = new StreamWriter(_tempPath))
            {
                foreach (string row in rows.Where(row => GetPk(row) != pk))
                {
                    file.Write(row);
                }
            }

            File.Delete(path);
            File.Move(_tempPath, path);

            return true;
        }

        public void Clear()
        {
            string path;

            for (int i = 1; i <= _blocks; i++)
            {
                path = GetBlockPath(i);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }

            if (File.Exists(_extendedBlockPath))
            {
                File.Delete(_extendedBlockPath);
            }

            FileInit();
        }

        public List<string> ReadBlock(int blockNumber)
        {
            List<string> rows = new List<string>();
            string data;

            string path = blockNumber == -1 ? _extendedBlockPath : GetBlockPath(blockNumber);

            using (StreamReader file = new StreamReader(path))
            {
                data = file.ReadToEnd();
            }

            return rows = data.Split('\n').Where(row => row.Length != 0).Select(row => $"{row}\n").ToList();
        }

        private (string, int) BinarySearch(int pk, List<string> rows)
        {
            int left = 0;
            int right = rows.Count - 1;
            int comparisons = 0;

            while (left <= right)
            {
                comparisons++;

                int mid = left + (right - left) / 2;

                comparisons++;

                if (GetPk(rows[mid]) == pk)
                {
                    return (rows[mid], comparisons);
                }

                comparisons++;

                if (GetPk(rows[mid]) < pk)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return (null, comparisons);
        }

        private int GetPk(string row)
        {
            return int.Parse(row.Split(' ')[0]);
        }

        private string BuildRow(int pk, string data)
        {
            return $"{pk} {data}\n";
        }

        private string GetData(string row)
        {
            return row.Split(' ')[1].Replace("\n", string.Empty);
        }

        private int GetBlockNumber(int pk)
        {
            int value = Math.Abs(pk.GetHashCode() % (_blocks + 1));

            if (value == 0)
            {
                return 1;
            }

            return value;
        }

        private string GetBlockPath(int blockNumber)
        {
            return $"{_filesFolder}{blockNumber}{_blockTemplateName}";
        }
    }


}
