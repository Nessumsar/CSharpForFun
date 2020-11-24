using System;

namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett nummer med decimaler.");
			string enteredString = Console.ReadLine();
			double enteredNumber = Convert.ToDouble(enteredString);

			Console.WriteLine("Hur många decimaler vill du avrunda till?");
			string dec = Console.ReadLine();
            int decimals = Convert.ToInt32(dec);

			Console.Write("Då avrundar vi det till: ");
			Console.WriteLine(Math.Round( enteredNumber , decimals ));
        }
    }
}
