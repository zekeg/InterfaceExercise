using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        string NumberOfWheels { get; set; }
        void drive();
    }
}
