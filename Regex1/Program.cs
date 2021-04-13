using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem ipsum chu sho.";
            var output = Regex.Replace(str.Split()[0], @"[^0-9a-zA-Z\ ]+", "");
            var output1 = Regex.Replace(str.Split().Last(), @"[^0-9a-zA-Z\ ]+", "");
            Console.WriteLine(output + " " + output1);

            Console.WriteLine("Browser Changing . . . "); //-_-_-_-
            Console.ReadKey();
        }
    }
}
