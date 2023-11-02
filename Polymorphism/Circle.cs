using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Geometri

    {
        public double Radius;
        public double Pi;

        public Circle() 
        {
           Radius = 4;
            Pi = 3.14;
        }
       
        public override double Area() //method to override the method in parent class
        {
            Console.WriteLine("Area Circle: {0}cm", Radius * Radius * Pi);
            return Radius * Radius * Pi;
            
            
        }
    }
}
