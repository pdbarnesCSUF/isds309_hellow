/*
 * Program: hello world + input
 * Author:  Patrick Barnes
 * Date:    8/28/2018
 */
using System;
using static System.Console;
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
            double class1grade, class2grade;

            //get info
            Write("Please enter your name:");
            name = ReadLine();
            Write("Please enter your first class:");
            class1 = ReadLine();
            Write("Please enter your first class grade:");
            class1grade = Convert.ToDouble(ReadLine());
            Write("Please enter your second class:");
            class2 = ReadLine();
            Write("Please enter your second class grade:");
            class2grade = Convert.ToDouble(ReadLine());

            //------------output------------
            WriteLine("------------------");
            WriteLine(name);
            WriteLine("1. " + class1 + " " + class1grade);
            WriteLine("2. " + class2 + " " + class2grade);
            WriteLine("Avg:" + ((class1grade + class2grade) / 2));

            ReadLine();
        }
    }
}
