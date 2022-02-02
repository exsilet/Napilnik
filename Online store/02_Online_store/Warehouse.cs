using System;
using System.Collections.Generic;

namespace _02_Online_store
{
    internal class Warehouse
    {
        private Dictionary<Good, int> _storage = new Dictionary<Good, int>();

        public Dictionary<Good, int> Storage => _storage;
        public Good Product;

        public void Delive(Good good, int count)
        {
            Product = good ?? throw new ArgumentNullException(nameof(good));

            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
            else
            {
                _storage.Add(good, count);
            }    
                
        }

        public void SubstractProduct(Good good, int count)
        {
            int currentCount = _storage[good] - count;
            if (currentCount == 0)
            {
                _storage.Remove(good);
            }
            else
            {
                _storage[good] = currentCount;
            }
        }

        public void ShowAllGoods()
        {
            Console.WriteLine("Товары на складе:");
            foreach (var good in _storage)
            {
                Console.WriteLine($"{good.Key.Name} - {good.Value} шт. ");
            }

            Console.WriteLine();
        }
    }
}