using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace T3
{
    public partial class UcPretendant : UserControl
    {
        public UcPretendant()
        {
            InitializeComponent();
        }

        private string lienImagePretendant;
        private string lienImageBlasonEglise;
        private string lienImageBlasonArmee;
        private string lienImageBlasonPeuple;

        /// <summary>
        /// Fonction permettant l'affichage d'une image dans le pictureBox de la tete du pretendant en fonction de la variable lienImagePretendant
        /// </summary>
        public string LienImagePretendant
        {
            get { return lienImagePretendant; }
            set
            {
                lienImagePretendant = value;
                if (lienImagePretendant == "baby_head.png")
                {
                    this.pctPretendant.Image = Properties.Resources.baby_head;
                }
                else if (lienImagePretendant == "knight_kid_head.png")
                {
                    this.pctPretendant.Image = Properties.Resources.knight_kid_head;
                }
                else
                {
                    this.pctPretendant.Image = Properties.Resources.princess_kid_head;
                }
                pctPretendant.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Fonction permettant le remplacement du texte du lblNomPretendant
        /// </summary>
        public string NomPretendant
        {
            get { return this.lblNomPretendant.Text; }
            set { this.lblNomPretendant.Text = value; lblNomPretendant.MaximumSize = new Size(100, 0); }
        }

        /// <summary>
        /// Fonction permettant le remplacement du texte du lblAgePretendant
        /// </summary>
        public string AgePretendant
        {
            get { return this.lblAgePretendant.Text; }
            set { this.lblAgePretendant.Text = value; lblAgePretendant.MaximumSize = new Size(100, 0); }
        }

        /// <summary>
        /// Fonction permettant le remplacement du texte du lblCroyancePretendant
        /// </summary>
        public string CroyancePretendant
        {
            get { return this.lblCroyancePretendant.Text; }
            set { this.lblCroyancePretendant.Text = value; lblCroyancePretendant.MaximumSize = new Size(100, 0); }
        }

        /// <summary>
        /// Fonction permettant le remplacement du texte du lblNationalitePretendant
        /// </summary>
        public string NationalitePretendant
        {
            get { return this.lblNationalitePretendant.Text; }
            set { this.lblNationalitePretendant.Text = value; lblNationalitePretendant.MaximumSize = new Size(100, 0); }
        }

        /// <summary>
        /// Fonction permettant l'affichage d'une image dans le pictureBox de l'eglise en fonction de la variable lienImageBlasonEglise
        /// </summary>
        public string LienImageBlasonEglise
        {
            get { return lienImageBlasonEglise; }
            set
            {
                lienImageBlasonEglise = value;
                if (lienImageBlasonEglise == "blason_vert.png")
                {
                    this.pctBlasonEglise.Image = Properties.Resources.blason_vert;
                }
                else if (lienImageBlasonEglise == "blason_rouge.png")
                {
                    this.pctBlasonEglise.Image = Properties.Resources.blason_rouge;
                }
                else
                {
                    this.pctBlasonEglise.Image = Properties.Resources.blason_orange;
                }
                pctBlasonEglise.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Fonction permettant l'affichage d'une image dans le pictureBox de l'armee en fonction de la variable lienImageBlasonArmee
        /// </summary>
        public string LienImageBlasonArmee
        {
            get { return lienImageBlasonArmee; }
            set
            {
                lienImageBlasonArmee = value;
                if (lienImageBlasonArmee == "blason_vert.png")
                {
                    this.pctBlasonArmee.Image = Properties.Resources.blason_vert;
                }
                else if (lienImageBlasonArmee == "blason_rouge.png")
                {
                    this.pctBlasonArmee.Image = Properties.Resources.blason_rouge;
                }
                else
                {
                    this.pctBlasonArmee.Image = Properties.Resources.blason_orange;
                }
                pctBlasonArmee.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Fonction permettant l'affichage d'une image dans le pictureBox du peuple en fonction de la variable lienImageBlasonPeuple
        /// </summary>
        public string LienImageBlasonPeuple
        {
            get { return lienImageBlasonPeuple; }
            set
            {
                lienImageBlasonPeuple = value;
                if (lienImageBlasonPeuple == "blason_vert.png")
                {
                    this.pctBlasonPeuple.Image = Properties.Resources.blason_vert;
                }
                else if (lienImageBlasonPeuple == "blason_rouge.png")
                {
                    this.pctBlasonPeuple.Image = Properties.Resources.blason_rouge;
                }
                else
                {
                    this.pctBlasonPeuple.Image = Properties.Resources.blason_orange;
                }
                pctBlasonPeuple.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Procedure permettant l'ajout d'un s au label age si celui ci est supérieur 1
        /// </summary>
        public void Pluriels()
        {
            if (int.Parse(this.lblAgePretendant.Text) > 1)
            {
                this.lblAns.Text += "s";
            }
        }
    }
}
