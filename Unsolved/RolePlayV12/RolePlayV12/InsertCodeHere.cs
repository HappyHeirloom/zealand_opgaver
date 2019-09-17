using System;

namespace RolePlayV12
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar", 200);
            Warrior warriorB = new Warrior("Lagertha", 200);

            Console.WriteLine("Just after creation:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            int damageFromA = warriorA.DealDamage();
            int damageFromB = warriorB.DealDamage();
            warriorA.ReceiveDamage(damageFromB);
            warriorB.ReceiveDamage(damageFromA);

            Console.WriteLine("After damage:");
            warriorA.changeWeapon();
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine($"{warriorA.Name} changes his main hand weapon to: {warriorA.WeaponName}");

            Console.WriteLine();

            damageFromA = warriorA.DealDamage();
            damageFromB = warriorB.DealDamage();
            warriorA.ReceiveDamage(damageFromB);
            warriorB.ReceiveDamage(damageFromA);

            Console.WriteLine("After damage:");
            warriorB.changeWeapon();
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine($"{warriorB.Name} changes his main hand weapon to: {warriorB.WeaponName}");

            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}