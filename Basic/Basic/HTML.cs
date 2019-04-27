using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Reflection;

namespace Basic
{
    class HTML
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Please specify URL. (ex) {0} http://www.google.com", 
                    Assembly.GetExecutingAssembly().GetName().Name);
                return;
            }

            string url = args[0];

            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(url);
            string outfile = Guid.NewGuid() + ".html";
            using (var wr = new StreamWriter(outfile))
            {
                wr.WriteLine(html);
            }
        }
    }
}
