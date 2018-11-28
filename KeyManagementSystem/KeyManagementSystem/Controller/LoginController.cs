using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using KeyManagementSystem.Entity;
using KeyManagementSystem.Controller;

namespace KeyManagementSystem.Controller
{
    class LoginController
    {
        public int login(int id, String password)
        {
            DateTime dateTime = DateTime.Now;
            DBConnector dBConnector = new DBConnector();
            Employee employee = dBConnector.getLogin(id);
            if (IsNumericType(employee.getEmployeeID()) && !employee.getPassword().Equals(null))
            {
                String pHash = employee.getPassword();
                byte[] hash = Convert.FromBase64String(pHash);
                byte[] salt = new byte[16];
                Array.Copy(hash, 0, salt, 0, 16);
                var keyD = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash1 = keyD.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hash[i + 16] != hash[i])
                        return -1;
                if (employee.getIsManager() == true)
                {
                    dBConnector.saveLogin(employee.getEmployeeID(), dateTime);
                    return 0;
                }
                else if (employee.getIsManager() == false)
                {
                    dBConnector.saveLogin(employee.getEmployeeID(), dateTime);
                    return 1;
                }
                return -1;
            }
            return -1;
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
