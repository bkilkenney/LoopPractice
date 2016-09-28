using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********************************Most basic is while loop, "while something is true do this************************************
            //Need to set a variable
            //Need to increment it

            int indiansWins = 75;
            while (indiansWins < 90)
            {
                Console.WriteLine("We need 90 wins to get into the playoffs.  We have " +indiansWins+"wins!!!");
                indiansWins++;
            }

            //***********************************************************************************************************************************


        }
    }
}


