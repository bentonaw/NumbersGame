using System.Reflection.Metadata.Ecma335;

namespace NumbersGame
{
    internal class Program
    {
        //public static bool CheckGuess(int randomNumber, int guessInt)
        //{
        //    if (guessInt == randomNumber)
        //    {

        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int randomNumber = random.Next(0, 20);
            int guessCounter = 0;
            while (guessCounter <5)
            {
                int guessInt = int.Parse(Console.ReadLine());
                
                if (guessInt == randomNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    guessCounter =5;

                }
                else if (guessInt > randomNumber)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    guessCounter++;
                    if (guessCounter == 5)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    }
                }
                else 
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    guessCounter++;
                    if (guessCounter == 5)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    }

                }
                
            }
        }
    }
}