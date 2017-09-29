using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var heighth = double.Parse(Console.ReadLine());
            var area = width * heighth;
            Console.WriteLine($"{area:F2}");

        }
    }
}