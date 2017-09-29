using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var calls = 0;

            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine().ToLower();
                switch (product)
                {
                    case "cheese": calls += 500; break;
                    case "tomato sauce": calls += 150; break;
                    case "salami": calls += 600; break;
                    case "pepper": calls += 50; break;

                }
                
            }
            Console.WriteLine("Total calories: {0}", calls);
        }
    }
}
