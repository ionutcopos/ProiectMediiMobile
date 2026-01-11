using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectMediiMobile.Models
{
    [Table("Programare")]
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int? ClientID { get; set; }
        
        [Ignore]
        public Client? Client { get; set; }
        
        public int? SalonID { get; set; }
        
        [Ignore]
        public Salon? Salon { get; set; }
        
        public int? StilistID { get; set; }
        
        [Ignore]
        public Stilist? Stilist { get; set; }

        public DateTime DataProgramarii { get; set; }
    }
}
