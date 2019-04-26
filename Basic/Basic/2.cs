using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _2
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i=1; i<=100; i++)
            {
                sum = sum + i; //sum += i;
            }

            Console.WriteLine("합계 : {0}", sum);
        }
    }
}
