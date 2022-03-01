using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory.GetVehicle(tireNumber:"Two");
            VehicleFactory.GetVehicle(tireNumber: "Four");

        }
    }
}
