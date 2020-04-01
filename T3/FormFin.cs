using System;
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
    public partial class FormFin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Constructeur du form fin
        /// </summary>
        /// <param name="annee">L'année à laquelle le jeu s'est fini</param>
        /// <param name="valeurFin">La raison de la fin du jeu</param>
        public FormFin(int annee,int valeurFin)
        {
            InitializeComponent();
            chargementEcranFin(annee, valeurFin);
        }

        /// <summary>
        /// Methode qui permet d'initialiser les valeurs pour l'affichage de l'ecran de fin
        /// </summary>
        /// <param name="annee">L'année a laquelle le jeu s'est fini</param>
        /// <param name="valeurFin">La raison de la fin du jeu</param>
        public void chargementEcranFin(int annee, int valeurFin)
        {
            string labelMessageFinText = "";
            switch (valeurFin)
            {
                case 0:
                    labelMessageFinText = "L'eglise n'est pas assez soutenu, elle laisse le royaume sans croyance";
                    break;
                case 2:
                    labelMessageFinText = "L'armée n'est pas assez soutenu, elle laisse le royaume sans défense";
                    break;
                case 4:
                    labelMessageFinText = "Le peuple n'est pas assez soutenu, il se rebelle";
                    break;
                case 6:
                    labelMessageFinText = "Trop de conflit à l'intérieur de la dynastie, elle est affaiblie et laisse le pouvoir à une autre dynastie";
                    break;
                case 7:
                    labelMessageFinText = "Vous n'avez plus d'heritier, votre dynastie n'a plus le pouvoir du royaume";
                    break;
                case 8:
                    labelMessageFinText = "Vous avez gagné ! Félicitations ! Votre dynastie est restée au pouvoir pendant plus d'un siècle !";
                    pctGameOver.Visible = false;
                    pctCongratulation.Visible = true;
                    break;
                case 9:
                    labelMessageFinText = "Vous avez gagné ! Félicitations ! Votre dynastie est restée au pouvoir pendant plus de deux siècles !";
                    pctGameOver.Visible = false;
                    pctCongratulation.Visible = true;
                    break;
                case 10:
                    labelMessageFinText = "Vous avez gagné ! Félicitations ! Votre dynastie est restée au pouvoir pendant plus de trois siècles !";
                    pctGameOver.Visible = false;
                    pctCongratulation.Visible = true;
                    break;
            }

            labelValeurAnneeFin.Text = annee.ToString();
            labelMessageFin.Text = labelMessageFinText;
        }

        /// <summary>
        /// Evenement qui quitte l'application lors du click sur pctQuitter
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void pctQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        /// Evenement qui permet de rejouer et donc d'afficher un nouveau form debut
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void pctRejouer_Click(object sender, EventArgs e)
        {
            FormDebut form = new FormDebut();
            form.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Evenement qui permet de rejouer et donc d'afficher un nouveau form debut
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void lblRejouer_Click(object sender, EventArgs e)
        {
            FormDebut form = new FormDebut();
            form.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Evenement qui deplace le form lors du lacher de click
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void FormFin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Evenement qui quitte l'application lors du click sur pctQuitter
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void lblVieRelle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
