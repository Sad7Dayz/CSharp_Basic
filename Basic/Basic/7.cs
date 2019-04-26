using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _7
    {
        static void Main(string[] args)
        {
            int[] scores = new int[10] { 90, 75, 85, 95, 70, 75, 85, 85, 95, 72 };

            double sum = 0;
            for(int i =0; i<scores.Length; i++)
            {
                sum += scores[i];
            }

            double avg = sum / scores.Length;

            Console.WriteLine("점수: {0}", string.Join<int>(",", scores));
            Console.WriteLine("합계: {0}", sum);
            Console.WriteLine("평균: {0}", avg);
        }
    }
}
