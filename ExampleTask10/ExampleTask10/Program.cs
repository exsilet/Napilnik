using System;

namespace ExampleTask10
{
    class Weapon
    {
        private const byte s_hasNotBullets = 0;
        private const byte s_gunShot = 1;
        
        private int _bullets;

        public bool CanShoot() => _bullets > s_hasNotBullets;

        public void Shoot() => _bullets -= s_gunShot;
    }
}
