using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _4
    {
        static void Main(string[] args)
        {
            
            for(int i =2; i<10; i++) //2~9단
            {
                Console.WriteLine("**{0}단**", i);
            
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2,2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
