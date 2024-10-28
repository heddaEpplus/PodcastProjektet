using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodcastProjektet.DAL
{
    
        internal class Serializer<P>

        {
            private string FileName;

            public Serializer(string fileName)
            {
                FileName = fileName;
            }

            public void Serialize(List<P> list)
            {
                XmlSerializer enXmlSerializer=new XmlSerializer(typeof(List<P>));
                FileStream minFileStream= new FileStream(FileName, FileMode.Create, FileAccess.Write);
                enXmlSerializer.Serialize(minFileStream, list);
                minFileStream.Close();

            }

            public List<P> Deserialize() 
            {
            if (!File.Exists(FileName))
            {
                // Returnera en tom lista om filen saknas
                return new List<P>();
            }

            List<P> list;
            XmlSerializer enXmlSerializer = new XmlSerializer(typeof(List<P>));

            using (FileStream minFileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                list = (List<P>)enXmlSerializer.Deserialize(minFileStream);
            }

            return list;
            //List<P> list;
            //XmlSerializer enXmlSerializer = new XmlSerializer(typeof(List<P>));
            //FileStream minFileStream= new FileStream(FileName,FileMode.Open, FileAccess.Read);
            //list = (List<P>)enXmlSerializer.Deserialize(minFileStream);
            //minFileStream.Close ();
            //return list;
        }
        
        }
}
