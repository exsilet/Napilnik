using System;

namespace Replacement_Logic
{
    public class QIWIForm : IPaymentForm
    {
        public string Name => "qiwi";

        public bool PaymentSuccessful { get; private set; }

        public void Show()
        {
            Console.WriteLine("Перевод на страницу QIWI...");
        }

        public void Pay()
        {
            PaymentSuccessful = true;
        }
    }
}
