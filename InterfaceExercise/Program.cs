using System.Collections.Generic;
using System;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes DONE

            /*Create 2 members that are specific to each class DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values; DONE
            //Creatively display and organize their values DONE

            List<IVehicle> vehicles = new List<IVehicle>();

            Car car1 = new Car()
            {
                Make = "Toyota",
                Model = "Yaris",
                Year = 2008,
                Slogan = "Let's Go Places",
                YearEstablished = 1937,
                TrunkSizeCm = 8658
            };
            SUV suv1 = new SUV()
            {
                Make = "Kia",
                Model = "Seltos",
                Year = 2022,
                Slogan = "Movement that inspires",
                YearEstablished = 1937,
                CargoHoldSizeCm = 753228
            }; 
            Truck truck1 = new Truck()
            {
                Make = "Ford",
                Model = "Super Duty LWB Crew Cab",
                Year = 2020,
                Slogan = "Built Ford Tough",
                YearEstablished = 1937,
                BedSizeCm = 48928
            };

            vehicles.Add(car1);
            vehicles.Add(suv1);
            vehicles.Add(truck1);

            Console.WriteLine("\n\n\nHere are the current created vehicles: \n");
            foreach(IVehicle vehicle in vehicles) {
                Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nNumber Of Wheels: {vehicle.NumberOfWheels}\nYear Released: {vehicle.Year}");
                vehicle.drive();
                Console.WriteLine("\n\n\n");
            }
            
        }
    }
}
