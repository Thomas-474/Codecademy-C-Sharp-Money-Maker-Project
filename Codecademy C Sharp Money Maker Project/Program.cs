using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecademy_C_Sharp_Money_Maker_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter amount of cents: ");

            string centsAsString = Console.ReadLine();
            double centsAsDouble = Convert.ToDouble(centsAsString);

            Console.WriteLine($"{centsAsDouble} cents is equal to...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(centsAsDouble / goldValue);
            double leftOverCentsAfterGold = centsAsDouble % goldValue;

            double silverCoins = Math.Floor(leftOverCentsAfterGold / silverValue);
            double bronzeCoins = leftOverCentsAfterGold % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {bronzeCoins}");

            Console.ReadKey();
        }
    }
}
