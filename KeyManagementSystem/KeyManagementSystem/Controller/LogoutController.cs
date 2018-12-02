using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyManagementSystem.Boundary;
using KeyManagementSystem.Controller;
using KeyManagementSystem.Entity;

namespace KeyManagementSystem.Controller
{
    class LogoutController
    {
        /*  
        This class is called when the user clicks "LogOut" on the Form.
        Methods - logout takes in a user. 
        Calls on classes DBConnector and LoginForm.
        */
        public void logout(int userID) 
        {
            int user = userID;
            DBConnector dbc = new DBConnector();
            DateTime dateTime = DateTime.Now;
            dbc.saveLogout(user, dateTime); //Passes userID and time of logout to the DBConnector. 
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
