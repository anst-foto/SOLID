using SOLID.L;

var student = new Student()
{
    FirstName = "A",
    LastName = "S",
    Faculty = "F"
};

var teacher = new Teacher()
{
    FirstName = "AA",
    LastName = "SS",
    Department = "D"
};

PrintPerson(student);
PrintPerson(teacher);


void PrintPerson(Person person)
{
    Console.WriteLine(person.FullName);
}