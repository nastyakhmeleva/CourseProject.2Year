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
    public partial class FormAddCity : Form
    {
        public FormAddStore ParentAddStore;
        public static ModelContainer model = new ModelContainer();
        public FormAddCity()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление нового города?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                ParentAddStore.Show();
                Close();
            }
        }

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            var stores = model.StoreSet.Where(u => u.Name.Contains(textBoxTitle.Text)).ToList();
            if (stores.Count <= 0)
            {
                if (textBoxTitle.Text != "")
                {
                    City cities = new City()
                    {
                        Name = textBoxTitle.Text
                    };
                    model.CitySet.Add(cities);
                    model.SaveChanges();

                    ParentAddStore.ShowCombobox();
                    ParentAddStore.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы не указали название города");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Магазин с таким названием уже существует");
                return;
            }
        }

        private void FormAddCity_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAddStore.Show();
        }
    }
}
