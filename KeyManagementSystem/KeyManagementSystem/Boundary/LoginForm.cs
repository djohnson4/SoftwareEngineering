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

        static int attempt = 3;
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

        protected void login_Click(object sender, EventArgs e)
        {
            LoginController helper = new LoginController();
            int username = Convert.ToInt32(idBox.Text);
            string password = passwordBox.Text;
            helper.login(username, password);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = null;
            passwordBox.Text = null;
        }
    }
}
