namespace StudyAid
{
    partial class SettingTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingTime));
            this.SettingHour = new System.Windows.Forms.NumericUpDown();
            this.SettingMinuits = new System.Windows.Forms.NumericUpDown();
            this.SettingSeconds = new System.Windows.Forms.NumericUpDown();
            this.Hour = new System.Windows.Forms.Label();
            this.Minuit = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.SelectStudy = new System.Windows.Forms.Label();
            this.StudyList = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SettingHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingMinuits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingHour
            // 
            this.SettingHour.Location = new System.Drawing.Point(29, 34);
            this.SettingHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.SettingHour.Name = "SettingHour";
            this.SettingHour.Size = new System.Drawing.Size(44, 21);
            this.SettingHour.TabIndex = 2;
            // 
            // SettingMinuits
            // 
            this.SettingMinuits.Location = new System.Drawing.Point(102, 34);
            this.SettingMinuits.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SettingMinuits.Name = "SettingMinuits";
            this.SettingMinuits.Size = new System.Drawing.Size(34, 21);
            this.SettingMinuits.TabIndex = 3;
            // 
            // SettingSeconds
            // 
            this.SettingSeconds.Location = new System.Drawing.Point(165, 34);
            this.SettingSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SettingSeconds.Name = "SettingSeconds";
            this.SettingSeconds.Size = new System.Drawing.Size(39, 21);
            this.SettingSeconds.TabIndex = 4;
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(6, 36);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(17, 12);
            this.Hour.TabIndex = 5;
            this.Hour.Text = "시";
            // 
            // Minuit
            // 
            this.Minuit.AutoSize = true;
            this.Minuit.Location = new System.Drawing.Point(79, 36);
            this.Minuit.Name = "Minuit";
            this.Minuit.Size = new System.Drawing.Size(17, 12);
            this.Minuit.TabIndex = 6;
            this.Minuit.Text = "분";
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(142, 36);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(17, 12);
            this.Seconds.TabIndex = 7;
            this.Seconds.Text = "초";
            // 
            // SelectStudy
            // 
            this.SelectStudy.AutoSize = true;
            this.SelectStudy.Location = new System.Drawing.Point(6, 11);
            this.SelectStudy.Name = "SelectStudy";
            this.SelectStudy.Size = new System.Drawing.Size(53, 12);
            this.SelectStudy.TabIndex = 8;
            this.SelectStudy.Text = "공부선택";
            // 
            // StudyList
            // 
            this.StudyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudyList.FormattingEnabled = true;
            this.StudyList.Location = new System.Drawing.Point(71, 8);
            this.StudyList.Name = "StudyList";
            this.StudyList.Size = new System.Drawing.Size(133, 20);
            this.StudyList.TabIndex = 9;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ok.Location = new System.Drawing.Point(8, 71);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(74, 23);
            this.Ok.TabIndex = 10;
            this.Ok.Text = "확인";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancel.Location = new System.Drawing.Point(129, 71);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SettingTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 106);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.StudyList);
            this.Controls.Add(this.SelectStudy);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minuit);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.SettingSeconds);
            this.Controls.Add(this.SettingMinuits);
            this.Controls.Add(this.SettingHour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingTime";
            this.Text = "SettingTime";
            ((System.ComponentModel.ISupportInitialize)(this.SettingHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingMinuits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SettingHour;
        private System.Windows.Forms.NumericUpDown SettingMinuits;
        private System.Windows.Forms.NumericUpDown SettingSeconds;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Minuit;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label SelectStudy;
        private System.Windows.Forms.ComboBox StudyList;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}