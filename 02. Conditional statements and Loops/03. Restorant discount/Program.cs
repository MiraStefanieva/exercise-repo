using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double hallPrice = 1;
            double packagePrice = 1;
            double discount = 1;

            string hallname = null;

            if (groupSize > 120) Console.WriteLine("We do not have an appropriate hall.");

            else
            {
                if(groupSize > 100 && groupSize <= 120)
                {
                    hallname = "Great Hall";
                    switch (package)
                    {
                        case "Normal": discount = 0.95; packagePrice = 500; break;
                        case "Gold": discount = 0.90; packagePrice = 750; break;
                        case "Platinum": discount = 0.85; packagePrice = 1000; break;

                    }
                    hallPrice = (7500 + packagePrice) * discount;
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    hallname = "Terrace";
                    switch (package)
                    {
                        case "Normal": discount = 0.95; packagePrice = 500; break;
                        case "Gold": discount = 0.90; packagePrice = 750; break;
                        case "Platinum": discount = 0.85; packagePrice = 1000; break;

                    }
                    hallPrice = (5000 + packagePrice) * discount;
                }
                else if (groupSize <= 50)
                {
                    hallname = "Small Hall";
                    switch (package)
                    {
                        case "Normal": discount = 0.95; packagePrice = 500; break;
                        case "Gold": discount = 0.90; packagePrice = 750; break;
                        case "Platinum": discount = 0.85; packagePrice = 1000; break;

                    }
                    hallPrice = (2500 + packagePrice) * discount;
                }
                double pricePerPerson = hallPrice / groupSize;
                Console.WriteLine("We can offer you the {0:F2}", hallname);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            
                

        }
    }
}
