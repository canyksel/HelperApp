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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phrase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxLighthouse = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabelClearResult = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxSingleUrlLighthouse = new System.Windows.Forms.CheckBox();
            this.btnStopAnalyze = new System.Windows.Forms.Button();
            this.btnStartAnalyze = new System.Windows.Forms.Button();
            this.txtSingleUrl = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(759, 525);
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
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.checkBoxLighthouse);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url,
            this.Status,
            this.ResponseTime,
            this.Phrase,
            this.Performance,
            this.FCP,
            this.LCP,
            this.CLS});
            this.dataGridView1.Location = new System.Drawing.Point(7, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 445);
            this.dataGridView1.TabIndex = 26;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status Code";
            this.Status.Name = "Status";
            // 
            // ResponseTime
            // 
            this.ResponseTime.HeaderText = "Response Time(ms)";
            this.ResponseTime.Name = "ResponseTime";
            this.ResponseTime.Width = 150;
            // 
            // Phrase
            // 
            this.Phrase.HeaderText = "Reason Phrase";
            this.Phrase.Name = "Phrase";
            this.Phrase.Width = 130;
            // 
            // Performance
            // 
            this.Performance.HeaderText = "Performance Score";
            this.Performance.Name = "Performance";
            this.Performance.Width = 150;
            // 
            // FCP
            // 
            this.FCP.HeaderText = "FCP";
            this.FCP.Name = "FCP";
            // 
            // LCP
            // 
            this.LCP.HeaderText = "LCP";
            this.LCP.Name = "LCP";
            // 
            // CLS
            // 
            this.CLS.HeaderText = "CLS";
            this.CLS.Name = "CLS";
            // 
            // checkBoxLighthouse
            // 
            this.checkBoxLighthouse.AutoSize = true;
            this.checkBoxLighthouse.Location = new System.Drawing.Point(576, 19);
            this.checkBoxLighthouse.Name = "checkBoxLighthouse";
            this.checkBoxLighthouse.Size = new System.Drawing.Size(127, 19);
            this.checkBoxLighthouse.TabIndex = 24;
            this.checkBoxLighthouse.Text = "Include Lighthouse";
            this.checkBoxLighthouse.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Stop Analyze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1002, 49);
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
            this.button1.Text = "Start Analyze";
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 578);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabelClearResult);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.checkBoxSingleUrlLighthouse);
            this.tabPage3.Controls.Add(this.btnStopAnalyze);
            this.tabPage3.Controls.Add(this.btnStartAnalyze);
            this.tabPage3.Controls.Add(this.txtSingleUrl);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1070, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crawl Single Page";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabelClearResult
            // 
            this.linkLabelClearResult.AutoSize = true;
            this.linkLabelClearResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelClearResult.LinkColor = System.Drawing.Color.Black;
            this.linkLabelClearResult.Location = new System.Drawing.Point(985, 50);
            this.linkLabelClearResult.Name = "linkLabelClearResult";
            this.linkLabelClearResult.Size = new System.Drawing.Size(79, 17);
            this.linkLabelClearResult.TabIndex = 33;
            this.linkLabelClearResult.TabStop = true;
            this.linkLabelClearResult.Text = "Clear Result";
            this.linkLabelClearResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearResult_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Http Results:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView2.Location = new System.Drawing.Point(7, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1057, 445);
            this.dataGridView2.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Url";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Status Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Response Time(ms)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Reason Phrase";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Performance Score";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "FCP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "LCP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "CLS";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // checkBoxSingleUrlLighthouse
            // 
            this.checkBoxSingleUrlLighthouse.AutoSize = true;
            this.checkBoxSingleUrlLighthouse.Location = new System.Drawing.Point(492, 20);
            this.checkBoxSingleUrlLighthouse.Name = "checkBoxSingleUrlLighthouse";
            this.checkBoxSingleUrlLighthouse.Size = new System.Drawing.Size(127, 19);
            this.checkBoxSingleUrlLighthouse.TabIndex = 30;
            this.checkBoxSingleUrlLighthouse.Text = "Include Lighthouse";
            this.checkBoxSingleUrlLighthouse.UseVisualStyleBackColor = true;
            // 
            // btnStopAnalyze
            // 
            this.btnStopAnalyze.Location = new System.Drawing.Point(199, 521);
            this.btnStopAnalyze.Name = "btnStopAnalyze";
            this.btnStopAnalyze.Size = new System.Drawing.Size(182, 23);
            this.btnStopAnalyze.TabIndex = 29;
            this.btnStopAnalyze.Text = "Stop Analyze";
            this.btnStopAnalyze.UseVisualStyleBackColor = true;
            this.btnStopAnalyze.Click += new System.EventHandler(this.btnStopAnalyze_Click);
            // 
            // btnStartAnalyze
            // 
            this.btnStartAnalyze.Location = new System.Drawing.Point(7, 521);
            this.btnStartAnalyze.Name = "btnStartAnalyze";
            this.btnStartAnalyze.Size = new System.Drawing.Size(182, 23);
            this.btnStartAnalyze.TabIndex = 27;
            this.btnStartAnalyze.Text = "Start Analyze";
            this.btnStartAnalyze.UseVisualStyleBackColor = true;
            this.btnStartAnalyze.Click += new System.EventHandler(this.btnStartAnalyze_Click);
            // 
            // txtSingleUrl
            // 
            this.txtSingleUrl.Location = new System.Drawing.Point(7, 16);
            this.txtSingleUrl.Name = "txtSingleUrl";
            this.txtSingleUrl.PlaceholderText = "Enter URL (https://...)";
            this.txtSingleUrl.Size = new System.Drawing.Size(468, 23);
            this.txtSingleUrl.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 602);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Crawler";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private TabPage tabPage2;
        private ListBox listBoxUrlList;
        private Label label3;
        private TabPage tabPage1;
        private Label label1;
        private Button button2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button btnSaveResult;
        private TextBox txtUrls;
        private TabControl tabControl1;
        private CheckBox checkBoxLighthouse;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn ResponseTime;
        private DataGridViewTextBoxColumn Phrase;
        private DataGridViewTextBoxColumn Performance;
        private DataGridViewTextBoxColumn FCP;
        private DataGridViewTextBoxColumn LCP;
        private DataGridViewTextBoxColumn CLS;
        private TabPage tabPage3;
        private Label label4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private CheckBox checkBoxSingleUrlLighthouse;
        private Button btnStopAnalyze;
        private Button btnStartAnalyze;
        private TextBox txtSingleUrl;
        private LinkLabel linkLabelClearResult;
    }
}