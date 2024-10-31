using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.DAL.Repository
{
    public interface IPoddRepository<P> where P : class
    {
        Task <List<P>> GetAll();
        P GetByID(string id);
        void Insert(P theObject);
        void Update(string titel, string nyttNamn);
        void UppdateraKategori(Guid poddId, Guid nyKategoriId);
        void Delete(string titel);
        void SaveChanges();

        bool AddNewPoddFeed(string rssUrl);
    }
}
