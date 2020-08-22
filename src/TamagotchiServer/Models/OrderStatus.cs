namespace TamagotchiServer.Models
{
    public enum OrderStatus
    {
        Created,
        NoPlace,
        PaymentMadeing,
        PaymentError,
        Confirmed,
        Preparing,
        Prepared,
        Completed
    }
}