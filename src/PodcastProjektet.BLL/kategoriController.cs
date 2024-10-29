﻿using System;
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

        public void SkappaDefaultKategori()
        {
            _categoryRepository.SkappaDefaultKategori();
        }

        public void TaBort(string kategori)
        {
            _categoryRepository.TaBort(kategori);
        }

        public void UppdateraKategori(string kategoriNamn, string nyKategoriNamn)
        {
            _categoryRepository.UppdateraKategori(kategoriNamn, nyKategoriNamn);
        }

        public void UppdateraPoddensKategori(string kategoriNamn, string nyKategoriNamn, string podTitel)
        {
            _categoryRepository.UppdateraPoddensKategori(kategoriNamn, nyKategoriNamn, podTitel);
        }
    }
}
