using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KeyManagementSystem.Boundary;
using KeyManagementSystem.Entity;

namespace KeyManagementSystem.Controller
{
    class RequestController
    {
        public String requestKey(int keyID, int userID)
        {
            DBConnector db = new DBConnector();
            return db.changeStatus("Requested", keyID, userID);
        }
    }
}
