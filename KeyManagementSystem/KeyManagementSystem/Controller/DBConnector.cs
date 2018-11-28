using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using Entity;
using System.Configuration;

namespace KeyManagementSystem
{
    class DBConnector
    {
        private readonly SqlConnection connection = new SqlConnection("Database1.mdf");
        string command;
        //SqlCommand command = new SqlCommand();
        Employee verifyUser(string username, string password)
        {
            //when do passwords get hashed and how does that work? 

            //passwords get hashed when the login/account is created. The hashed passwords are saved to the database. Whenenever someone
            //tries to login, the text is the textbox gets hashed, then the hashed password gets checked with the database
        }

        protected void createUser(int id, String password, Boolean isManager)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var keyD = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = keyD.GetBytes(20);
            byte[] hashB = new byte[36];
            Array.Copy(salt, 0, hashB, 0, 16);
            Array.Copy(hash, 0, hashB, 16, 20);
            string pHash = Convert.ToBase64String(hashB);
            using (connection)
            {
                string sql = null;
                sql = "insert into dbo.USER ([userID], [password], [isManager]) values(@id,@password,@isManager)";
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@userID", id);
                    sqlCommand.Parameters.AddWithValue("@password", pHash);
                    sqlCommand.Parameters.AddWithValue("@isManager", isManager);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        protected Employee getLogin(int id)
        {
            int eID;
            string password = null;
            Boolean isManager;
            using (connection)
            {
                connection.Open();
                string sql = "SELECT id, password, isManager FROM dbo.USER WHERE id=@id";
                using(SqlCommand sqlCmd = new SqlCommand(sql, connection))
                {
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader sqlReader = sqlCmd.ExecuteReader())
                    {
                        eID = Convert.ToInt32(sqlReader["id"].ToString());
                        password = sqlReader["password"].ToString();
                        if (sqlReader["isManager"].ToString().Equals(true))
                            isManager = true;
                        else
                            isManager = false;
                    }
                }
                connection.Close();
            }
            Employee employee = new Employee(id, password, isManager);
            return employee;
        }

        public String changeStatus(String status, String keyID, int userID)
        {
            using (connection)
            {
                connection.Open();
                String sql = "SELECT keyID FROM dbo.KEY WHERE userID=" +userID.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandText = "Delete from dbo.KEY where keyID=" + keyID;
                    command.ExecuteNonQuery();
                    command.Parameters.AddWithValue("@keyID", keyID);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return "0";
        }

        public void getKeys(Employee user, ref DataTable Keys)//accepts a user and a reference to a dataTable, and displays all the keys associated with that user or with 'open' status
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
                con.Close();
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
