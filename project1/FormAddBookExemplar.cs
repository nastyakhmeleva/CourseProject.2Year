using System;
using System.Linq;
using System.Windows.Forms;
using static project1.FormBookExemplar;
using FormatException = System.FormatException;

namespace project1
{
    public partial class FormAddBookExemplar : Form
    {
        public FormBookExemplar ParentBookExemplar;
        public static ModelContainer model = new ModelContainer();
        public static Books book;

        public FormAddBookExemplar(Books b)
        {
            book = model.BooksSet.Find(b.Id);
            InitializeComponent();
            labelTitle.Text = book.Name;
            labelAuthor.Text = book.Author.Surname + " " + book.Author.Name + " " + book.Author.SecondName;
            labelGenre.Text = book.Genre.Name;
            labelBookDescription.Text = book.Description;
            labelGenreDescription.Text = book.Genre.Description;
            ShowComboBoxes();
        }

        public void ShowComboBoxes()
        {
            comboBoxSeries.Items.Clear();
            foreach (Series series in model.SeriesSet)
            {
                comboBoxSeries.Items.Add(series.Name);
            }

            comboBoxStore.Items.Clear();
            foreach (Store store in model.StoreSet)
            {
                comboBoxStore.Items.Add(store.Name+" "+store.City.Name);
            }
        }

        private void buttonAddSeries_Click(object sender, EventArgs e)
        {
            FormAddSeries newForm = new FormAddSeries();
            newForm.ParentBookExemplar = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            FormAddStore newForm = new FormAddStore();
            newForm.ParentAddBookExemplar = this;
            newForm.Show();
            Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление информации о новом экземпляре?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                ParentBookExemplar.Show();
                Close();
            }
        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            if ((comboBoxSeries.SelectedItem != null) && (comboBoxStore.SelectedItem != null))
            {
                BookExemplar bookexemplar = new BookExemplar();
                {
                    try
                    {
                        if (Int32.Parse(textBoxYear.Text) <= DateTime.Now.Year)
                        {
                            bookexemplar.Year = Int32.Parse(textBoxYear.Text);
                        }
                        else
                        {
                            MessageBox.Show("Неверно указан год");
                            return;
                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверно указан год");
                        return;
                    }

                    try
                    {
                        bookexemplar.Number = Int32.Parse(textBoxNumber.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверно указано количество");
                        return;
                    }
                }

                Series series =
                    model.SeriesSet.Find(
                        model.SeriesSet.Where(x => x.Name.Contains(comboBoxSeries.Text)).ToList()[0].Id);
                series.BookExemplar.Add(bookexemplar);
                Store store =
                    model.StoreSet.Find(model.StoreSet.Where(x => (x.Name+" "+x.City.Name).Contains(comboBoxStore.Text)).ToList()[0].Id);
                store.BookExemplar.Add(bookexemplar);

                book.BookExemplar.Add(bookexemplar);

                model.BookExemplarSet.Add(bookexemplar);
                model.SaveChanges();

                ParentBookExemplar.ShowTable();
                ParentBookExemplar.Show();
                Close();
            }
            else
            {
                if (comboBoxSeries.SelectedItem == null) MessageBox.Show("Вы не указали серию");
                if (comboBoxStore.SelectedItem == null) MessageBox.Show("Вы не указали магазин");
            }
        }

        private void FormAddBookExemplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentBookExemplar.Show();
        }
    }
}
