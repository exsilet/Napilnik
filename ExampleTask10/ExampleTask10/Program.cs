using System;

namespace ExampleTask10
{
    class Weapon
    {
        private const byte GunShot = 1;
        
        private int _bullets;

        public bool CanShoot() => _bullets > GunShot;

        public void Shoot() => _bullets -= GunShot;
    }
}
