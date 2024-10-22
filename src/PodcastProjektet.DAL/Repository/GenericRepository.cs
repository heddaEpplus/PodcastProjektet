using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjektet.DAL.Repository
{
    public interface GenericRepository<P>
    {
        List<P> GetAll();
        P GetByID(string id);
        void Insert(P theObject);
        void Update(int index, P theObject);
        void Delete(int index);
        void SaveChanges();

        bool AddNewPoddFeed(string rssUrl);
    }
}
