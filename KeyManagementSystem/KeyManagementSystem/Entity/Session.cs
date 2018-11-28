using System;

namespace KeyManagementSystem.Entity
{
    public class Session
    {
        private int startDate, startTime, endDate, endTime, userID;
        private string sessionID;

        public Session(int startDate, int startTime, int endDate, int endTime, int userID, string sessionID)
        {
            this.startDate = startDate;
            this.startTime = startTime;
            this.endDate = endDate;
            this.endTime = endTime;
            this.userID = userID;
            this.sessionID = sessionID;
        }
        
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
