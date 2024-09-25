using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public decimal BidAmount { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public DateTime BidTime { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Car Car { get; set; }
    }
}