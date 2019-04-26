using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _13
    {
        static void Main(string[] args)
        {
            //Triangle 클래스로부터 객체 생성
            Triangle t1 = new Triangle(3, 4, 5);
            Console.WriteLine("삼각형1: A={0}, B={1}, C={2}", t1.A, t1.B, t1.C);

            //Triangle 속성 사용
            double p = t1.Perimeter;
            Console.WriteLine("둘레길이: {0}\n", p);

            //다른 객체 생성
            Triangle t2 = new Triangle(3, 3, 3);
            Console.WriteLine("삼각형2: A={0}, B={1}, C={2}", t2.A, t2.B, t2.C);

            //Triangle 메서드 호출
            t2.Draw();
        }
    }

    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //속성 : 각 변의 길이
        public double A
        {
            get { return this.a; }
        }

        public double B
        {
            get { return this.b; }
        }

        public double C
        {
            get { return this.c; }
        }

        //속성: 삼각형 둘레
        public double Perimeter
        {
            get { return a + b + c; }
        }
        //메서드 
        public void Draw()
        {
            Console.WriteLine("Draw({0}, {1}, {2})", a, b, c);
        }
    }
}
