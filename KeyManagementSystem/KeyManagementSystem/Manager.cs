using System;

namespace Entity
{
    public class Manager : Employee
    {
        private Boolean isManager = true;

        public Manager(int userID, String password, Boolean isManager)
        {
            base(userID, password, isManager);
        }
    }
}
