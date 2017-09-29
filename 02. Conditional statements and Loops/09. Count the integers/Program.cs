using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            var integerCount = 0;
            try
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());
                    integerCount++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(integerCount);
            }
        }
    }
}
