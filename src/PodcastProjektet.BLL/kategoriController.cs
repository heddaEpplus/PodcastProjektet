using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;

namespace PodcastProjektet.BLL
{
    public class KategoriController
    {
        CategoryRepository _categoryRepository;

        public KategoriController()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<string> HamtaAllaKategorier()
        {
            List<string> allaKategorier = new List<string>();
            allaKategorier = _categoryRepository.HamtaAllaKategorier();
            return allaKategorier;
        }

        public void LaggTillKategori(string nyKategori)
        {
            _categoryRepository.LaggTillKategori(nyKategori);
        }

        public void SkappaDefaultKategori()
        {
            _categoryRepository.SkappaDefaultKategori();
        }

        public void TaBort(string kategori)
        {
            _categoryRepository.TaBort(kategori);
        }

        public void Uppdatera(string kategoriNamn, string nyKategoriNamn)
        {
            _categoryRepository.Uppdatera(kategoriNamn, nyKategoriNamn);
        }

        public void Uppdatera(string kategoriNamn, string nyKategoriNamn, string podTitel)
        {
            _categoryRepository.Uppdatera(kategoriNamn, nyKategoriNamn, podTitel);
        }
    }
}
