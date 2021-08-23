using System;
using System.Collections.Generic;

namespace ExampleTask15
{
    class Program
    {
        private class Player { }
        private class Weapon { }
        private class Follow { }
        private class Unit
        {
            public IReadOnlyCollection<Unit> Units { get; private set; }
        }
    }
}
