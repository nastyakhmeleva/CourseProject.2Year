using System;
using System.Linq;
using System.Windows.Forms;

namespace project1
{
    public partial class FormAddStore : Form
    {
        public FormChangeBookExemplar ParentChangeBookExemplar;
        public FormAddBookExemplar ParentAddBookExemplar;
        public static ModelContainer model = new ModelContainer();
        public FormAddStore()
        {
            InitializeComponent();
            ShowCombobox();
        }

        public void ShowCombobox()
        {
            comboBoxCity.Items.Clear();
            foreach (City city in model.CitySet)
            {
                comboBoxCity.Items.Add(city.Name);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление нового магазина?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                if (ParentAddBookExemplar == null)
                    ParentChangeBookExemplar.Show();
                else
                    ParentAddBookExemplar.Show();
                Close();
            }
        }

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            FormAddCity newForm = new FormAddCity();
            newForm.ParentAddStore = this;
            newForm.Show();
            Hide();
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            var stores = model.StoreSet.Where(u => u.Name.Contains(textBoxName.Text)&&u.City.Name.Contains(comboBoxCity.SelectedText)).ToList();
            if (stores.Count <= 0)
            {
                if ((textBoxName.Text != "") && (textBoxStreet.Text != "") && (textBoxHouse.Text != "") &&
                    (comboBoxCity.SelectedItem != null))
                {
                    Store store = new Store()
                    {
                        Name = textBoxName.Text,
                        Address = textBoxStreet.Text + " " + textBoxHouse.Text
                    };

                    City city = model.CitySet.Find(
                        model.CitySet.Where(x => x.Name.Contains(comboBoxCity.Text)).ToList()[0]
                            .Id);
                    city.Store.Add(store);

                    model.StoreSet.Add(store);
                    model.SaveChanges();

                    if (ParentAddBookExemplar == null)
                    {
                        ParentChangeBookExemplar.ShowComboBoxes();
                        ParentChangeBookExemplar.Show();
                    }
                    else
                    {
                        ParentAddBookExemplar.ShowComboBoxes();
                        ParentAddBookExemplar.Show();
                    }

                    Close();
                }
                else
                {
                    if (textBoxName.Text == "") MessageBox.Show("Вы не указали название магазина");
                    if (textBoxStreet.Text == "") MessageBox.Show("Вы не указали название улицы");
                    if (textBoxHouse.Text == "") MessageBox.Show("Вы не указали номер дома");
                    if (comboBoxCity.SelectedItem == null) MessageBox.Show("Вы не выбрали город");
                }
            }
            else MessageBox.Show("Магазин с указанным названием уже существует");
        }

        private void FormAddStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ParentAddBookExemplar == null)
                ParentChangeBookExemplar.Show();
            else
                ParentAddBookExemplar.Show();
        }
    }
}
