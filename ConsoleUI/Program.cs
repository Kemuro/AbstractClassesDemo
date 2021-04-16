using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car item1 = new Car("2021", "Audi", "A4 2.0T", "Black", 4, true);
            vehicles.Add(item1);

            Motorcycle item2 = new Motorcycle("2021", "Susuki", "Katana", "Gold", false, "Sprot");
            vehicles.Add(item2);

            Vehicle item3 = new Car()
            {
                Year = "2019",
                Make = "BMW",
                Model = "6 Series 640i",
                Color = "Glacier Silver",
                numOfDoors = 2,
                isSport = true
            };
            vehicles.Add(item3);

            Vehicle item4 = new Car()
            {
                Year = "2020",
                Make = "Dodge",
                Model = "Challenger",
                Color = "Pearl White",
                numOfDoors = 2,
                isSport = true
            };
            vehicles.Add(item4);



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach(var product in vehicles)
            {
                Console.WriteLine($"Year: {product.Year} \n" +
                    $"Make: {product.Make} \n" +
                    $"Model: {product.Model} \n" +
                    $"Color: {product.Color}");
                Console.WriteLine();
            }



            // Call each of the drive methods for one car and one motorcycle
            item1.DriveAbstract();
            item2.DriveVirtual();
            item3.DriveVirtual();
            item4.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
