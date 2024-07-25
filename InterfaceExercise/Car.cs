using System;
namespace InterfaceExercise;

public class Car
{
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public string Logo { get; set; }
    public string Name { get; set; }

    public bool HasTrunk { get; set; }
    public int NumberOfDoors { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details:\nModel: {Model}\nColor: {Color}\nNumber of Wheels: {NumberOfWheels}\nYear: {Year}\nHas Trunk: {HasTrunk}\nNumber of doors: {NumberOfDoors}\nCompany: {Name}\nLogo: {Logo}\n");
    }
}