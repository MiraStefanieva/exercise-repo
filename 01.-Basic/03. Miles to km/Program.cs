using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {

            var mile = 1.60934;
            var input = Double.Parse(Console.ReadLine());
            var output = input * mile;
            Console.WriteLine($"{output:F2}");
        }
    }
}