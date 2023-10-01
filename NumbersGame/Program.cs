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
        public static string difficulty(int difficulty)
        {
            switch(difficulty)
            {
                case 1:
                    return ("1. Nummret är mellan 0-20 och du får fem försök.");
                    break;
                case 2:
                    return ("2. Nummret är mellan 0-30 och du får fyra försök.");
                    break;
                case 3:
                    return ("3. Nummret är mellan 0-50 och du får fyra försök.");
                    break;
                default:
                    return ("Jag förstod inte riktigt vad du menade, välj svårighetsgrad mellan 1-3.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket?");
            Console.WriteLine("Välj svårighetsgrad:");
            Console.WriteLine(difficulty(1));
            Console.WriteLine(difficulty(2));
            Console.WriteLine(difficulty(3));

            int difficultyInt = int.Parse(Console.ReadLine());
            Random random = new Random();
            int randomNumber = 0;
            int guessCounter = 0;

            switch (difficultyInt)
            {
                case 1:
                    randomNumber = random.Next(0, 20);
                    guessCounter = 5;
                    Console.WriteLine("Du har valt svårighetsgrad 1. Varssågod och börja gissa:");
                    break;
                case 2:
                    random = new Random();
                    randomNumber = random.Next(0, 30);
                    guessCounter = 4;
                    Console.WriteLine("Du har valt svårighetsgrad 2. Varssågod och börja gissa:");
                    break;
                case 3:
                    random = new Random();
                    randomNumber = random.Next(0, 50);
                    guessCounter = 4;
                    Console.WriteLine("Du har valt svårighetsgrad 3. Varssågod och börja gissa:");
                    break;
                default:
                    Console.WriteLine("Jag förstod inte riktigt vad du menade, välj svårighetsgrad mellan 1-3.");
                    difficultyInt = int.Parse(Console.ReadLine());
                    break;
            }
            
            while (guessCounter != 0)
            {

            int guessInt = int.Parse(Console.ReadLine());

                if (CheckGuess(randomNumber, guessInt) != 0)
                {
                    guessCounter--;
                    if (guessCounter == 5)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    }
                }
                else
                {
                    guessCounter = 0;
                }

            }
            

            }
        }
    }

