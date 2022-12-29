namespace RandomGenerator
{
    partial class displayForm
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("新細明體", 14F);
            this.tbDisplay.Location = new System.Drawing.Point(67, 26);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(472, 297);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDisplay_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "複製文字";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDisplay);
            this.Name = "displayForm";
            this.Text = "displayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button button1;
    }
}