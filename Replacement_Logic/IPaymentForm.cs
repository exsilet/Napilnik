namespace Replacement_Logic
{
    public interface IPaymentForm
    {
        bool PaymentSuccessful { get; }

        string Name { get; }

        void Show();

        void Pay();
    }
}
