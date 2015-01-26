using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AMLibary
{
    class XmlCreator
    {
        public void createXml()
        {
            DirectoryHandler directory = new DirectoryHandler();

            List<string> animelist = new List<string>();
            animelist = directory.getNameList("M:/anime");

            List<string> pathlist = new List<string>();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\Toricima\Desktop\Audio\Work music\Animelist.xml", settings);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("animes");


            foreach (string anime in animelist)
            {

                pathlist = getAnimePath(anime);

                xmlWriter.WriteStartElement("anime");
                xmlWriter.WriteAttributeString("title", anime);

                xmlWriter.WriteStartElement("story");
                xmlWriter.WriteString("");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("episodes");
                xmlWriter.WriteString(countAnimeEpisodes(anime).ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("studio");
                xmlWriter.WriteString("");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("path");
                xmlWriter.WriteString("");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private int countAnimeEpisodes(string anime_name)
        {
            DirectoryHandler anime_dir = new DirectoryHandler();

            int count = anime_dir.getEpisodes(@"M:/anime\", anime_name).Count;
            return count;
        }

        private List<string> getAnimePath(string anime_name)
        {
            DirectoryHandler anime_dir = new DirectoryHandler();

            return anime_dir.getEpisodes(@"M:/anime\", anime_name);
        }
    }
}
