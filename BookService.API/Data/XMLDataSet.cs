using BookService.API.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookService.API.Data
{
    public class XMLDataSet<T> where T : class
    {
        private string _rootAttribute;
        private string _filePath;
        private List<T> _entities;
        public XMLDataSet(string filePath, string rootAttribute)
        {
            _filePath = filePath;
            _rootAttribute = rootAttribute;
        }
        public List<T> Data {
            get
            {
                try
                {
                    if (_entities == null) Load();
                }
                catch
                {
                    _entities = new List<T>();
                }

                return _entities;
            }
            set
            {
                _entities = value;
                Save();
            }
        }

        public void Save()
        {
            XmlSerializer serializer;
            if (_rootAttribute == null)
            {
                serializer = new XmlSerializer(typeof(List<T>));
            }
            else
            {
                serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(_rootAttribute));
            }
            StreamWriter sw = new StreamWriter(_filePath);
            serializer.Serialize(sw, _entities);
            sw.Close();
            sw.Dispose();
        }

        public void Load()
        {
            XmlSerializer serializer;
            if (_rootAttribute == null)
            {
                serializer = new XmlSerializer(typeof(List<T>));
            }
            else
            {
                serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(_rootAttribute));
            }
            StreamReader sr = new StreamReader(_filePath);
            _entities = serializer.Deserialize(sr) as List<T>;
            sr.Close();
            sr.Dispose();
        } 
    }
}
