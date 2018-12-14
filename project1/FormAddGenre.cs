using System;
using System.Linq;
using System.Windows.Forms;

namespace project1
{
    public partial class FormAddGenre : Form
    {
        public FormAddBook ParentAddBook;
        public FormChangeBook ParentChangeBook;
        public static ModelContainer model = new ModelContainer();
        public FormAddGenre()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление нового жанра?",
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
                this.Close();
            }
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            var genre = model.GenreSet.Where(u => u.Name==textBoxTitle.Text).ToList();
            if (genre.Count <= 0)
            {
                if (textBoxTitle.Text != "")
                {
                    Genre genres = new Genre()
                    {
                        Name = textBoxTitle.Text,
                        Description = textBoxDescription.Text
                    };
                    model.GenreSet.Add(genres);
                    model.SaveChanges();

                    if (ParentAddBook == null)
                    {
                        ParentChangeBook.Show();
                        ParentChangeBook.ShowComboBoxes();
                    }
                    else
                    {
                        ParentAddBook.ShowComboBoxes();
                        ParentAddBook.Show();
                    }

                    this.Close();
                }
                else MessageBox.Show("Вы не указали название жанра");
            }
            else MessageBox.Show("Жанр с указанным названием уже существует");
        }

        private void FormAddGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ParentAddBook == null)
                ParentChangeBook.Show();
            else
                ParentAddBook.Show();
        }
    }
}
