using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AMLibary
{
    class XmlParser
    {
        string elementContent;
        string _searchElement;

        public T ParseByXMLDocument<T>() where T : new()
        {
            var parsedDocument = new T();

            XmlReader reader = XmlReader.Create(@"C:\Users\Toricima\Desktop\test envirment\anime-devilishly.xml");
            return parsedDocument;
        }

        public void startSearchInElement(string element)
        {
            _searchElement = element;
        }

        public string fetchElementInfoByName(string name)
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Toricima\Desktop\test envirment\anime-devilishly.xml");
            
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == _searchElement+@"\"+name))
                {
                    elementContent = reader.ReadElementContentAsString();
                }
            }

            return elementContent;
        }
    }
}