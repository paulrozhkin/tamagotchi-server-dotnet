using System.Collections.Generic;

namespace TamagotchiServer.Models
{
    public class Dish : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<File> Photos { get; set; }
    }
}