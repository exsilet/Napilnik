using System;

namespace Replacement_Logic
{
    public class CardForm : IPaymentForm
    {
        public string Name => "card";

        public bool PaymentSuccessful { get; private set; }

        public void Show()
        {
            Console.WriteLine("Вызов API банка эмитера карты Card...");
        }

        public void Pay()
        {
            PaymentSuccessful = true;
        }
    }
}
