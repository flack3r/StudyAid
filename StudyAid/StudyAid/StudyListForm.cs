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
    public partial class StudyListForm : Form
    {
        StudyManager StudyManager;
        public StudyListForm()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void UpdateListView()
        {
            this.listView1.BeginUpdate();
            listView1.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("StudyName", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("AllTime", 80, HorizontalAlignment.Left);

            StudyManager = SingleTon.StudyManagerInstance();
            List<Study> sl = StudyManager.GetStudyList();

            foreach (Study tmp in sl)
            {
                ListViewItem lvi = new ListViewItem(tmp.StudyName);
                string TotalTime = String.Format("{0:00}:{1:00}:{2:00}", tmp.hours, tmp.minuits, tmp.seconds);
                lvi.SubItems.Add(TotalTime);

                listView1.Items.Add(lvi);

            }
            this.listView1.EndUpdate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string _StudyName = "";
            if (InputBox("Register StudyName", "등록할 StudyName을 입력하세요", ref _StudyName) == DialogResult.OK)
            {
                if (StudyManager.FindStudy(_StudyName) == null)
                {
                    StudyManager.SubjectUpdate(_StudyName, "0", "0", "0");
                    UpdateListView();
                    MessageBox.Show("등록완료");
                }
                else
                {
                    MessageBox.Show("Name중복!");
                }
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string _StudyName = "";
            if (InputBox("Register StudyName", "등록할 StudyName을 입력하세요", ref _StudyName) == DialogResult.OK)
            {
                if (StudyManager.SubjectDelete(_StudyName) == true)
                {
                    UpdateListView();
                    MessageBox.Show("삭제완료");
                }
                else
                {
                    MessageBox.Show("입력하신 Study가 없음");
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
