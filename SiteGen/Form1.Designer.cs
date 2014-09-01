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
            this.contentsPage = new System.Windows.Forms.TabPage();
            this.folderPage = new System.Windows.Forms.TabPage();
            this.folderStart = new System.Windows.Forms.Button();
            this.folderProgress = new System.Windows.Forms.ProgressBar();
            this.folderSelectTarget = new System.Windows.Forms.Button();
            this.folderTargetPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderSelectOrigin = new System.Windows.Forms.Button();
            this.folderOriginPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contentsSelectOrigin = new System.Windows.Forms.Button();
            this.contentsOriginPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contentsOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contentsGo = new System.Windows.Forms.Button();
            this.contentsProgress = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.contentsPage.SuspendLayout();
            this.folderPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.folderPage);
            this.tabControl1.Controls.Add(this.contentsPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // contentsPage
            // 
            this.contentsPage.Controls.Add(this.contentsGo);
            this.contentsPage.Controls.Add(this.contentsProgress);
            this.contentsPage.Controls.Add(this.label4);
            this.contentsPage.Controls.Add(this.contentsOutput);
            this.contentsPage.Controls.Add(this.contentsSelectOrigin);
            this.contentsPage.Controls.Add(this.contentsOriginPath);
            this.contentsPage.Controls.Add(this.label3);
            this.contentsPage.Location = new System.Drawing.Point(4, 25);
            this.contentsPage.Name = "contentsPage";
            this.contentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.contentsPage.Size = new System.Drawing.Size(506, 309);
            this.contentsPage.TabIndex = 0;
            this.contentsPage.Text = "Inhaltsverzeichnis";
            this.contentsPage.UseVisualStyleBackColor = true;
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
            this.folderPage.Size = new System.Drawing.Size(506, 309);
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
            // contentsSelectOrigin
            // 
            this.contentsSelectOrigin.Location = new System.Drawing.Point(407, 35);
            this.contentsSelectOrigin.Name = "contentsSelectOrigin";
            this.contentsSelectOrigin.Size = new System.Drawing.Size(90, 24);
            this.contentsSelectOrigin.TabIndex = 5;
            this.contentsSelectOrigin.Text = "Auswählen";
            this.contentsSelectOrigin.UseVisualStyleBackColor = true;
            // 
            // contentsOriginPath
            // 
            this.contentsOriginPath.Location = new System.Drawing.Point(6, 35);
            this.contentsOriginPath.Name = "contentsOriginPath";
            this.contentsOriginPath.ReadOnly = true;
            this.contentsOriginPath.Size = new System.Drawing.Size(395, 22);
            this.contentsOriginPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ausgangsordner";
            // 
            // contentsOutput
            // 
            this.contentsOutput.Location = new System.Drawing.Point(9, 84);
            this.contentsOutput.Multiline = true;
            this.contentsOutput.Name = "contentsOutput";
            this.contentsOutput.ReadOnly = true;
            this.contentsOutput.Size = new System.Drawing.Size(488, 169);
            this.contentsOutput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ausgabe";
            // 
            // contentsGo
            // 
            this.contentsGo.Location = new System.Drawing.Point(407, 268);
            this.contentsGo.Name = "contentsGo";
            this.contentsGo.Size = new System.Drawing.Size(90, 24);
            this.contentsGo.TabIndex = 9;
            this.contentsGo.Text = "Los";
            this.contentsGo.UseVisualStyleBackColor = true;
            // 
            // contentsProgress
            // 
            this.contentsProgress.Location = new System.Drawing.Point(9, 268);
            this.contentsProgress.Name = "contentsProgress";
            this.contentsProgress.Size = new System.Drawing.Size(392, 23);
            this.contentsProgress.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 362);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiteGen";
            this.tabControl1.ResumeLayout(false);
            this.contentsPage.ResumeLayout(false);
            this.contentsPage.PerformLayout();
            this.folderPage.ResumeLayout(false);
            this.folderPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage contentsPage;
        private System.Windows.Forms.TabPage folderPage;
        private System.Windows.Forms.Button folderStart;
        private System.Windows.Forms.ProgressBar folderProgress;
        private System.Windows.Forms.Button folderSelectTarget;
        private System.Windows.Forms.TextBox folderTargetPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button folderSelectOrigin;
        private System.Windows.Forms.TextBox folderOriginPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contentsSelectOrigin;
        private System.Windows.Forms.TextBox contentsOriginPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button contentsGo;
        private System.Windows.Forms.ProgressBar contentsProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contentsOutput;
    }
}

