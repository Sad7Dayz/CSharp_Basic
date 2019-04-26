using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("My Sonata");
            mycar.Maker = "Hyundai";
            mycar.Model = "Sonata";

            mycar.Start();
            mycar.Accelerate(19);
            int speed = mycar.Speed;
            Console.WriteLine(speed);

            mycar.Accelerate(20);
            Console.WriteLine(speed);

            mycar.Stop();
        }
    }
}
