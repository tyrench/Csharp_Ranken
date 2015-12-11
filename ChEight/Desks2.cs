using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desks2
{
    class Desks2
    {
        static void Main(string[] args)
        {
            int drawsMethod=0, cost=0;
            DisplayNumberOfDraws(out drawsMethod);
            DisplayTypeOfWood(out cost);
            DisplayCalcOfDesk(cost, drawsMethod);


        }
        private static void DisplayNumberOfDraws(out int drawsMethod)
        {
            WriteLine("How many draws would you like?  ");
            string input = ReadLine();
            drawsMethod = Convert.ToInt32(input);
        }
        private static void DisplayTypeOfWood(out int cost)
        {
            char letter = 'o';
            WriteLine("What kind of wood would you like? Mahogany(m), Oak(o), and Pine(p):  ");
            string input = ReadLine();
            letter = Convert.ToChar(input);

            cost = 0;
            string name = "name";

            if ((letter == 'M') || (letter == 'm'))
            {
                name = "mahoganey";
                cost = 180;
                WriteLine("You picked {0}", name);

            }
            if ((letter == 'O') || (letter == 'o'))
            {
                name = "Oak";
                cost = 140;
                WriteLine("You picked {0}", name);

            }
            if ((letter == 'P') || (letter == 'p'))
            {
                name = "Pine";
                cost = 100;
                WriteLine("You picked {0}", name);
            }
            
        }
        private static void DisplayCalcOfDesk(int woodMethod, int numOfDraws)
        {
            int totalDrawCost = numOfDraws * 30;
            int totalForDesk = totalDrawCost + woodMethod;
            
            WriteLine("Your total for the draws is {0}", totalDrawCost.ToString("C"));
            WriteLine("Your total for the wood {0}", woodMethod.ToString("C"));
            WriteLine("Your total for the desk would be {0}", totalForDesk.ToString("C"));
        }
    }
}
