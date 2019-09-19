using System;

namespace RolePlayV20
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog);
            Beast theBeast = new Beast(theNumberGenerator, theLog);

            // Now battle...How do we do that (Hint: You need a loop)

            while (theHero.Dead != true || theBeast.Dead != true)
            {
                int heroDamage = theHero.DealDamage();
                int beastDamage = theBeast.DealDamage();
                theHero.ReceiveDamage(beastDamage);
                theBeast.ReceiveDamage(heroDamage);
            }

            theLog.PrintLog();

            // The LAST line of code should be ABOVE this line
        }
    }
}