namespace SOLID.D;

public class AmericanName : AbstractName
{
    public string FirstName { get; init; }
    public string MiddleName { get; init; }
    public string LastName { get; init; }

    public AmericanName(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    public override string FullName() => $"{FirstName} {MiddleName} {LastName}";
}