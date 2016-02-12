using System.Drawing;

namespace StudyAid
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SystemTimer = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemTime = new System.Windows.Forms.Label();
            this.MonitorStat = new System.Windows.Forms.CheckBox();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.diaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.공부설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.study설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.멈춤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일시정지시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudyProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.StudyTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.trayButton.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemTimer
            // 
            this.SystemTimer.Enabled = true;
            this.SystemTimer.Interval = 1000;
            this.SystemTimer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // menualToolStripMenuItem
            // 
            this.menualToolStripMenuItem.Name = "menualToolStripMenuItem";
            this.menualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.menualToolStripMenuItem.Text = "Menual";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorToolStripMenuItem,
            this.diaryToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monitorToolStripMenuItem.Text = "Monitor";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // diaryToolStripMenuItem
            // 
            this.diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            this.diaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diaryToolStripMenuItem.Text = "Diary";
            this.diaryToolStripMenuItem.Click += new System.EventHandler(this.diaryToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemTime
            // 
            this.SystemTime.Font = new System.Drawing.Font("굴림", 10F);
            this.SystemTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SystemTime.Location = new System.Drawing.Point(47, 43);
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SystemTime.Size = new System.Drawing.Size(204, 25);
            this.SystemTime.TabIndex = 6;
            this.SystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorStat
            // 
            this.MonitorStat.Appearance = System.Windows.Forms.Appearance.Button;
            this.MonitorStat.Location = new System.Drawing.Point(106, 282);
            this.MonitorStat.Name = "MonitorStat";
            this.MonitorStat.Size = new System.Drawing.Size(91, 22);
            this.MonitorStat.TabIndex = 8;
            this.MonitorStat.Text = "모니터링 꺼짐";
            this.MonitorStat.UseVisualStyleBackColor = true;
            this.MonitorStat.CheckedChanged += new System.EventHandler(this.MonitorStat_CheckedChanged);
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.trayButton;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "StudyAid";
            this.Tray.Visible = true;
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_DoubleClick);
            // 
            // trayButton
            // 
            this.trayButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diaryToolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.trayButton.Name = "trayButton";
            this.trayButton.Size = new System.Drawing.Size(103, 48);
            // 
            // diaryToolStripMenuItem1
            // 
            this.diaryToolStripMenuItem1.Name = "diaryToolStripMenuItem1";
            this.diaryToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.diaryToolStripMenuItem1.Text = "Diary";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.ExitToolStripMenuItem.Text = "종료";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.StudyProgress,
            this.StudyTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(301, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공부설정,
            this.시간설정});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // 공부설정
            // 
            this.공부설정.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.study설정ToolStripMenuItem,
            this.업데이트ToolStripMenuItem});
            this.공부설정.Name = "공부설정";
            this.공부설정.Size = new System.Drawing.Size(122, 22);
            this.공부설정.Text = "공부설정";
            // 
            // study설정ToolStripMenuItem
            // 
            this.study설정ToolStripMenuItem.Name = "study설정ToolStripMenuItem";
            this.study설정ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.study설정ToolStripMenuItem.Text = "Study설정";
            this.study설정ToolStripMenuItem.Click += new System.EventHandler(this.study설정ToolStripMenuItem_Click);
            // 
            // 업데이트ToolStripMenuItem
            // 
            this.업데이트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.불러오기ToolStripMenuItem,
            this.보내기ToolStripMenuItem});
            this.업데이트ToolStripMenuItem.Name = "업데이트ToolStripMenuItem";
            this.업데이트ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.업데이트ToolStripMenuItem.Text = "연동하기";
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // 보내기ToolStripMenuItem
            // 
            this.보내기ToolStripMenuItem.Name = "보내기ToolStripMenuItem";
            this.보내기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.보내기ToolStripMenuItem.Text = "보내기";
            this.보내기ToolStripMenuItem.Click += new System.EventHandler(this.보내기ToolStripMenuItem_Click);
            // 
            // 시간설정
            // 
            this.시간설정.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.멈춤ToolStripMenuItem,
            this.일시정지시작ToolStripMenuItem});
            this.시간설정.Name = "시간설정";
            this.시간설정.Size = new System.Drawing.Size(122, 22);
            this.시간설정.Text = "시간설정";
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.시작ToolStripMenuItem.Text = "시작";
            this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
            // 
            // 멈춤ToolStripMenuItem
            // 
            this.멈춤ToolStripMenuItem.Name = "멈춤ToolStripMenuItem";
            this.멈춤ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.멈춤ToolStripMenuItem.Text = "종료";
            this.멈춤ToolStripMenuItem.Click += new System.EventHandler(this.멈춤ToolStripMenuItem_Click);
            // 
            // 일시정지시작ToolStripMenuItem
            // 
            this.일시정지시작ToolStripMenuItem.Name = "일시정지시작ToolStripMenuItem";
            this.일시정지시작ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.일시정지시작ToolStripMenuItem.Text = "일시정지/시작";
            this.일시정지시작ToolStripMenuItem.Click += new System.EventHandler(this.일시정지시작ToolStripMenuItem_Click);
            // 
            // StudyProgress
            // 
            this.StudyProgress.AutoSize = false;
            this.StudyProgress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudyProgress.Name = "StudyProgress";
            this.StudyProgress.Size = new System.Drawing.Size(170, 16);
            // 
            // StudyTime
            // 
            this.StudyTime.Name = "StudyTime";
            this.StudyTime.Size = new System.Drawing.Size(82, 17);
            this.StudyTime.Spring = true;
            this.StudyTime.Text = "00:00:00";
            // 
            // MainBackground
            // 
            this.MainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBackground.Image = ((System.Drawing.Image)(resources.GetObject("MainBackground.Image")));
            this.MainBackground.Location = new System.Drawing.Point(0, 24);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(301, 347);
            this.MainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainBackground.TabIndex = 5;
            this.MainBackground.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MonitorStat);
            this.Controls.Add(this.SystemTime);
            this.Controls.Add(this.MainBackground);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.trayButton.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainBackground;
        private System.Windows.Forms.Timer SystemTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label SystemTime;
        private System.Windows.Forms.CheckBox MonitorStat;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip trayButton;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaryToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 공부설정;
        private System.Windows.Forms.ToolStripMenuItem study설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간설정;
        private System.Windows.Forms.ToolStripProgressBar StudyProgress;
        private System.Windows.Forms.ToolStripStatusLabel StudyTime;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 멈춤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일시정지시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업데이트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보내기ToolStripMenuItem;
    }
}

