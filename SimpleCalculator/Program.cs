using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your equation");
            string equation = (Console.ReadLine()); 

            Console.WriteLine("Write a number for x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write a number for y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("// Choose a option //");
            Console.WriteLine("1 - addition");
            Console.WriteLine("2 - subtration ");
            Console.WriteLine("3 - multification");
            Console.WriteLine("4 - division");
            //Console.WriteLine("5 - percentage");

            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine(x / y);
                    break;
                /*case 5:
                    Console.WriteLine(x / y);
                    break;*/
            }
            Console.ReadKey(true);
        }

        /*Console.WriteLine("Enter your number of friends");
          int x = Convert.ToInt32(Console.ReadLine());
          if x = 2 alive
          if x = 3 alive
          if x >= 4 dead

            {
                case 1:
                   if x = 1 Console.WriteLine(dead);
                break;
                case 2:
                    if x = 2 Console.WriteLine(alive);
                break;
                case 3:
                    if x = 3 Console.WriteLine(alive);
                break;
                case 4:
                    if x = 4 Console.WriteLine(dead);
                break;*/
    }
}
    
