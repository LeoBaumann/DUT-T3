namespace T3
{
    partial class FormRegnes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegnes));
            this.panelListeRegnes = new System.Windows.Forms.Panel();
            this.pctMinimiser = new System.Windows.Forms.PictureBox();
            this.pctReduire = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            this.pctRegnes = new System.Windows.Forms.PictureBox();
            this.lblRegnes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegnes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListeRegnes
            // 
            this.panelListeRegnes.AutoScroll = true;
            this.panelListeRegnes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListeRegnes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelListeRegnes.Location = new System.Drawing.Point(64, 152);
            this.panelListeRegnes.Name = "panelListeRegnes";
            this.panelListeRegnes.Size = new System.Drawing.Size(307, 359);
            this.panelListeRegnes.TabIndex = 0;
            // 
            // pctMinimiser
            // 
            this.pctMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.pctMinimiser.BackgroundImage = global::T3.Properties.Resources.negative_sign;
            this.pctMinimiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMinimiser.Location = new System.Drawing.Point(279, 12);
            this.pctMinimiser.Name = "pctMinimiser";
            this.pctMinimiser.Size = new System.Drawing.Size(30, 28);
            this.pctMinimiser.TabIndex = 49;
            this.pctMinimiser.TabStop = false;
            this.pctMinimiser.Click += new System.EventHandler(this.pctMinimiser_Click);
            // 
            // pctReduire
            // 
            this.pctReduire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctReduire.BackColor = System.Drawing.Color.Transparent;
            this.pctReduire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctReduire.BackgroundImage")));
            this.pctReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctReduire.Location = new System.Drawing.Point(331, 12);
            this.pctReduire.Name = "pctReduire";
            this.pctReduire.Size = new System.Drawing.Size(30, 28);
            this.pctReduire.TabIndex = 48;
            this.pctReduire.TabStop = false;
            this.pctReduire.Click += new System.EventHandler(this.pctReduire_Click);
            // 
            // pctQuitter
            // 
            this.pctQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pctQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctQuitter.BackgroundImage")));
            this.pctQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctQuitter.Location = new System.Drawing.Point(383, 12);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(30, 28);
            this.pctQuitter.TabIndex = 47;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // pctRegnes
            // 
            this.pctRegnes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctRegnes.BackgroundImage = global::T3.Properties.Resources.family;
            this.pctRegnes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRegnes.Location = new System.Drawing.Point(48, 48);
            this.pctRegnes.Name = "pctRegnes";
            this.pctRegnes.Size = new System.Drawing.Size(93, 84);
            this.pctRegnes.TabIndex = 50;
            this.pctRegnes.TabStop = false;
            // 
            // lblRegnes
            // 
            this.lblRegnes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegnes.AutoSize = true;
            this.lblRegnes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegnes.Location = new System.Drawing.Point(187, 84);
            this.lblRegnes.Name = "lblRegnes";
            this.lblRegnes.Size = new System.Drawing.Size(97, 28);
            this.lblRegnes.TabIndex = 51;
            this.lblRegnes.Text = "Règnes";
            // 
            // FormRegnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 523);
            this.Controls.Add(this.lblRegnes);
            this.Controls.Add(this.pctRegnes);
            this.Controls.Add(this.pctMinimiser);
            this.Controls.Add(this.pctReduire);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.panelListeRegnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegnes";
            this.Text = "Form_Regnes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegnes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelListeRegnes;
        private System.Windows.Forms.PictureBox pctMinimiser;
        private System.Windows.Forms.PictureBox pctReduire;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.PictureBox pctRegnes;
        private System.Windows.Forms.Label lblRegnes;
    }
}