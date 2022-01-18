using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDamageble player = new Player(100);
            Weapon weapon = new Weapon(3, 4);
            Bot bot = new Bot(weapon);
            bot.OnSeePlayer(player);
        }
    }
}
