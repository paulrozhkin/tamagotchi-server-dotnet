namespace TamagotchiServer.Models
{
    public class Score : Entity
    {
        public string PaymentToken { get; set; }
        public ulong PaymentAmount { get; set; }
    }
}