using System;
namespace InterfaceExercise;

public class SUV : IVehicle , ICompany
{
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public string Logo { get; set; }
    public string Name { get; set; }

    public bool Has4WD { get; set; }
    public int NumberOfSeats { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"SUV Details:\nModel: {Model}\nColor: {Color}\nNumber of Wheels: {NumberOfWheels}\nYear: {Year}\nHas 4WD: {Has4WD}\nNumber of seats: {NumberOfSeats}\nCompany: {Name}\nLogo: {Logo}\n");
    }
}