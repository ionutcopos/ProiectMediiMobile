using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectMediiMobile.Models
{
    [Table("Client")]
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string? Nume { get; set; }

        public string? Email { get; set; }
        public string? Adresa { get; set; }
        public string? NumarTelefon { get; set; }
        
        [Ignore]
        public ICollection<Programare>? Programari { get; set; }
    }
}
