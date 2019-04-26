using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter line number: ");
            string line = Console.ReadLine();

            int n = int.Parse(line);

            for(int i =0; i < n; i++)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
