using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiMobile.Models
{
    public class Stilist
    {
        public int ID { get; set; }
        public string? Nume { get; set; }
        public decimal Pret { get; set; }
        public int? SalonID { get; set; }
        public Salon? Salon { get; set; }
        public ICollection<Programare>? Programari { get; set; }
        public override string ToString()
        {
            return Nume; // Assuming 'Nume' is the property for the salon's name
        }
    }
}
