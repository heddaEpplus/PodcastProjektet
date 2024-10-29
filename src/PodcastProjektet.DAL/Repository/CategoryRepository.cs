using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodcastProjektet.Models; 

namespace PodcastProjektet.DAL.Repository
{
    public class CategoryRepository : IcategoryRepository<Podd>
    {
        List<Kategori> kategoriLista;
        Serializer<Kategori> serializer;
        List<Podd> poddLista;
        PodcastRepository _podcastRepository;

        public CategoryRepository()
        {
            kategoriLista = new List<Kategori>();
            serializer = new Serializer<Kategori>(nameof(kategoriLista));
            _podcastRepository = new PodcastRepository();
            poddLista = _podcastRepository.GetAll();
            SkappaDefaultKategori();
        }
        public List<Kategori> HamtaAllaKategorier()
        {
            if(poddLista != null && poddLista.Count > 0)
            {
                HamtaKategoriFranPodd();
            }
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
            if (!kategoriLista.Any(k => k.KategoriNamn == nyKategori))
            {
                kategoriLista.Add(new Kategori(nyKategori));
                serializer.Serialize(kategoriLista);  // Spara kategorier till fil
            }
            else
            {
                throw new ArgumentException($"Kategorin '{nyKategori}' finns redan.");
            }
        }

        public void SkappaDefaultKategori()
        {
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

        public void TaBort(string kategori)
        {
            var kategoriAttTaBort = kategoriLista.FirstOrDefault(k => k.KategoriNamn == kategori);
            if (kategoriAttTaBort != null)
            {
                kategoriLista.Remove(kategoriAttTaBort);
                serializer.Serialize(kategoriLista);  // Uppdatera filen
            }
            else
            {
                throw new ArgumentException($"Kategorin '{kategori}' finns inte.");
            }
        }

        public void UppdateraKategori(string kategoriNamn, string nyKategoriNamn)
        {
            var kategoriAttUppdatera = kategoriLista.FirstOrDefault(k => k.KategoriNamn == kategoriNamn);
            if (kategoriAttUppdatera != null)
            {
                kategoriAttUppdatera.KategoriNamn = nyKategoriNamn;
                serializer.Serialize(kategoriLista);  // Spara uppdateringar
            }
            else
            {
                throw new ArgumentException($"Kategorin '{kategoriNamn}' finns inte.");
            }
        }

        public void UppdateraPoddensKategori(string kategoriNamn, string nyKategoriNamn, string podTitel)
        {
            var kategoriAttUppdatera = kategoriLista.FirstOrDefault(k => k.KategoriNamn == kategoriNamn);

            if (kategoriAttUppdatera !=null)
            {
                var poddAttUppdatera = kategoriAttUppdatera.Poddar.FirstOrDefault(p => p.Titel == podTitel);
                if (poddAttUppdatera != null)
                {
                    poddAttUppdatera.Kategori = nyKategoriNamn;
                    // Uppdatera kategori-namnet
                    kategoriAttUppdatera.KategoriNamn = nyKategoriNamn;

                    // Spara de ändrade kategorierna till fil
                    serializer.Serialize(kategoriLista);
                }
                else if (poddAttUppdatera != null)
                {
                    throw new ArgumentException($"Podd '{podTitel}' finns inte i kategorin '{kategoriNamn}'.");
                }
                else 
                {
                    // Om kategorin inte finns, kasta ett undantag
                    throw new ArgumentException($"Kategorin '{kategoriNamn}' finns inte.");
                }

            }
        }
    }
}
