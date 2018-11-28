using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Entity;

namespace KeyManagementSystem
{
    class LoginController
    {
        public int login(int id, String password)
        {
            DateTime dateTime = DateTime.Now;
            DBConnector dBConnector = new DBConnector();
            Employee employee = dBConnector.getLogin(id);
            if (IsNumericType(employee.userID) && !employee.password.Equals(null))
            {
                String pHash = employee.password;
                byte[] hash = Convert.FromBase64String(pHash);
                byte[] salt = new byte[16];
                Array.Copy(hash, 0, salt, 0, 16);
                var keyD = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash1 = keyD.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hash[i + 16] != hash[i])
                        return 0;
                if (employee.aBoolean == true)
                {
                    dBConnector.sa
                }
            }
        }
        public static bool IsNumericType(this object o)
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
