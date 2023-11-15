using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Emne3_RandomHobbyGenerator
{
    internal class Program
    {
        private static string[] tekstArray = 
        { 
            "Du er en magiker", 
            "Du er dårlig til å kode...sorry",
            "Du er en stjerne",
            "Du er flinkeste til å kode",
            "Jeg har ingenting å si om deg dessverre..."
        };

        public static void randomHobby() 
        {
            Random number = new Random();
            Console.WriteLine("Hei, hva heter du? Si navnet ditt så jeg kan si noe om deg.");
            Console.ReadLine();
            var randomNumber = number.Next(0, 5);
            if (randomNumber == 0)
            {
                Console.WriteLine($"{tekstArray[0]}");
            }
            else if (randomNumber == 1) 
            {
                Console.WriteLine($"{tekstArray[1]}");
            }
            else if (randomNumber == 2)
            { 
                Console.WriteLine($"{tekstArray[2]}"); 
            }
            else if (randomNumber == 3) 
            { 
                Console.WriteLine($"{tekstArray[3]}"); 
            }
            else 
            { 
                Console.WriteLine($"{tekstArray[4]}"); 
            }
        }

        public static void startOver()
        {
            while (true)
            {
                Console.WriteLine("Vil du starte på nytt? (ja/nei): ");
                string response = Console.ReadLine();

                if (response == "ja")
                {
                    randomHobby();
                }
                else if (response == "nei")
                {
                    Console.WriteLine("Ok stikk ut.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response");
                }
            }
        }

        static void Main(string[] args)
        {
           randomHobby();
           startOver();
        }

    }
}
