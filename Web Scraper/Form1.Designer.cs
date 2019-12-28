namespace Web_Scraper
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
            this.rtb_debugDisplay = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_Website = new System.Windows.Forms.TextBox();
            this.txb_SearchTerms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_debugDisplay
            // 
            this.rtb_debugDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_debugDisplay.Location = new System.Drawing.Point(12, 81);
            this.rtb_debugDisplay.Name = "rtb_debugDisplay";
            this.rtb_debugDisplay.Size = new System.Drawing.Size(776, 329);
            this.rtb_debugDisplay.TabIndex = 0;
            this.rtb_debugDisplay.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(352, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // txb_Website
            // 
            this.txb_Website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Website.Location = new System.Drawing.Point(95, 12);
            this.txb_Website.Name = "txb_Website";
            this.txb_Website.Size = new System.Drawing.Size(693, 20);
            this.txb_Website.TabIndex = 2;
            this.txb_Website.Text = "https://www.oceannetworks.ca/news/stories";
            // 
            // txb_SearchTerms
            // 
            this.txb_SearchTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SearchTerms.Location = new System.Drawing.Point(95, 39);
            this.txb_SearchTerms.Name = "txb_SearchTerms";
            this.txb_SearchTerms.Size = new System.Drawing.Size(693, 20);
            this.txb_SearchTerms.TabIndex = 3;
            this.txb_SearchTerms.Text = "Ocean,Nature,Pollution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Website:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Terms:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_SearchTerms);
            this.Controls.Add(this.txb_Website);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_debugDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_debugDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_Website;
        private System.Windows.Forms.TextBox txb_SearchTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

