using System;

namespace MovieManagerV05
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie theCode = new Movie();
            Console.WriteLine("Choose which movie to view information about, " + "\n" + "1 = " + theCode.firstMovieTitle + "\n" + "2 = " + theCode.secondMovieTitle);
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                theCode.first_movie();
            } else if (userInput == 2)
            {
                theCode.second_movie();
            }
            


            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
