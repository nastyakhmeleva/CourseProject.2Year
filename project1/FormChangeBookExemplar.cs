using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project1.FormBookExemplar;

namespace project1
{
    public partial class FormChangeBookExemplar : Form
    {
        public FormBookExemplar ParentBookExemplar;
        public static ModelContainer model = new ModelContainer();
        public static BookExemplar bookexemplar;

        public FormChangeBookExemplar(int id)
        {
            InitializeComponent();
            bookexemplar = model.BookExemplarSet.Find(id);
            labelTitle.Text = book.Name;
            labelAuthor.Text = book.Author.Surname + " " + book.Author.Name + " " + book.Author.SecondName;
            labelGenre.Text = book.Genre.Name;
            labelBookDescription.Text = book.Description;
            labelGenreDescription.Text = book.Genre.Description;
            ShowComboBoxes();
            ShowTextBoxes();
        }

        public void ShowComboBoxes()
        {
            comboBoxSeries.Items.Clear();
            comboBoxSeries.Items.Add(bookexemplar.Series.Name);
            foreach (Series series in model.SeriesSet)
            {
                if (series.Id != bookexemplar.Series.Id)
                    comboBoxSeries.Items.Add(series.Name);
            }

            comboBoxSeries.SelectedItem = comboBoxSeries.Items[0];


            comboBoxStore.Items.Clear();
            comboBoxStore.Items.Add(bookexemplar.Store.Name+" "+bookexemplar.Store.City.Name);
            foreach (Store store in model.StoreSet)
            {
                if (store.Id != bookexemplar.Store.Id)
                    comboBoxStore.Items.Add(store.Name+" "+store.City.Name);
            }

            comboBoxStore.SelectedItem = comboBoxStore.Items[0];
        }

        public void ShowTextBoxes()
        {
            textBoxNumber.Text = bookexemplar.Number.ToString();
            textBoxYear.Text = bookexemplar.Year.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить изменение информации об экземпляре книги?",
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

        private void buttonAddSeries_Click(object sender, EventArgs e)
        {
            FormAddSeries newForm=new FormAddSeries();
            newForm.ParentChangeBookExemplar = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            FormAddStore newForm=new FormAddStore();
            newForm.ParentChangeBookExemplar = this;
            newForm.Show();
            Hide();
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            if ((comboBoxSeries.SelectedItem != null) && (comboBoxStore.SelectedItem != null))
            {
                if (bookexemplar.Year.ToString() != textBoxNumber.Text)
                {
                    try
                    {
                        if (Int32.Parse(textBoxYear.Text) <= DateTime.Now.Year)
                        {
                            bookexemplar.Year = Int32.Parse(textBoxYear.Text);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Вы не указали год");
                        return;
                    }

                    if (bookexemplar.Number.ToString() != textBoxNumber.Text)
                        try
                        {
                            bookexemplar.Number = Int32.Parse(textBoxNumber.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Вы не указали количество");
                            return;
                        }
                }

                if (comboBoxSeries.SelectedIndex != 0)
                    bookexemplar.Series =
                        model.SeriesSet.Find(
                            model.SeriesSet.Where(x => x.Name.Contains(comboBoxSeries.Text)).ToList()[0].Id);

                if (comboBoxStore.SelectedIndex != 0)
                    bookexemplar.Store =
                        model.StoreSet.Find(model.StoreSet.Where(x => (x.Name+" "+x.City.Name).Contains(comboBoxStore.Text)).ToList()[0]
                            .Id);

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

        private void FormChangeBookExemplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentBookExemplar.Show();
        }
    }
}
