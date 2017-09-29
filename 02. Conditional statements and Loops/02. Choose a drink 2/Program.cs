using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Choose_a_drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete": Console.WriteLine($"The {profession} has to pay {(0.70 * quantity):F2}."); break;
                case "Businessman": 
                case "Businesswoman": Console.WriteLine($"The {profession} has to pay {(1.00 * quantity):F2}."); break;
                case "SoftUni Student": Console.WriteLine($"The {profession} has to pay {(1.70 * quantity):F2}."); break;
                default: Console.WriteLine($"The {profession} has to pay {(1.20 * quantity):F2}."); break;

            }
        }
    }
}
