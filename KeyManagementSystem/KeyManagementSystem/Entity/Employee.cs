using System;

namespace KeyManagementSystem.Entity

{
    public class Employee
    {
        private Boolean isManager;
        private int userID;
        private string password;

        public Employee(int userID, String password)
        {
            this.userID = userID;
            this.password = password;
        }

        public Employee(int userID, String password, Boolean isManager)
        {
            this.userID = userID;
            this.password = password;
            this.isManager = isManager;
        }

        public String getPassword()
        {
            return password;
        }

        public int getEmployeeID()
        {
            return userID;
        }

        public void setEmployeeID(int userID)
        {
            this.userID = userID;
        }

        public Boolean getIsManager()
        {
            return isManager;
        }

        public void setIsManager(Boolean isManager)
        {
            this.isManager = isManager;
        }

    }
}
