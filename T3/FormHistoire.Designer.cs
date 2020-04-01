namespace T3
{
    partial class FormHistoire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoire));
            this.pctHistoire = new System.Windows.Forms.PictureBox();
            this.pctMinimiser = new System.Windows.Forms.PictureBox();
            this.pctReduire = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctHistoire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctHistoire
            // 
            this.pctHistoire.Image = ((System.Drawing.Image)(resources.GetObject("pctHistoire.Image")));
            this.pctHistoire.Location = new System.Drawing.Point(-2, 49);
            this.pctHistoire.Name = "pctHistoire";
            this.pctHistoire.Size = new System.Drawing.Size(1431, 799);
            this.pctHistoire.TabIndex = 0;
            this.pctHistoire.TabStop = false;
            // 
            // pctMinimiser
            // 
            this.pctMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.pctMinimiser.BackgroundImage = global::T3.Properties.Resources.negative_sign;
            this.pctMinimiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMinimiser.Location = new System.Drawing.Point(1285, 12);
            this.pctMinimiser.Name = "pctMinimiser";
            this.pctMinimiser.Size = new System.Drawing.Size(30, 28);
            this.pctMinimiser.TabIndex = 52;
            this.pctMinimiser.TabStop = false;
            this.pctMinimiser.Click += new System.EventHandler(this.pctMinimiser_Click);
            // 
            // pctReduire
            // 
            this.pctReduire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctReduire.BackColor = System.Drawing.Color.Transparent;
            this.pctReduire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctReduire.BackgroundImage")));
            this.pctReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctReduire.Location = new System.Drawing.Point(1337, 12);
            this.pctReduire.Name = "pctReduire";
            this.pctReduire.Size = new System.Drawing.Size(30, 28);
            this.pctReduire.TabIndex = 51;
            this.pctReduire.TabStop = false;
            this.pctReduire.Click += new System.EventHandler(this.pctReduire_Click);
            // 
            // pctQuitter
            // 
            this.pctQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pctQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctQuitter.BackgroundImage")));
            this.pctQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctQuitter.Location = new System.Drawing.Point(1389, 12);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(30, 28);
            this.pctQuitter.TabIndex = 50;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.pictureBox1.Location = new System.Drawing.Point(185, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 11);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // FormHistoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 849);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctMinimiser);
            this.Controls.Add(this.pctReduire);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.pctHistoire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistoire";
            this.Text = "FormHistoire";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHistoire_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctHistoire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctHistoire;
        private System.Windows.Forms.PictureBox pctMinimiser;
        private System.Windows.Forms.PictureBox pctReduire;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}