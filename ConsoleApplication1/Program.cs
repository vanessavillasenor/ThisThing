using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisApplication
{
    class ThisGame
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Guess the Magiiiic Number! oooOOOooh!");
            int magicNumber = new Random().Next(1, 51); // Random number from 1 - 50
            int initialGuess = 0; // incorrect guess
            while (initialGuess != magicNumber) // execute loop until true
            {
                initialGuess = int.Parse(Console.ReadLine()); // integer values
                if(initialGuess < magicNumber) // if lower than magicNumber
                {
                    Console.WriteLine("No, Higher!");
                }
                if(initialGuess > magicNumber) // if higher than magicNumber
                {
                    Console.WriteLine("No, Lower!");
                }
            }
            Console.WriteLine("Si, estas correct!");
        }
    }
}
