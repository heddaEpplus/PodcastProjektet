using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PodcastProjektet.Models; 

namespace PodcastProjektet.DAL.Repository
{
    public class CategoryRepository : IcategoryRepository<Podd>
    {
        Serializer<Kategori> serializer;
        List<Podd> poddLista;
        PodcastRepository _podcastRepository;

        public CategoryRepository()
        {
            serializer = new Serializer<Kategori>("kategoriLista");
            _podcastRepository = new PodcastRepository();
            InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            poddLista = await _podcastRepository.GetAll();
            SkapaDefaultKategori();
        }
        public List<Kategori> HamtaAllaKategorier()
        {
            var kategoriLista = serializer.Deserialize();
            return kategoriLista;
        }


        public void LaggTillKategori(string nyKategori)
        {
            var kategoriLista = serializer.Deserialize();
            if (!kategoriLista.Any(k => k.Namn == nyKategori))
            {
                kategoriLista.Add(new Kategori(nyKategori));
                serializer.Serialize(kategoriLista);  
            }
            else
            {
                throw new ArgumentException($"Kategorin '{nyKategori}' finns redan.");
            }
        }

        public void SkapaDefaultKategori()
        {
            var kategoriLista = serializer.Deserialize();
            if (kategoriLista.Count == 0)
            {
                kategoriLista.Add(new Kategori("Komedi"));
                kategoriLista.Add(new Kategori("Skräck"));
                kategoriLista.Add(new Kategori("Sport"));
                kategoriLista.Add(new Kategori("Vetenskap"));
                kategoriLista.Add(new Kategori("Teknologi"));
                serializer.Serialize(kategoriLista);  
            }
        }

        public void TaBort(Guid kategoriId)
        {
            var kategoriLista = serializer.Deserialize();
            var kategoriAttTaBort = kategoriLista.FirstOrDefault(k => k.Id == kategoriId);
            if (kategoriAttTaBort != null)
            {
                kategoriLista.Remove(kategoriAttTaBort);
                serializer.Serialize(kategoriLista);  
            }
            else
            {
                throw new ArgumentException($"Kategorin '{kategoriId}' finns inte.");
            }
        }

        public void UppdateraKategori(Guid kategoriId, string nyKategoriNamn)
        {
            var kategoriLista = serializer.Deserialize();
            var kategoriAttUppdatera = kategoriLista.FirstOrDefault(k => k.Id == kategoriId);
            if (kategoriAttUppdatera != null)
            {
                kategoriAttUppdatera.Namn = nyKategoriNamn;
                serializer.Serialize(kategoriLista);
            }
            else
            {
                throw new ArgumentException($"Kategorin '{kategoriId}' finns inte.");
            }
        }


    }
}
