using System;

namespace ExampleTask17
{
    class Program
    {
        private static int _chance;
        private static int _hourlyRate;

        public static void CreatingNewObjectTheMap()
        {
            //Создание объекта на карте
        }

        public static void Luck()
        {
            _chance = Random.Range(0, 100);
        }

        public static int GetPaymentLabor(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
    }
}
