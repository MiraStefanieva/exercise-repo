using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int ingredientsNumber = 0;
            while( input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                ingredientsNumber++;
            }
            Console.WriteLine($"Preparing cake with {ingredientsNumber} ingredients.");
        }
    }
}
