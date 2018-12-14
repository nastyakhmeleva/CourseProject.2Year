using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace project1
{
    public partial class FormBookExemplar : Form
    {
        public FormAdminMainMenu ParentAdminMainMenu;

        public static ModelContainer model = new ModelContainer();
        public static Books book = new Books();

        public FormBookExemplar(int id)
        {
            InitializeComponent();
            book = model.BooksSet.Find(id);

            labelTitle.Text = book.Name;
            labelAuthor.Text = book.Author.Surname+" "+book.Author.Name+" "+book.Author.SecondName;
            labelGenre.Text = book.Genre.Name;
            labelBookDescription.Text = book.Description;
            labelGenreDescription.Text = book.Genre.Description;

            ShowTable();
        }

        public void ShowTable()
        {
            dataGridViewBE.Rows.Clear();
            model = new ModelContainer();
            
            List<string[]> data = new List<string[]>();
            var bookexemplar = model.BookExemplarSet.Where(x => x.Books.Id == book.Id);
            foreach (BookExemplar bookExemplar in bookexemplar)
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = bookExemplar.Id.ToString();
                data[data.Count - 1][1] = bookExemplar.Year.ToString();
                data[data.Count - 1][2] = bookExemplar.Series.Name;
                data[data.Count - 1][3] = bookExemplar.Series.CoverType;
                data[data.Count - 1][4] = bookExemplar.Number.ToString();
                data[data.Count - 1][5] = bookExemplar.Store.Name;
                data[data.Count - 1][6] = bookExemplar.Store.City.Name+" "+bookExemplar.Store.Address;

                dataGridViewBE.Rows.Add(data[data.Count - 1]);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddBookExemplar newForm = new FormAddBookExemplar(book);
            newForm.ParentBookExemplar = this;
            newForm.Show();
            Hide();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeBookExemplar newForm =
                    new FormChangeBookExemplar(Int32.Parse(dataGridViewBE.CurrentRow.Cells[0].Value.ToString()));
                newForm.ParentBookExemplar = this;
                newForm.Show();
                Hide();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Строка не выбрана");
            }
        }

        private void FormBookExemplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAdminMainMenu.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dataGridViewBE.CurrentRow.Cells[0].Value.ToString());

                model.BookExemplarSet.Remove(model.BookExemplarSet.Where(x => x.Id == id).ToList()[0]);
                model.SaveChanges();
                ShowTable();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Строка не выбрана");
            }
        }

        private void buttonSearching_Click(object sender, EventArgs e)
        {
            if (textBoxSearching.Text != "")
            {
                string search = textBoxSearching.Text;
                int id = 0;

                Int32.TryParse(search, out id);
                var Exemplar = model.BookExemplarSet.Where(x => x.Books.Id == book.Id);
                var bookexemplar = Exemplar.Where(x =>
                        x.Year.ToString() == search || x.Series.Name == search || x.Series.CoverType == search ||
                        x.Store.Name == search || x.Store.City.Name == search || x.Store.Address == search ||
                        id == x.Id)
                    .ToList();

                dataGridViewBE.Rows.Clear();

                List<string[]> data = new List<string[]>();

                foreach (BookExemplar bookExemplar in bookexemplar)
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = bookExemplar.Id.ToString();
                    data[data.Count - 1][1] = bookExemplar.Year.ToString();
                    data[data.Count - 1][2] = bookExemplar.Series.Name;
                    data[data.Count - 1][3] = bookExemplar.Series.CoverType;
                    data[data.Count - 1][4] = bookExemplar.Number.ToString();
                    data[data.Count - 1][5] = bookExemplar.Store.Name;
                    data[data.Count - 1][6] = bookExemplar.Store.City.Name + " " + bookExemplar.Store.Address;

                    dataGridViewBE.Rows.Add(data[data.Count - 1]);
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
            newExcel.Cells[1, 2] = "Год публикации";
            newExcel.Cells[1, 3] = "Серия";
            newExcel.Cells[1, 4] = "Тип обложки";
            newExcel.Cells[1, 5] = "Количество";
            newExcel.Cells[1, 6] = "Магазин";
            newExcel.Cells[1, 7] = "Адрес";

            int cellRowIndex = 2;
            int cellColumnIndex = 1;
            for (int i = 0; i < dataGridViewBE.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewBE.Columns.Count; j++)
                {
                    worksheet.Cells[cellRowIndex, cellColumnIndex] =
                        dataGridViewBE.Rows[i].Cells[j].Value.ToString();
                    cellColumnIndex++;
                }

                cellColumnIndex = 1;
                cellRowIndex++;
            }

            newExcel.Visible = true;
        }
    }
}
