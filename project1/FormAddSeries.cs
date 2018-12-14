using System;
using System.Linq;
using System.Windows.Forms;

namespace project1
{
    public partial class FormAddSeries : Form
    {
        public FormAddBookExemplar ParentBookExemplar;
        public FormChangeBookExemplar ParentChangeBookExemplar;
        public static ModelContainer model = new ModelContainer();
        public FormAddSeries()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление новой серии?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                if (ParentBookExemplar == null)
                    ParentChangeBookExemplar.Show();
                else
                    ParentBookExemplar.Show();
                Close();
            }
        }

        private void buttonAddSeries_Click(object sender, EventArgs e)
        {
            var seria = model.SeriesSet.Where(u => u.Name==textBoxTitle.Text).ToList();
            if (seria.Count <= 0)
            {
                if ((textBoxTitle.Text != "") && (comboBoxCoverType.SelectedItem != null))
                {
                    Series series = new Series()
                    {
                        Name = textBoxTitle.Text,
                        CoverType = comboBoxCoverType.Text.ToString()
                    };
                    model.SeriesSet.Add(series);
                    model.SaveChanges();

                    if (ParentBookExemplar == null)
                    {
                        ParentChangeBookExemplar.ShowComboBoxes();
                        ParentChangeBookExemplar.Show();
                    }
                    else
                    {
                        ParentBookExemplar.ShowComboBoxes();
                        ParentBookExemplar.Show();
                    }

                    Close();
                }
                else
                {
                    if (textBoxTitle.Text == "") MessageBox.Show("Вы не указали название серии");
                    if (comboBoxCoverType.SelectedItem == null) MessageBox.Show("Вы не выбрали тип обложки");
                }
            }
            else MessageBox.Show("Серия с указанным названием уже существует");
        }

        private void FormAddSeries_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (ParentBookExemplar == null)
                ParentChangeBookExemplar.Show();
            else
                ParentBookExemplar.Show();
        }
    }
}
