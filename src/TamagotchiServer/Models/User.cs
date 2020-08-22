namespace TamagotchiServer.Models
{
    public class User : Entity
    {
        public string Login { get; set; }
        public Role Role { get; set; }
        public File Avatar { get; set; }
        public string FullName { get; set; }
        public string IsBlocked { get; set; }
    }
}