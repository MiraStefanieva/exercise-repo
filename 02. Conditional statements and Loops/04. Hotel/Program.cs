using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitPrice = 0;
            double totalStudio = 0;
            double totalDouble = 0;
            double totalSuit = 0;

            
                
            if( nightCount > 7 && nightCount <= 14)
            {
                switch (month)
                {
                    case "May": studioPrice = 50 * 0.95; doublePrice = 65; suitPrice = 75;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "October": studioPrice = 50 * 0.95; doublePrice = 65; suitPrice = 75;
                        totalStudio = studioPrice * (nightCount - 1);
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "June": studioPrice = 60; doublePrice = 72; suitPrice = 82;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "September": studioPrice = 60; doublePrice = 72; suitPrice = 82;
                        totalStudio = studioPrice * (nightCount - 1);
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "July": studioPrice = 68; doublePrice = 77; suitPrice = 89; totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "August": studioPrice = 68; doublePrice = 77; suitPrice = 89;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "December": studioPrice = 68; doublePrice = 77; suitPrice = 89;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                }
                
            }
            else if (nightCount > 14)
            {
                switch (month)
                {
                    case "May": 
                    case "October": studioPrice = 50; doublePrice = 65; suitPrice = 75;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "June": 
                    case "September": studioPrice = 60; doublePrice = 72 * 0.9; suitPrice = 82;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "July": 
                    case "August": 
                    case "December": studioPrice = 68; doublePrice = 77; suitPrice = 89 * 0.85;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount;
                        break;
                }
            }
            else if (nightCount <= 7)
            {
                switch (month)
                {
                    case "May":
                    case "October": studioPrice = 50; doublePrice = 65; suitPrice = 75;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "June":
                    case "September": studioPrice = 60; doublePrice = 72; suitPrice = 82;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                    case "July":
                    case "August":
                    case "December": studioPrice = 68; doublePrice = 77; suitPrice = 89;
                        totalStudio = studioPrice * nightCount;
                        totalDouble = doublePrice * nightCount;
                        totalSuit = suitPrice * nightCount; break;
                }
            }
            Console.WriteLine("Studio: {0:f2} lv.", totalStudio);
            Console.WriteLine("Double: {0:f2} lv.", totalDouble);
            Console.WriteLine("Suite: {0:f2} lv.", totalSuit);
        }
    }
}
