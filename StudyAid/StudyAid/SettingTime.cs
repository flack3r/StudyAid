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
    public partial class SettingTime : Form
    {
        public int MaxHours { get; set; }
        public int MaxMinuits { get; set; }
        public int MaxSeconds { get; set; }
        public string SelectSubject { get; set; }

        public SettingTime()
        {
            InitializeComponent();
            this.Load += SettingTime_Load;
        }

        private void SettingTime_Load(object sender, EventArgs s)
        {
            StudyManager sm = SingleTon.StudyManagerInstance();
            foreach(Study tmp in sm.GetStudyList())
            {
                this.StudyList.Items.Add(tmp.StudyName);
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.MaxHours = Decimal.ToInt32(this.SettingHour.Value);
            this.MaxMinuits = Decimal.ToInt32(this.SettingMinuits.Value);
            this.MaxSeconds = Decimal.ToInt32(this.SettingSeconds.Value);
            this.SelectSubject = this.StudyList.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
