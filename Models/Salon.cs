using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiMobile.Models
{
    public class Salon
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Oras { get; set; }
        public string Adresa { get; set; }
        public string Pret { get; set; }
        public string Categorie { get; set; }
        public ICollection<Stilist>? Stilisti { get; set; }
        public ICollection<Programare>? Programari { get; set; }
        public override string ToString()
        {
            return Nume; // Assuming 'Nume' is the property for the salon's name
        }
    }
}
