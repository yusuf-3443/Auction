using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Area { get; set; }
        public string TypeOfBuilding { get; set; }
        public int Floor { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal Price { get; set; }
        public string Renovation { get; set; }
        public string Condition { get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
    }
}