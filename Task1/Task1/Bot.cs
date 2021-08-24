namespace Task1
{
    internal class Bot
    {
        private readonly Weapon _weapon;
        private ITarget _target;

        public Bot(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void OnSeePlayer()
        {
            _weapon.Fire(_target);
        }
    }
}
