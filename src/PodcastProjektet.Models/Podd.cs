using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.Models
{
    public class Podd
    {
        public string Titel;
        public String Id;
        public string AntalAvsnitt;
        public String Kategori;
        public string Namn;
        
        public List<Avsnitt> AvsnittLista { get; set; } // Ny lista för avsnitt

        public string Url { get; set; }
        public Podd()
        {
            AvsnittLista = new List<Avsnitt>(); // Initiera listan
        }

        public string hamtaPodd()
        {
            return Titel;
        }

    }
}
