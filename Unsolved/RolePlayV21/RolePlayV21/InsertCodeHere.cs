using System;
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression

namespace RolePlayV21
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator generator = new NumberGenerator();
            BattleLog log = new BattleLog();

            // Battle logic (1-on-1)
            #region 1-on-1 battle logic
            //Hero theHero = new Hero(generator, log, "Olafur", 100, 10, 30);
            //Beast theBeast = new Beast(generator, log, "Zakhial", 90, 10, 25);

            //while (!theHero.Dead && !theBeast.Dead)
            //{
            //    int damageByHero = theHero.DealDamage();
            //    theBeast.ReceiveDamage(damageByHero);

            //    if (!theBeast.Dead)
            //    {
            //        int damageByBeast = theBeast.DealDamage();
            //        theHero.ReceiveDamage(damageByBeast);
            //    }
            //}

            //log.PrintLog();
            //Console.WriteLine();
            //if (theBeast.Dead)
            //{
            //    Console.WriteLine($"The Hero {theHero.Name} was Victorious!!");
            //}
            //else
            //{
            //    Console.WriteLine($"The Beast {theBeast.Name} won... ;-(");
            //}
            #endregion


            // New battle logic (1-on-many)
            #region 1-on-many battle logic
            int heroWon = 0;
            int armyWon = 0;

            Hero hero = new Hero(generator, log, "stupid", 200, 20, 30);
            BeastArmy theArmy = new BeastArmy();
            Beast beast1 = new Beast(generator, log, "idiot", 100, 5, 10);
            Beast beast2 = new Beast(generator, log, "idiot2", 20, 5, 10);
            Beast beast3 = new Beast(generator, log, "idiot3", 80, 5, 10);
            Beast beast4 = new Beast(generator, log, "idiot4", 300, 10, 10);

            theArmy.AddBeast(beast1);
            theArmy.AddBeast(beast2);
            theArmy.AddBeast(beast3);
            theArmy.AddBeast(beast4);


            for (int i = 0; i < 100; i++)
            {
                while (!hero.Dead && !theArmy.Dead)
                {
                    int heroDamage = hero.DealDamage();
                    theArmy.ReceiveDamage(heroDamage);

                    if (!theArmy.Dead)
                    {
                        int armyDamage = theArmy.DealDamage();
                        hero.ReceiveDamage(armyDamage);
                    }
                }


                log.PrintLog();
                Console.WriteLine();
                if (theArmy.Dead)
                {
                    Console.WriteLine($"The Hero {hero.Name} was Victorious!!");
                    ++heroWon;
                }
                else
                {
                    Console.WriteLine($"The Beast army won... ;-(");
                    ++armyWon;
                }
                Console.WriteLine($"The Hero was won: {heroWon} times");
                Console.WriteLine($"The army has won: {armyWon} times");
            }
            #endregion

            // The LAST line of code should be ABOVE this line
        }
    }
}