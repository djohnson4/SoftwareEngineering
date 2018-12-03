using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using KeyManagementSystem.Entity;
using KeyManagementSystem.Controller;
using KeyManagementSystem.Boundary;

namespace KeyManagementSystem.Controller
{
    class LoginController
    {
        public int login(int id, String password)//returns -1 if invalid, 0 if a manager, 1 if an employee
        {
            DateTime dateTime = DateTime.Now;
            DBConnector dBConnector = new DBConnector();
            int verdict = dBConnector.verifyUser(id, password);
            if (verdict == 1)//verified, is a manager
            {
                Employee user = new Employee(id, "notstored", true);//creates a new instance of employee with given id, dummy password, and isMgr = true
                //.saveLogin(user.getEmployeeID(), dateTime);
                UpdateKeyStatusForm mgr = new UpdateKeyStatusForm(user);
                mgr.ShowDialog();
                return 0;
            }
            else if (verdict == 0)//verified, not a manager
            {
                Employee user = new Employee(id, "notstored", false);//creates a new instance of employee with given id, dummy password, and isMgr = false
                //dBConnector.saveLogin(user.getEmployeeID(), dateTime);
                KeyRequestForm krf = new KeyRequestForm(user);
                krf.ShowDialog();
                return 1;
            }
            else
            {
                return -1;
            }            
        }
        public static bool IsNumericType(object o)
        {
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }
    }
}
