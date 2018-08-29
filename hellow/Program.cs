/*
 * Program: hello world + input
 * Author:  Patrick Barnes
 * Date:    8/28/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isds309_hellow
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string name, class1, class2;
            string class1grade, class2grade; //able to int later when convert

            //get info
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your first class:");
            class1 = Console.ReadLine();
            Console.WriteLine("Please enter your first class grade:");
            class1grade = Console.ReadLine();
            Console.WriteLine("Please enter your second class:");
            class2 = Console.ReadLine();
            Console.WriteLine("Please enter your second class grade:");
            class2grade = Console.ReadLine();
            
            //------------output------------
            Console.WriteLine(name);
            Console.WriteLine("1. " + class1 + " " + class1grade);
            Console.WriteLine("2. " + class2 + " " + class2grade);
        }
    }
}
