using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year = "----";
        public string Make = "----";
        public string Model = "----";
        public string Color = "----";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("driving base");
        }
    }
}
