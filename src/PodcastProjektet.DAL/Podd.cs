namespace PodcastProjektet.DAL
{
    public class Podd
    {
        public string Namn;
        public String Id;
        public Podd()
        { Namn = "Ursäkta";
          Id = "1";
        }

        public string hamtaPodd()
        {
            return Namn;
        }

    }
}
