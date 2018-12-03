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
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\GitHub\\SoftwareEngineering\\KeyManagementSystem\\KeyManagementSystem\\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(connString);
        public KeyRequestForm(Employee user)
        {
            thisUser = user;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            con.getKeys(thisUser, ref Keys);//need to have a way of accessing the user for the current session
            return Keys;
        }

        private void RequestKey(String keyID)
        {
            RequestController request = new RequestController();
            var requestStatus = request.requestKey(keyID, thisUser.getEmployeeID());
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            availableKeysList.Update();
            availableKeysList.Refresh();
        }

        private void database1DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void logOff_Click(object sender, EventArgs e)
        {
            LogoutController helper = new LogoutController();
            helper.logout(thisUser.getEmployeeID()); // This calls 'logout' method from LogoutController and passes in ther UsersID. Need to ensure this is done properly. 
            Close();
        }
    }
}
