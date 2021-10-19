using System;

namespace Replacement_Logic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var orderForm = new OrderForm();
            var paymentHandler = new PaymentHandler();

            var paymentForm = orderForm.ShowForm();

            paymentForm.Show();

            paymentForm.Pay();

            paymentHandler.ShowPaymentResult(paymentForm);
            Console.ReadLine();
        }
    }
}