using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;
using PodcastProjektet.Models;

namespace PodcastProjektet.BLL
{
    public class KategoriController
    {
        CategoryRepository _categoryRepository;

        public KategoriController()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<Kategori> HamtaAllaKategorier()
        {
            return _categoryRepository.HamtaAllaKategorier();
        }

        public void LaggTillKategori(string nyKategori)
        {
            _categoryRepository.LaggTillKategori(nyKategori);
        }

        public Dictionary<Guid, Kategori> HamtaKategoriViaId()
        {
            var kategorier = _categoryRepository.HamtaAllaKategorier();
            var dictionary = new Dictionary<Guid, Kategori>();
            foreach (var kategori in kategorier)
            {
                dictionary[kategori.Id] = kategori;
            }
            return dictionary;
        }

        public void TaBort(Guid kategoriId)
        {
            _categoryRepository.TaBort(kategoriId);
        }
        public void TaBort(string kategoriNamn)
        {
            var categories = _categoryRepository.HamtaAllaKategorier();
            var kategori = categories.FirstOrDefault(x => x.Namn == kategoriNamn);
            if (kategori != null)
            {
                _categoryRepository.TaBort(kategori.Id);
            }
        }
        public void UppdateraKategori(Guid kategoriId, string nyKategoriNamn)
        {
            _categoryRepository.UppdateraKategori(kategoriId, nyKategoriNamn);
        }

        //public void UppdateraPoddensKategori(string kategoriNamn, string nyKategoriNamn, string podTitel)
        //{
        //    _categoryRepository.UppdateraPoddensKategori(kategoriNamn, nyKategoriNamn, podTitel);
        //}
    }
}
