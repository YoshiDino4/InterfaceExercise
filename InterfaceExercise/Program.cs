using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                NumberOfWheels = 4,
                Color = "Silver",
                Year = 1997,
                Model = "R34 Skyline",
                Logo = "GTR",
                Name = "Nissan",
                HasTrunk = true,
                NumberOfDoors = 2
            };

            var truck = new Truck
            {
                NumberOfWheels = 4,
                Color = "Red",
                Year = 2009,
                Model = "F-150",
                Logo = "Blue oval with silver lettering",
                Name = "Ford",
                HasBed = true,
                TowingCapacity = 11300
            };

            var suv = new SUV
            {
                NumberOfWheels = 4,
                Color = "Green",
                Year = 2006,
                Model = "CR-V",
                Logo = "H",
                Name = "Honda",
                NumberOfSeats = 5,
                Has4WD = true
            };

            car.DisplayDetails();
            truck.DisplayDetails();
            suv.DisplayDetails();
        }
    }
}
