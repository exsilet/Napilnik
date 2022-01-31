using System;

namespace ExampleTask1
{
    class Program
    {
        public static int GetNumber(int a, int b, int c)
        {
            if (a < b)
                return b;
            else if (a > c)
                return c;
            else
                return a;
        }
    }
}
