namespace exploringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Colin";
            string heroLastName = "Moore";
            string heroFullName;
            string villianTitle = "The Blue Warlock of the East";
            string minionTitle =  "The bouncer";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //Begin Code Instructions

            heroFullName = heroFirstName + " " + heroLastName;
           Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villianName = "Dr. Platter";
            minion1Name = "Bob";
            minion2Name = "Mike";

            Console.WriteLine(heroFullName + "'s arch rival is " + villianName + " the " +villianTitle);

            //Don't forget about the minions
            Console.WriteLine(villianName + " the " + villianTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            //Are you prepared to fight!?
            Console.WriteLine("The fighter eneter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //Time to fight!
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Minions attack
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero turn to attack
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
            //do math
            //Take the current health, subtract the damage then store the new value back into health
            //but this time lets use the combination assignment and arithemtic operator
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + "now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " the " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " the " + minion2Name + " now has " + minion2Health + " health!");

            //The minion have  been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated by the glorious hero: " + heroFullName);

            //End of round buff!
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats a cake to restore halth!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //final round of fight
            Console.WriteLine("The remaining fighter continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossStrength);
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Hero turn to attack
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");
            //do math
            bossHealth = bossHealth - heroStrength;
            //Display result to the console
            Console.WriteLine(villianName + " the " + villianTitle + "now has " + bossHealth + " health!");
            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine(heroFullName + " then takes the ice cream sundae that his arch rival " + villianName + " the " + villianTitle + " he has orgianl stolen from " + heroFullName + " hometwon called Candyville");
            Console.WriteLine( "When " + heroFullName + " return home his village isso happy that they got the ice cream sundae back and knew that " + heroFullName + " faced a tough challenge so they then give the ice cream to " + heroFullName + " in order for him eat and to restore all the heath he lost!");
            //do math
            heroHealth += 59;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health");
            Console.WriteLine("Glory for the hero of Candyvile");



        }
    }
}
