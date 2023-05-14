using SOLID.D;

var russianPerson = new Person(new RussianName("Andrey", "Starinin", "Nikolaevich"));
var americanPerson = new Person(new AmericanName("A", "B", "C"));

PrintName(russianPerson.Name);
PrintName(americanPerson.Name);


void PrintName(AbstractName name)
{
    Console.WriteLine(name.FullName());
}

void PrintPerson(Person person)
{
    Console.WriteLine(person.FullName);
}