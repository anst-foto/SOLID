namespace SOLID.I;

public class Bus : Transport, IPassenger
{
    public void PassengerBoarding()
    {
        Console.WriteLine($"Посадка пассажиров в {Name}");
    }

    public void PassengerUnboarding()
    {
        Console.WriteLine($"Высадка пассажиров из {Name}");
    }
}