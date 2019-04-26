using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _14
    {
        public class Calculator<T>
        {
            //덧셈
            public T Add(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                dynamic c = da + db;
                return c;
            }

            //뺄셈
            public T Substract(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                dynamic c = da - db;
                return c;
            }

            //곱셈
            public T Multiply(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                dynamic c = da * db;
                return c;
            }

            //나눗셈
            public T Divide(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                dynamic c = da / db;
                return c;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //정수형 테스트
                var calc = new Calculator<int>();
                int a = 20;
                int b = 10;
                int r1, r2, r3, r4;
                r1 = calc.Add(a, b);
                r2 = calc.Substract(a, b);
                r3 = calc.Multiply(a, b);
                r4 = calc.Divide(a, b);
                Console.WriteLine($"a={a}, b={b}");
                Console.WriteLine($"사칙연산 결과: {r1},{r2},{r3},{r4}");
                Console.WriteLine();

                //float형 테스트
                var calc2 = new Calculator<float>();
                float x = 20.5f;
                float y = 10.5f;
                float f1, f2, f3, f4;
                f1 = calc2.Add(x, y);
                f2 = calc2.Substract(x, y);
                f3 = calc2.Multiply(x, y);
                f4 = calc2.Divide(x, y);
                Console.WriteLine($"x={x}, y={y}");
                Console.WriteLine($"사칙연산 결과: {f1},{f2},{f3},{f4}");
            }
        }
    }
}
