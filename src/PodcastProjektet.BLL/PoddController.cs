using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;
using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.BLL
{
    public class PoddController
    {
        IPoddRepository<Podd> podcastRepository;
            public PoddController()
        {
            podcastRepository=new PodcastRepository();

        }

        public List<Podd> GetAllPodcasts()
        {
            return podcastRepository.GetAll();
        }

        // Hämta en podd baserat på ID
        public Podd GetPoddById(string id)
        {
            return podcastRepository.GetByID(id);
        }

        // Lägg till en ny podd
        public void AddPodd(Podd newPodd)
        {
            podcastRepository.Insert(newPodd);
        }

        // Uppdatera en befintlig podd
        public void UpdatePodd(string titel, string nyttNamn)
        {
            podcastRepository.Update(titel, nyttNamn);
        }

        // Ta bort en podd baserat på titel
        public void DeletePodd(string titel)
        {
            podcastRepository.Delete(titel);
        }

        // Lägg till ett nytt RSS-flöde
        public bool AddNewPoddFromRSS(string rssUrl)
        {
            return ((PodcastRepository)podcastRepository).AddNewPoddFeed(rssUrl);
        }

        public List<string> GetAllAvsnittBeskrivningarForPodd(string poddId)
        {
            Podd podd = podcastRepository.GetByID(poddId);
            if (podd != null)
            {
                return podd.AvsnittLista.Select(a => a.Beskrivning).ToList();
            }
            return new List<string>();
        }







    }
}
