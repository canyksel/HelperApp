namespace WebpConverter
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Select_Target = new System.Windows.Forms.Button();
            this.Open_Folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.cmbxFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear_Image_List = new System.Windows.Forms.Button();
            this.Clear_Convert_Image_List = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxQuality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 439);
            this.listBox1.TabIndex = 3;
            // 
            // Select_Target
            // 
            this.Select_Target.Location = new System.Drawing.Point(676, 499);
            this.Select_Target.Name = "Select_Target";
            this.Select_Target.Size = new System.Drawing.Size(125, 23);
            this.Select_Target.TabIndex = 5;
            this.Select_Target.Text = "Target Folder";
            this.Select_Target.UseVisualStyleBackColor = true;
            this.Select_Target.Click += new System.EventHandler(this.Select_Target_Click);
            // 
            // Open_Folder
            // 
            this.Open_Folder.Location = new System.Drawing.Point(12, 499);
            this.Open_Folder.Name = "Open_Folder";
            this.Open_Folder.Size = new System.Drawing.Size(125, 23);
            this.Open_Folder.TabIndex = 7;
            this.Open_Folder.Text = "Select Folder";
            this.Open_Folder.UseVisualStyleBackColor = true;
            this.Open_Folder.Click += new System.EventHandler(this.Open_Folder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Image List";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(418, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(383, 439);
            this.listBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(418, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Converted Image List";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(222, 513);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(371, 23);
            this.Convert.TabIndex = 15;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // cmbxFormat
            // 
            this.cmbxFormat.FormattingEnabled = true;
            this.cmbxFormat.Location = new System.Drawing.Point(842, 78);
            this.cmbxFormat.Name = "cmbxFormat";
            this.cmbxFormat.Size = new System.Drawing.Size(115, 23);
            this.cmbxFormat.TabIndex = 17;
            this.cmbxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Convert Type";
            // 
            // Clear_Image_List
            // 
            this.Clear_Image_List.Location = new System.Drawing.Point(12, 528);
            this.Clear_Image_List.Name = "Clear_Image_List";
            this.Clear_Image_List.Size = new System.Drawing.Size(125, 23);
            this.Clear_Image_List.TabIndex = 21;
            this.Clear_Image_List.Text = "Clear List";
            this.Clear_Image_List.UseVisualStyleBackColor = true;
            this.Clear_Image_List.Click += new System.EventHandler(this.Clear_Image_List_Click);
            // 
            // Clear_Convert_Image_List
            // 
            this.Clear_Convert_Image_List.Location = new System.Drawing.Point(676, 528);
            this.Clear_Convert_Image_List.Name = "Clear_Convert_Image_List";
            this.Clear_Convert_Image_List.Size = new System.Drawing.Size(125, 23);
            this.Clear_Convert_Image_List.TabIndex = 22;
            this.Clear_Convert_Image_List.Text = "Clear List";
            this.Clear_Convert_Image_List.UseVisualStyleBackColor = true;
            this.Clear_Convert_Image_List.Click += new System.EventHandler(this.Clear_Convert_Image_List_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quality";
            // 
            // cmbxQuality
            // 
            this.cmbxQuality.FormattingEnabled = true;
            this.cmbxQuality.Location = new System.Drawing.Point(842, 122);
            this.cmbxQuality.Name = "cmbxQuality";
            this.cmbxQuality.Size = new System.Drawing.Size(65, 23);
            this.cmbxQuality.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Source Folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Target Folder:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(348, 559);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 595);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxQuality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear_Convert_Image_List);
            this.Controls.Add(this.Clear_Image_List);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxFormat);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Open_Folder);
            this.Controls.Add(this.Select_Target);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button Select_Target;
        private Button Open_Folder;
        private Label label1;
        private ListBox listBox2;
        private Label label2;
        private Button Convert;
        private ComboBox cmbxFormat;
        private Label label3;
        private Button Clear_Image_List;
        private Button Clear_Convert_Image_List;
        private Label label4;
        private ComboBox cmbxQuality;
        private Label label5;
        private Label label6;
        private Label errorLabel;
    }
}