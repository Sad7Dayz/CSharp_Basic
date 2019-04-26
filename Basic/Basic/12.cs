using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _12
    {
        static void Main(string[] args)
        {
            int x = Add(3, 5);
            x = Substract(x, 2);
            x = Multiply(x, 2);
            x = Divide(x, 3);

            Console.WriteLine("(3+5-2)x2/3={0}", x);
        }

        //덧셈
        static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        //뺄셈
        static int Substract(int a, int b)
        {
            int c = a - b;
            return c;
        }

        //곱셈
        static int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }

        //나눗셈
        static int Divide(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
