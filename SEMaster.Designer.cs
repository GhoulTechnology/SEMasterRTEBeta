namespace SEMasterRTEBeta
{
    partial class SEMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMaster));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabsPanel = new System.Windows.Forms.Panel();
            this.SERTEtab = new Guna.UI2.WinForms.Guna2Button();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBoxConsoleLogs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConnectionStatus = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnLoadCFGorTestScript = new System.Windows.Forms.Button();
            this.BtnDownloadCvars = new System.Windows.Forms.Button();
            this.TxtBoxEnterCvar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitlePanel.SuspendLayout();
            this.TabsPanel.SuspendLayout();
            this.ActivePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.AccessibleName = "TitlePanel";
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.BtnInfo);
            this.TitlePanel.Controls.Add(this.BtnClose);
            this.TitlePanel.Controls.Add(this.BtnMinimize);
            this.TitlePanel.Controls.Add(this.label2);
            this.TitlePanel.Controls.Add(this.pictureBox1);
            this.TitlePanel.Controls.Add(this.label1);
            this.TitlePanel.Location = new System.Drawing.Point(10, 10);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(980, 60);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Window);
            // 
            // BtnInfo
            // 
            this.BtnInfo.AccessibleName = "BtnInfo";
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Azonix", 9F);
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.Location = new System.Drawing.Point(855, 15);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(30, 30);
            this.BtnInfo.TabIndex = 3;
            this.BtnInfo.Text = "?";
            this.BtnInfo.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleName = "BtnClose";
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Azonix", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(935, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.AccessibleName = "BtnMinimize";
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Azonix", 9F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(895, 15);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(59, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open Beta 1.0 | RTE Build";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Window);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SE Master";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Window);
            // 
            // TabsPanel
            // 
            this.TabsPanel.AccessibleName = "TabsPanel";
            this.TabsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.TabsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabsPanel.Controls.Add(this.SERTEtab);
            this.TabsPanel.Location = new System.Drawing.Point(10, 70);
            this.TabsPanel.Name = "TabsPanel";
            this.TabsPanel.Size = new System.Drawing.Size(980, 35);
            this.TabsPanel.TabIndex = 1;
            // 
            // SERTEtab
            // 
            this.SERTEtab.AccessibleName = "SERTEtab";
            this.SERTEtab.Animated = true;
            this.SERTEtab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SERTEtab.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(246)))));
            this.SERTEtab.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.SERTEtab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SERTEtab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SERTEtab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SERTEtab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SERTEtab.FillColor = System.Drawing.Color.Transparent;
            this.SERTEtab.Font = new System.Drawing.Font("Azonix", 10F);
            this.SERTEtab.ForeColor = System.Drawing.Color.White;
            this.SERTEtab.Location = new System.Drawing.Point(0, 0);
            this.SERTEtab.Name = "SERTEtab";
            this.SERTEtab.Size = new System.Drawing.Size(110, 33);
            this.SERTEtab.TabIndex = 0;
            this.SERTEtab.Text = "SE | RTE";
            // 
            // ActivePanel
            // 
            this.ActivePanel.AccessibleName = "ActivePanel";
            this.ActivePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ActivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActivePanel.Controls.Add(this.panel1);
            this.ActivePanel.Location = new System.Drawing.Point(10, 105);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(980, 580);
            this.ActivePanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtBoxConsoleLogs);
            this.panel1.Controls.Add(this.TxtBoxEnterCvar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtConnectionStatus);
            this.panel1.Controls.Add(this.BtnConnect);
            this.panel1.Controls.Add(this.BtnLoadCFGorTestScript);
            this.panel1.Controls.Add(this.BtnDownloadCvars);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 560);
            this.panel1.TabIndex = 0;
            // 
            // TxtBoxConsoleLogs
            // 
            this.TxtBoxConsoleLogs.AccessibleName = "TxtBoxConsoleLogs";
            this.TxtBoxConsoleLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.TxtBoxConsoleLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxConsoleLogs.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxConsoleLogs.ForeColor = System.Drawing.Color.White;
            this.TxtBoxConsoleLogs.Location = new System.Drawing.Point(10, 50);
            this.TxtBoxConsoleLogs.MaxLength = 10000;
            this.TxtBoxConsoleLogs.Multiline = true;
            this.TxtBoxConsoleLogs.Name = "TxtBoxConsoleLogs";
            this.TxtBoxConsoleLogs.ReadOnly = true;
            this.TxtBoxConsoleLogs.Size = new System.Drawing.Size(940, 460);
            this.TxtBoxConsoleLogs.TabIndex = 0;
            this.TxtBoxConsoleLogs.Text = "eeeeeeeeeeeeee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Azonix", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SE | Console";
            // 
            // TxtConnectionStatus
            // 
            this.TxtConnectionStatus.AccessibleName = "TxtConnectionStatus";
            this.TxtConnectionStatus.AutoSize = true;
            this.TxtConnectionStatus.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConnectionStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtConnectionStatus.Location = new System.Drawing.Point(7, 26);
            this.TxtConnectionStatus.Name = "TxtConnectionStatus";
            this.TxtConnectionStatus.Size = new System.Drawing.Size(125, 14);
            this.TxtConnectionStatus.TabIndex = 2;
            this.TxtConnectionStatus.Text = "Status: Not Connected";
            this.TxtConnectionStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Window);
            // 
            // BtnConnect
            // 
            this.BtnConnect.AccessibleName = "BtnConnect";
            this.BtnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.Font = new System.Drawing.Font("Azonix", 12F);
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(292, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(157, 30);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnLoadCFGorTestScript
            // 
            this.BtnLoadCFGorTestScript.AccessibleName = "BtnLoadCFG/TestScript";
            this.BtnLoadCFGorTestScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadCFGorTestScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadCFGorTestScript.Font = new System.Drawing.Font("Azonix", 12F);
            this.BtnLoadCFGorTestScript.ForeColor = System.Drawing.Color.White;
            this.BtnLoadCFGorTestScript.Location = new System.Drawing.Point(459, 10);
            this.BtnLoadCFGorTestScript.Name = "BtnLoadCFGorTestScript";
            this.BtnLoadCFGorTestScript.Size = new System.Drawing.Size(267, 30);
            this.BtnLoadCFGorTestScript.TabIndex = 3;
            this.BtnLoadCFGorTestScript.Text = "Load CFG/TestScript";
            this.BtnLoadCFGorTestScript.UseVisualStyleBackColor = true;
            this.BtnLoadCFGorTestScript.Click += new System.EventHandler(this.BtnLoadCFGorTestScript_Click);
            // 
            // BtnDownloadCvars
            // 
            this.BtnDownloadCvars.AccessibleName = "BtnDownloadCvars";
            this.BtnDownloadCvars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDownloadCvars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownloadCvars.Font = new System.Drawing.Font("Azonix", 12F);
            this.BtnDownloadCvars.ForeColor = System.Drawing.Color.White;
            this.BtnDownloadCvars.Location = new System.Drawing.Point(736, 10);
            this.BtnDownloadCvars.Name = "BtnDownloadCvars";
            this.BtnDownloadCvars.Size = new System.Drawing.Size(214, 30);
            this.BtnDownloadCvars.TabIndex = 3;
            this.BtnDownloadCvars.Text = "Download Cvars";
            this.BtnDownloadCvars.UseVisualStyleBackColor = true;
            this.BtnDownloadCvars.Click += new System.EventHandler(this.BtnDownloadCvars_Click);
            // 
            // TxtBoxEnterCvar
            // 
            this.TxtBoxEnterCvar.AcceptsReturn = true;
            this.TxtBoxEnterCvar.AccessibleName = "TxtBoxEnterCvar";
            this.TxtBoxEnterCvar.AllowDrop = true;
            this.TxtBoxEnterCvar.Animated = true;
            this.TxtBoxEnterCvar.AutoCompleteCustomSource.AddRange(new string[] {
            "sv_cheats",
            "ent_fire",
            "ent_keyvalue",
            "addoutput"});
            this.TxtBoxEnterCvar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtBoxEnterCvar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.TxtBoxEnterCvar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TxtBoxEnterCvar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxEnterCvar.DefaultText = "";
            this.TxtBoxEnterCvar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBoxEnterCvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBoxEnterCvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxEnterCvar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxEnterCvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.TxtBoxEnterCvar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(246)))));
            this.TxtBoxEnterCvar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxEnterCvar.ForeColor = System.Drawing.Color.White;
            this.TxtBoxEnterCvar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(246)))));
            this.TxtBoxEnterCvar.Location = new System.Drawing.Point(10, 521);
            this.TxtBoxEnterCvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtBoxEnterCvar.MaxLength = 300;
            this.TxtBoxEnterCvar.Name = "TxtBoxEnterCvar";
            this.TxtBoxEnterCvar.PasswordChar = '\0';
            this.TxtBoxEnterCvar.PlaceholderText = "Input CVARs...";
            this.TxtBoxEnterCvar.SelectedText = "";
            this.TxtBoxEnterCvar.Size = new System.Drawing.Size(940, 28);
            this.TxtBoxEnterCvar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Window);
            // 
            // SEMaster
            // 
            this.AccessibleName = "SEMaster";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 695);
            this.Controls.Add(this.ActivePanel);
            this.Controls.Add(this.TabsPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SEMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Window);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.TabsPanel.ResumeLayout(false);
            this.ActivePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TabsPanel;
        private System.Windows.Forms.Panel ActivePanel;
        private Guna.UI2.WinForms.Guna2Button SERTEtab;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtBoxEnterCvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDownloadCvars;
        private System.Windows.Forms.Button BtnLoadCFGorTestScript;
        private System.Windows.Forms.TextBox TxtBoxConsoleLogs;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label TxtConnectionStatus;
    }
}

