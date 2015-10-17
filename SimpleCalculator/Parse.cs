using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Parse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your equation");
            string expressions = (Console.ReadLine());

            string pattern = @"(\d+)\s+([-+*%/])\s+(\d+)";

            foreach (Match m in Regex.Matches(expressions, pattern))
            {
                int value1 = Int32.Parse(m.Groups[1].Value);
                int value2 = Int32.Parse(m.Groups[3].Value);
                switch (m.Groups[2].Value) 
}
        }
    }
}
