using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash_Course_Tim
{
    class Cat
    {
        // Attributes / Properties
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sound{ get; set; }
        //Constructor
        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
            this.Sound = "Meow!";
        }
        //Methods
        public string Hello()
        {
            return "My name is " + this.Name + ".";
        }
        public string Describe()
        {
            return "This cat is " + this.Color + ".";
        }
        public string Speak()
        {
            return this.Sound;
        }
    }
}
