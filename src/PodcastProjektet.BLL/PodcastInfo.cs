using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.BLL
{
    public class PodcastInfo
    {
        public string Id { get; set; }
        public int AntalAvsnitt { get; set; }
        public string? Namn { get; set; }
        public string? Titel { get; set; }
        public string? Frekvens { get; set; }
        public string? Kategori { get; set; }

        public PodcastInfo()
        {

        }
        public PodcastInfo(string Id, int AntalAvsnitt, string Namn, string Titel, string Frekvens, string Kategori)
        {
            this.Id = Id;
            this.AntalAvsnitt = AntalAvsnitt;
            this.Namn = Namn;
            this.Titel = Titel;
            this.Frekvens = Frekvens;
            this.Kategori = Kategori;
        }
    }
}
