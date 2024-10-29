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
            poddLista = _podcastRepository.GetAll();
            SkapaDefaultKategori();
        }
        public List<Kategori> HamtaAllaKategorier()
        {
            var kategoriLista = serializer.Deserialize();
            return kategoriLista;
        }
        public void HamtaKategoriFranPodd()
        {
            //if (poddLista.Count > 0)
            //{
            //    foreach (var podd in poddLista)
            //    {
            //        string poddensKategoriNamn = podd.Kategori;
            //        if (kategoriOversattning.ContainsKey(poddensKategoriNamn))
            //        {
            //            poddensKategoriNamn = kategoriOversattning[poddensKategoriNamn];
            //        }
            //        var matchadKategori = kategoriLista.FirstOrDefault(k => k.KategoriNamn == poddensKategoriNamn);
            //        if (matchadKategori == null)
            //        {
            //            matchadKategori = new Kategori(poddensKategoriNamn);
            //            kategoriLista.Add(matchadKategori);
            //            serializer.Serialize(kategoriLista);
            //        }
            //        podd.Kategori = poddensKategoriNamn;
            //    }
            //}
        }

        public void LaggTillKategori(string nyKategori)
        {
            var kategoriLista = serializer.Deserialize();
            if (!kategoriLista.Any(k => k.Namn == nyKategori))
            {
                kategoriLista.Add(new Kategori(nyKategori));
                serializer.Serialize(kategoriLista);  // Spara kategorier till fil
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
                serializer.Serialize(kategoriLista);  // Spara till fil
            }
        }

        public void TaBort(Guid kategoriId)
        {
            var kategoriLista = serializer.Deserialize();
            var kategoriAttTaBort = kategoriLista.FirstOrDefault(k => k.Id == kategoriId);
            if (kategoriAttTaBort != null)
            {
                kategoriLista.Remove(kategoriAttTaBort);
                serializer.Serialize(kategoriLista);  // Uppdatera filen
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
                serializer.Serialize(kategoriLista);  // Spara uppdateringar
            }
            else
            {
                throw new ArgumentException($"Kategorin '{kategoriId}' finns inte.");
            }
        }

        //public void UppdateraPoddensKategori(Guid kategoriId, string nyKategoriNamn, string podTitel)
        //{
        //    var kategoriAttUppdatera = kategoriLista.FirstOrDefault(k => k.Id == kategoriId);

        //    if (kategoriAttUppdatera !=null)
        //    {
        //        var poddAttUppdatera = kategoriAttUppdatera.Poddar.FirstOrDefault(p => p.Titel == podTitel);
        //        if (poddAttUppdatera != null)
        //        {
        //            poddAttUppdatera.KategoriId = kategoriId;
        //            // Uppdatera kategori-namnet
        //            kategoriAttUppdatera.Namn = nyKategoriNamn;

        //            // Spara de ändrade kategorierna till fil
        //            serializer.Serialize(kategoriLista);
        //        }
        //        else if (poddAttUppdatera != null)
        //        {
        //            throw new ArgumentException($"Podd '{podTitel}' finns inte i kategorin '{kategoriNamn}'.");
        //        }
        //        else 
        //        {
        //            // Om kategorin inte finns, kasta ett undantag
        //            throw new ArgumentException($"Kategorin '{kategoriNamn}' finns inte.");
        //        }

        //    }
        //}
    }
}
