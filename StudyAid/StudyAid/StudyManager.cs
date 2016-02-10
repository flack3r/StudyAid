using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace StudyAid
{
    class StudyManager
    {
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
        }

        public string GetTimeFromPost()
        {
            Post p = blog.getPost(postid, blogid, pw);
            return p.description;
        }

        public void UpdatetimeToPost(string descript)
        {
            Post p = new Post();
            p.title = "공부시간";
            p.description = descript;
            p.dateCreated = DateTime.Now;

            blog.editPost(postid, id, pw, p, false);
        }

        /// <summary>
        /// 파일 xml파일로 subject 업데이트
        /// </summary>
        /// <param name="name"> 과목명</param>
        /// <param name="hours"> 시간 </param>
        /// <param name="minuits"> 분</param>
        /// <param name="seconds"> 초</param>
        public void FileUpdate(string name, string hours, string minuits, string seconds)
        {
            
        }
    }
}
