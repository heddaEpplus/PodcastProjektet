using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodcastProjektet.DAL.Repository
{
    public interface IcategoryRepository <P> where P: class
    {
        public void TaBort(string kategori);

        public void UppdateraKategori(string kategoriNamn, string nyKategoriNamn);
        public List<Kategori> HamtaAllaKategorier();
        public void SkappaDefaultKategori();
        public void LaggTillKategori(string nyKategori);
        public void UppdateraPoddensKategori(string kategoriNamn, string nyKategoriNamn, string podTitel);
  


    }
}
