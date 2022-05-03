using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle , ICompany
    {
        public int CargoHoldSizeCm { get; set; }

        public string Slogan { get; set; }
        public int YearEstablished { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string NumberOfWheels { get; set; }
        public void drive()
        {
            Console.WriteLine($"I am a {Make} {Model}. My company found date is {YearEstablished} and their slogan is '{Slogan}'");
        }
    }
}
