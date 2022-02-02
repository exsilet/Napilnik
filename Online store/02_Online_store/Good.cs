using System;

namespace _02_Online_store
{
    internal class Good
    {
        public string Name => _name;

        private string _name;

        public Good(string name)
        {
            if (IsNotValidName(name))
                throw new ArgumentOutOfRangeException(nameof(name));

            _name = name;
        }

        private bool IsNotValidName (string name)
        {
            if (string.IsNullOrEmpty(name))
                return true;

            return false;
        }
    }
}