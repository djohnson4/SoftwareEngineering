using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using KeyManagementSystem.Controller;
using KeyManagementSystem.Entity;

namespace KeyManagementSystem.Boundary
{
    public partial class KeyRequestForm : Form
    {
        private static Employee thisUser;
        private DataTable availableKeys;
        private int selectedKey;
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\GitHub\\SoftwareEngineering\\KeyManagementSystem\\KeyManagementSystem\\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(connString);
        public KeyRequestForm(Employee user)
        {
            thisUser = user;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKey = Convert.ToInt32(availableKeysList.SelectedRows[0].Cells[1].Value);
        }

        private void KeyRequestForm_Load(object sender, EventArgs e)
        {
            this.availableKeysList.DataSource = GetAvailableKeys();
            
            //this.kEYTableAdapter.Fill(this.database1DataSet.KEY);
        }
        private DataTable GetAvailableKeys()
        {
            DataTable Keys = new DataTable();
            DBConnector con = new DBConnector();
            con.getKeys(thisUser, ref Keys);
            availableKeys = Keys;
            return Keys;
        }

        private void RequestKey(int keyID)
        {
            RequestController request = new RequestController();
            var requestStatus = request.requestKey(keyID, thisUser.getEmployeeID());
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedKey = Convert.ToInt32(availableKeysList.SelectedRows[0].Cells[1].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnector helper = new DBConnector();
            helper.changeStatus("requested", selectedKey, thisUser.getEmployeeID());
            availableKeys = GetAvailableKeys();
            availableKeysList.Update();
            this.KeyRequestForm_Load(sender, e);//is reloading, is not modifying the displayed table bc it isn't modifying the database
            //availableKeysList.Update();
            //availableKeysList.Refresh();
        }

        private void database1DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void logOff_Click(object sender, EventArgs e)//this should close the form but it doesn't
        {
            this.Hide();
            this.Close();
            LogoutController helper = new LogoutController();
            helper.logout(thisUser.getEmployeeID(), this); // This calls 'logout' method from LogoutController and passes in ther UsersID. Need to ensure this is done properly. 
            
            //LoginForm refresh = new LoginForm();
            //refresh.Show();
            //MessageBox.Show("You have successfully logged out.", "");
            
        }
    }
}
