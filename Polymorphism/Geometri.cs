using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Geometri
    {
        public virtual double Area() //Creating vitual method so we can override with child class methods
        {
            return double.NaN;

        }
    }
}
