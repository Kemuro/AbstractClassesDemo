using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public Car(string Year, string Make, string Model, string Color, int numOfDoors, bool isSport)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.Color = Color;
            this.numOfDoors = numOfDoors;
            this.isSport = isSport;
        }
        public Car()
        {

        }
        public int numOfDoors { get; set; }
        public bool isSport { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("driving abstract");
        }
    }
}
