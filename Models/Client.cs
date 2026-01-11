using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiMobile.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string? Nume { get; set; }

        public string? Email { get; set; }
        public string? Adresa { get; set; }
        public string? NumarTelefon { get; set; }
        public ICollection<Programare>? Programari { get; set; }
    }
}
