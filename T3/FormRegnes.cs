﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace T3
{
    public partial class FormRegnes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Constructeur de FormRegnes
        /// </summary>
        public FormRegnes()
        {
            InitializeComponent();
            affichageDesRois();
        }

        /// <summary>
        /// Méthode qui permet d'afficher la liste des rois lors du jeu
        /// </summary>
        public void affichageDesRois()
        {
            int width = 20;
            int heigh = 10;

            panelListeRegnes.Controls.Clear();

            foreach (Roi roi in CtrlHumain.getInstance().getListeRoi())
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(width, heigh);
                label.Size = new System.Drawing.Size(35, 13);
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                if (roi.getGenre()==0)
                {
                    if (roi.getAnneePassationTrone() != 0)
                    {
                        label.Text = "Roi "+roi.getPrenom() + " : ( " + roi.getAnneeObtentionTrone() + " - " + roi.getAnneePassationTrone() + " ) , Mort à "+roi.getAge()+" ans";
                    }
                    else
                    {
                        label.Text = "Roi "+ roi.getPrenom() + " : ( " + roi.getAnneeObtentionTrone() + " - ";
                    }
                }
                else
                {
                    if (roi.getAnneePassationTrone() != 0)
                    {
                        label.Text = "Reine "+roi.getPrenom() + " : ( " + roi.getAnneeObtentionTrone() + " - " + roi.getAnneePassationTrone() + " ) , Morte à " + roi.getAge()+ "ans";
                    }
                    else
                    {
                        label.Text = "Reine " + roi.getPrenom() + " : ( " + roi.getAnneeObtentionTrone() + " - ";
                    }
                }
                heigh = heigh + 20;
                panelListeRegnes.Controls.Add(label);
            }
        }

        /// <summary>
        /// Evenement qui quitte le form lors du click sur pctQuitter
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void pctQuitter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        /// <summary>
        /// Evenement qui reduit ou agrandit le form lors du click sur pctReduire
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void pctReduire_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Evenement qui minimise le form lors du click sur pctMinimiser
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void pctMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Evenement qui deplace le form lors du lacher de click
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void FormRegnes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
