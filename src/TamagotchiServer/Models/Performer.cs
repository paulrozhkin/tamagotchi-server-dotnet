using System;

namespace TamagotchiServer.Models
{
    public class Performer : Entity
    {
        public User Staff { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}