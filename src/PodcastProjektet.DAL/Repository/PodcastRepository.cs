using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PodcastProjektet.DAL.Repository
{
    public class PodcastRepository : IPoddRepository<Podd>
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
           List<Podd> poddlistDeserialized = new List<Podd>();
                try {
                poddlistDeserialized = PoddSerializer.Deserialize();
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
            return poddlistDeserialized;
          
        }

        public void Delete(string titel)
        {

            var doc = XDocument.Load("PoddList.xml");
            var node = doc.Descendants("Podd").Where(podd => (string)podd.Element("Titel") == titel).ToList();

            foreach (var podd in node)
            {
                podd.Remove();
            }

            doc.Save("PoddList.xml");

            
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
            PoddList = PoddSerializer.Deserialize();
            PoddList.Add(theObject);
            SaveChanges();
        }

        public void SaveChanges()
        {
            PoddSerializer.Serialize(PoddList);
        }

       

        public void Update(string titel, string nyttNamn)
        {
            var doc = XDocument.Load("PoddList.xml");
            var node = doc.Descendants("Podd").FirstOrDefault(podd => (string)podd.Element("Titel") == titel);

            if (node != null)
            {
                // Uppdatera namnet på podden
                var namnElement = node.Element("Namn");
                if (namnElement != null)
                {
                    namnElement.Value = nyttNamn; // Sätt det nya namnet
                    doc.Save("PoddList.xml"); // Spara ändringarna till filen
                }
                else
                {
                    Console.WriteLine("Elementet 'Namn' hittades inte för den angivna podden.");
                }
            }
            else
            {
                Console.WriteLine("Ingen podd hittades med titeln: " + titel);
            }

        }

        public bool AddNewPoddFeed(string rssUrl)
        {
            try
            {
                using (var reader = XmlReader.Create(rssUrl))
                {
                    XDocument doc = XDocument.Load(rssUrl);
                    var feed = SyndicationFeed.Load(reader);
                    if (feed != null)
                    {
                        string kategori = (from c in doc.Descendants(XName.Get("category", "http://www.itunes.com/dtds/podcast-1.0.dtd"))
                                           select c.Attribute("text")?.Value).FirstOrDefault();
                        if (feed.ElementExtensions.Count > 0)
                        {
                            
                            // Skapa ett nytt Podd-objekt med information från RSS-flödet
                            var newPodd = new Podd
                            {
                                Id = Guid.NewGuid().ToString(), // Skapa ett unikt ID för varje podd
                                Titel = feed.Title.Text, // Använd titel från RSS-flödet
                                AntalAvsnitt = feed.Items.Count().ToString(), //hämta antalavsnitt
                                Kategori = kategori ?? "Ingen kategori",
                                //Kategori = _categoryRepository.HamtaKategori(kategori).KategoriNamn,
                                Namn = feed.Title.Text, // Använd titel från RSS-flödet
                             
                                Url = rssUrl // Spara URL till flödet
                            };

                            foreach (var item in feed.Items)
                            {
                                var avsnitt = new Avsnitt
                                {
                                    Titel = item.Title.Text,
                                    Beskrivning = item.Summary?.Text ?? "Ingen beskrivning tillgänglig",
                                   
                                };
                                newPodd.AvsnittLista.Add(avsnitt); // Lägg till avsnittet i Podd
                            }

                            PoddList = PoddSerializer.Deserialize();
                            // Lägg till det nya podd-objektet till listan och spara ändringarna
                            PoddList.Add(newPodd);
                            SaveChanges();

                            return true; // Indikerar att tillägget lyckades
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Det uppstod ett fel vid tillägg av RSS-flödet: " + ex.Message);
            }

            return false; // Indikerar att tillägget misslyckades
        }
    }
}
