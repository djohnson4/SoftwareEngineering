﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyManagementSystem.Entity;
using System.Data.SqlClient;

namespace KeyManagementSystem.Controller
{
    class RequestController
    {
        public String requestKey(String keyID, int userID)
        {
            DBConnector db = new DBConnector();
            return db.changeStatus("Requested", keyID, userID);
        }
    }
}
