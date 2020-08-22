namespace TamagotchiServer.Models
{
    public class MenuItem : Entity
    {
        public Dish Dish { get; set; }
        public ulong Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}