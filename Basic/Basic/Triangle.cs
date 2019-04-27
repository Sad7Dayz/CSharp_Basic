using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Triangle : IDrawable
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw Triangle({A}, {B}, {C})");
        }
    }
}
