using System;

namespace RolePlayV11
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            int k = 0;
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar", 700);
            Warrior warriorB = new Warrior("Lagertha", 700);

            Console.WriteLine($"Warrior A is called {warriorA.Name} is level {warriorA.Level} and has {warriorA.HP} hp");
            Console.WriteLine($"Warrior B is called {warriorB.Name} is level {warriorB.Level} and has {warriorB.HP} hp");
            Console.WriteLine("\n");

            while (k == 0)
            {
                Console.WriteLine
                    (
                    $"{warriorA.Name} Attacks {warriorB.Name} with {warriorA.attackNum()} amount of damage " +
                    $"{warriorB.Name} now has {warriorB.HP - warriorA.attackNum()} HP"
                    );
                warriorB.decreaseHP();

                Console.WriteLine("");
                Console.WriteLine
                     (
                     $"{warriorB.Name} Attacks {warriorA.Name} with {warriorB.attackNum()} amount of damage " +
                     $"{warriorA.Name} now has {warriorA.HP - warriorB.attackNum()} HP"
                     );
                warriorA.decreaseHP();

                warriorA.LevelUp();
                Console.WriteLine($"{warriorA.Name} er level {warriorA.Level}");
                warriorB.LevelUp();
                Console.WriteLine($"{warriorB.Name} er level {warriorA.Level}");

                if (warriorA.Dead == true || warriorB.Dead == true)
                {
                    Console.WriteLine("You died!");
                    k = 1;
                }
                Console.ReadLine();
                Console.WriteLine();
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}