namespace Task1
{
    public interface ITarget
    {
        bool IsAlive { get; }

        void TakeDamage(int damage);
    }
}