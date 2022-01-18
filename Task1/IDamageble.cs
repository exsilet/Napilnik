namespace Task1
{
    public interface IDamageble
    {
        bool CanRecieveDamage { get; }

        void TakeDamage(int damage);
    }
}