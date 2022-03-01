using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tireNumber) 
        {
            switch (tireNumber.ToLower())
            {
                case "Four":
                    Car myCar = new Car();
                    return myCar;
                case "Two":
                    Motorcycle myMotorcycle = new Motorcycle();
                    return myMotorcycle;
                default:
                    Car myCar1 = new Car();
                    return myCar1;
            }
        }
    }
}
