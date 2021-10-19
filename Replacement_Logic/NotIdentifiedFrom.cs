using System;

namespace Replacement_Logic
{
    public class NotIdentifiedFrom : IPaymentForm
    {
        public string Name => string.Empty;

        public bool PaymentSuccessful => false;

        public void Show()
        {
            Console.WriteLine("Неизвестный способ платежа");
        }

        public void Pay()
        {
        }
    }
}
