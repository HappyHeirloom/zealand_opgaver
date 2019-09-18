using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Car car1 = new Car("CK 12 989", 20000);
            Car car2 = new Car("CK 12 989", 50000);
            Console.WriteLine(car1.Price);
            Car.PrintUsageStatistics();

            Console.WriteLine();

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };
            ListMethods listMethodsObject = new ListMethods();

            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}");
            #endregion

            // The LAST line of code should be ABOVE this line
        }
    }
}