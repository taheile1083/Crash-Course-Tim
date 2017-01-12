using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash_Course_Tim
{
    class Car
    {
        // Attributes / Properties
        public string Color { get; set; }

        //Constructor
        public Car(string color)
        {
            this.Color = color;
        }
        //Methods
        public string Describe()
        {
            return "This car is " + this.Color;
        }
        public string Drive()
        {
            return "Driving...";
        }
        //get();
        //set();
    }
}
