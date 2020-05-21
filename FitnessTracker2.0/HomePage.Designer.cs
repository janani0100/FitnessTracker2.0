namespace FitnessTracker2._0
{
    partial class HomePage
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
            this.Quotes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.Panel();
            this.AboutYouPic = new System.Windows.Forms.PictureBox();
            this.AboutYouLabel = new System.Windows.Forms.Label();
            this.Quotes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.pic1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutYouPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Quotes
            // 
            this.Quotes.Controls.Add(this.label1);
            this.Quotes.Location = new System.Drawing.Point(12, 62);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(251, 413);
            this.Quotes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quotes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Location = new System.Drawing.Point(282, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 256);
            this.panel1.TabIndex = 1;
            // 
            // pb
            // 
            this.pb.Image = global::FitnessTracker2._0.Properties.Resources.welcome;
            this.pb.Location = new System.Drawing.Point(41, 50);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(243, 203);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // pic
            // 
            this.pic.AutoSize = true;
            this.pic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic.Location = new System.Drawing.Point(3, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(107, 19);
            this.pic.TabIndex = 0;
            this.pic.Text = "Today\'s Status";
            // 
            // pic1
            // 
            this.pic1.Controls.Add(this.AboutYouPic);
            this.pic1.Controls.Add(this.AboutYouLabel);
            this.pic1.Location = new System.Drawing.Point(282, 274);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(393, 227);
            this.pic1.TabIndex = 2;
            this.pic1.Paint += new System.Windows.Forms.PaintEventHandler(this.pic1_Paint);
            // 
            // AboutYouPic
            // 
            this.AboutYouPic.Location = new System.Drawing.Point(90, 41);
            this.AboutYouPic.Name = "AboutYouPic";
            this.AboutYouPic.Size = new System.Drawing.Size(303, 186);
            this.AboutYouPic.TabIndex = 1;
            this.AboutYouPic.TabStop = false;
            // 
            // AboutYouLabel
            // 
            this.AboutYouLabel.AutoSize = true;
            this.AboutYouLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutYouLabel.Location = new System.Drawing.Point(16, 19);
            this.AboutYouLabel.Name = "AboutYouLabel";
            this.AboutYouLabel.Size = new System.Drawing.Size(0, 19);
            this.AboutYouLabel.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(891, 605);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Quotes);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Quotes.ResumeLayout(false);
            this.Quotes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.pic1.ResumeLayout(false);
            this.pic1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutYouPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Quotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label pic;
        private System.Windows.Forms.Panel pic1;
        private System.Windows.Forms.PictureBox AboutYouPic;
        private System.Windows.Forms.Label AboutYouLabel;
    }
}