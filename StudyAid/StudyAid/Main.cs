using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudyAid
{
    // 타이머 관련 구조체
    public struct StudyTimer
    {
        public int MaxHours;
        public int MaxMinuits;
        public int MaxSeconds;
        public string SelectedSubject;

        public StudyTimer(int _MaxHours, int _MaxMinuits, int _MaxSeconds, string _SelectedSubject)
        {
            MaxHours = _MaxHours;
            MaxMinuits = _MaxMinuits;
            MaxSeconds = _MaxSeconds;
            SelectedSubject = _SelectedSubject;
        }

    }

    // 블로그 로그인 관련 구조체
    public struct Blog
    {
        public String id;
        public String pw;
        public String postid;
        public String blogid;
        public String blogUrl;

        public Blog(string _id,string _pw, string _postid, string _blogid, string _blogUrl)
        {
            id = _id;
            pw = _pw;
            postid = _postid;
            blogid = _blogid;
            blogUrl = _blogUrl;
        }
    }

    public partial class Main : Form
    {
        Stopwatch SW = new Stopwatch();
        StudyTimer StudyTimeValue = new StudyTimer(0, 0, 0, "");
        Blog blog = new Blog("","","","","");
        Boolean exit = false;

        StudyManager Smanager;
        public Main()
        {
            InitializeComponent();
            this.SystemTime.Text = DateTime.Now.ToString();
            this.SystemTime.BackColor = Color.Transparent;
            this.SystemTime.Parent = this.MainBackground;
            this.FormClosing += Form1_FormClosing;
            this.Tray.DoubleClick += Tray_DoubleClick;
            this.ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 종료 이벤트를 취소 시킨다
            this.Visible = false; // 폼을 표시하지 않는다;
            if (this.exit == true)
                e.Cancel = false;
            
        }

        void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //트레이아이콘 없앰
            Tray.Visible = false;
            this.exit = true;
            //프로세스 종료
            Application.Exit();
        }

        private void diaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary diary = new Diary();
            diary.ShowDialog();
        }

        // SystemTime 출력
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.SystemTime.Text = DateTime.Now.ToString();
            if(SW.IsRunning)
            {
                TimeSpan ts  = SW.Elapsed;

                // 시간 표시
                string TotalTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                this.StudyTime.Text = TotalTime;

                // progress 진행(1초 간격)
                StudyProgress.PerformStep();

                // 시간 다됬을 때
                if (ts.Hours == StudyTimeValue.MaxHours && ts.Minutes == StudyTimeValue.MaxMinuits && ts.Seconds == StudyTimeValue.MaxSeconds)
                {
                    SW.Stop();
                    UpdateStudyTime(StudyTimeValue.SelectedSubject);
                    MessageBox.Show("목표 공부시간 끝~ 수고수고");
                }
            }
        }

        private void MonitorStat_CheckedChanged(object sender, EventArgs e)
        {
            // everytime you click the button checkbox states will change.
            if(MonitorStat.Text.Equals("모니터링 꺼짐"))
            {
                MessageBox.Show("모니터링 킴");
                MonitorStat.Text = "모니터링 동작중";
            }
            else
            {
                MessageBox.Show("모니터링 끔");
                MonitorStat.Text = "모니터링 꺼짐";
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Javis Project Ver 1.0 \nMade By flack3r\nContact: kyj9206@gmail.com");
        }

        void Tray_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
        }


        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInstanceStudyManager();
            SettingTime st = new SettingTime() ;
            if(st.ShowDialog() == DialogResult.OK)
            {
                // 시간 설정
                StudyTimeValue.MaxHours = st.MaxHours;
                StudyTimeValue.MaxMinuits = st.MaxMinuits;
                StudyTimeValue.MaxSeconds = st.MaxSeconds;
                StudyTimeValue.SelectedSubject = st.SelectSubject;
                
                // progress bar 설정
                StudyProgress.Minimum = 0;
                StudyProgress.Maximum = st.MaxHours*60 + st.MaxMinuits*60 + st.MaxSeconds;
                StudyProgress.Step = 1;

                // StopWatch 시작
                SW.Reset();
                StudyProgress.Value = 0;
                SW.Start();
            }
        }

        private void 멈춤ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if(SW.IsRunning)
            {
                SW.Stop();
                UpdateStudyTime(StudyTimeValue.SelectedSubject);
            }
        }

        /// <summary>
        /// 지금까지 공부한 StudyTime 업데이트
        /// </summary>
        /// <param name="_name">업데이트할 study name</param>
        private void UpdateStudyTime(string _name)
        {
            TimeSpan ts = SW.Elapsed;
            Study tmp = Smanager.FindStudy(_name);
            if(tmp != null)
            {
                int TmpHour = Convert.ToInt32(tmp.hours)+ts.Hours;
                int TmpMinuit = Convert.ToInt32(tmp.minuits) + ts.Minutes;
                int TmpSeconds = Convert.ToInt32(tmp.seconds) + ts.Seconds;

                Smanager.SubjectUpdate(_name, Convert.ToString(TmpHour), Convert.ToString(TmpMinuit), Convert.ToString(TmpSeconds));
            }
        }

        private void 일시정지시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SW.IsRunning)
            {
                SW.Stop();
            }
            else
            {
                // 기존에 선택되었던 과목이 있으면 시작
                if(!StudyTimeValue.SelectedSubject.Equals(""))
                    SW.Start();
            }
        }

        private void study설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInstanceStudyManager();
            StudyListForm st = new StudyListForm();
            st.Show();
        }

        private void LoadBlogInfo()
        {
            string configPath = Environment.CurrentDirectory + "\\config.xml";
            XElement config = null;
            if (!File.Exists(configPath))
            {
                RegisterBlog rb = new RegisterBlog();
                if (rb.ShowDialog() == DialogResult.OK)
                {
                    blog.blogid = rb.v_blogid;
                    blog.blogUrl = rb.v_blogurl;
                    blog.id = rb.v_id;
                    blog.pw = rb.v_pw;
                    blog.postid = rb.v_postid;

                    config = new XElement("config", new XElement("id", rb.v_id), new XElement("pw", rb.v_pw),
                        new XElement("blogid", rb.v_blogid), new XElement("blogurl", rb.v_blogurl),
                        new XElement("postid", rb.v_postid));

                    config.Save(configPath);
                    MessageBox.Show("블로그 계정등록 성공");
                }
                else
                {
                    return;
                }
            }
            config = XElement.Load(configPath);
            blog.blogid = config.Element("blogid").Value;
            blog.blogUrl = config.Element("blogurl").Value;
            blog.id = config.Element("id").Value;
            blog.pw = config.Element("pw").Value;
            blog.postid = config.Element("postid").Value;
        }

        private void CheckInstanceStudyManager()
        {
            if (SingleTon.StudyManagerInstance() == null)
            {
                LoadBlogInfo();
            }
            Smanager = SingleTon.StudyManagerInstance(blog.blogUrl, blog.blogid, blog.id, blog.pw, blog.postid);
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInstanceStudyManager();
            Smanager.GetXmlFromPost();
            MessageBox.Show("불러오기 성공");
        }

        private void 보내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInstanceStudyManager();
            Smanager.SaveXmlToPost();
            MessageBox.Show("포스팅(저장) 성공");
        }
    }
}
