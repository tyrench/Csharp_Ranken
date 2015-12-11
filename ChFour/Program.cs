using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOnePickedAsString;
            string numTwoPickedAsString;
            string numThreePickedAsString;
            int numOnePicked;
            int numTwoPicked;
            int numThreePicked;

            Random ranNumberGenerator1 = new Random();
                int randomNumber1;
                randomNumber1 = ranNumberGenerator1.Next(1, 4);
            Random ranNumberGenerator2 = new Random();
                int randomNumber2;
                randomNumber2 = ranNumberGenerator2.Next(1, 4);
            Random ranNumberGenerator3 = new Random();
                int randomNumber3;
                randomNumber3 = ranNumberGenerator3.Next(1, 4);

            Console.WriteLine("Pick a number between 1 and 4: ");
                numOnePickedAsString = Console.ReadLine();
                numOnePicked = Convert.ToInt32(numOnePickedAsString);
            Console.WriteLine("Pick a number between 1 and 4: ");
                numTwoPickedAsString = Console.ReadLine();
                numTwoPicked = Convert.ToInt32(numTwoPickedAsString);
            Console.WriteLine("Pick a number between 1 and 4: & GOOD LUCK ");
                numThreePickedAsString = Console.ReadLine();
                numThreePicked = Convert.ToInt32(numThreePickedAsString);



            if ((numOnePicked == randomNumber1) && (numTwoPicked == randomNumber2) && (numThreePicked == randomNumber3))
                //all three numbers right
                Console.WriteLine("Controgs you win 10,000. The 3 numbers you picked was {0}, {1}, and {2} and the computer picked {3}, {4}, {5} ", numOnePicked, numTwoPicked, numThreePicked, randomNumber1, randomNumber2, randomNumber3);


            else
                if ((numOnePicked == randomNumber1) || (numTwoPicked == randomNumber2) || (numThreePicked == randomNumber3))
                //one number right
                Console.WriteLine("Congrats you win 10. The 3 numbers you picked was {0}, {1}, and {2} and the computer picked {3}, {4}, {5} ", numOnePicked, numTwoPicked, numThreePicked, randomNumber1, randomNumber2, randomNumber3);


            else 
               if (((numOnePicked == randomNumber1) && (numTwoPicked == randomNumber2)) || ((numTwoPicked == randomNumber2) && (numThreePicked == randomNumber3)) || ((numOnePicked == randomNumber1) && (numThreePicked == randomNumber3)))
                // if two numbers were guessed correctly (figure out)
                Console.WriteLine("Congrats you win 100. The 3 numbers you picked was {0}, {1}, and {2} and the computer picked {3}, {4}, {5} ", numOnePicked, numTwoPicked, numThreePicked, randomNumber1, randomNumber2, randomNumber3);


            else
                if ((numOnePicked == randomNumber1) || (numTwoPicked == randomNumber2) || (numThreePicked == randomNumber3))
                // if all three were correct but not in the right order (figure out)
                    Console.WriteLine("Congrats you win 1000. The 3 numbers you picked was {0}, {1}, and {2} and the computer picked {3}, {4}, {5} ", numOnePicked, numTwoPicked, numThreePicked, randomNumber1, randomNumber2, randomNumber3);


            else
                Console.WriteLine("You lose. The 3 numbers you picked was {0}, {1}, and {2} and the computer picked {3}, {4}, {5} ", numOnePicked, numTwoPicked, numThreePicked, randomNumber1, randomNumber2, randomNumber3);

        }
    }
}
