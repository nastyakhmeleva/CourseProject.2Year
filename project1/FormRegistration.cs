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

    public partial class FormRegistration : Form
    {
        public FormAuthorization ParentAuthorization;
        public static ModelContainer model = new ModelContainer();

        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "")
            {
                var users = model.UserSet.Where(u => u.Name.Contains(textBoxLogin.Text)).ToList();

                if (users.Count <= 0)
                {
                    if (textBoxPassword.Text != "")
                    {
                        if (textBoxPasswordCheck.Text != "")
                        {
                            if (textBoxPassword.Text == textBoxPasswordCheck.Text)
                            {
                                User user = new User
                                {
                                    Name = textBoxLogin.Text,
                                    Password = textBoxPassword.Text,
                                    PrivelegeId = 2
                                };

                                model.UserSet.Add(user);
                                model.SaveChanges();

                                ParentAuthorization.Show();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Пароли не совпадают");
                                textBoxPasswordCheck.Text = null;
                            }
                        }
                        else MessageBox.Show("Вы не повторили пароль");
                    }
                    else MessageBox.Show("Вы не указали пароль");

                }
                else MessageBox.Show("Пользователь с данным логином уже существует");
            }
            else MessageBox.Show("Вы не ввели логин");
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentAuthorization.Show();
        }
    }
}
