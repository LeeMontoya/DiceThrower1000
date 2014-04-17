using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passing in parameters here
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");

            Console.ReadKey();
        }

        //declare a function called "ThrowDice" that takes a string parameter "diceString"
        static void ThrowDice(string diceString)
        {  //creating variable - string
            var String = "36d7";
            //spliting string into an array removing the 'd'
            string[] splitArray = String.Split('d');
            
            //converting the number of rolls into an index of 0
            int numRolls = Convert.ToInt32(splitArray[0]);
            //converting the number of sides into an index of 1
            int numSides = Convert.ToInt32(splitArray[1]);
            
            //Printing out "Throwing" to tell us what type of dice is being rolled and how many times.
                Console.WriteLine("Throwing: " + diceString);
            //printing out the "Results" of each roll
                Console.Write("Results:");

            //creating for loop to roll the dice the amount of times that is passed through in the parameter of numRolls
            var random = new Random();
            for (var i = 1; i <= numRolls; i++)
            {
                
                var theRoll = random.Next(1, numSides +1);
                Console.Write(theRoll + " ");
            }
        }
    }
}
