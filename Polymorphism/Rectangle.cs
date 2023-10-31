using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : Geometri
    {
        public double Height { get; set; }
        public double Base {  get; set; }
        


        public Rectangle()
        {
            Height = 24.5;
            Base = 12.5;
        }

        public override double Area() //method to override the method in parent class
        {
            Console.WriteLine("Rectangle: {0}", Height * Base);
            return Height * Base;
        }
    }
}
