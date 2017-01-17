using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash_Course_Tim
{
    class Animal
    {
        // Attributes / Properties
        public string Name { get; set; }
        public string Color { get; set; }
        //public string Sound { get; set; }
        //Constructor
        public Animal(string name, string color)
        {
            this.Name = name;
            this.Color = color;
            //this.Sound = "Woof!";
        }
        //Methods
        public string Hello()
        {
            return "My name is " + this.Name + ".";
        }
        public string Describe()
        {
            return "I am " + this.Color + ".";
        }
        //public string Speak()
        //{
        //    return this.Sound;
        //}
    }
}
