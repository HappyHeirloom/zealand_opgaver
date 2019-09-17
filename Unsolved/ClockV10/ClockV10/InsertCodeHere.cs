using System;

namespace ClockV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Clock myClock = new Clock(08, 23, 55);
            Console.WriteLine(myClock.displayClock);
            myClock.plusMinutes();
            Console.WriteLine(myClock.displayClock);



            // The LAST line of code should be ABOVE this line
        }
    }
}