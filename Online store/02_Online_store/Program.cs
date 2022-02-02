using System;

namespace _02_Online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");
            Good iPhone13 = new Good("IPhone 13");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Delive(iPhone12, 10);
            warehouse.Delive(iPhone11, 1);
            warehouse.Delive(iPhone13, 2);

            //Вывод всех товаров на складе с их остатком
            warehouse.ShowAllGoods();

            Cart cart = shop.cart();
            //cart.Add(iPhone12, 4);
            cart.Add(iPhone13, 2);
            cart.Add(iPhone11, 3); //при такой ситуации возникает ошибка так, как нет нужного количества товара на складе

            //Вывод всех товаров в корзине
            cart.ShowAllGoods();

            //Console.WriteLine(cart.Order.Paylink);

            cart.Add(iPhone13, 2); //Ошибка, после заказа со склада убираются заказанные товары
        }
    }
}
