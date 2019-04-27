using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Edu
    {
        static void Main(string[] args)
        {
            string dataFile = "data.txt";
            string outFile = dataFile + ".out";

            using (var rdr = new StreamReader(dataFile))
            {
                using (var wr = new StreamWriter(outFile))
                {
                    while(!rdr.EndOfStream)
                    {
                        string line = rdr.ReadLine();
                        string[] s = line.Split(',');
                        int id = int.Parse(s[0]);
                        int kor = int.Parse(s[1]);
                        int eng = int.Parse(s[2]);
                        int math = int.Parse(s[3]);

                        int sum = kor + eng + math;
                        int avg = sum / 3;

                        string output = string.Format("{0}, {1}, {2}, {3}, {4}, {5}", id, kor, eng, math, sum, avg);
                            wr.WriteLine(output);
                    }
                }
            }
        }
    }
}
