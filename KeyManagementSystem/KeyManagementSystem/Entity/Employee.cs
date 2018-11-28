using System;

namespace KeyManagementSystem.Entity

{
    public class Employee
    {
        private Boolean aBoolean;
        private int userID;
        private string password;

        public Employee(int userID, String password)
        {
            this.userID = userID;
            this.password = password;
        }

        public Employee(int userID, String password, Boolean aBoolean)
        {
            this.userID = userID;
            this.password = password;
            this.aBoolean = aBoolean;
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
            return aBoolean;
        }

        public void setIsManager(Boolean aBoolean)
        {
            this.aBoolean = aBoolean;
        }

    }
}
