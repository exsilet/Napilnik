using System;

namespace ExampleTask10
{
    class Weapon
    {
        private const byte HasNotBullets = 0;
        private const byte GunShot = 1;
        
        private int _bullets;

        public bool CanShoot() => _bullets > HasNotBullets;

        public void Shoot() => _bullets -= GunShot;
    }
}
