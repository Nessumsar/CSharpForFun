using System;

namespace uppgift1
{
 class Program{
        static void Main(string[] args){

            Console.Write("Skriv in ditt förnamn.");
            string firstName = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn."); 
            string lastName = Console.ReadLine();

            string fullName = firstName + lastName;

            Console.WriteLine("Hur gammal är du?");

            int age = int.Parse(Console.ReadLine());
            int pension = 65;
            int difference = pension - age;

            Console.WriteLine("Hej " + name + ". Du är " + age + "år. Du har " + difference + " år kvar till pensionen.");

            Console.ReadLine();
        }
       
    }

}