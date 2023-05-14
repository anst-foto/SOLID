namespace SOLID.D;

public class RussianName : AbstractName
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Patronymic { get; init; }

    public RussianName(string firstName, string lastName, string patronymic)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
    }

    public override string FullName() => $"{LastName} {FirstName} {Patronymic}";
}