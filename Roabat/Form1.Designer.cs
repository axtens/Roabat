namespace Roabat
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
            this.WBMain = new System.Windows.Forms.WebBrowser();
            this.LBScripts = new System.Windows.Forms.ListBox();
            this.BRun = new System.Windows.Forms.Button();
            this.LStatus = new System.Windows.Forms.Label();
            this.BReloadList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WBMain
            // 
            this.WBMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBMain.Location = new System.Drawing.Point(12, 12);
            this.WBMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBMain.Name = "WBMain";
            this.WBMain.Size = new System.Drawing.Size(1254, 442);
            this.WBMain.TabIndex = 0;
            this.WBMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WBMain_DocumentCompleted);
            // 
            // LBScripts
            // 
            this.LBScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBScripts.FormattingEnabled = true;
            this.LBScripts.ItemHeight = 16;
            this.LBScripts.Location = new System.Drawing.Point(12, 461);
            this.LBScripts.Name = "LBScripts";
            this.LBScripts.Size = new System.Drawing.Size(414, 52);
            this.LBScripts.TabIndex = 1;
            // 
            // BRun
            // 
            this.BRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BRun.Location = new System.Drawing.Point(432, 461);
            this.BRun.Name = "BRun";
            this.BRun.Size = new System.Drawing.Size(75, 23);
            this.BRun.TabIndex = 2;
            this.BRun.Text = "Run";
            this.BRun.UseVisualStyleBackColor = true;
            this.BRun.Click += new System.EventHandler(this.BRun_Click);
            // 
            // LStatus
            // 
            this.LStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(433, 495);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(86, 17);
            this.LStatus.TabIndex = 3;
            this.LStatus.Text = "Status Texts";
            this.LStatus.Visible = false;
            // 
            // BReloadList
            // 
            this.BReloadList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BReloadList.Location = new System.Drawing.Point(513, 461);
            this.BReloadList.Name = "BReloadList";
            this.BReloadList.Size = new System.Drawing.Size(75, 23);
            this.BReloadList.TabIndex = 4;
            this.BReloadList.Text = "Reload List";
            this.BReloadList.UseVisualStyleBackColor = true;
            this.BReloadList.Click += new System.EventHandler(this.BReloadList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 522);
            this.Controls.Add(this.BReloadList);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.BRun);
            this.Controls.Add(this.LBScripts);
            this.Controls.Add(this.WBMain);
            this.Name = "Form1";
            this.Text = "روابط";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBMain;
        private System.Windows.Forms.ListBox LBScripts;
        private System.Windows.Forms.Button BRun;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button BReloadList;
    }
}

