using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello World";
            string second = new object<string>("Hello World");

            bool equal1 = first == second;
            bool equal2 = first.Equals(second);

            Console.WriteLine("== is : {0}", equal1);
            Console.WriteLine("Equals is : {0}", equal2);
            Console.ReadKey();
        }
    }
}
