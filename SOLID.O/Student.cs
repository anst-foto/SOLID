namespace SOLID.O;

public class Student : Person
{
    public string Faculty { get; set; }
    
    public override string toString() => $"{LastName} {FirstName}, {Faculty}";
}