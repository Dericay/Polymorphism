using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : Geometri
    {
        public double Height;
        public double Base;
        


        public Rectangle()
        {
            Height = 24.5;
            Base = 12.5;
        }

        public override double Area() //method to override the method in parent class
        {
            Console.WriteLine("Area Rectangle: {0}cm", Height * Base);
            return Height * Base;
        }
    }
}
