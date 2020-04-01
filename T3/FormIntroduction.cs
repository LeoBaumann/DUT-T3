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
    public partial class FormIntroduction : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Constructeur de FormIntroduction
        /// </summary>
        public FormIntroduction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode de l'evenement du bouton partie qui lance le FormDebut et l'affiche
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void buttonPartie_Click(object sender, EventArgs e)
        {
            FormDebut form = new FormDebut();
            form.Show();
            this.Visible = false;
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
        /// Evenement qui deplace le form lors du lacher de click
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void FormIntroduction_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonHistoire_Click(object sender, EventArgs e)
        {
            FormHistoire formH = new FormHistoire();
            formH.Show();
        }
    }
}
