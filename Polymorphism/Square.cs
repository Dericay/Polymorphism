using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Geometri
    {
        public double Side { get; set; }
        

        public Square() 
        {
            Side = 10;
            

        }

        public override double Area() //method to override the method in parent class
        {
            Console.WriteLine("Square: {0}", Side * Side);           
            return Side * Side;
        }
    }
}
