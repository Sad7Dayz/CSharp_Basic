using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ProgramCar
    {
        static void Main(string[] args)
        {
            MyPaint paint = new MyPaint();

            Triangle t = new Triangle(3, 4, 5);
            paint.DrawShape(t);
            Console.WriteLine();

            paint.DrawShape(new Rectangle(5, 10));
            Console.WriteLine();

            paint.DrawShape(new CustomShape(5, 10, 2, 2));
            Console.WriteLine();
        }
    }
}
