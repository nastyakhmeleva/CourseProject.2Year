using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class FormAddCountry : Form
    {
        public FormAddAuthor ParentAddAuthor;
        public static ModelContainer model = new ModelContainer();
        public FormAddCountry()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление новой страны?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                ParentAddAuthor.Show();
                Close();
            }
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            var countrie = model.CountrySet.Where(u => u.Name.Contains(textBoxTitle.Text)).ToList();
            if (countrie.Count <= 0)
            {
                if (textBoxTitle.Text != "")
                {
                    Country countries = new Country()
                    {
                        Name = textBoxTitle.Text
                    };
                    model.CountrySet.Add(countries);
                    model.SaveChanges();

                    ParentAddAuthor.ShowComboboxes();
                    ParentAddAuthor.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы не указали название страны");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Страна с указанным названием уже существует");
                return;
            }
        }

        private void FormAddCountry_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAddAuthor.Show();
        }
    }
}
