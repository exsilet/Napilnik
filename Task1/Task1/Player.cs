using System;

namespace Task1
{
    public class Player : IDamageable
    {
        private int _health;

        public Player(int health)
        {
            if (_health <= 0)
                throw new ArgumentOutOfRangeException();

            _health = health;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new InvalidOperationException();
            }

            _health -= damage;

            if (_health < 0)
            {
                _health = 0;
            }
        }
    }
}