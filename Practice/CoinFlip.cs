using System;

 //Coin Flip Simulator by Hunter

namespace CoinFlipSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many times would you like to flip the coin?");
            string userInput = Console.ReadLine();

            Random rand = new Random();
            int numberOfFlips;
            int tails = 0;
            int heads = 0;
            
            if(int.TryParse(userInput, out numberOfFlips)) {
                
                for (var i = 0; i < numberOfFlips; i++)
                {
                    if (rand.Next(2) == 0)
                    {
                        tails++;
                    }
                    else
                    {
                        heads++;
                    }
                }

                Console.WriteLine("Tails: " + tails);
                Console.WriteLine("Heads: " + heads);
                Console.ReadLine();
            }


        }
    }
}
