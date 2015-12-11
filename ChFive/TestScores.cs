using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class TestScores
    {
        static void Main(string[] args)
        {
            int score = 0;
            int total = 0;
            int scoreCounter = 0;

            Console.WriteLine("Welcome to the test score average calculator!");

            while (score != 101)
            {
                Console.WriteLine("Enter a score or enter 101 to get the total and average: ");
                int.TryParse(Console.ReadLine(), out score);

                if ((score < 0) || (score > 100))
                {
                    Console.WriteLine("Score Entered was not in between 0 and 100!");
                }
                else
                {
                    total = total + score;
                    scoreCounter++;
                }
            }

            Console.WriteLine();
        }
    }
}
