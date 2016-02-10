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
    public partial class RegisterBlog : Form
    {
        public string v_id { get; set; }
        public string v_pw { get; set; }
        public string v_blogid { get; set; }
        public string v_blogurl { get; set; }
        public string v_postid { get; set; }

        public RegisterBlog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v_blogid = this.BlogId.Text;
            v_blogurl = this.BlogUrl.Text;
            v_postid = this.PostId.Text;
            v_id = this.Id.Text;
            v_pw = this.Pw.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
