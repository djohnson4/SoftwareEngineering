using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Configuration;

namespace KeyManagementSystem
{
    class DBConnector
    {
        private readonly SqlConnection connection = new SqlConnection("Database1.mdf");
        string command;
        //SqlCommand command = new SqlCommand();
        Entity.Employee verifyUser(string username, string password)
        {
            //when do passwords get hashed and how does that work? 
        }

        public void getKeys(Entity.Employee user, ref DataTable Keys)//accepts a user and a reference to a dataTable, and displays all the keys associated with that user or with 'open' status
        {
            int userID = user.getEmployeeID();
            string stringcmd = "SELECT * FROM dbo.KEY WHERE userID = '" + userID.ToString()+"' OR status = 'open'";
            string connString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(stringcmd, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Keys.Load(reader);
                }
            }
            //var dataAdapter = new SqlDataAdapter(command, connection);
            //connection.Open();
            //command = "SELECT * FROM dbo.KEY WHERE STATUS = 'open'";
            //SqlCommand input = new SqlCommand(command, connection);
            //input.CommandType = CommandType.Text;
            //dataAdapter.SelectCommand = input;
            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            ////dataAdapter.TableMappings.Add("Table", "KEY");
            //var ds = new DataSet();
            //dataAdapter.Fill(ds);
            
            ////dataGridView1.ReadOnly = true;
            ////dataGridView1.DataSource = ds.Tables[0];
        }
        
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
