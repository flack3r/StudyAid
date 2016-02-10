using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAid
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://calendar.naver.com/main.nhn");
        }

        private void Diary_Load(object sender, EventArgs e)
        {

        }

    }
}
