using System;

namespace ExampleTask10
{
    class Weapon
    {
        private const byte _hasNotBullets = 0;
        private const byte _gunShot = 1;
        
        private int _bullets;

        public bool CanShoot() => _bullets > _hasNotBullets;

        public void Shoot() => _bullets -= _gunShot;
    }
}
