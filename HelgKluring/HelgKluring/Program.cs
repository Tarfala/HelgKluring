using System;

namespace HelgKluring
{
    public class Program
    {
        public static int numberOfDidgits = 0;

        static void Main(string[] args)
        {
            while (true) // Ta bort loopen ifall programmet endast ska köras 1 gång
            {
                RunProgram();
            }
        }

        private static void RunProgram()
        {
            int? input = GetInputFromUser(); // Tar fram, och validerar det användaren skriver in
            if (input != null)
            {
                Console.WriteLine("Antal siffror i talet är: " + NumDigits((int)input));
            }

            Console.WriteLine("Klicka på valfri knapp för att testa igen");
            Console.ReadKey();
            numberOfDidgits = 0;
            Console.Clear();
        }
    

        private static int? GetInputFromUser()
        {
            Console.WriteLine("Ange ett nummer och klicka på enter:");
            try
            {
                int input = int.Parse(Console.ReadLine());
                return input;
            }
            catch (Exception) // Om parsen inte funkar returneras null 
            {
                Console.WriteLine("Du måste ange ett heltal (max +/- 2,147,483,647), klicka på valfri knapp för att försöka igen");
                return null;
            }
        }

        private static int NumDigits(int input)
        {
            numberOfDidgits++;
            input /= 10;
            if (input == 0)
            {
                return numberOfDidgits;
            }            
            NumDigits(input);
            
            //if (input != 0) // Ta bort denna If-satsen ifall talet 0 inte ska räknas som en siffra (0 returnerar i så fall 0)
            //{
            //    return 1;
            //}

            //while (input != 0) 
            //{
            //    numberOfDidgits++;
            //    input /= 10;
            //}


            return numberOfDidgits;
        }
    }
}
