namespace SOLID.I;

public class TruckBus : Transport, ICargo, IPassenger
{
    public void CargoLoad()
    {
        Console.WriteLine($"Загрузка груза в {Name}");
    }

    public void CargoUnload()
    {
        Console.WriteLine($"Выгрузка груза из {Name}");
    }

    public void PassengerBoarding()
    {
        Console.WriteLine($"Посадка пассажиров в {Name}");
    }

    public void PassengerUnboarding()
    {
        Console.WriteLine($"Высадка пассажиров из {Name}");
    }
}