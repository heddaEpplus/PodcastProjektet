using PodcastProjektet.DAL.Repository;
using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.BLL
{
    public class ValideringsController
    {

        IPoddRepository<Podd> poddRepo;
        CategoryRepository kategoriRepo;

        public ValideringsController()
        {
            poddRepo = new PodcastRepository();
            kategoriRepo = new CategoryRepository();
        }

        public bool KollaOmStrangArTom(string text)
        {
            if ((text == null) || (text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KollaOmKategoriFinns(string kategoriNamn)
        {
            bool finns = false;
            foreach (var enKategori in kategoriRepo.HamtaAllaKategorier())
            {
                if (enKategori.Equals(kategoriNamn))
                {
                    finns = true;
                }
            }
            return finns;
        }

        public bool KollaOmPoddFinns(string poddTitel)
        {
            bool finns = false;
            foreach (var enPodd in poddRepo.GetAll())
            {
                if (enPodd.Titel.Equals(poddTitel))
                {
                    finns = true;
                }
            }
            return finns;
        }
        
    }
}
