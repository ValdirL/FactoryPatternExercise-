﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public void Drive() 
        {
            Console.WriteLine("Building a new truck!");    
        }
    }
}
