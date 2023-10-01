using System.Reflection.Metadata.Ecma335;

namespace NumbersGame
{
    internal class Program
    {
        public static int CheckGuess(int randomNumber, int guessInt)
        {
            if (guessInt == randomNumber)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                return 0;
            }
            else if (guessInt > randomNumber)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
                return 1;
            }
            else
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
            }
            return 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int randomNumber = random.Next(0, 20);
            int guessCounter = 5;
            while (guessCounter != 0)
            {

            int guessInt = int.Parse(Console.ReadLine());

                if (CheckGuess(randomNumber, guessInt) != 0)
                {
                    guessCounter--;
                }
                else
                {
                    guessCounter = 0;
                }

                
            }
            if (guessCounter == 5)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }

            }
        }
    }

