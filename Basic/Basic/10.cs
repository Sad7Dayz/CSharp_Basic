using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class _10
    {
        static void Main(string[] args)
        {
            string plainText = "Hello World";

            //결과값을 누적하는 변수
            StringBuilder sb = new StringBuilder();

            //각 문자 하나씩 가져옴
            foreach(char ch in plainText)
            {
                char newchar = ch;

                //문자가 알파벳인지 체크
                if((ch>='A' && ch<='Z') || (ch>='a' && ch<='z'))
                {
                    //Key = 3만큼 이등
                    newchar = (char)(ch + 3);

                    //Z를 넘는 경우 조정
                    if((Char.IsUpper(ch)&& newchar > 'Z')|| (Char.IsLower(ch)&& newchar > 'z'))
                    {
                        newchar = (char)(newchar - 26);
                    }
                }
                //새문자를 누적
                sb.Append(newchar);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
