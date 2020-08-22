using System;
using System.Collections.Generic;

namespace TamagotchiServer.Models
{
    public class Order : Entity
    {
        public Restaurant Restaurant { get; set; }
        public int NumberOfPersons { get; set; }
        public List<MenuItem> Menu { get; set; }
        public List<Table> ReservedTable { get; set; }
        public string Comment { get; set; }
        public Score Score { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public OrderStaffStatus OrderCooksStatus { get; set; }
        public OrderStaffStatus OrderWaitersStatus { get; set; }
        public DateTime VisitTime { get; set; }
        public DateTime TimeCreated { get; set; }
        public List<Performer> Performers { get; set; }
    }
}