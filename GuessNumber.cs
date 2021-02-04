using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_NUMBER = 1000;
            // Zufallszahlengenerator initialisieren
            Random random = new Random();
            string input;
            int number;   // zu erratende Zahl
            int counter = 0;
            int guess;

            // Zufallszahl zwischen 1 und grenze erzeugen
            number = random.Next(1, MAX_NUMBER + 1);
            Console.WriteLine("Versuche meine Zahl zu erraten (1-{0})!", MAX_NUMBER);
            do
            {
                counter++;
                Console.Write("{0}. Versuch: ", counter);
                input = Console.ReadLine();
                guess = Convert.ToInt32(input);
                if (number < guess)
                {
                    Console.Write("Gesuchte Zahl ist kleiner, ");
                }
                else if (number > guess)
                {
                    Console.Write("Gesuchte Zahl ist größer, ");
                }
            }
            while (guess != number);  // bis die Zahl endlich erraten wurde

            //Hier ist guess==number!

            if (counter > 10)
            {
                Console.WriteLine("Endlich geschafft!");
            }
            else if (counter > 5)
            {
                Console.WriteLine("Schon ganz gut!");
            }
            else
            {
                Console.WriteLine("Tolle Leistung!");
            }

            Console.Write("Beenden mit der Eingabetaste ...");
            Console.ReadLine();
        }
    }
}
