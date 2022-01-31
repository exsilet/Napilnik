using System;

namespace Task1
{
    public class Player : IDamageble
    {
        private int _health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException();

            _health = health;
        }

        public bool CanRecieveDamage => _health > 0;

        public void TakeDamage(int damage)
        {
            if (CanRecieveDamage == false)
                throw new InvalidOperationException("CanRecieveDamage is false");

            if (damage < 0)
                throw new InvalidOperationException("Damage cannot be less than zero");

            if (damage > _health)
                throw new InvalidOperationException("damage dealt more than health");

            _health -= damage;
        }
    }
}