using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodcastProjektet.Models
{
    public class Podd
    {
        public string Titel { get; set; }
        public Guid Id { get; set; }
        public string AntalAvsnitt { get; set; }
        public string Namn { get; set; }
        public Guid KategoriId { get; set; }
        [XmlIgnore]
        public string KategoriNamn { get; set; }
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
