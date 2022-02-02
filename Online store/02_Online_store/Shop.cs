using System;

namespace _02_Online_store
{
    internal class Shop
    {
        private Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public bool CanSell(Good good, int count)
        {
            if (count <= _warehouse.Storage[good])
            {
                _warehouse.SubstractProduct(good, count);
                return true;
            }
            else
            {
                Console.WriteLine($"такого товара больше нельзя взять : {good.Name} - их осталось {_warehouse.Storage[good]}");
                return false;
            }
        }

        public Cart cart()
        {
            return new Cart(this);
        }
    }
}