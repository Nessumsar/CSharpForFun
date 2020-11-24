using System.Data;
using System;

namespace amerikanen_i_bastun_E
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean controller = true;
            while (controller){
            Console.WriteLine("Hello American! How hot do you wish the sauna to be?");
            String line = Console.ReadLine();
            int wish;
            if (!Int32.TryParse(line, out wish)){
                throw new InvalidExpressionException();    
            }
            int converted = convertToCelcius(wish);
            if(converted == 75){
                Console.WriteLine("Nice! That's optimal.");
                controller = false;
            }else if (converted >= 73 && converted <= 77){
                Console.WriteLine("Nice. That's acceptable.");
                controller = false;
            }else if (converted > 77){
                Console.WriteLine("That's a bit too hot but ok...");
                controller = false;
            }else{
                Console.WriteLine(converted + " is a bit too cold. Try a bit more heat.");
            }

            }

        }


        public static int convertToCelcius(int wish){
            int deduct = wish-32;
            int multi = deduct * 5;
            return (multi/9);
        }

    }
}
