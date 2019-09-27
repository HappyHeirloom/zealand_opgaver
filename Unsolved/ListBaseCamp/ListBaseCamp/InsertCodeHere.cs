using System;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable CollectionNeverQueried.Local

namespace ListBaseCamp
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> listOfInt = new List<int>();
            listOfInt.Add(4);
            listOfInt.Add(12);
            listOfInt.Add(9);

            // Case 1
            Console.WriteLine($"Case 1: Element with index 1 is {listOfInt[1]}");
            Console.WriteLine();

            // Case 2
            Console.WriteLine($"Case 2: List contains {listOfInt.Count} elements");
            Console.WriteLine();

            listOfInt.Add(5);
            listOfInt.Add(22);

            // Case 3
            Console.WriteLine($"Case 3: Element with index 3 is {listOfInt[3]}");
            Console.WriteLine();

            listOfInt.RemoveAt(0);

            // Case 4
            Console.WriteLine($"Case 4: Element with index 3 is {listOfInt[3]}");
            Console.WriteLine();



            listOfInt.Clear();
            listOfInt.Add(14);
            listOfInt.Add(87);
            listOfInt.Add(62);
            listOfInt.Add(21);
            listOfInt.Add(40);
            listOfInt.Add(3);

            // Case 5: Add code that prints out 
            //all the elements in the list
            for (int i = 0; i < listOfInt.Count; i++)
            {
                Console.WriteLine(listOfInt[i]);
            }
            Console.WriteLine();



            // Case 6: Add code that finds the 
            // sum of the elements in the list, and prints the result
            int sum = 0;

            for (int i = 0; i < listOfInt.Count; i++)
            {
                sum = sum + listOfInt[i];
                Console.WriteLine(sum);
            }
            Console.WriteLine();



            // [DIFFICULT]
            // Case 7: Add code that finds the smallest  
            // element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually
            //Console.WriteLine(listOfInt.Min());
            //Console.WriteLine();

            int lowestValue;
            if (listOfInt.Any())
            {
                lowestValue = int.MaxValue;
                foreach (int item in listOfInt)
                {
                    if (item <= lowestValue)
                    {
                        lowestValue = item;
                        Console.WriteLine(item);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                lowestValue = 0;
                Console.WriteLine();
            }



            // [(maybe) DIFFICULT]
            // Case 8: Add code that sorts the content of the list.
            // Tip: Think before you code...
            listOfInt.Sort();
            for (int i = 0; i < listOfInt.Count; i++)
            {
                Console.WriteLine(listOfInt[i]);
            }
            listOfInt.ForEach(Console.WriteLine);


            // The LAST line of code should be ABOVE this line
        }
    }
}