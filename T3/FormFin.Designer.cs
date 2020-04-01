namespace T3
{
    partial class FormFin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFin));
            this.labelMessageFin = new System.Windows.Forms.Label();
            this.labelAnneeFin = new System.Windows.Forms.Label();
            this.labelValeurAnneeFin = new System.Windows.Forms.Label();
            this.lblRejouer = new System.Windows.Forms.Label();
            this.lblVieRelle = new System.Windows.Forms.Label();
            this.pctCongratulation = new System.Windows.Forms.PictureBox();
            this.pctGameOver = new System.Windows.Forms.PictureBox();
            this.pctRejouer = new System.Windows.Forms.PictureBox();
            this.pctMinimiser = new System.Windows.Forms.PictureBox();
            this.pctReduire = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCongratulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRejouer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMessageFin
            // 
            this.labelMessageFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMessageFin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageFin.Location = new System.Drawing.Point(303, 110);
            this.labelMessageFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessageFin.Name = "labelMessageFin";
            this.labelMessageFin.Size = new System.Drawing.Size(389, 177);
            this.labelMessageFin.TabIndex = 0;
            this.labelMessageFin.Text = "label1";
            // 
            // labelAnneeFin
            // 
            this.labelAnneeFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnneeFin.AutoSize = true;
            this.labelAnneeFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnneeFin.Location = new System.Drawing.Point(305, 308);
            this.labelAnneeFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnneeFin.Name = "labelAnneeFin";
            this.labelAnneeFin.Size = new System.Drawing.Size(276, 23);
            this.labelAnneeFin.TabIndex = 1;
            this.labelAnneeFin.Text = "Vous êtes arrivé à l\'année :";
            // 
            // labelValeurAnneeFin
            // 
            this.labelValeurAnneeFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelValeurAnneeFin.AutoSize = true;
            this.labelValeurAnneeFin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValeurAnneeFin.Location = new System.Drawing.Point(601, 306);
            this.labelValeurAnneeFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValeurAnneeFin.Name = "labelValeurAnneeFin";
            this.labelValeurAnneeFin.Size = new System.Drawing.Size(84, 28);
            this.labelValeurAnneeFin.TabIndex = 2;
            this.labelValeurAnneeFin.Text = "label3";
            // 
            // lblRejouer
            // 
            this.lblRejouer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRejouer.AutoSize = true;
            this.lblRejouer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejouer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRejouer.Location = new System.Drawing.Point(828, 480);
            this.lblRejouer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRejouer.Name = "lblRejouer";
            this.lblRejouer.Size = new System.Drawing.Size(99, 28);
            this.lblRejouer.TabIndex = 51;
            this.lblRejouer.Text = "Rejouer";
            this.lblRejouer.Click += new System.EventHandler(this.lblRejouer_Click);
            // 
            // lblVieRelle
            // 
            this.lblVieRelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVieRelle.AutoSize = true;
            this.lblVieRelle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVieRelle.Location = new System.Drawing.Point(399, 480);
            this.lblVieRelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVieRelle.Name = "lblVieRelle";
            this.lblVieRelle.Size = new System.Drawing.Size(260, 30);
            this.lblVieRelle.TabIndex = 53;
            this.lblVieRelle.Text = "Retour à la vie réelle";
            this.lblVieRelle.Click += new System.EventHandler(this.lblVieRelle_Click);
            // 
            // pctCongratulation
            // 
            this.pctCongratulation.BackgroundImage = global::T3.Properties.Resources.clap;
            this.pctCongratulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctCongratulation.Location = new System.Drawing.Point(24, 362);
            this.pctCongratulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctCongratulation.Name = "pctCongratulation";
            this.pctCongratulation.Size = new System.Drawing.Size(201, 176);
            this.pctCongratulation.TabIndex = 54;
            this.pctCongratulation.TabStop = false;
            this.pctCongratulation.Visible = false;
            // 
            // pctGameOver
            // 
            this.pctGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pctGameOver.BackgroundImage = global::T3.Properties.Resources.game_over;
            this.pctGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctGameOver.Location = new System.Drawing.Point(24, 362);
            this.pctGameOver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctGameOver.Name = "pctGameOver";
            this.pctGameOver.Size = new System.Drawing.Size(201, 176);
            this.pctGameOver.TabIndex = 52;
            this.pctGameOver.TabStop = false;
            // 
            // pctRejouer
            // 
            this.pctRejouer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctRejouer.BackgroundImage = global::T3.Properties.Resources.Reset;
            this.pctRejouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRejouer.Location = new System.Drawing.Point(941, 448);
            this.pctRejouer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctRejouer.Name = "pctRejouer";
            this.pctRejouer.Size = new System.Drawing.Size(100, 91);
            this.pctRejouer.TabIndex = 50;
            this.pctRejouer.TabStop = false;
            this.pctRejouer.Click += new System.EventHandler(this.pctRejouer_Click);
            // 
            // pctMinimiser
            // 
            this.pctMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.pctMinimiser.BackgroundImage = global::T3.Properties.Resources.negative_sign;
            this.pctMinimiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMinimiser.Location = new System.Drawing.Point(872, 15);
            this.pctMinimiser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctMinimiser.Name = "pctMinimiser";
            this.pctMinimiser.Size = new System.Drawing.Size(40, 34);
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
            this.pctReduire.Location = new System.Drawing.Point(941, 15);
            this.pctReduire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctReduire.Name = "pctReduire";
            this.pctReduire.Size = new System.Drawing.Size(40, 34);
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
            this.pctQuitter.Location = new System.Drawing.Point(1011, 15);
            this.pctQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(40, 34);
            this.pctQuitter.TabIndex = 47;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // FormFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pctCongratulation);
            this.Controls.Add(this.lblVieRelle);
            this.Controls.Add(this.pctGameOver);
            this.Controls.Add(this.lblRejouer);
            this.Controls.Add(this.pctRejouer);
            this.Controls.Add(this.pctMinimiser);
            this.Controls.Add(this.pctReduire);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.labelValeurAnneeFin);
            this.Controls.Add(this.labelAnneeFin);
            this.Controls.Add(this.labelMessageFin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFin";
            this.Text = "Form_fin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormFin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctCongratulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRejouer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessageFin;
        private System.Windows.Forms.Label labelAnneeFin;
        private System.Windows.Forms.Label labelValeurAnneeFin;
        private System.Windows.Forms.PictureBox pctMinimiser;
        private System.Windows.Forms.PictureBox pctReduire;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.PictureBox pctRejouer;
        private System.Windows.Forms.Label lblRejouer;
        private System.Windows.Forms.PictureBox pctGameOver;
        private System.Windows.Forms.Label lblVieRelle;
        private System.Windows.Forms.PictureBox pctCongratulation;
    }
}