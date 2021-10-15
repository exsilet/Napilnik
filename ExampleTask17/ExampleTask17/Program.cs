using System;

namespace ExampleTask17
{
    class Program
    {
        private static int _chance;
        private static int _hourlyRate;

        public static void CreatingNewObject()
        {
            //Создание объекта на карте
        }

        public static void GenerateChance()
        {
            _chance = Random.Range(0, 100);
        }

        public static int GetSalary(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
    }
}
