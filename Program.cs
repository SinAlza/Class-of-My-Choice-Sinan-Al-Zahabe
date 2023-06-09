namespace Class_of_My_Choice_Sinan_Al_Zahabe
{
    internal class Program
    {

        public static Necromancer enemy;
        public static Necromancer ally;
        public static void Main(string[] args)
        {

            // Create a new Necromancer object
            Necromancer character = new Necromancer("undead Sage", 150, 300, 25, 20, 50, 50, 25, 10);
            ally = character;
            // Create a list of enemies
            List<Necromancer> enemies = new List<Necromancer>();
            enemies.Add(new Necromancer("Goblin", 50, 50, 15, 5, 5, 0, 0, 15));
            enemies.Add(new Necromancer("Orc", 100, 100, 25, 10, 10, 0, 0, 20));
            enemies.Add(new Necromancer("Dragon", 200, 200, 40, 20, 20, 20, 20, 20));

            // Create a random number generator
            Random random = new Random();

            // Generate a random enemy
            int enemyIndex = random.Next(enemies.Count);
            enemy = enemies[enemyIndex];

            // Print the enemy's name and health
            Console.WriteLine("The enemy is a {0} with {1} health!", enemy.Name, enemy.Health);

            // Create a loop that allows the user to repeatedly attack, Use Power, take damage, restore health, and restore mana
            while (character.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine(ally.Name + " Health: " + ally.Health + " Mana:" + ally.Mana);
                Console.WriteLine(enemy.Name + " Health: " + enemy.Health + " Mana:" + enemy.Mana);
                // Get the user's input
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Power");
                Console.WriteLine("3. Take damage");
                Console.WriteLine("4. Restore health");
                Console.WriteLine("5. Restore mana");
                int input = Convert.ToInt32(Console.ReadLine());

                // Perform the user's action
                switch (input)
                {
                    case 1:
                        enemy.Attack();
                        break;
                    case 2:
                        enemy.UsePower();
                        break;
                    case 3:

                        Random randoms = new Random();
                        int newRandom = randoms.Next(1, 11);
                        if (newRandom < 6)
                        {
                            character.EnemyAttack();
                        }
                        else
                        {
                            character.EnemyPower();
                        }
                        break;
                    case 4:
                        character.RestoreHealth();
                        break;
                    case 5:
                        character.RestoreMana();
                        break;
                }
                Console.Clear();
            }

            // Check if the character or enemy is still alive
            if (character.Health > 0)
            {
                Console.WriteLine("The character has defeated the enemy!");
            }
            else
            {
                Console.WriteLine("The enemy has defeated your character!");
            }
        }
    }
}