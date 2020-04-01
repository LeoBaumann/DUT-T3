namespace T3
{
    partial class FormRegles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegles));
            this.pctPrecendent = new System.Windows.Forms.PictureBox();
            this.pctSuivant = new System.Windows.Forms.PictureBox();
            this.pctRegles1 = new System.Windows.Forms.PictureBox();
            this.pctMinimiser = new System.Windows.Forms.PictureBox();
            this.pctReduire = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            this.pctRegles2 = new System.Windows.Forms.PictureBox();
            this.pctRegles = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrecendent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSuivant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegles2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegles)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPrecendent
            // 
            this.pctPrecendent.BackColor = System.Drawing.Color.Transparent;
            this.pctPrecendent.BackgroundImage = global::T3.Properties.Resources.left_arrow;
            this.pctPrecendent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPrecendent.Location = new System.Drawing.Point(697, 816);
            this.pctPrecendent.Name = "pctPrecendent";
            this.pctPrecendent.Size = new System.Drawing.Size(50, 45);
            this.pctPrecendent.TabIndex = 52;
            this.pctPrecendent.TabStop = false;
            this.pctPrecendent.Click += new System.EventHandler(this.pctPrecendent_Click);
            // 
            // pctSuivant
            // 
            this.pctSuivant.BackColor = System.Drawing.Color.Transparent;
            this.pctSuivant.BackgroundImage = global::T3.Properties.Resources.right_arrow;
            this.pctSuivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSuivant.Location = new System.Drawing.Point(804, 816);
            this.pctSuivant.Name = "pctSuivant";
            this.pctSuivant.Size = new System.Drawing.Size(51, 45);
            this.pctSuivant.TabIndex = 51;
            this.pctSuivant.TabStop = false;
            this.pctSuivant.Click += new System.EventHandler(this.pctSuivant_Click);
            // 
            // pctRegles1
            // 
            this.pctRegles1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctRegles1.BackgroundImage")));
            this.pctRegles1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRegles1.Location = new System.Drawing.Point(12, 33);
            this.pctRegles1.Name = "pctRegles1";
            this.pctRegles1.Size = new System.Drawing.Size(1465, 803);
            this.pctRegles1.TabIndex = 50;
            this.pctRegles1.TabStop = false;
            // 
            // pctMinimiser
            // 
            this.pctMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.pctMinimiser.BackgroundImage = global::T3.Properties.Resources.negative_sign;
            this.pctMinimiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMinimiser.Location = new System.Drawing.Point(1340, 4);
            this.pctMinimiser.Name = "pctMinimiser";
            this.pctMinimiser.Size = new System.Drawing.Size(30, 28);
            this.pctMinimiser.TabIndex = 46;
            this.pctMinimiser.TabStop = false;
            this.pctMinimiser.Click += new System.EventHandler(this.pctMinimiser_Click);
            // 
            // pctReduire
            // 
            this.pctReduire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctReduire.BackColor = System.Drawing.Color.Transparent;
            this.pctReduire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctReduire.BackgroundImage")));
            this.pctReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctReduire.Location = new System.Drawing.Point(1390, 4);
            this.pctReduire.Name = "pctReduire";
            this.pctReduire.Size = new System.Drawing.Size(30, 28);
            this.pctReduire.TabIndex = 45;
            this.pctReduire.TabStop = false;
            this.pctReduire.Click += new System.EventHandler(this.pctReduire_Click);
            // 
            // pctQuitter
            // 
            this.pctQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pctQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctQuitter.BackgroundImage")));
            this.pctQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctQuitter.Location = new System.Drawing.Point(1442, 4);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(30, 28);
            this.pctQuitter.TabIndex = 44;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // pctRegles2
            // 
            this.pctRegles2.Image = ((System.Drawing.Image)(resources.GetObject("pctRegles2.Image")));
            this.pctRegles2.Location = new System.Drawing.Point(6, 38);
            this.pctRegles2.Name = "pctRegles2";
            this.pctRegles2.Size = new System.Drawing.Size(1465, 803);
            this.pctRegles2.TabIndex = 49;
            this.pctRegles2.TabStop = false;
            // 
            // pctRegles
            // 
            this.pctRegles.Location = new System.Drawing.Point(0, 0);
            this.pctRegles.Name = "pctRegles";
            this.pctRegles.Size = new System.Drawing.Size(100, 50);
            this.pctRegles.TabIndex = 0;
            this.pctRegles.TabStop = false;
            // 
            // FormRegles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1477, 871);
            this.Controls.Add(this.pctPrecendent);
            this.Controls.Add(this.pctSuivant);
            this.Controls.Add(this.pctRegles1);
            this.Controls.Add(this.pctMinimiser);
            this.Controls.Add(this.pctReduire);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.pctRegles2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegles";
            this.Text = "FormRegles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegles_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctPrecendent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSuivant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegles2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctRegles;
        private System.Windows.Forms.PictureBox pctMinimiser;
        private System.Windows.Forms.PictureBox pctReduire;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.PictureBox pctRegles2;
        private System.Windows.Forms.PictureBox pctRegles1;
        private System.Windows.Forms.PictureBox pctSuivant;
        private System.Windows.Forms.PictureBox pctPrecendent;
    }
}