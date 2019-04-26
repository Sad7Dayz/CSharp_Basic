using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _6
    {
        static void Main(string[] args)
        {
            string grade;

            Console.Write("점수 입력: ");

            string input = Console.ReadLine();

            int score = int.Parse(input);

            if(score >= 90)
            {
                grade = "A";
            }
            else if(score >= 80)
            {
                grade = "B";
            }
            else if(score >= 70)
            {
                grade = "C";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine("학점: {0}", grade);
        }
    }
}
