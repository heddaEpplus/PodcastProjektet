namespace PodcastProjektet.DAL
{
    public class Podd
    {
        public string Titel;
        public String Id;
        public string AntalAvsnitt;
        public String Kategori;
        public string Namn;
        public string Url { get; set; }
        public Podd()
        { 
          
        }

        public string hamtaPodd()
        {
            return Titel;
        }

    }
}
