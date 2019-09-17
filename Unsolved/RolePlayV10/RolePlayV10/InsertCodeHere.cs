using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar");
            Warrior warriorB = new Warrior("Lagertha");


            Console.WriteLine($"Warrior A is called {warriorA.Name}, the level of this warrior is: {warriorA.Level} ");
            Console.WriteLine($"Warrior B is called {warriorB.Name}, the level of this warrior is: {warriorB.Level} ");

            warriorA.lvlup();

            Console.WriteLine($"Your warrior is now level {warriorA.Level}");

            // The LAST line of code should be ABOVE this line
        }
    }
}