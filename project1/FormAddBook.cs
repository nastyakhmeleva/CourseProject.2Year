using System;
using System.Windows.Forms;
using System.Linq;


namespace project1
{
    public partial class FormAddBook : Form
    {
        public FormAdminMainMenu ParentAdminMainMenu;
        public static ModelContainer model = new ModelContainer();

        public FormAddBook()
        {
            InitializeComponent();
            ShowComboBoxes();
        }

        public void ShowComboBoxes()
        {
            comboBoxAuthor.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                comboBoxAuthor.Items.Add(author.Surname + " " + author.Name + " " + author.SecondName + " - " +
                                         author.Country1.Name);
            }

            comboBoxGenre.Items.Clear();
            foreach (Genre genre in model.GenreSet)
            {
                comboBoxGenre.Items.Add(genre.Name);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление новой книги?",
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

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor newForm = new FormAddAuthor();
            newForm.ParentAddBook = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre newForm = new FormAddGenre();
            newForm.ParentAddBook = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            var books= model.BooksSet.Where(u => u.Name.Contains(textBoxTitle.Text)).ToList();
            if (books.Count <= 0)
            {
                if ((textBoxTitle.Text != "") && (comboBoxAuthor.SelectedItem != null) &&
                    (comboBoxGenre.SelectedItem != null))
                {
                    Books book = new Books()
                    {
                        Name = textBoxTitle.Text,
                        Description = textBoxBookDescription.Text,
                        Author = model.AuthorSet.Find(model.AuthorSet.Where(x =>
                            (x.Surname + " " + x.Name + " " + x.SecondName + " - " + x.Country1.Name).Contains(
                                comboBoxAuthor.Text)).ToList()[0].Id),
                        Genre = model.GenreSet.Find(
                            model.GenreSet.Where(x => x.Name.Contains(comboBoxGenre.Text)).ToList()[0].Id),
                    };
                    model.BooksSet.Add(book);
                    model.SaveChanges();

                    ParentAdminMainMenu.ShowTable();
                    ParentAdminMainMenu.Show();
                    Close();
                }
                else
                {
                    if (textBoxTitle.Text == "") MessageBox.Show("Вы не указали название книги");
                    if (comboBoxAuthor.SelectedItem == null) MessageBox.Show("Вы не выбрали автора");
                    if (comboBoxGenre.SelectedItem == null) MessageBox.Show("Вы не выбрали жанр");
                }
            }
            else
            {
                MessageBox.Show("Книга с указанным названием уже существует");
                return;
            }
        }

        private void FormAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAdminMainMenu.Show();
        }
    }
}
