using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _9
    {
        static void Main(string[] args)
        {
            string s = "Hello World";

            string result = string.Empty;
            for(int i=0; i<s.Length; i++)
            {
                char t = s[i];
                if (char.IsUpper(t))
                {
                    t = char.ToLower(t);
                }
                else if (char.IsLower(t))
                {
                    t = char.ToUpper(t);
                }
                result = result + t;
            }
            Console.WriteLine(result);
        }
    }
}
