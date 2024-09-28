




namespace GameAttach03
{
    public abstract class Character : IAttacker
    {
        private string name;
        private int health ;
        private int attackPower ;
        private int healAmount ;

        public int Health => health;

        public bool IsAlive => health > 0;


        public Character(string name, int health, int attackPower)
        {
            this.name = name;   
            this.health = health;
            this.healAmount = health;
            this.attackPower = attackPower;
        }



        public void Attack(IAttacker opponent)
        {
            opponent.TakeDamage(attackPower);
            Console.WriteLine($"{name} attackera och gör {attackPower} skada!\n");
        }

        public void Heal()
        {
            health += healAmount;
            Console.WriteLine($"{name} läker och har {healAmount} hälsopoäng!\n");
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"{name} tar {damage} skada.\n");
        }
    }

}
