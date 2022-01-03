using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Sphere : Shape
    {
        public double Radius { get; set; }
       
        public Sphere(double radius)
        {
            Radius = radius;
            Name = "Sphere";
        }
        public override double Volume()
        {
            return 4*Math.PI*Math.Pow(Radius,2);
        }
    }
}
