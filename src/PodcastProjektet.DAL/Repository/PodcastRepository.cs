using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PodcastProjektet.DAL.Repository
{
    public class PodcastRepository : GenericRepository<Podd>
    {
        //private readonly string _rssUrl;
        Serializer<Podd> PoddSerializer;
        List<Podd> PoddList;

        public PodcastRepository()
        {
            //_rssUrl = rssUrl;
            PoddList = new List<Podd>();
            PoddSerializer = new Serializer<Podd>(nameof(PoddList));
            
        }

        public List<Podd> GetAll()
        {
            return PoddSerializer.Deserialize();
            //var poddList = new List<string>();

            //try
            //{
            //    using (var reader = XmlReader.Create(_rssUrl))
            //    {
            //        var feed = SyndicationFeed.Load(reader);
            //        if(feed != null)
            //        {
            //            foreach (var item in feed.Items)
            //            {
            //                poddList.Add(item.Title.Text);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine("Det uppstod ett fel vid hämtning av RSS: " + ex.Message);
            //}

            //return poddList;
        }

        public void Delete(int index)
        {
            PoddList.RemoveAt(index);
            SaveChanges();  
        }

        public Podd GetByID(string id)
        {
            Podd enPodd = null;
            foreach (var item in PoddSerializer.Deserialize())
            {
                if (item.Id.Equals(id))
                {
                    enPodd = item;
                    break;
                }
                
            }
            return enPodd;
        }

        public void Insert( Podd theObject)
        {
            PoddList.Add(theObject);
            SaveChanges();
        }

        public void SaveChanges()
        {
            PoddSerializer.Serialize(PoddList);
        }

       

        public void Update(int index, Podd theNewObject)
        {
           if (index >=0)
            {
                PoddList[index]=theNewObject;
            }
           SaveChanges();
        }
    }
}
