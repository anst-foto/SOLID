namespace SOLID.I;

public class Truck : Transport, ICargo
{
    public void CargoLoad()
    {
        Console.WriteLine($"Загрузка груза в {Name}");
    }

    public void CargoUnload()
    {
        Console.WriteLine($"Выгрузка груза из {Name}");
    }
}