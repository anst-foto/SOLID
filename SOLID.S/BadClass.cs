namespace SOLID.S;

public class BadClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName()
    {
        var name = $"{LastName} {FirstName}";
        Console.WriteLine(name); // BAD
        return name;
    }
}