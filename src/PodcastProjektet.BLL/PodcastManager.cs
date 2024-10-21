using PodcastProjektet.DAL;

namespace PodcastProjektet.BLL
{
    public class PodcastManager
    {
        public Podd enPodd;

        public PodcastManager()
        {
            enPodd = new Podd();
        }
        public string getNamn()
        {
            return enPodd.hamtaPodd();
        }

    }
}
