using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using KeyManagementSystem.Controller;
using KeyManagementSystem.Entity;

namespace KeyManagementSystem.Boundary
{
    public partial class LoginForm : Form
    {
        //static int attempt = 3;
        private int username;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            LoginController helper = new LoginController();
            username = Convert.ToInt32(idBox.Text);
            password = passwordBox.Text;
            helper.login(username, password);
            int x = helper.login(username, password);
            if (x == -1)
            {
                idBox.Text = "";
                passwordBox.Text = "";
                DialogResult result;
                result = MessageBox.Show("Invalid Login Credentials.", "");
            }
            else
            {
                Close();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
            passwordBox.Text = "";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
