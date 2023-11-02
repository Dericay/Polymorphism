using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Geometri
    {
        public double Side;
        

        public Square() 
        {
            Side = 10;
            

        }

        public override double Area() //method to override the method in parent class
        {
            Console.WriteLine("Area Square: {0}cm", Side * Side);           
            return Side * Side;
        }
    }
}
