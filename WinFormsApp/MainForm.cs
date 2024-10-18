using ClassLibrary;


namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private SparseIndex bd = new SparseIndex();

        public MainForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int pk;

            if (int.TryParse(pkTextBox.Text, out pk))
            {
                (string, int) result = bd.Search(pk);

                if (result.Item1 is not null)
                {
                    resultTextBox.Text = result.Item1;
                }
                else
                {
                    resultTextBox.Text = "Не знайдено";
                }

                lastComparisons.Text = result.Item2.ToString();
            }
            else
            {
                resultTextBox.Text = "Введіть коректний ключ";
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int pk;

            if (!int.TryParse(pkTextBox.Text, out pk))
            {
                resultTextBox.Text = "Введіть коректний ключ";
                return;
            }
            if (dataTextBox.Text.Length == 0)
            {
                resultTextBox.Text = "Введіть дані";
                return;
            }

            bool result = bd.Add(pk, dataTextBox.Text);

            if (result)
            {
                resultTextBox.Text = "Успіх";
            }
            else
            {
                resultTextBox.Text = "Вже існує";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int pk;

            if (int.TryParse(pkTextBox.Text, out pk))
            {
                bool result = bd.Remove(pk);

                if (result)
                {
                    resultTextBox.Text = "Успіх";
                }
                else
                {
                    resultTextBox.Text = "Не знайдено";
                }
            }
            else
            {
                resultTextBox.Text = "Введіть коректний ключ";
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            bd.Clear();
            resultTextBox.Text = "Очищено";
        }

        private void randomAddButton_Click(object sender, EventArgs e)
        {
            int count;

            if (int.TryParse(randomCount.Text, out count))
            {
                BDGenerator.AddStrData(bd, count);

                resultTextBox.Text = "Дані додано";
            }
            else
            {
                resultTextBox.Text = "Введіть коректне значення";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int pk;
            int newPk;

            if (!int.TryParse(pkTextBox.Text, out pk))
            {
                resultTextBox.Text = "Введіть коректний ключ";
                return;
            }

            if (!int.TryParse(newPkTextBox.Text, out newPk))
            {
                newPk = pk;
            }

            int result = bd.Edit(pk, newPk, dataTextBox.Text);

            if (result == 1)
            {
                resultTextBox.Text = "Дані змінено";
            } else if (result == -1) {
                resultTextBox.Text = "Ключ не знайдено";
            } else
            {
                resultTextBox.Text = "Дані змінено, ключ вже існує";
            }
        }
    }
}

