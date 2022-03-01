using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public string Make { get; set; }
        public bool HasSpoiler { get; set; }
        public void Drive() 
        {
            Console.WriteLine("Building a new car!");    
        }

    }
}
