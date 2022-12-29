namespace RandomGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGeneratorNum = new System.Windows.Forms.ComboBox();
            this.cbCaps = new System.Windows.Forms.ComboBox();
            this.chkIncludeSign = new System.Windows.Forms.CheckBox();
            this.tbGroupNum = new System.Windows.Forms.TextBox();
            this.btnCreateShow = new System.Windows.Forms.Button();
            this.btnCreateExcel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnSelectExcelPath = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "產生位數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "英文大小寫:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(384, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "含特殊符號:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F);
            this.label4.Location = new System.Drawing.Point(384, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "產生組數:";
            // 
            // cbGeneratorNum
            // 
            this.cbGeneratorNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneratorNum.Font = new System.Drawing.Font("新細明體", 14F);
            this.cbGeneratorNum.FormattingEnabled = true;
            this.cbGeneratorNum.Location = new System.Drawing.Point(187, 21);
            this.cbGeneratorNum.Name = "cbGeneratorNum";
            this.cbGeneratorNum.Size = new System.Drawing.Size(145, 31);
            this.cbGeneratorNum.TabIndex = 4;
            // 
            // cbCaps
            // 
            this.cbCaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaps.Font = new System.Drawing.Font("新細明體", 14F);
            this.cbCaps.FormattingEnabled = true;
            this.cbCaps.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbCaps.Location = new System.Drawing.Point(187, 82);
            this.cbCaps.Name = "cbCaps";
            this.cbCaps.Size = new System.Drawing.Size(149, 31);
            this.cbCaps.TabIndex = 5;
            // 
            // chkIncludeSign
            // 
            this.chkIncludeSign.AutoSize = true;
            this.chkIncludeSign.Font = new System.Drawing.Font("新細明體", 16F);
            this.chkIncludeSign.Location = new System.Drawing.Point(593, 36);
            this.chkIncludeSign.Name = "chkIncludeSign";
            this.chkIncludeSign.Size = new System.Drawing.Size(18, 17);
            this.chkIncludeSign.TabIndex = 6;
            this.chkIncludeSign.UseVisualStyleBackColor = true;
            // 
            // tbGroupNum
            // 
            this.tbGroupNum.Font = new System.Drawing.Font("新細明體", 14F);
            this.tbGroupNum.Location = new System.Drawing.Point(544, 78);
            this.tbGroupNum.Name = "tbGroupNum";
            this.tbGroupNum.Size = new System.Drawing.Size(153, 35);
            this.tbGroupNum.TabIndex = 7;
            // 
            // btnCreateShow
            // 
            this.btnCreateShow.Location = new System.Drawing.Point(79, 319);
            this.btnCreateShow.Name = "btnCreateShow";
            this.btnCreateShow.Size = new System.Drawing.Size(195, 41);
            this.btnCreateShow.TabIndex = 8;
            this.btnCreateShow.Text = "產生並顯示";
            this.btnCreateShow.UseVisualStyleBackColor = true;
            this.btnCreateShow.Click += new System.EventHandler(this.btnCreateShow_Click);
            // 
            // btnCreateExcel
            // 
            this.btnCreateExcel.Location = new System.Drawing.Point(472, 319);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(195, 41);
            this.btnCreateExcel.TabIndex = 9;
            this.btnCreateExcel.Text = "產生Excel檔";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.btnCreateExcel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(75, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Excel檔案位置:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Enabled = false;
            this.txtExcelPath.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtExcelPath.Location = new System.Drawing.Point(228, 168);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(355, 31);
            this.txtExcelPath.TabIndex = 12;
            // 
            // btnSelectExcelPath
            // 
            this.btnSelectExcelPath.Location = new System.Drawing.Point(593, 169);
            this.btnSelectExcelPath.Name = "btnSelectExcelPath";
            this.btnSelectExcelPath.Size = new System.Drawing.Size(83, 31);
            this.btnSelectExcelPath.TabIndex = 13;
            this.btnSelectExcelPath.Text = "選擇";
            this.btnSelectExcelPath.UseVisualStyleBackColor = true;
            this.btnSelectExcelPath.Click += new System.EventHandler(this.btnSelectExcelPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 377);
            this.Controls.Add(this.btnSelectExcelPath);
            this.Controls.Add(this.txtExcelPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateExcel);
            this.Controls.Add(this.btnCreateShow);
            this.Controls.Add(this.tbGroupNum);
            this.Controls.Add(this.chkIncludeSign);
            this.Controls.Add(this.cbCaps);
            this.Controls.Add(this.cbGeneratorNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RandomGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGeneratorNum;
        private System.Windows.Forms.ComboBox cbCaps;
        private System.Windows.Forms.CheckBox chkIncludeSign;
        private System.Windows.Forms.TextBox tbGroupNum;
        private System.Windows.Forms.Button btnCreateShow;
        private System.Windows.Forms.Button btnCreateExcel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnSelectExcelPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

