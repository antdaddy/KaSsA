using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Здесь можно добавить проверку логина и пароля
            if (username == "" && password == "") //изменить на 1 1
            {
                MessageBox.Show("Авторизация прошла успешно!");

                KassaForm kassaForm = new KassaForm();
                kassaForm.FormClosed += (s, args) => this.Close(); // Закрывает текущую форму LoginForm при закрытии MainForm
                kassaForm.Show();
                this.Hide(); // Скрывает текущую форму LoginForm

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");

            }
        }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }


        public void btnLogin_Click(object p1, object p2)
        {
            throw new NotImplementedException();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*  private void barcodeInput_TextChanged(object sender, EventArgs e)
           {

           }
        */
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
