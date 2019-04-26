using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _8
    {
        static void Main(string[] args)
        {
            int[,] scores = new int[5, 3]
            {
                {90, 80, 90},
                {85, 85, 95},
                {95, 70, 75},
                {80, 80, 90},
                {90, 75, 80}
            };

            for(int i=0; i<scores.GetLength(0); i++)
            {
                double sum = 0;
                for(int j=0; j<scores.GetLength(1); j++)
                {
                    sum += scores[i, j];
                }

                double avg = sum / 3;
                Console.WriteLine("ID={0}: 합계 ={1}, 평균={2:N2}", i, sum, avg);
            }
        }
    }
}
