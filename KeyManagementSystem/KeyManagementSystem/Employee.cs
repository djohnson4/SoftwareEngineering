using System;

namespace KeyRequest.Entity
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

        public int getEmployeeID()
        {
            return userID;
        }

        public void setEmployeeID(int userID)
        {
            this.userID = userID;
        }

        protected Boolean getIsManager()
        {
            return aBoolean;
        }

        protected void setIsManager(Boolean aBoolean)
        {
            this.aBoolean = aBoolean;
        }

    }
}
