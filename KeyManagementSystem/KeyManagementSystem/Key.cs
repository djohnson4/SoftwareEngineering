using System;

namespace Entity
{
    public class Key
    {
        private Byte keyID;
        private Boolean aBoolean;
        private DateTime lastModified;
        private string status = "";

        public Key(Byte keyID)
        {
            this.keyID = keyID;
            this.lastModified = DateTime.Now;
        }

        public Key(Byte keyID, Boolean aBoolean)
        {
            this.keyID = keyID;
            this.aBoolean = aBoolean;
            this.lastModified = DateTime.Now;
        }

        protected void setStatus(string status)
        {
            this.status = status;
        }

        protected string getStatus()
        {
            return status;
        }

        protected Boolean isAssigned()
        {
            return aBoolean;
        }

        protected Byte getKeyID()
        {
            return keyID;
        }

        protected void setaBoolean(Boolean aBoolean)
        {
            this.aBoolean = aBoolean;
            this.lastModified = DateTime.Now;
        }
    }
}
