using System;

namespace uppgift3 {
    class Program {
        static void Main(string[] args) {
            Boolean unfinished = true;
            Random r = new Random();
            int magicNumber = r.Next(1, 101);

            while(unfinished){
                Console.WriteLine("Gissa på ett nummer.");
                string guess = Console.ReadLine();
                int guessNumber = Convert.ToInt32(guess);

                if(guessNumber == magicNumber){
                    Console.WriteLine("Correct!");
                    unfinished = false;
                }
                if(guessNumber > magicNumber){
                    Console.WriteLine(guessNumber + "is higher than the magic number.");
                }
                if(guessNumber < magicNumber){
                    Console.WriteLine(guessNumber + " is lower than the magic number.");
                }

            }

        }
    }
}
