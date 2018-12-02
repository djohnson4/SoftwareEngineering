﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KeyManagementSystem.Entity;
using KeyManagementSystem.Controller;


namespace KeyManagementSystem.Controller
{
    class DBConnector
    {
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\GitHub\\SoftwareEngineering\\KeyManagementSystem\\KeyManagementSystem\\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(connString);
        
        public void createUser(int id, String password, Boolean isManager)
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
                sql = "INSERT INTO dbo.[USER] (userID, password, isManager) VALUES (@id, @password, @isManager)";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    sqlCommand.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = pHash;
                    if (isManager)
                        sqlCommand.Parameters.AddWithValue("@isManager", SqlDbType.Bit).Value = 1;
                    else
                        sqlCommand.Parameters.AddWithValue("@isManager", SqlDbType.Bit).Value = 0;
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public Employee verifyUser(int id)
        {
            Boolean isManager;
            using (connection)
            {
                connection.Open();
                string sql = "SELECT userID, password, isManager FROM dbo.[USER] WHERE userID=@id";

                using (SqlCommand sqlCmd = new SqlCommand(sql, connection))
                {
                    sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    if (sqlReader.Read())//if user is found
                    {
                        int Eid = Convert.ToInt32(sqlReader.GetValue(0));
                        string Hashedpassword = sqlReader.GetValue(1).ToString();
                        int bitMgr = Convert.ToInt32(sqlReader.GetValue(2));

                        //hashing the input password
                        byte[] salt;
                        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                        var keyD = new Rfc2898DeriveBytes(password, salt, 10000);
                        byte[] hash = keyD.GetBytes(20);
                        byte[] hashB = new byte[36];
                        Array.Copy(salt, 0, hashB, 0, 16);
                        Array.Copy(hash, 0, hashB, 16, 20);
                        string inputHashed = Convert.ToBase64String(hashB);
                        //checking the hashed input against the hashed password from database
                        for (int i = 0; i < 20; i++)
                            if (hash[i + 16] != hash[i])
                                return -1;
                        if (bitMgr == 0)
                        {
                            return 0;
                        }
                        else if (bitMgr == 1)
                        {
                            return 1;
                        }
                        else
                        { throw new Exception("The manager status of this user is not set properly."); }
                        //Employee result = new Employee(Eid, Hashedpassword, isMgr);
                    }
                    else
                    {
                        return -1; // some value to indicate a missing record
                                   // or throw an exception
                    }
                }
                connection.Close();
            }
            Employee employee = new Employee(id, password, isManager);
            return employee;
        }

        public void saveLogin(int userID, DateTime date)
        {
            int id = 0;
            using (connection)
            {
                connection.Open();
                string sql = "SELECT userID FROM SESSION";
                using(SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id++;
                        }
                    }
                }
                connection.Close();
            }
            using (connection)
            {
                string sql = "";
                sql = "INSERT into SESSION ([userID], [sessionID], [time], [log]) values(@userID,@id,@log)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@sessioID", id);
                    cmd.Parameters.AddWithValue("@time", date);
                    cmd.Parameters.AddWithValue("@log", "Login");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void saveLogout(int userID, DateTime date)
        {
            int id = 0;
            using (connection)
            {
                connection.Open();
                string sql = "SELECT userID FROM SESSION";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id++;
                        }
                    }
                }
                connection.Close();
            }
            using (connection)
            {
                string sql = "";
                sql = "INSERT into SESSION ([userID], [sessionID], [time], [log]) values(@userID,@id,@log)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@sessioID", id);
                    cmd.Parameters.AddWithValue("@time", date);
                    cmd.Parameters.AddWithValue("@log", "Logout");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public String changeStatus(String status, String keyID, int userID)
        {
            using (connection)
            {
                connection.Open();
                String sql = "SELECT keyID FROM KEY WHERE userID=" +userID.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandText = "Delete from KEY where keyID=" + keyID;
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
            string stringcmd = "SELECT * FROM KEY WHERE userID = '" + userID.ToString()+"' OR status = 'open'";
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
            //command = "SELECT * FROM KEY WHERE STATUS = 'open'";
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
