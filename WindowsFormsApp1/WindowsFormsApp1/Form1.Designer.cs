namespace WindowsFormsApp1
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
            this.textBoxHome = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gambarHome = new System.Windows.Forms.PictureBox();
            this.gambarSearch = new System.Windows.Forms.PictureBox();
            this.gambarInfo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHome
            // 
            this.textBoxHome.Location = new System.Drawing.Point(93, 36);
            this.textBoxHome.Multiline = true;
            this.textBoxHome.Name = "textBoxHome";
            this.textBoxHome.Size = new System.Drawing.Size(368, 122);
            this.textBoxHome.TabIndex = 0;
            this.textBoxHome.TextChanged += new System.EventHandler(this.textBoxHome_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConvert.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvert.Location = new System.Drawing.Point(352, 164);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 36);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gambarHome
            // 
            this.gambarHome.Image = ((System.Drawing.Image)(resources.GetObject("gambarHome.Image")));
            this.gambarHome.Location = new System.Drawing.Point(28, 61);
            this.gambarHome.Name = "gambarHome";
            this.gambarHome.Size = new System.Drawing.Size(43, 40);
            this.gambarHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarHome.TabIndex = 2;
            this.gambarHome.TabStop = false;
            this.gambarHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gambarSearch
            // 
            this.gambarSearch.Image = ((System.Drawing.Image)(resources.GetObject("gambarSearch.Image")));
            this.gambarSearch.Location = new System.Drawing.Point(28, 140);
            this.gambarSearch.Name = "gambarSearch";
            this.gambarSearch.Size = new System.Drawing.Size(43, 40);
            this.gambarSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarSearch.TabIndex = 3;
            this.gambarSearch.TabStop = false;
            // 
            // gambarInfo
            // 
            this.gambarInfo.Image = ((System.Drawing.Image)(resources.GetObject("gambarInfo.Image")));
            this.gambarInfo.Location = new System.Drawing.Point(28, 221);
            this.gambarInfo.Name = "gambarInfo";
            this.gambarInfo.Size = new System.Drawing.Size(43, 38);
            this.gambarInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarInfo.TabIndex = 4;
            this.gambarInfo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 117);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gambarInfo);
            this.Controls.Add(this.gambarSearch);
            this.Controls.Add(this.gambarHome);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBoxHome);
            this.Name = "Form1";
            this.Text = "Signly";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gambarInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHome;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gambarHome;
        private System.Windows.Forms.PictureBox gambarSearch;
        private System.Windows.Forms.PictureBox gambarInfo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

