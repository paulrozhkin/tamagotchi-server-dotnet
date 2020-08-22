using System.Collections.Generic;

namespace TamagotchiServer.Models
{
    public class Table : Entity
    {
        public string Description { get; set; }
        public List<File> Photos { get; set; }
        public bool IsDeleted { get; set; }
    }
}