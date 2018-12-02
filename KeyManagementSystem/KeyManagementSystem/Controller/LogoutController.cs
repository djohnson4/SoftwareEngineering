using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyManagementSystem.Boundary;

namespace KeyManagementSystem.Controller
{
    class LogoutController
    {
        public void logout(int userID)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
