﻿using PodcastProjektet.DAL.Repository;
using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                if (enKategori.Namn.Equals(kategoriNamn))
                {
                    finns = true;
                }
            }
            return finns;
        }
        public bool KollaOmKategoriArMarkerad(bool markeradKategori)
        {
            return markeradKategori;
        }

        public async Task <bool> KollaOmNamnFinns(string poddNamn)
        {
            bool finns = false;
            var poddar = await poddRepo.GetAll();
            foreach (var enPodd in poddar)
            {
                if (enPodd.Namn.Equals(poddNamn))
                {
                    finns = true;
                }
            }
            return finns;
        }

        public async Task <bool> KollaOmPoddFinns(string rssUrl)
        {
            var poddar = await poddRepo.GetAll();
            var selectUrl = from enPodd in poddar
                            where enPodd.Url.Equals(rssUrl)
                            select enPodd.Url;
            return selectUrl.Any();

        }

        public bool KollaGiltigUrl(string url)
        {
            try
            {
                SyndicationFeed syndicationFeed = SyndicationFeed.Load(XmlReader.Create(url));

                foreach (SyndicationItem item in syndicationFeed.Items)
                {
                    Debug.Print(item.Title.Text);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }
}
