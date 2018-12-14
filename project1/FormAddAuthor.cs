using System;
using System.Linq;
using System.Windows.Forms;

namespace project1
{
    public partial class FormAddAuthor : Form
    {
        public FormChangeBook ParentChangeBook;
        public FormAddBook ParentAddBook;
        public static ModelContainer model = new ModelContainer();

        public FormAddAuthor()
        {
            InitializeComponent();
            ShowComboboxes();
        }

        public void ShowComboboxes()
        {
            comboBoxCountry.Items.Clear();
            foreach (Country country in model.CountrySet)
            {
                comboBoxCountry.Items.Add(country.Name);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление нового автора?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                if (ParentAddBook == null)
                    ParentChangeBook.Show();
                else
                    ParentAddBook.Show();

                Close();
            }
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            FormAddCountry newForm = new FormAddCountry();
            newForm.ParentAddAuthor = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            var authors = model.AuthorSet.Where(x =>
                x.Name.Contains(textBoxName.Text) && x.Surname.Contains(textBoxSurname.Text) &&
                x.SecondName.Contains(textBoxSecondName.Text)).ToList();
            if (authors.Count <= 0)
            {
                if ((textBoxSurname.Text != "") && (comboBoxCountry.SelectedItem != null))
                {
                    Author author = new Author()
                    {
                        Name = textBoxName.Text,
                        SecondName = textBoxSecondName.Text,
                        Surname = textBoxSurname.Text
                    };

                    Country country =
                        model.CountrySet.Find(
                            model.CountrySet.Where(x => x.Name.Contains(comboBoxCountry.Text)).ToList()[0]
                                .Id);

                    country.Author.Add(author);

                    model.AuthorSet.Add(author);
                    model.SaveChanges();

                    if (ParentAddBook == null)
                    {
                        ParentChangeBook.ShowComboBoxes();
                        ParentChangeBook.Show();
                    }
                    else
                    {
                        ParentAddBook.ShowComboBoxes();
                        ParentAddBook.Show();
                    }

                    Close();
                }
                else
                {
                    if (textBoxSurname.Text == "")
                        MessageBox.Show("Вы не указали фамилию");
                    if (comboBoxCountry.Text == "")
                        MessageBox.Show("Вы не выбрали страну");
                }
            }
            else
            {
                MessageBox.Show("Автор с таким именем уже существует");
                return;
            }
        }

        private void FormAddAuthor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ParentAddBook == null)
                ParentChangeBook.Show();
            else
                ParentAddBook.Show();
        }
    }
}
