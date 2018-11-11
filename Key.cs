using System;

public class Key
{
    private sealed Byte keyID;
    private Boolean aBoolean;
    private DateTime lastModified;

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

    public Boolean isAssigned()
    {
        return aBoolean;
    }

    public Byte getKeyID()
    {
        return keyID;
    }

    public void setaBoolean(Boolean aBoolean)
    {
        this.aBoolean = aBoolean;
        this.lastModified = DateTime.Now;
    }
}
