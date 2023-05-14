namespace SOLID.D;

public class Person
{
    public AbstractName Name { get; init; }

    public Person(AbstractName name)
    {
        Name = name;
    }

    public string FullName => Name.FullName();
}