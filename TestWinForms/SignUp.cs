using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestWinForms
{
    public partial class SignUp : Form
    {
        DB dataBase = new DB();
        public SignUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        //Логин должен быть не менее 8 символов
       // Пароль 8 символов, минимум одна заглавная и одна цифра
        //Поля логин, пароль и повторный пароль (нужно сделать проверку того чтобы во все эти поля можно вводить только латинские курильские буквы и цифры)
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?!.*\s).{8,50}$";

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginField.Text) == true)
            {
                loginField.Focus();
                errorLogin.SetError(this.loginField, "Пожалуйста, введите логин!");
            }
            else
            {
                errorLogin.Clear();
            }
        }

        private void buttonClosePass_Click(object sender, EventArgs e)
        {
            if (passField.PasswordChar == '*')
            {
                buttonOpenPass.BringToFront();
                passField.PasswordChar = '\0';
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            var login = loginField.Text;
            var password = passField.Text;

            string querystring = $"Insert into register(login_user,password_user) values ('{login}','{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Аккаунт успешно создан!","Успех!");
                LoginForm fm_login = new LoginForm();
                this.Hide();
                fm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = loginField.Text;
            var passUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user='(loginUser) and password_user='(passUser)'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count>0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void passField_TextChanged(object sender, EventArgs e)
        {
            passField.PasswordChar = '*';
            if (Regex.IsMatch(passField.Text, pattern) == false)
            {
                passField.Focus();
                errorPass.SetError(this.passField, "НА ЛАТИНСКОМ, НЕ МЕНЕЕ 8 СИМВОЛОВ, МИНИМУМ 1 ЗАГЛАВНАЯ 1 ПРОПИСНАЯ И 1 ЦИФР");
            }
            else
            {
                errorPass.Clear();
            }
        }

       

        private void buttonOpenPass_Click(object sender, EventArgs e)
        {
            if (passField.PasswordChar == '\0')
            {
                buttonClosePass.BringToFront();
                passField.PasswordChar = '*';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (confirmPass.PasswordChar == '*')
            {
                confirmOpen.BringToFront();
                confirmPass.PasswordChar = '\0';
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            confirmPass.PasswordChar = '*';
            if (confirmPass.Text != passField.Text)
            {
                errorPassConfirm.SetError(this.confirmPass, "Подтверждение не совпадает с паролем!");
            }
            else
            {
                errorPassConfirm.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (confirmPass.PasswordChar == '\0')
            {
                confirmClose.BringToFront();
                confirmPass.PasswordChar = '*';
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void SignUp_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

    }
}
