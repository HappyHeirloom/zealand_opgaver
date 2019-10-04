﻿namespace RolePlayV23
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new Character("Angor", 100, 15, 25));
            redTeam.AddCharacter(new Character("Zurin", 85, 18, 30));
            redTeam.AddCharacter(new Defender("DefenderRed", 200, 5, 10));
            redTeam.AddCharacter(new Damager("DamagerRed", 100, 20, 20));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Character("Baldur", 120, 12, 18));
            greenTeam.AddCharacter(new Character("Eliza", 80, 20, 35));
            greenTeam.AddCharacter(new Defender("DefenderGreen", 200, 5, 10));
            greenTeam.AddCharacter(new Damager("DamagerGreen", 100, 20, 20));

            BattleHandler.DoBattle(redTeam, greenTeam);

            // The LAST line of code should be ABOVE this line
        }
    }
}