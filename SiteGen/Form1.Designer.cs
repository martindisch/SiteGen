namespace SiteGen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.folderPage = new System.Windows.Forms.TabPage();
            this.folderStart = new System.Windows.Forms.Button();
            this.folderProgress = new System.Windows.Forms.ProgressBar();
            this.folderSelectOrigin = new System.Windows.Forms.Button();
            this.folderOriginPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contentsPage = new System.Windows.Forms.TabPage();
            this.contentsStart = new System.Windows.Forms.Button();
            this.contentsProgress = new System.Windows.Forms.ProgressBar();
            this.contentsSelectOrigin = new System.Windows.Forms.Button();
            this.contentsOriginPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderSelectTarget = new System.Windows.Forms.Button();
            this.folderTargetPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.folderPage.SuspendLayout();
            this.contentsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.folderPage);
            this.tabControl1.Controls.Add(this.contentsPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 244);
            this.tabControl1.TabIndex = 0;
            // 
            // folderPage
            // 
            this.folderPage.Controls.Add(this.folderStart);
            this.folderPage.Controls.Add(this.folderProgress);
            this.folderPage.Controls.Add(this.folderSelectTarget);
            this.folderPage.Controls.Add(this.folderTargetPath);
            this.folderPage.Controls.Add(this.label2);
            this.folderPage.Controls.Add(this.folderSelectOrigin);
            this.folderPage.Controls.Add(this.folderOriginPath);
            this.folderPage.Controls.Add(this.label1);
            this.folderPage.Location = new System.Drawing.Point(4, 25);
            this.folderPage.Name = "folderPage";
            this.folderPage.Padding = new System.Windows.Forms.Padding(3);
            this.folderPage.Size = new System.Drawing.Size(506, 215);
            this.folderPage.TabIndex = 1;
            this.folderPage.Text = "Ordneransichten";
            this.folderPage.UseVisualStyleBackColor = true;
            // 
            // folderStart
            // 
            this.folderStart.Location = new System.Drawing.Point(407, 149);
            this.folderStart.Name = "folderStart";
            this.folderStart.Size = new System.Drawing.Size(90, 24);
            this.folderStart.TabIndex = 7;
            this.folderStart.Text = "Los";
            this.folderStart.UseVisualStyleBackColor = true;
            this.folderStart.Click += new System.EventHandler(this.folderStart_Click);
            // 
            // folderProgress
            // 
            this.folderProgress.Location = new System.Drawing.Point(9, 149);
            this.folderProgress.Name = "folderProgress";
            this.folderProgress.Size = new System.Drawing.Size(392, 23);
            this.folderProgress.TabIndex = 6;
            // 
            // folderSelectOrigin
            // 
            this.folderSelectOrigin.Location = new System.Drawing.Point(407, 37);
            this.folderSelectOrigin.Name = "folderSelectOrigin";
            this.folderSelectOrigin.Size = new System.Drawing.Size(90, 24);
            this.folderSelectOrigin.TabIndex = 2;
            this.folderSelectOrigin.Text = "Auswählen";
            this.folderSelectOrigin.UseVisualStyleBackColor = true;
            this.folderSelectOrigin.Click += new System.EventHandler(this.folderSelectOrigin_Click);
            // 
            // folderOriginPath
            // 
            this.folderOriginPath.Location = new System.Drawing.Point(6, 37);
            this.folderOriginPath.Name = "folderOriginPath";
            this.folderOriginPath.ReadOnly = true;
            this.folderOriginPath.Size = new System.Drawing.Size(395, 22);
            this.folderOriginPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ausgangsordner";
            // 
            // contentsPage
            // 
            this.contentsPage.Controls.Add(this.contentsStart);
            this.contentsPage.Controls.Add(this.contentsProgress);
            this.contentsPage.Controls.Add(this.contentsSelectOrigin);
            this.contentsPage.Controls.Add(this.contentsOriginPath);
            this.contentsPage.Controls.Add(this.label3);
            this.contentsPage.Location = new System.Drawing.Point(4, 25);
            this.contentsPage.Name = "contentsPage";
            this.contentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.contentsPage.Size = new System.Drawing.Size(506, 215);
            this.contentsPage.TabIndex = 0;
            this.contentsPage.Text = "Inhaltsverzeichnis";
            this.contentsPage.UseVisualStyleBackColor = true;
            // 
            // contentsStart
            // 
            this.contentsStart.Location = new System.Drawing.Point(407, 95);
            this.contentsStart.Name = "contentsStart";
            this.contentsStart.Size = new System.Drawing.Size(90, 24);
            this.contentsStart.TabIndex = 12;
            this.contentsStart.Text = "Los";
            this.contentsStart.UseVisualStyleBackColor = true;
            this.contentsStart.Click += new System.EventHandler(this.contentsGo_Click);
            // 
            // contentsProgress
            // 
            this.contentsProgress.Location = new System.Drawing.Point(6, 95);
            this.contentsProgress.Name = "contentsProgress";
            this.contentsProgress.Size = new System.Drawing.Size(395, 23);
            this.contentsProgress.TabIndex = 11;
            // 
            // contentsSelectOrigin
            // 
            this.contentsSelectOrigin.Location = new System.Drawing.Point(407, 37);
            this.contentsSelectOrigin.Name = "contentsSelectOrigin";
            this.contentsSelectOrigin.Size = new System.Drawing.Size(90, 24);
            this.contentsSelectOrigin.TabIndex = 5;
            this.contentsSelectOrigin.Text = "Auswählen";
            this.contentsSelectOrigin.UseVisualStyleBackColor = true;
            this.contentsSelectOrigin.Click += new System.EventHandler(this.contentsSelectOrigin_Click);
            // 
            // contentsOriginPath
            // 
            this.contentsOriginPath.Location = new System.Drawing.Point(6, 37);
            this.contentsOriginPath.Name = "contentsOriginPath";
            this.contentsOriginPath.ReadOnly = true;
            this.contentsOriginPath.Size = new System.Drawing.Size(395, 22);
            this.contentsOriginPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ausgangsordner";
            // 
            // folderSelectTarget
            // 
            this.folderSelectTarget.Location = new System.Drawing.Point(407, 95);
            this.folderSelectTarget.Name = "folderSelectTarget";
            this.folderSelectTarget.Size = new System.Drawing.Size(90, 24);
            this.folderSelectTarget.TabIndex = 5;
            this.folderSelectTarget.Text = "Auswählen";
            this.folderSelectTarget.UseVisualStyleBackColor = true;
            this.folderSelectTarget.Click += new System.EventHandler(this.folderSelectTarget_Click);
            // 
            // folderTargetPath
            // 
            this.folderTargetPath.Location = new System.Drawing.Point(6, 95);
            this.folderTargetPath.Name = "folderTargetPath";
            this.folderTargetPath.ReadOnly = true;
            this.folderTargetPath.Size = new System.Drawing.Size(395, 22);
            this.folderTargetPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zielordner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 267);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiteGen";
            this.tabControl1.ResumeLayout(false);
            this.folderPage.ResumeLayout(false);
            this.folderPage.PerformLayout();
            this.contentsPage.ResumeLayout(false);
            this.contentsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage contentsPage;
        private System.Windows.Forms.TabPage folderPage;
        private System.Windows.Forms.Button folderStart;
        private System.Windows.Forms.ProgressBar folderProgress;
        private System.Windows.Forms.Button folderSelectOrigin;
        private System.Windows.Forms.TextBox folderOriginPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contentsSelectOrigin;
        private System.Windows.Forms.TextBox contentsOriginPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button contentsStart;
        private System.Windows.Forms.ProgressBar contentsProgress;
        private System.Windows.Forms.Button folderSelectTarget;
        private System.Windows.Forms.TextBox folderTargetPath;
        private System.Windows.Forms.Label label2;
    }
}

