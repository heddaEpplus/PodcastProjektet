using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.DAL.Repository
{
    public interface IPoddRepository<P> where P : class
    {
        List<P> GetAll();
        P GetByID(string id);
        void Insert(P theObject);
        void Create(P item);
        void Delete(int index);
        void SaveChanges();

        bool AddNewPoddFeed(string rssUrl);
    }
}
