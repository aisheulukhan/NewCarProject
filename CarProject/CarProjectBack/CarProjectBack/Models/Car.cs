using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProjectBack.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public string Luggage { get; set; }
        public bool Transmission { get; set; }
        public bool AirConditioning { get; set; }
        public int MinimumAge { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        //public IFromFile Photo { get; set; }
    }
}
