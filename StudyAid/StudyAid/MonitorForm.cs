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
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            MonitorManager mm = SingleTon.MonitorManagerInstance();
            this.listView1.BeginUpdate();
            listView1.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("금지된 Url", 150, HorizontalAlignment.Left);

            List<string> urllist = mm.GetUrlList();

            foreach (string tmp in urllist)
            {
                ListViewItem lvi = new ListViewItem(tmp);
                listView1.Items.Add(lvi);

            }
            this.listView1.EndUpdate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string tmp = "";
            if(InputBox("AddUrl","금지시킬 url을 입력하세요",ref tmp) == DialogResult.OK)
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(tmp,"^http://.*/|^https://.*/"))
                {
                    MonitorManager mm = SingleTon.MonitorManagerInstance();
                    mm.AddUrl(tmp);
                }
                else
                {
                    MessageBox.Show("올바른 URL이 아닙니다.");
                }
            }
            UpdateListView();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string tmp = "";
            if(InputBox("DelUrl","삭제시킬 url을 입력하세요",ref tmp) == DialogResult.OK)
            {
                MonitorManager mm = SingleTon.MonitorManagerInstance();
                if (mm.FindUrl(tmp) == true)
                {
                    mm.DelUrl(tmp);
                    UpdateListView();
                }
                else
                {
                    MessageBox.Show("입력하신 url은 등록된게 아닙니다.");
                }
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        
    }
}
