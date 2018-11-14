using System;

namespace KeyRequest.Entity
{
    public class Manager : Employee
    {
        private Boolean isManager;

        public Manager(int userID, String password, Boolean isManager)
        {
            base(userID, password, isManager);
        }
    }
}
