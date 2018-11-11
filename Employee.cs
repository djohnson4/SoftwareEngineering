using System;

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

    public Boolean isManager()
    {
        return aBoolean;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public override string toString()
    {
        return lastName + ", " + firstName;
    }
}
