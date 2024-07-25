namespace InterfaceExercise;

public interface IVehicle
{
    int NumberOfWheels { get; set; }
    string Color { get; set; }
    double EngineSize { get; set; }
    string Model { get; set; }
    
    void DisplayDetails();
}