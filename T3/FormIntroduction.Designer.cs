namespace T3
{
    partial class FormIntroduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntroduction));
            this.buttonPartie = new System.Windows.Forms.Button();
            this.pctTable = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctMinimiser = new System.Windows.Forms.PictureBox();
            this.pctReduire = new System.Windows.Forms.PictureBox();
            this.pctQuitter = new System.Windows.Forms.PictureBox();
            this.buttonHistoire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPartie
            // 
            this.buttonPartie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPartie.Location = new System.Drawing.Point(621, 415);
            this.buttonPartie.Name = "buttonPartie";
            this.buttonPartie.Size = new System.Drawing.Size(132, 23);
            this.buttonPartie.TabIndex = 1;
            this.buttonPartie.Text = "Lancer une partie";
            this.buttonPartie.UseVisualStyleBackColor = true;
            this.buttonPartie.Click += new System.EventHandler(this.buttonPartie_Click);
            // 
            // pctTable
            // 
            this.pctTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctTable.BackColor = System.Drawing.Color.Transparent;
            this.pctTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctTable.BackgroundImage")));
            this.pctTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctTable.Location = new System.Drawing.Point(115, 49);
            this.pctTable.Name = "pctTable";
            this.pctTable.Size = new System.Drawing.Size(191, 198);
            this.pctTable.TabIndex = 2;
            this.pctTable.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Ronde";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(191, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(221, 286);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(329, 33);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "La marche vers la gloire";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 73);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pctMinimiser
            // 
            this.pctMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.pctMinimiser.BackgroundImage = global::T3.Properties.Resources.negative_sign;
            this.pctMinimiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMinimiser.Location = new System.Drawing.Point(618, 12);
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
            this.pctReduire.Location = new System.Drawing.Point(670, 12);
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
            this.pctQuitter.Location = new System.Drawing.Point(722, 12);
            this.pctQuitter.Name = "pctQuitter";
            this.pctQuitter.Size = new System.Drawing.Size(30, 28);
            this.pctQuitter.TabIndex = 47;
            this.pctQuitter.TabStop = false;
            this.pctQuitter.Click += new System.EventHandler(this.pctQuitter_Click);
            // 
            // buttonHistoire
            // 
            this.buttonHistoire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHistoire.Location = new System.Drawing.Point(621, 386);
            this.buttonHistoire.Name = "buttonHistoire";
            this.buttonHistoire.Size = new System.Drawing.Size(132, 23);
            this.buttonHistoire.TabIndex = 50;
            this.buttonHistoire.Text = "Histoire";
            this.buttonHistoire.UseVisualStyleBackColor = true;
            this.buttonHistoire.Click += new System.EventHandler(this.ButtonHistoire_Click);
            // 
            // FormIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 452);
            this.Controls.Add(this.buttonHistoire);
            this.Controls.Add(this.pctMinimiser);
            this.Controls.Add(this.pctReduire);
            this.Controls.Add(this.pctQuitter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctTable);
            this.Controls.Add(this.buttonPartie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIntroduction";
            this.Text = "Form_Introduction";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormIntroduction_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPartie;
        private System.Windows.Forms.PictureBox pctTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pctMinimiser;
        private System.Windows.Forms.PictureBox pctReduire;
        private System.Windows.Forms.PictureBox pctQuitter;
        private System.Windows.Forms.Button buttonHistoire;
    }
}