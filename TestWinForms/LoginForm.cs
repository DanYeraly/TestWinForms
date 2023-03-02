using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWinForms.Properties;
using System.Data.SqlClient;

namespace TestWinForms
{
    public partial class LoginForm : Form
    {
        DB database = new DB();

        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user,login_user,password_user from register where login_user = '{loginUser}' and password_user='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Show();
                Main m = new Main();
                m.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (checkBox1.Checked==true)
            {
                Properties.Settings.Default.Username = loginField.Text;
                Properties.Settings.Default.Password = passField.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username!=string.Empty)
            {
                loginField.Text = Properties.Settings.Default.Username;
                passField.Text = Properties.Settings.Default.Password;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passField.PasswordChar = '*';
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (passField.PasswordChar == '*')
            {
                buttonOpenPass.BringToFront();
                passField.PasswordChar = '\0';
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passField.PasswordChar == '\0')
            {
                buttonClosePass.BringToFront();
                passField.PasswordChar = '*';
            }
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp frm_sign = new SignUp();
            frm_sign.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
