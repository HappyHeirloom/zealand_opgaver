using System;

namespace Flinter
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Profile profile1 = new Profile(Profile.gender.Man, Profile.hC.Blond, Profile.eC.Green, Profile.hCategory.Medium);
            Profile profile2 = new Profile(Profile.gender.Man, Profile.hC.Green, Profile.eC.Blue, Profile.hCategory.Short);
            Profile profile3 = new Profile(Profile.gender.Woman, Profile.hC.Brown, Profile.eC.Red, Profile.hCategory.Tall);

            Console.WriteLine(profile1.Description);
            Console.WriteLine(profile2.Description);
            Console.WriteLine(profile3.Description);

            // The LAST line of code should be ABOVE this line
        }
    }
}