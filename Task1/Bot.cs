namespace Task1
{
    internal class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void OnSeePlayer(IDamageble target)
        {
            _weapon.Fire(target);
        }
    }
}
