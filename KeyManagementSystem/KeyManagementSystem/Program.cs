using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KeyManagementSystem.Boundary;
using KeyManagementSystem.Entity;
using KeyManagementSystem.Controller;

namespace KeyManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBConnector populate = new DBConnector();

            //populate.createUser(4, "password4", false);
            Application.Run(new LoginForm());
        }
    }
}
    

