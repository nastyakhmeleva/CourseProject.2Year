using System;
using System.Linq;
using System.Windows.Forms;

namespace project1
{
    public partial class FormChangeBook : Form
    {
        public FormAdminMainMenu ParentAdminMainMenu;
        public static ModelContainer model = new ModelContainer();
        public static Books book;
        public FormChangeBook(int Id)
        {
            InitializeComponent();
            book = model.BooksSet.Find(Id);
            ShowComboBoxes();
            ShowTextBoxes();
        }

        public void ShowComboBoxes()
        {
            comboBoxAuthor.Items.Clear();
            comboBoxAuthor.Items.Add(book.Author.Surname + " " + book.Author.Name + " " + book.Author.SecondName + " - " +
                                     book.Author.Country1.Name);
            foreach (Author author in model.AuthorSet)
            {
                if (author.Id != book.Author.Id)
                {
                    comboBoxAuthor.Items.Add(author.Surname + " " + author.Name + " " + author.SecondName + " - " +
                                             author.Country1.Name);
                }
            }

            comboBoxAuthor.SelectedItem = comboBoxAuthor.Items[0];

            comboBoxGenre.Items.Clear();
            comboBoxGenre.Items.Add(book.Genre.Name);
            foreach (Genre genre in model.GenreSet)
            {
                if (genre.Id != book.Genre.Id)
                    comboBoxGenre.Items.Add(genre.Name);
            }

            comboBoxGenre.SelectedItem = comboBoxGenre.Items[0];
        }

        public void ShowTextBoxes()
        {
            textBoxTitle.Text = book.Name;
            textBoxBookDescription.Text = book.Description;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить изменение информации о книге?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                ParentAdminMainMenu.Show();
                this.Close();
            }
        }

        private void buttonChangeBook_Click(object sender, EventArgs e)
        {
            if ((textBoxTitle.Text != "")&&(comboBoxAuthor.SelectedItem!=null)&&(comboBoxGenre.SelectedItem!=null))
            {
                if (book.Name != textBoxTitle.Text)
                    book.Name = textBoxTitle.Text;

                if (comboBoxAuthor.SelectedIndex != 0)
                    book.Author = model.AuthorSet.Find(model.AuthorSet.Where(x =>
                        (x.Surname + " " + x.Name + " " + x.SecondName + " - " + x.Country1.Name).Contains(
                            comboBoxAuthor
                                .Text)).ToList()[0].Id);

                if (comboBoxGenre.SelectedIndex != 0)
                    book.Genre = model.GenreSet.Find(model.GenreSet.Where(x =>
                        x.Name.Contains(comboBoxGenre.Text)).ToList()[0].Id);

                if (book.Description != textBoxBookDescription.Text)
                    book.Description = textBoxBookDescription.Text;

                model.SaveChanges();

                ParentAdminMainMenu.ShowTable();
                ParentAdminMainMenu.Show();
                Close();
            }
            else
            {
                if (textBoxTitle.Text=="") MessageBox.Show("Вы не указали название книги");
                if (comboBoxAuthor.SelectedItem == null) MessageBox.Show("Вы не указали автора");
                if (comboBoxGenre.SelectedItem == null) MessageBox.Show("Вы не указали жанр");
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor newForm = new FormAddAuthor();
            newForm.ParentChangeBook = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre newForm = new FormAddGenre();
            newForm.ParentChangeBook = this;
            newForm.Show();
            Hide();
        }

        private void FormChangeBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAdminMainMenu.Show();
        }
    }
}
