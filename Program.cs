namespace GameAttach03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();
            Random rand = new Random();

            while (player.IsAlive && enemy.IsAlive)
            {
                // Player's turn
                Console.WriteLine("------------Spelares tur------------\n");
                Console.WriteLine($"Spelares Helsa: {player.Health}, fiendes Helsa: {enemy.Health}\n\n");
                Console.WriteLine("Ange 'a' för att attackera eller 'h' för att läka:\n");

                string choice = Console.ReadLine()!;

                if (choice == "a")
                {
                    player.Attack(enemy);
                }
                else if (choice == "h")
                {
                    player.Heal();
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, sväng hoppade över.\n");
                }

                if (!enemy.IsAlive)
                    break;

                // Enemy's turn
                Console.WriteLine("------------Fiendes tur------------\n");
                int enemyChoice = rand.Next(0, 2); // 0 = Attack, 1 = Heal

                if (enemyChoice == 0)
                {
                    enemy.Attack(player);
                }
                else
                {
                    enemy.Heal();
                }

                if (!player.IsAlive)
                    break;
            }

            // Game result
            if (player.IsAlive)
            {
                Console.WriteLine("Grattis, du har vunnit!\n");
            }
            else
            {
                Console.WriteLine("Game Over!  Fienden har besegrat dig.\n");
            }
        }
    }
}
