using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string Year, string Make, string Model, string Color, bool hasGoodStorage, string style)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.Color = Color;
            this.hasGoodStorage = hasGoodStorage;
            this.style = style;
        }
        public Motorcycle()
        {

        }

        public bool hasGoodStorage { get; set; }
        public string style { get; set; }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("driving abstract");
        }
    }
}
