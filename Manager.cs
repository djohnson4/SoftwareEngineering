﻿using System;

namespace AugustaUniversity.SoftwareEngineering.KeyRequest
{
    public class Manager : Employee
    {
        private Boolean isManager;

        public Manager(String firstName, String lastName, Boolean isManager)
        {
            base(firstName, lastName);
            this.isManager = isManager;
        }
    }
}
