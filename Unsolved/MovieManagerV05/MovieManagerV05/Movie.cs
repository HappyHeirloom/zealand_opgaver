using System;

namespace MovieManagerV05
{
    public class Movie
    {
        string forChildren;
        public string firstMovieTitle = "Den lille kanin";
        public string secondMovieTitle = "Kaninus";

        public void first_movie()
        {

            // The FIRST line of code should be BELOW this line

            int movieLength = 120;
            int movieSerieNumber = 1;
            string movieInstructor = "Marc Johnson";
            bool underAged = true;

            if (underAged == true)
            {
                forChildren = "suitable for children";
            }
            else
            {
                forChildren = "not suitable for children";
            }


            Console.WriteLine
                (
                "The movie title is: " + firstMovieTitle + "\n\n" +
                "The movie length is: " + movieLength + " minutes long" + "\n\n" +
                "The movie is number " + movieSerieNumber + " in the serie" + "\n\n" +
                "The instructor of the movie is: " + movieInstructor + "\n\n" +
                "The movie is " + forChildren + "\n\n"

                );
            // The LAST line of code should be ABOVE this line
        }

        public void second_movie()
        {

            int movieLength = 160;
            int movieSerieNumber = 3;
            string movieInstructor = "Steven Spielberg";
            bool underAged = false;

            if (underAged == true)
            {
                forChildren = "suitable for children";
            } else
            {
                forChildren = "not suitable for children";
            }


            Console.WriteLine
                (
                "The movie title is: " + secondMovieTitle + "\n\n" + 
                "The movie length is: " + movieLength + " minutes long" + "\n\n" + 
                "The movie is number " + movieSerieNumber + " in the serie" + "\n\n" +
                "The instructor of the movie is: " + movieInstructor + "\n\n" +
                "The movie is " + forChildren + "\n\n"

                );

        }
    }
}
