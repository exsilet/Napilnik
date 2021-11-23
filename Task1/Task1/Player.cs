using System;

namespace Task1
{
    public class Player : ITarget
    {
        private int _health;

        public Player(int health)
        {
            if (_health <= 0)
                throw new ArgumentOutOfRangeException();

            _health = health;
        }

        public event Action OnDie;

        public bool IsAlive => _health > 0;

        public void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException();
            }

            _health -= damage;

            if (_health < damage)
            {
                throw new InvalidOperationException();
            }

            if (_health <= 0)
            {
                _health = 0;
                OnDie?.Invoke();
            }
        }
    }
}