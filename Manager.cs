using System;

namespace AugustaUniversity.SoftwareEngineering.KeyRequest
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
