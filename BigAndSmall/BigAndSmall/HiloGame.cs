using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigAndSmall
{
    public static class HiloGame
    {
        public const int MAXIMUM = 100;
        static Random random = new Random();
        private static int currentNumber  = random.Next(1,MAXIMUM +1 );
        private static int newNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 11;

        public static void Guess(bool higer)
        {
            Console.WriteLine("\n");
            newNumber = random.Next(1,MAXIMUM +1);
            if (higer)
            {
                if(newNumber >= currentNumber)
                {
                    Console.WriteLine("Ти вгадав!");
                    pot++;
                }
                else
                {
                    Console.WriteLine("Ох, тобi не пощастило!");
                    pot--;
                }
            }
            else
            {
                if (newNumber <= currentNumber)
                {
                    Console.WriteLine("Ти вгадав!");
                    pot++;
                }
                else
                {
                    Console.WriteLine("Ох, тобi не пощастило!");
                    pot--;
                }
            }
            currentNumber = newNumber;
            Console.WriteLine($"Число : {currentNumber}");
        }

        public static void Hint()
        {
            Console.WriteLine("\n");
            int half = MAXIMUM / 2;
            if (newNumber <= half)
            {
                Console.WriteLine($"Це число менше за {half} !");
                pot--;
            }
            else
            {
                Console.WriteLine($"Це число бiльше {half}");
                pot--;
            }
        }

        public static int GetPot()
        {
            return pot;
        }
    }
}
