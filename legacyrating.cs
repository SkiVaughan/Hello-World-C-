using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughan_Rating
{
    internal class rating
    {
        static void Main()
        {
            int rating;

            int coolness;

            int numofAS;

            int mvps;

            int hof;


            //college and professional
            int numofShips;

            int gfhotness;

            Console.WriteLine("Name of Player? ");

            string player = (Console.ReadLine());

            Console.WriteLine("How cool is your player 1 to 10 (10 is cool as can be) ");

            coolness = (int.Parse(Console.ReadLine()));

            Console.WriteLine("How many all star or pro bowls has your player been to?  ");

            numofAS = (int.Parse(Console.ReadLine()));

            Console.WriteLine("How hot is his significant other on a scale of 1-10? (if n/a answer 3)  ");

            gfhotness = (int.Parse(Console.ReadLine()));

            Console.WriteLine("How many championships has your player won (college+pro) ");

            numofShips = (int.Parse(Console.ReadLine()));

            Console.WriteLine("# of MVPS ");

            mvps = (int.Parse(Console.ReadLine()));

            Console.WriteLine("HOF? \n 1.yes \n 2. no ");

            hof = (int.Parse(Console.ReadLine()));

            if (hof==1)
            {
                hof = 10;
            }
            else
            {
                hof = 0;
            }

            if (player == "Patrick Mahomes")
            {
                Console.WriteLine("Sorry we do not rate faggots");
                rating = -100;


            }

          if (player == "Josh Allen")
            {
                Console.WriteLine("GOAT");
                rating = 99;

            }
          
         

          rating = (coolness*2) + (numofAS*2) + (numofShips*5) + (gfhotness/2) + (mvps*5) + (hof);

            if (rating >= 100)
            {
                rating = 99;

            }

            Console.WriteLine($"{player} according to the Vaughan Rating Scale has a rating of {rating}" );

            Console.ReadLine();
            

        }
    }
}
