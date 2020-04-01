using System;
using System.Collections;
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
    public partial class FormJeu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public static int anneeJeu;
        public static int difficulte;
        public static int valeurEglise;
        public static int valeurArmee;
        public static int valeurPeuple;
        public static int valeurConflit;

        /// <summary>
        /// Constructeur de FormJeu
        /// </summary>
        /// <param name="nom">Nom de la dynastie</param>
        /// <param name="prenom">Prénom du premier roi</param>
        /// <param name="genre">Genre du premier roi</param>
        public FormJeu(String nom, String prenom, int genre, int diff)
        {
            InitializeComponent();
            difficulte = diff;
            chargementJeu(nom, prenom, genre);
        }

        /// <summary>
        /// Procedure mettant en place tous les parametres du jeu
        /// </summary>
        /// <param name="nom">Nom de la dynastie</param>
        /// <param name="prenom">Prénom du premier roi</param>
        /// <param name="genre">Genre du premier roi</param>
        private void chargementJeu(String nom, String prenom, int genre)
        {
            initialisationValeurs();

            Roi roi = CtrlHumain.getInstance().creerRoi(anneeJeu,nom,prenom,genre,0);

            progressbarArmee.Width = valeurArmee;
            progressbarPeuple.Width = valeurPeuple;
            progressbarEglise.Width = valeurEglise;
            progressbarConflit.Width = valeurConflit;

            actualiserJeu();
            actualiserLois();
            buttonAvancerTemps_Click(null,null);
        }

        /// <summary>
        /// Procedure initialisant les differentes variables necessaires au jeu
        /// </summary>
        private void initialisationValeurs()
        {
            anneeJeu = 0;
            valeurArmee = 50;
            valeurEglise = 50;
            valeurPeuple = 50;
            valeurConflit = 0;

            Lois.listeLoisNonVote = new ArrayList(Lois.listeLois);
            Lois.listeLoisVote = new ArrayList();
            CtrlHumain.getInstance().resetCtrlHumain();

        }

        /// <summary>
        /// Procedure actualisant les differents parametres du jeu 
        /// </summary>
        private void actualiserJeu()
        {
            actualiserInformationRoi();
            actualiserPretendant();
            actualiserHeritier(0);
        }

        /// <summary>
        /// Procedure actualisant les progressBar à l'élection de chaque roi
        /// </summary>
        /// <param name="heritier">Pretendant selectionne</param>
        private void actualiserProgressBar(Pretendant heritier)
        {
            try
            {
                switch (heritier.getValReligion())
                {
                    case 0:
                        valeurEglise -= 25;
                        break;
                    case 1:
                        valeurEglise -= 10;
                        break;
                    default:
                        if (valeurEglise + 20 > 100)
                        {
                            valeurEglise = 100;
                        }
                        else
                        {
                            valeurEglise += 20;
                        }
                        break;
                }
                switch (heritier.getValArmee())
                {
                    case 0:
                        valeurArmee -= 25;
                        break;
                    case 1:
                        valeurArmee -= 10;
                        break;
                    default:
                        if (valeurArmee + 20 > 100)
                        {
                            valeurArmee = 100;
                        }
                        else
                        {
                            valeurArmee += 20;
                        }
                        break;
                }
                switch (heritier.getValPeuple())
                {
                    case 0:
                        valeurPeuple -= 25;
                        break;
                    case 1:
                        valeurPeuple -= 10;
                        break;
                    default:
                        if (valeurPeuple + 20 > 100)
                        {
                            valeurPeuple = 100;
                        }
                        else
                        {
                            valeurPeuple += 20;
                        }
                        break;
                }
                if (valeurEglise <= 0)
                {
                    throw new Exception("0");
                }
                if (valeurArmee <= 0)
                {
                    throw new Exception("2");
                }
                if (valeurPeuple <= 0)
                {
                    throw new Exception("4");
                }
                if (valeurConflit >= 100)
                {
                    throw new Exception("6");
                }
            }
            catch(Exception e)
            {
                FormFin form = new FormFin(anneeJeu,int.Parse(e.Message));
                form.Show();
                this.Visible = false;
            }

            progressbarArmee.Width = valeurArmee;
            progressbarPeuple.Width = valeurPeuple;
            progressbarEglise.Width = valeurEglise;
            progressbarConflit.Width = valeurConflit;

            if (valeurConflit > 70)
            {
                progressbarConflit.BackColor = Color.Red;
            }
            if (valeurArmee < 30)
            {
                progressbarArmee.BackColor = Color.Red;
            }
            else
            {
                progressbarArmee.BackColor = Color.Green;
            }
            if (valeurEglise < 30)
            {
                progressbarEglise.BackColor = Color.Red;
            }
            else
            {
                progressbarEglise.BackColor = Color.Green;
            }
            if (valeurPeuple < 30)
            {
                progressbarPeuple.BackColor = Color.Red;
            }
            else
            {
                progressbarPeuple.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Méthode qui actualise la progresse bar
        /// </summary>
        private void actualiserProgressBar()
        {
            progressbarArmee.Width = valeurArmee;
            progressbarPeuple.Width = valeurPeuple;
            progressbarEglise.Width = valeurEglise;
            progressbarConflit.Width = valeurConflit;

            if (valeurConflit > 70)
            {
                progressbarConflit.BackColor = Color.Red;
            }
            if (valeurArmee < 30)
            {
                progressbarArmee.BackColor = Color.Red;
            }
            else
            {
                progressbarArmee.BackColor = Color.Green;
            }
            if (valeurEglise < 30)
            {
                progressbarEglise.BackColor = Color.Red;
            }
            else
            {
                progressbarEglise.BackColor = Color.Green;
            }
            if (valeurPeuple < 30)
            {
                progressbarPeuple.BackColor = Color.Red;
            }
            else
            {
                progressbarPeuple.BackColor = Color.Green;
            }
        }
        

        /// <summary>
        /// Procedure actualisant les donnees du roi pour chaque nouvel heritier
        /// </summary>
        private void actualiserInformationRoi()
        {
            Roi roi = CtrlHumain.getInstance().getRoi();

            if (roi.getGenre() == 0)
            {
                labelPrenom.Text = "Roi :";
                labelAge.Text = "Age du roi :";
            }
            else
            {
                labelPrenom.Text = "Reine :";
                labelAge.Text = "Age de la reine :";
            }

            labelPrenomRoi.Text = roi.getPrenom();
            labelDynastieRoi.Text = roi.getNom();
            labelAnneeActuelle.Text = anneeJeu.ToString();
            labelAgeRoi.Text = roi.getAge().ToString();
        }

        /// <summary>
        /// Procedure affichant dynamiquement chaque donnees de chaque pretendant 
        /// </summary>
        private void actualiserPretendant()
        {
            string valReligion;
            string valCroyance;
            string valArmee;
            string valPeuple;
            string valGenre;
            string valNationalite;

            panelPretendant.Controls.Clear();
            int i = 0;
            foreach (Pretendant pretendant in CtrlHumain.getInstance().getRoi().getEnfant())
            {
                switch (pretendant.getValReligion())
                {
                    case 0:
                        valReligion = "blason_rouge.png";
                        break;
                    case 1:
                        valReligion = "blason_orange.png";
                        break;
                    default:
                        valReligion = "blason_vert.png";
                        break;
                }

                switch (pretendant.getValArmee())
                {
                    case 0:
                        valArmee = "blason_rouge.png";
                        break;
                    case 1:
                        valArmee = "blason_orange.png";
                        break;
                    default:
                        valArmee = "blason_vert.png";
                        break;
                }

                switch (pretendant.getValPeuple())
                {
                    case 0:
                        valPeuple = "blason_rouge.png";
                        break;
                    case 1:
                        valPeuple = "blason_orange.png";
                        break;
                    default:
                        valPeuple = "blason_vert.png";
                        break;
                }

                switch (pretendant.getReligion())
                {
                    case 0:
                        valCroyance = "Catholique";
                        break;
                    case 1:
                        valCroyance = "Protestant";
                        if (pretendant.getGenre() == 1)
                        {
                            valCroyance += "e";
                        }
                        break;
                    default:
                        valCroyance = "Catholique";
                        break;
                }

                switch (pretendant.getNationalite())
                {
                    case 0:
                        valNationalite = "Français";
                        if (pretendant.getGenre() == 1)
                        {
                            valNationalite += "e";
                        }
                        break;
                    case 1:
                        valNationalite = "Espagnol";
                        if (pretendant.getGenre() == 1 )
                        {
                            valNationalite += "e";
                        }
                        break;
                    default:
                        valNationalite = "Anglais";
                        if (pretendant.getGenre() == 1 )
                        {
                            valNationalite += "e";
                        }
                        break;
                }

                if (pretendant.getAge() >= 3)
                {
                    switch (pretendant.getGenre())
                    {
                        case 0:
                            valGenre = "knight_kid_head.png";
                            break;
                        case 1:
                            valGenre = "princess_kid_head.png";
                            break;
                        default:
                            valGenre = "knight_kid_head.png";
                            break;
                    }
                }
                else
                {
                    valGenre = "baby_head.png";
                }

                UcPretendant uc = new UcPretendant
                {
                    Left = 10 + 200 * i++,
                    LienImageBlasonEglise = valReligion,
                    LienImageBlasonArmee = valArmee,
                    LienImageBlasonPeuple = valPeuple,
                    LienImagePretendant = valGenre,
                    NomPretendant = pretendant.getPrenom(),
                    AgePretendant = pretendant.getAge().ToString(),
                    CroyancePretendant = valCroyance,
                    NationalitePretendant = valNationalite
                };

                uc.Pluriels();
                uc.Tag = pretendant.getId();
                
                panelPretendant.Controls.Add(uc);
            }
        }

        /// <summary>
        /// Procedure actualisant les progressBar à chaque nouveau pretendant
        /// </summary>
        /// <param name="i">Tag du checkbox</param>
        private void actualiserHeritier(int i)
        {
            actualiserChoixLois(i);
            ArrayList heritier = Lois.testTrouverHeritier();

            Color clr = Color.LimeGreen;
            if (heritier.Count > 1)
            {
                clr = Color.PaleVioletRed;
            }

            foreach (Control c in panelPretendant.Controls)
            {
                UserControl uc = (UserControl)c;
                uc.BackColor = FormJeu.DefaultBackColor;

                foreach (Humain hum in heritier)
                {
                    if ((int)uc.Tag == hum.getId())
                    {
                        uc.BackColor = clr;
                    }
                }
            }
        }

        /// <summary>
        /// Procedure generant et actualisant les lois votés et non votés
        /// </summary>
        private void actualiserLois()
        {
            int width = 40;
            int height = 30;

            groupBoxChoixLois.Controls.Clear();

            foreach (String loi in Lois.listeLoisNonVote)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(width, height);
                checkBox.Size = new System.Drawing.Size(35, 13);
                checkBox.Text = loi;
                checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                height = height + 20;
                groupBoxChoixLois.Controls.Add(checkBox);
            }

            width = 40;
            height = 30;

            groupBoxLoisVotees.Controls.Clear();

            foreach (String loi in Lois.listeLoisVote)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(width, height);
                checkBox.Size = new System.Drawing.Size(35, 13);
                checkBox.Text = loi;
                checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                height = height + 20;
                groupBoxLoisVotees.Controls.Add(checkBox);
            }

        }

        /// <summary>
        /// Procedure qui apporte des effets aux lois votées
        /// </summary>
        /// <param name="i">Tag du checkbox selectionne</param>
 
        private void actualiserChoixLois(int i)
        {
            foreach (Control control in groupBoxChoixLois.Controls)
            {
                CheckBox CheckBox = (CheckBox)control;
                if (CheckBox.Checked)
                {
                    if (!Lois.testPresenceLoi(CheckBox.Text, Lois.listeLoisVote))
                    {
                        Lois.listeLoisVote.Add(CheckBox.Text);
                        Lois.listeLoisNonVote.Remove(CheckBox.Text);
                    }
                    if (CheckBox.Text == (String)Lois.listeLois.GetValue(2) && i == 2)
                    {
                        valeurArmee -= 15;
                    }
                    else if (CheckBox.Text == (String)Lois.listeLois.GetValue(6) && i == 6)
                    {
                        valeurPeuple -= 15;
                    }
                    else if (CheckBox.Text == (String)Lois.listeLois.GetValue(7) && i == 7)
                    {
                        valeurPeuple -= 15;
                    }
                }
                else
                {
                    if (Lois.testPresenceLoi(CheckBox.Text, Lois.listeLoisVote))
                    {
                        Lois.listeLoisVote.Remove(CheckBox.Text);
                        Lois.listeLoisNonVote.Add(CheckBox.Text);
                    }
                    if (CheckBox.Text == (String)Lois.listeLois.GetValue(2) && i == 2)
                    {
                        valeurArmee += 15;
                    }
                    else if (CheckBox.Text == (String)Lois.listeLois.GetValue(6) && i == 6)
                    {
                        valeurPeuple += 15;
                    }
                    else if (CheckBox.Text == (String)Lois.listeLois.GetValue(7) && i == 7)
                    {
                        valeurPeuple += 15;
                    }
                }
            }

            foreach (Control control in groupBoxLoisVotees.Controls)
            {
                CheckBox CheckBox = (CheckBox)control;
                if (CheckBox.Checked)
                {
                    if (!Lois.testPresenceLoi(CheckBox.Text, Lois.listeLoisNonVote))
                    {
                        Lois.listeLoisNonVote.Add(CheckBox.Text);
                        Lois.listeLoisVote.Remove(CheckBox.Text);
                    }
                    if (CheckBox.Text == (String)Lois.listeLois.GetValue(1) && i==1)
                    {
                        valeurArmee -= 15;
                    }
                    else if (CheckBox.Text == (String)Lois.listeLois.GetValue(5) && i == 5)
                    {
                        valeurPeuple -= 15;
                    }
                }
                else
                {
                    if (Lois.testPresenceLoi(CheckBox.Text, Lois.listeLoisNonVote))
                    {
                        Lois.listeLoisNonVote.Remove(CheckBox.Text);
                        Lois.listeLoisVote.Add(CheckBox.Text);
                    }
                    if (CheckBox.Text == (String)Lois.listeLois.GetValue(1) && i ==1)
                    {
                        valeurArmee += 15;
                    }
                    else if (CheckBox.Text == (String)Lois.listeLois.GetValue(5) && i == 5)
                    {
                        valeurPeuple += 15;
                    }
                }
            }
            actualiserProgressBar();
        }

        /// <summary>
        /// Evenement qui permet d'avancer le temps et d'aller jusqu'a la prochaine passation de pouvoir lors du click sur le boutton avancer temps
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void buttonAvancerTemps_Click(object sender, EventArgs e)
        {
            anneeJeu=anneeJeu+CtrlHumain.getInstance().avancerTemps();

            if (difficulte != 4 && anneeJeu >= (difficulte * 100))
            {
                FormFin form = new FormFin(anneeJeu, difficulte+7);
                form.Show();
                this.Visible = false;
            }

            actualiserJeu();
            buttonValider.Visible = true;
        }

        /// <summary>
        /// Evenement qui permet de valider les chois pour ensuite actualiser le jeu et ses données lors du click sur le boutton valider
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                actualiserProgressBar(CtrlHumain.getInstance().changerRoi());
                actualiserLois();
                actualiserJeu();
                buttonValider.Visible = false;
            }
            catch
            {
                FormFin form = new FormFin(anneeJeu,7);
                form.Show();
                this.Visible = false;
            }
        }

        /// <summary>
        /// Evenement qui actualise l'heriter en fonction du checkbox qui vient d'etre clické
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Text == (String)Lois.listeLois.GetValue(1))
            {
                actualiserHeritier(1);
            }
            else if (checkBox.Text == (String)Lois.listeLois.GetValue(2))
            {
                actualiserHeritier(2);
            }
            else if (checkBox.Text == (String)Lois.listeLois.GetValue(5))
            {
                actualiserHeritier(5);
            }
            else if (checkBox.Text == (String)Lois.listeLois.GetValue(6))
            {
                actualiserHeritier(6);
            }
            else if (checkBox.Text == (String)Lois.listeLois.GetValue(7))
            {
                actualiserHeritier(7);
            }
            else
            {
                actualiserHeritier(0);
            }
        }

        /// <summary>
        /// Evenement qui affiche le form d'infos sur les lois lors du click sur le boutton info lois
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void buttonInfoLois_Click(object sender, EventArgs e)
        {
            FormInfoLois form = new FormInfoLois();
            form.Show();
        }

        /// <summary>
        /// Evenement qui affiche le form regnes lors du click sur le boutton regnes
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void buttonRegnes_Click(object sender, EventArgs e)
        {
            FormRegnes form = new FormRegnes();
            form.Show();
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
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                panelPretendant.Size = new Size(970, 359);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                panelPretendant.Size = new Size(1300, 359);
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
        /// Evenement qui affiche le form regles lors du click sur le boutton regles
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void ButtonRegles_Click(object sender, EventArgs e)
        {
            FormRegles form_regles = new FormRegles();
            form_regles.Show();
        }

        /// <summary>
        /// Evenement qui deplace le form lors du lacher de click
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void FormJeu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Evenement qui modifie la taille du panel au chargement du form
        /// </summary>
        /// <param name="sender">Objet référence qui a déclenché l'évènement</param>
        /// <param name="e">L'évenement lancé</param>
        private void FormJeu_Load(object sender, EventArgs e)
        {
            panelPretendant.Size = new Size(1300, 359);
        }
    }
}