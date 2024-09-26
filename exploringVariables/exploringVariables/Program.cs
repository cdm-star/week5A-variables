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
            Console.WriteLine(villianName + " the ");
        }
    }
}
