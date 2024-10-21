namespace PodcastProjektet.DAL
{
    public class Podd
    {
        public string Namn;
        public Podd()
        { Namn = "Ursäkta"; }

        public string hamtaPodd()
        {
            return Namn;
        }

    }
}
