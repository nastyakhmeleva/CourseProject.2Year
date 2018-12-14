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
    public partial class FormAuthorization : Form
    {
        public static ModelContainer model = new ModelContainer();

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "")
            {
                var users = model.UserSet.Where(u => u.Name.Contains(textBoxLogin.Text)).ToList();

                if (users.Count > 0)
                {
                    if (textBoxPassword.Text == users[0].Password)
                    {
                        if (users[0].Privelege.Available)
                        {
                            FormAdminMainMenu newForm = new FormAdminMainMenu();
                            newForm.ParentAuthorization = this;
                            newForm.Show();
                            Hide();
                        }
                        else
                        {
                            FormUserMainMenu newForm = new FormUserMainMenu();
                            newForm.ParentAuthorization = this;
                            newForm.Show();
                            Hide();
                        }
                    }
                    else MessageBox.Show("Пароль неверен");
                }
                else MessageBox.Show("Пользователь не найден");
            }
            else MessageBox.Show("Пользователь не найден");

            textBoxPassword.Text = "";
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration newForm = new FormRegistration();
            newForm.ParentAuthorization = this;
            newForm.Show();
            Hide();
        }
    }
}
