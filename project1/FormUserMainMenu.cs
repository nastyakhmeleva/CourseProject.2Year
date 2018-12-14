using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace project1
{
    public partial class FormUserMainMenu : Form
    {
        public FormAuthorization ParentAuthorization;
        public static ModelContainer model = new ModelContainer();
        public FormUserMainMenu()
        {
            InitializeComponent();
            ShowTable();
        }

        public void ShowTable()
        {
            dataGridViewB.Rows.Clear();

            List<string[]> data = new List<string[]>();

            foreach (Books book in model.BooksSet)
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = book.Id.ToString();
                data[data.Count - 1][1] = book.Name;
                data[data.Count - 1][2] = book.Author.Surname + " " + book.Author.Name + " " + book.Author.SecondName;
                data[data.Count - 1][3] = book.Genre.Name;

                dataGridViewB.Rows.Add(data[data.Count - 1]);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormFullInfo newForm = new FormFullInfo(Int32.Parse(dataGridViewB.CurrentRow.Cells[0].Value.ToString()));
            newForm.ParentUserMainMenu = this;
            newForm.Show();
            Hide();
        }

        private void FormUserMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAuthorization.Show();
        }

        private void buttonSearching_Click(object sender, EventArgs e)
        {
            if (textBoxSearching.Text != "")
            {
                string search = textBoxSearching.Text;
                int id = 0;

                Int32.TryParse(search, out id);

                var books = model.BooksSet.Where(x =>
                    x.Name == search || x.Genre.Name == search || x.Author.Name == search ||
                    x.Author.SecondName == search || x.Author.Surname == search || id == x.Id).ToList();

                dataGridViewB.Rows.Clear();

                List<string[]> data = new List<string[]>();

                foreach (Books book in books)
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = book.Id.ToString();
                    data[data.Count - 1][1] = book.Name;
                    data[data.Count - 1][2] =
                        book.Author.Surname + " " + book.Author.Name + " " + book.Author.SecondName;
                    data[data.Count - 1][3] = book.Genre.Name;

                    dataGridViewB.Rows.Add(data[data.Count - 1]);
                }
            }
            else MessageBox.Show("Поиск невозможно осуществить без ключевых слов");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearching.Text = "";
            ShowTable();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application newExcel = new Microsoft.Office.Interop.Excel.Application();
            newExcel.Application.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (Worksheet)newExcel.ActiveSheet;
            newExcel.Columns.ColumnWidth = 25;

            newExcel.Cells[1, 1] = "ID";
            newExcel.Cells[1, 2] = "Название";
            newExcel.Cells[1, 3] = "Автор";
            newExcel.Cells[1, 4] = "Жанр";

            int cellRowIndex = 2;
            int cellColumnIndex = 1;
            for (int i = 0; i < dataGridViewB.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewB.Columns.Count; j++)
                {
                    worksheet.Cells[cellRowIndex, cellColumnIndex] =
                        dataGridViewB.Rows[i].Cells[j].Value.ToString();
                    cellColumnIndex++;
                }

                cellColumnIndex = 1;
                cellRowIndex++;
            }

            newExcel.Visible = true;
        }
    }
}
