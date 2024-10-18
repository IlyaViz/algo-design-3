using ClassLibrary;


namespace WinFormsApp
{
    public static class BDGenerator
    {
        private static string _allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static Random r = new Random();

        public static void AddStrData(SparseIndex bd, int count)
        {
            int current = 0;
            int added = 0;
            string strData;
            
            while (added < count)
            {
                strData = GenerateStr();

                if (bd.Add(current, strData))
                {
                    added++;
                }

                current++;
            }
        }

        private static string GenerateStr()
        {
            string result = "";
            char nextChar;
            int length = r.Next(1, _allowedChars.Length);

            for (int i = 0; i < length; i++)
            {
                nextChar = _allowedChars[r.Next(length)];
                result += nextChar;
            }

            return result;
        }
    }
}
