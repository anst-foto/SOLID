namespace SOLID.S;

public class GoodClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{LastName} {FirstName}";
}