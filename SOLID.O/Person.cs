namespace SOLID.O;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual string toString() => $"{LastName} {FirstName}";
}