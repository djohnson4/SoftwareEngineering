﻿using System;

namespace Entity
{
    public class Session
    {
        private int startDate, startTime, endDate, endTime, userID;
        private string sessionID;

        public Session(int startDate, int startTime, int endDate, int endTime, int userID, string sessionID)
        {
            this.StartDate = startDate;
            this.StartTime = startTime;
            this.EndDate = endDate;
            this.EndTime = endTime;
            this.UserID = userID;
            this.SessionID = sessionID;
        }
        /*
         * This is autogenerated getters and setters from VS2017. Wasn't sure if this was allowed, but the method names don't match the class diagram
         * and I figured "why not just do it manually just to be safe" *shrug*
         *public int StartDate { get => startDate; set => startDate = value; }
         *public int StartTime { get => startTime; set => startTime = value; }
         *public int EndDate { get => endDate; set => endDate = value; }
         *public int EndTime { get => endTime; set => endTime = value; }
         *public int UserID { get => userID; set => userID = value; }
         *public string SessionID { get => sessionID; set => sessionID = value; }
        */

        public int getStartDate()
        {
            return startDate;
        }

        public void setStartDate(int startDate)
        {
            this.startDate = startDate;
        }

        public int getStartTime()
        {
            return startTime;
        }

        public void setStartTime(int startTime)
        {
            this.startTime = startTime;
        }

        public int getEndDate()
        {
            return endDate;
        }

        public void setEndDate(int endDate)
        {
            this.endDate = endDate;
        }

        public int getEndTime()
        {
            return endTime;
        }

        public void setEndTime(int endTime)
        {
            this.endTime = endTime;
        }

        public string getSessionID()
        {
            return sessionID;
        }

        public void setSessionID(string sessionID)
        {
            this.sessionID = sessionID;
        }
    }

}
