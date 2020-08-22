namespace TamagotchiServer.Models
{
    public class File : Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
    }
}