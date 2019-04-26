using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _11
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 80, 90, 95, 75, 70 };
            int[] b = new int[] { 90, 85, 85, 85, 80 };

            int sumA = Sum(a);
            Console.WriteLine("A: {0}", string.Join<int>(",", a));
            Console.WriteLine("Sum(A) = {0}", sumA);

            int sumB = Sum(b);
            Console.WriteLine("B: {0}", string.Join<int>(",", b));
            Console.WriteLine("Sum(B) = {0}", sumB);
        }

        //정수 배열을 받아들여 합계를 리턴하는 메서드
        
        static int Sum(int[] data)
        {
            int s = 0;
            for(int i =0; i<data.Length; i++)
            {
                s += data[i];
            }
            return s;
        }
    }
}
