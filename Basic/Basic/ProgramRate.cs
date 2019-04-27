using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ProgramRate
    {
        static void Main(string[] args)
        {
            var emp1 = new FulltimeEmployee("Lee");
            emp1.Email = "lee@test.com"; //Base 클래스 속성
            emp1.AnnualSalray = 10000; //파생클래스 속성
            emp1.AdjustSalray(500); //파생클래스 메서드
            Console.WriteLine(emp1.ToString()); //Base클래스 메서드
            Console.WriteLine("Pay: {0}\n", emp1.AnnualSalray);

            var emp2 = new ParttimeEmployee("Song", 10);
            emp2.Email = "song@test.com";
            int pay = emp2.CalculatePay(8);
            Console.WriteLine(emp2.ToString());
            Console.WriteLine("Pay: {0}", pay);
        }
    }
}
