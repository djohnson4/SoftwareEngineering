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
            //dbc.saveLogout(user, ); //need to log the time user logs out. 
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
