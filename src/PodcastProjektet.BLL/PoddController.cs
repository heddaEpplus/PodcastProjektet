using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.BLL
{
    public class PoddController
    {
        GenericRepository<Podd> podcastRepository;
            public PoddController()
        {
            podcastRepository=new PodcastRepository();

        }

        

    }
}
