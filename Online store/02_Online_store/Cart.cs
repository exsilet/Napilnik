using System;
using System.Collections.Generic;

namespace _02_Online_store
{
    internal class Cart
    {
        private Shop _shop;
        private Dictionary<Good, int> _bag = new Dictionary<Good, int>();

        public Cart(Shop shop)
        {
            _shop = shop ?? throw new ArgumentNullException();
        }

        public void Add(Good good, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            else
            {
                if (_shop.CanSell(good, count))
                    _bag.Add(good, count);
            }
        }

        public void ShowAllGoods()
        {
            Console.WriteLine("Товары в корзине:");
            foreach (var good in _bag)
	        {
                Console.WriteLine($"{good.Key.Name} - {good.Value} шт. ");
	        }

            Console.WriteLine();
        }
    }
}