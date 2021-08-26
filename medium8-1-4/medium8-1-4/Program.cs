using System;

namespace medium8_1_4
{
    class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public void Move()
        {
            //Do move
        }

        public void Attack()
        {
            //attack
        }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }
    }

    class Movement
    {
        public float Speed { get; private set; }
        public float DirectionX { get; private set; }
        public float DirectionY { get; private set; }
    }

    class Weapon
    {
        public int Damage { get; private set; }
        public float Cooldown { get; private set; }
    }
}
