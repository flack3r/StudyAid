using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace StudyAid
{
    class StudyManager
    {
        private List<Study> studylist = new List<Study>();
        MetaWeblog blog;
        String id = "rladudwls321@naver.com";
        String pw = "";
        String postid = "";
        String blogid = "";


        public StudyManager(string url, string _blogid, string _id, string _pw, string _postid)
        {
            blog = new MetaWeblog(url);
            id = _id;
            pw = _pw;
            blogid = _blogid;
            postid = _postid;
            SubjectRead();
        }

        public void GetXmlFromPost()
        {
            string configPath = Environment.CurrentDirectory + "\\StudyList.xml";
            Post p = blog.getPost(postid, id, pw);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(p.description);
            xmldoc.Save(configPath);
            SubjectRead();
        }

        public void SaveXmlToPost()
        {
            string configPath = Environment.CurrentDirectory + "\\StudyList.xml";
            if(!File.Exists(configPath))
            {
                XElement slist = new XElement("StudyList");
                slist.Save(configPath);
            }
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(configPath);

            Post p = new Post();
            p.title = "공부시간 리스트";
            p.description = xmldoc.OuterXml;
            p.dateCreated = DateTime.Now;

            blog.editPost(postid, id, pw, p, false);
        }


        public void StudyToXmlFile()
        {
            string configPath = Environment.CurrentDirectory + "\\StudyList.xml";
            XElement studyToXml = new XElement("StudyList",
                from study in studylist
                select new XElement("Study",
                new XElement("Name", study.StudyName),
                new XElement("hours", study.hours),
                new XElement("minuits", study.minuits),
                new XElement("seconds", study.seconds)
                )
               );

            studyToXml.Save(configPath);
        }

        /// <summary>
        /// 메모리 리스트 update후 파일 xml파일로 저장.
        /// </summary>
        /// <param name="name"> 과목명</param>
        /// <param name="hours"> 시간 </param>
        /// <param name="minuits"> 분</param>
        /// <param name="seconds"> 초</param>
        public void SubjectUpdate(string name, string hours, string minuits, string seconds)
        {
            // studylist 변경
            Study tmp = FindStudy(name);
            // 새로 들어온 과목일 경우
            if (tmp == null)
            {
                tmp = new Study(name, hours, minuits, seconds);
                studylist.Add(tmp);
            }
            else
            {
                int idx = studylist.IndexOf(tmp);
                studylist.RemoveAt(idx);
                tmp.hours = hours;
                tmp.minuits = minuits;
                tmp.seconds = seconds;

                studylist.Insert(idx, tmp);
            }
            StudyToXmlFile();
        }

        public Boolean SubjectDelete(string name)
        {
            Study tmp = FindStudy(name);
            if(tmp != null)
            {
                studylist.Remove(tmp);
                StudyToXmlFile();
                return true;
            }
            return false;
        }

        public void SubjectRead()
        {
            // 0. 파일이 있는지 확인(없으면 만듦)
            string configPath = Environment.CurrentDirectory + "\\StudyList.xml";
            if(!File.Exists(configPath))
            {
                XElement slist = new XElement("StudyList");
                slist.Save(configPath);
            }
            //존재하면 읽음
            else
            {
                studylist.Clear();
                try
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(configPath);
                    XmlElement root = xmldoc.DocumentElement;

                    XmlNodeList nodes = root.ChildNodes;
                    foreach(XmlNode node in nodes)
                    {
                        string Name = node.SelectSingleNode("Name").InnerText;
                        string hours = node.SelectSingleNode("hours").InnerText;
                        string minuits = node.SelectSingleNode("hours").InnerText;
                        string seconds = node.SelectSingleNode("seconds").InnerText;
                        studylist.Add(new Study(Name, hours,minuits,seconds));
                    }
                }
                catch(IOException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public Study FindStudy(string _name)
        {
            Study Find = null;
            foreach(Study tmp in studylist)
            {
                if(tmp.StudyName.Equals(_name))
                {
                    Find = tmp;
                }
            }
            return Find;
        }

        public List<Study> GetStudyList()
        {
            return studylist;
        }
    }
}
