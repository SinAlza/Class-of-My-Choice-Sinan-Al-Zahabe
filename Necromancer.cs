namespace Class_of_My_Choice_Sinan_Al_Zahabe
{
    public class Necromancer
    {

        //Properties

        // The character's name
        public string Name { get; set; }

        // The character's health
        public int Health { get; set; }

        // The character's mana
        public int Mana { get; set; }

        // The character's strength
        public int Strength { get; set; }

        // The character's dexterity
        public int Dexterity { get; set; }

        // The character's intelligence
        public int Intelligence { get; set; }

        // The character's wisdom
        public int Wisdom { get; set; }

        // The character's constitution
        public int Constitution { get; set; }

        // the chracter's defense
        public int Defense { get; set; }



        //Constructor

        // Create a new Necromancer object
        public Necromancer(string name, int health, int mana, int strength, int dexterity, int intelligence, int wisdom, int constitution, int defense)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Constitution = constitution;
            Defense = defense;
        }



        // Methods

        // Attack an enemy
        public void Attack()
        {
            Health -= Program.ally.Strength - Defense;
            Console.WriteLine("You Slashed the enemy with your scythe.");
            Console.ReadLine();

            //// TODO: Implement attack method
            //// This method will calculate the damage that the character deals to an enemy.
            //// Get the enemy's health
            //int enemyHealth = Health;

            //// Calculate the damage that the Necromancer deals to the enemy
            //int damage = Strength - Defense;

            //// Reduce the enemy's health by the damage dealt
            //enemyHealth -= damage;

            // Check if the enemy is dead
            if (Health <= 0)
            {
                // The enemy is dead
                Console.WriteLine("You have defeated the enemy!");
            }

        }
        public void EnemyAttack()
        {
            Health -= Program.enemy.Strength - Defense;
            Console.WriteLine("Enemy has charged at you!");
            Console.ReadLine();


            if (Health <= 0)
            {
                // The enemy is dead
                Console.WriteLine("You have Died...");
            }

        }

        // Cast Powers
        public void UsePower()
        {
            Health -= Program.ally.Intelligence - Defense;
            Program.ally.Mana -= 65;
            Console.WriteLine("You cast Toll of the Dead.");
            Console.ReadLine();
            //// TODO: Implement Use Power method
            //// This method will calculate the damage that the character deals to an enemy, or the effect that the character has on the environment.
            //// Get the Power's damage
            //int powerDamage = Intelligence;

            //// Get the enemy's health
            //int enemyHealth = Health;

            //// Reduce the enemy's health by the Power damage
            //enemyHealth -= powerDamage;

            // Check if the enemy is dead
            if (Health <= 0)
            {
                // The enemy is dead
                Console.WriteLine("Your Power has defeated the enemy!");
            }
        }

        public void EnemyPower()
        {
            Health -= Program.enemy.Intelligence - Defense;
            Program.enemy.Mana -= 60;
            Console.WriteLine("Enemy breathes Fire.");
            Console.ReadLine();

            if (Health <= 0)
            {
                // The enemy is dead
                Console.WriteLine("You have Died....");
            }
        }

        // Take damage
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        // Restore health
        public void RestoreHealth()
        {
            Health += 50;
            Console.WriteLine("You drank a Potion.");
            Console.ReadLine();
        }

        // Restore mana
        public void RestoreMana()
        {
            Mana += 50;
            Console.WriteLine("You drank an Ether.");
            Console.ReadLine();
        }

        //Enemy Attack Method
        public void AttackPlayer()
        {
            // Get the player's health
            int playerHealth = Health;

            // Calculate the damage that the enemy deals to the player
            int damage = Strength - Defense;

            // Reduce the player's health by the damage dealt
            playerHealth -= damage;

            // Check if the player is dead
            if (playerHealth <= 0)
            {
                // The player is dead
                Console.WriteLine("You have Died....");
                Console.ReadLine();
            }


            // Get the player's health
            int NecromancerHealth = Health;

            // Calculate the damage that the enemy deals to the player
            int damage1 = Strength - Defense;

            // Get a random number between 0 and 1
            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            // Check if the enemy's accuracy is greater than the random number
            if (5 > randomNumber)
            {
                // The enemy hits the player
                playerHealth -= damage1;

                // Check if the player is dead
                if (playerHealth <= 0)
                {
                    // The player is dead
                    Console.WriteLine("You have Died....");
                    Console.ReadLine();
                }
            }
            else
            {
                // The enemy misses the player
                Console.WriteLine("You Dodged the Enemy's attack!");
                Console.ReadLine();

            }

        }

    }

}

