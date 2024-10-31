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
        private ValideringsController valideringsController;
        private readonly KategoriController kategoriController;
        public PoddController()
        {
            podcastRepository=new PodcastRepository();
            valideringsController = new ValideringsController();
            kategoriController = new KategoriController();

        }

        public async Task <List<Podd>> GetAllPodcasts()
        {
            var podcasts = await podcastRepository.GetAll();
            var categories = kategoriController.HamtaKategoriViaId();
            foreach(var podcast in podcasts)
            {
                if (podcast.KategoriId == Guid.Empty || !categories.ContainsKey(podcast.KategoriId)) continue;
                podcast.KategoriNamn = categories[podcast.KategoriId].Namn;
            }
            return podcasts;
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
        public async Task UpdatePodd(string titel, string nyttNamn)
        {
            podcastRepository.Update(titel, nyttNamn);
        }

        public void UppdateraKategori(Guid poddId, Guid nyKategoriId)
        {
            podcastRepository.UppdateraKategori(poddId, nyKategoriId);
        }

        // Ta bort en podd baserat på titel
        public void DeletePodd(string titel)
        {
            podcastRepository.Delete(titel);
        }

        // Lägg till ett nytt RSS-flöde
        public async Task AddNewPoddFromRSS(string rssUrl)
           
        {
            ((PodcastRepository)podcastRepository).AddNewPoddFeed(rssUrl);
            await Task.Delay(1000);
           
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
