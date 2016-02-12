using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAid
{
    class SingleTon
    {
        private static StudyManager SM;
        private static MonitorManager MonitorM;
        protected SingleTon()
        {

        }

        public static MonitorManager MonitorManagerInstance()
        {
            if(MonitorM == null)
            {
                MonitorM = new MonitorManager();
            }
            return MonitorM;
        }

        public static StudyManager StudyManagerInstance(string _url,string _blogid, string _id, string _pw, string _postid)
        {
            if( SM == null)
            {
                SM = new StudyManager(_url,_blogid,_id,_pw,_postid);
            }
            return SM;
        }

        public static StudyManager StudyManagerInstance()
        {
            return SM;
        }
    }
}
