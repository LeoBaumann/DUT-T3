namespace T3
{
    partial class FormInfoLois
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoLois));
            this.pctMinimiser = new System.Windows.Forms.PictureBox();
            this.pctReduire = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            this.pctLois1 = new System.Windows.Forms.PictureBox();
            this.pctLois2 = new System.Windows.Forms.PictureBox();
            this.pctPrecendent = new System.Windows.Forms.PictureBox();
            this.pctSuivant = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLois1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLois2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrecendent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSuivant)).BeginInit();
            this.SuspendLayout();
            // 
            // pctMinimiser
            // 
            this.pctMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.pctMinimiser.BackgroundImage = global::T3.Properties.Resources.negative_sign;
            this.pctMinimiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMinimiser.Location = new System.Drawing.Point(550, 5);
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
            this.pctReduire.Location = new System.Drawing.Point(602, 5);
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
            this.pctQuitter.Location = new System.Drawing.Point(654, 5);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(30, 28);
            this.pctQuitter.TabIndex = 44;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // pctLois1
            // 
            this.pctLois1.BackgroundImage = global::T3.Properties.Resources.lois;
            this.pctLois1.Location = new System.Drawing.Point(0, 39);
            this.pctLois1.Name = "pctLois1";
            this.pctLois1.Size = new System.Drawing.Size(695, 802);
            this.pctLois1.TabIndex = 0;
            this.pctLois1.TabStop = false;
            // 
            // pctLois2
            // 
            this.pctLois2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLois2.BackgroundImage")));
            this.pctLois2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLois2.Location = new System.Drawing.Point(0, 39);
            this.pctLois2.Name = "pctLois2";
            this.pctLois2.Size = new System.Drawing.Size(695, 802);
            this.pctLois2.TabIndex = 47;
            this.pctLois2.TabStop = false;
            // 
            // pctPrecendent
            // 
            this.pctPrecendent.BackColor = System.Drawing.Color.Transparent;
            this.pctPrecendent.BackgroundImage = global::T3.Properties.Resources.left_arrow;
            this.pctPrecendent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPrecendent.Location = new System.Drawing.Point(235, 825);
            this.pctPrecendent.Name = "pctPrecendent";
            this.pctPrecendent.Size = new System.Drawing.Size(50, 45);
            this.pctPrecendent.TabIndex = 54;
            this.pctPrecendent.TabStop = false;
            this.pctPrecendent.Click += new System.EventHandler(this.pctPrecendent_Click);
            // 
            // pctSuivant
            // 
            this.pctSuivant.BackColor = System.Drawing.Color.Transparent;
            this.pctSuivant.BackgroundImage = global::T3.Properties.Resources.right_arrow;
            this.pctSuivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSuivant.Location = new System.Drawing.Point(342, 825);
            this.pctSuivant.Name = "pctSuivant";
            this.pctSuivant.Size = new System.Drawing.Size(51, 45);
            this.pctSuivant.TabIndex = 53;
            this.pctSuivant.TabStop = false;
            this.pctSuivant.Click += new System.EventHandler(this.pctSuivant_Click);
            // 
            // FormInfoLois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 873);
            this.Controls.Add(this.pctPrecendent);
            this.Controls.Add(this.pctSuivant);
            this.Controls.Add(this.pctLois2);
            this.Controls.Add(this.pctMinimiser);
            this.Controls.Add(this.pctReduire);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.pctLois1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfoLois";
            this.Text = "Form_InfoLois";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInfoLois_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLois1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLois2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrecendent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSuivant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLois1;
        private System.Windows.Forms.PictureBox pctMinimiser;
        private System.Windows.Forms.PictureBox pctReduire;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.PictureBox pctLois2;
        private System.Windows.Forms.PictureBox pctPrecendent;
        private System.Windows.Forms.PictureBox pctSuivant;
    }
}