using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Geometri

    {
        public double Radius { get; set; }
        public double Pi {  get; set; }

        public Circle() 
        {
           Radius = 4;
            Pi = 3.14;
        }
       
        public override double Area() //method to override the method in parent class
        {
            Console.WriteLine("Circle: {0}", Radius * Radius * Pi);
            return Radius * Radius * Pi;
            
            
        }
    }
}
