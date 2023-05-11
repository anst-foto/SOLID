// See https://aka.ms/new-console-template for more information

using SOLID.O;

var student = new Student()
{
    FirstName = "A",
    LastName = "S",
    Faculty = "F"
};

var abitur = new Abitur()
{
    FirstName = "AA",
    LastName = "SS"
};

Console.WriteLine(student.toString());
Console.WriteLine(abitur.toString());