namespace HttpResponseApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxUrlList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxResponses = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(745, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxUrlList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1070, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "URL-List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxUrlList
            // 
            this.listBoxUrlList.FormattingEnabled = true;
            this.listBoxUrlList.ItemHeight = 15;
            this.listBoxUrlList.Location = new System.Drawing.Point(7, 48);
            this.listBoxUrlList.Name = "listBoxUrlList";
            this.listBoxUrlList.Size = new System.Drawing.Size(1057, 499);
            this.listBoxUrlList.TabIndex = 3;
            this.listBoxUrlList.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "URL-List";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBoxResponses);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnSaveResult);
            this.tabPage1.Controls.Add(this.txtUrls);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1070, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crawl Website";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Http Results:";
            // 
            // listBoxResponses
            // 
            this.listBoxResponses.FormattingEnabled = true;
            this.listBoxResponses.ItemHeight = 15;
            this.listBoxResponses.Location = new System.Drawing.Point(6, 70);
            this.listBoxResponses.Name = "listBoxResponses";
            this.listBoxResponses.Size = new System.Drawing.Size(1058, 439);
            this.listBoxResponses.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Stop Scan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1002, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear List";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(399, 16);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(153, 23);
            this.btnSaveResult.TabIndex = 20;
            this.btnSaveResult.Text = "Save Result";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // txtUrls
            // 
            this.txtUrls.Location = new System.Drawing.Point(7, 16);
            this.txtUrls.Name = "txtUrls";
            this.txtUrls.PlaceholderText = "Enter URL (https://...)";
            this.txtUrls.Size = new System.Drawing.Size(375, 23);
            this.txtUrls.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 578);
            this.tabControl1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Crawler";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TabPage tabPage2;
        private ListBox listBoxUrlList;
        private Label label3;
        private TabPage tabPage1;
        private Label label1;
        private ListBox listBoxResponses;
        private Button button2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button btnSaveResult;
        private TextBox txtUrls;
        private TabControl tabControl1;
        private ListBox listBoxResponseList;
    }
}