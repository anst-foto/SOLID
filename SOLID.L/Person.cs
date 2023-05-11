namespace SOLID.L;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{LastName} {FirstName}";
}