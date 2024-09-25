using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs.CarDTOs
{
    public class UpdateCarDto
    {
           public int Id { get; set; }
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}