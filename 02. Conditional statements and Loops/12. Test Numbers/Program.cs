using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            var combinations = 0;
            var sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += 3 * i * j;
                    combinations++;
                    if (sum >= boundary)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundary}");
                        return;
                    }

                }
            }
            
           
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            
            
            

        }
    }
}
