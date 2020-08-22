using System.Collections.Generic;

namespace TamagotchiServer.Models
{
    public class Restaurant : Entity
    {
        public string Address { get; set; }
        public double PositionLatitude { get; set; }
        public double PositionLongitude { get; set; }
        public bool IsParkingPresent { get; set; }
        public bool IsCardPaymentPresent { get; set; }
        public bool IsWifiPresent { get; set; }
        public List<File> Photos { get; set; }
        public List<MenuItem> Menu { get; set; }
        public List<Table> Tables { get; set; }
        public bool IsDeleted {get; set; }
    }
}