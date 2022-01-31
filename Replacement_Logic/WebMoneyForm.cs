using System;

namespace Replacement_Logic
{
    public class WebMoneyForm : IPaymentForm
    {
        public string Name => "webmoney";

        public bool PaymentSuccessful { get; private set; }

        public void Show()
        {
            Console.WriteLine("Вызов API WebMoney...");
        }

        public void Pay()
        {
            PaymentSuccessful = true;
        }
    }
}
