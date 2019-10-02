using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            string name;
            int age;
            int number;

            Console.WriteLine("Please tell me your name");
            name = Console.ReadLine();
            Console.WriteLine("Please tell me your age in numbers");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please tell me your phonenumber in numbers");
            number = Int32.Parse(Console.ReadLine());



            Person person1 = new Person("Jonas", 20, 21562886);
            Person person2 = new Person("Alex", 20, 30860306);
            Person user = new Person(name, age, number);

            person1.PrintAll();
            person2.PrintAll();
            user.PrintAll();

            person1.increaseAge();

            // The LAST line of code should be ABOVE this line
        }
    }
}