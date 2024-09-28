
namespace GameAttach03
{
    // Interface defining common methods for Player and Enemy

    public interface IAttacker
    {
        void Attack(IAttacker opponent);
        void Heal();
        bool IsAlive { get; }
        int Health { get; }
        void TakeDamage(int damage);
         //void sheildPower(int power);
    }
}
