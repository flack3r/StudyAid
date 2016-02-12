using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace StudyAid
{
    class MonitorManager
    {
        List<string> BanUrlList = new List<string>();
        public MonitorManager()
        {
            Load_XmlFile_To_List();
        }

        public void AddUrl(string url)
        {
            BanUrlList.Add(url);
            Save_List_To_XmlFile();
        }

        public void DelUrl(string url)
        {
            BanUrlList.Remove(url);
            Save_List_To_XmlFile();
        }

        public Boolean FindUrl(string _url)
        {
            foreach(string tmp in BanUrlList)
            {
                if(_url.Equals(tmp))
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> GetUrlList()
        {
            return BanUrlList;
        }

        public void Load_XmlFile_To_List()
        {
            string configPath = Environment.CurrentDirectory + "\\UrlList.xml";
            BanUrlList.Clear();
            if(!File.Exists(configPath))
            {
                XElement tmp = new XElement("BanUrlList");
                tmp.Save(configPath);
            }

            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(configPath);
                XmlElement root = xmldoc.DocumentElement;

                XmlNodeList nodes = root.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    string Url = node.InnerText;
                    BanUrlList.Add(Url);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Save_List_To_XmlFile()
        {
            string configPath = Environment.CurrentDirectory + "\\UrlList.xml";
            XElement UrlToXml = new XElement("BanUrlList",
                from url in BanUrlList
                select new XElement("Url", url)
               );

            UrlToXml.Save(configPath);
        }

        public void MonitoringStart()
        {

        }

        public void MonitoringStop()
        {

        }

    }
}
