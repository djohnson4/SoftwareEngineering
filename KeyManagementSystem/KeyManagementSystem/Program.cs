using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            Application.Run(new LoginForm());
            SqlConnection connection = new SqlConnection("Database1.mdf");
            //SqlCommand command = new SqlCommand(user1, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();
                    //SqlDataReader reader = command.ExecuteReader();
                    //try
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine(String.Format("{0}, {1}",
                    //            reader[0], reader[1]));
                    //    }
                    //}
                    //finally
                    //{
                    //    // Always call Close when done reading.
                    //    reader.Close();
                    //}
                }
            }
        }
    

