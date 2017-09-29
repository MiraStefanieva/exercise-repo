using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int matchCounter = 0;
            for (int i = secondNumber; i >= firstNumber; i--)
            {
                for (int j = secondNumber; j >= firstNumber; j--)
                {
                    counter++;
                    if (i + j == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
                        matchCounter++;
                        return;
                    }
                    
                }
            }
            if (matchCounter == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
           
        }
    }
}
