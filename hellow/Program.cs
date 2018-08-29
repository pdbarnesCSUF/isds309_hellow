using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isds309_hellow
{
    class Program
    {
        static void Pause()
        {
            Console.WriteLine("Press the anykey to continue.");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello world! again");
            string input;
            input = Console.ReadLine();

            Console.WriteLine("input:" + input);
            Pause();
        }
    }
}
