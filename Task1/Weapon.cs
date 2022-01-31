﻿using System;

namespace Task1
{
    internal class Weapon
    {
        private int _damage;
        private int _bullets;

        public Weapon(int damage, int bullets)
        {
            _damage = damage;
            _bullets = bullets;
        }

        public void Fire(IDamageble target)
        {
            if (_bullets <= 0)
            {
                throw new InvalidOperationException();
            }

            target.TakeDamage(_damage);
            _bullets--;
        }
    }
}
