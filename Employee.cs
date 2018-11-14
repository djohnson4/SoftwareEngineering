using System;

namespace AugustaUniversity.SoftwareEngineering.KeyRequest
{
    public class Employee
    {
        private sealed String firstName;
        private sealed String lastName;
        private Boolean aBoolean;

        public Employee(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee(String firstName, String lastName, Boolean aBoolean)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.aBoolean = aBoolean;
        }

        protected Boolean isManager()
        {
            return aBoolean;
        }

        protected String getFirstName()
        {
            return firstName;
        }

        protected String getLastName()
        {
            return lastName;
        }

        protected override string toString()
        {
            return lastName + ", " + firstName;
        }
    }
}
