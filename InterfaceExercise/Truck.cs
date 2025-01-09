using System;
namespace InterfaceExercise;

public class Truck : IVehicle , ICompany
{
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public string Logo { get; set; }
    public string Name { get; set; }

    public bool HasBed { get; set; }
    public int TowingCapacity { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Truck Details:\nModel: {Model}\nColor: {Color}\nNumber of Wheels: {NumberOfWheels}\nYear: {Year}\nHas Bed: {HasBed}\nTowing Capacity (in lbs): {TowingCapacity}\nCompany: {Name}\nLogo: {Logo}\n");
    }
}