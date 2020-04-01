using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class CtrlHumain 
    {
        private static CtrlHumain ctrlHumain;
        private Random rnd = new Random();
        private Roi roi;
        private ArrayList listeRoi;
        private ArrayList listeHumain;

        private String[] prenomHomme = { "Louis" ,"Frédéric","Arthur","Charles","Constantin","Guillaume","Germain","Gauthier","Geoffroy","Hubert"};
        private String[] prenomFemme = { "Agnes" ,"Beatrice","Anastasie","Catherine","Emeline","Bénédicte","Bertille","Clotilde","Blanche","Agarde"};

        /// <summary>
        /// Méthode qui permet de recuperer l'instance de la classe CtrlHumain
        /// La creer si elle n'est pas encore crée
        /// </summary>
        /// <returns>Instance de la classe CtrlHumain</returns>
        public static CtrlHumain getInstance()
        {
            if (ctrlHumain == null)
            {
                ctrlHumain = new CtrlHumain();
            }
            return ctrlHumain;
        }

        /// <summary>
        /// Méthode qui permet de reset les deux listes en attribut
        /// </summary>
        public void resetCtrlHumain()
        {
            listeRoi = new ArrayList();
            listeHumain = new ArrayList();
        }

        /// <summary>
        /// Méthode qui permet de recuperer la liste de tous les humains
        /// </summary>
        /// <returns>Liste des humains de la partie en cours</returns>
        public ArrayList getListeHumain()
        {
            return new ArrayList(listeHumain);
        }

        /// <summary>
        /// Méthode qui permet de recuperer la liste des différents rois ou reines lors de la partie en cours
        /// </summary>
        /// <returns>Liste de tous les rois ou reines de la partie</returns>
        public ArrayList getListeRoi()
        {
            return new ArrayList(listeRoi);
        }

        /// <summary>
        /// Méthode qui permet de recuperer le Roi en cours
        /// </summary>
        /// <returns>Roi à l'instant t</returns>
        public Roi getRoi()
        {
            return this.roi;
        }

        /// <summary>
        /// Méthode qui permet de creer un prétendant à un humain
        /// </summary>
        /// <param name="parent">Humain qui aura pour enfant le prétendant crée</param>
        /// <returns>Prétendant créé</returns>
        public Pretendant creerPretendant(Humain parent)
        {
            int numGenre = rnd.Next(2);

            string prenom;
            if (numGenre == 0)
            {
                prenom = (String)prenomHomme.GetValue(rnd.Next(prenomHomme.Length));
            }
            else
            {
                prenom = (String)prenomFemme.GetValue(rnd.Next(prenomFemme.Length));
            }

            int religion = rnd.Next(2);
            int valReligion = rnd.Next(3);
            int valArmee = rnd.Next(3);
            int valPeuple = rnd.Next(3);

            int valNationalite = rnd.Next(10);
            int nationalite;
            if(valNationalite < 6)
            {
                nationalite = 0;
            }
            else if(valNationalite <8){
                nationalite = 1;
            }
            else
            {
                nationalite = 2;
            }

            Pretendant pretendant = new Pretendant(parent,prenom,parent.getNom(),numGenre,religion,nationalite,0,valReligion,valArmee,valPeuple);
            listeHumain.Add(pretendant);

            return pretendant;
        }

        /// <summary>
        /// Méthode qui permet de créer un roi en fonction de ces paramètres
        /// </summary>
        /// <param name="anneeTrone">Annee a laquelle le nouveau roi récupère le trone</param>
        /// <param name="nom">Nom du nouveau roi</param>
        /// <param name="prenom">Prénom du nouveau roi</param>
        /// <param name="genre">Genre du nouveau roi</param>
        /// <param name="age">Age du nouveau roi</param>
        /// <returns></returns>
        public Roi creerRoi(int anneeTrone, String nom,String prenom,int genre,int age)
        {
            int religion = rnd.Next(2);

            Roi roi = new Roi(anneeTrone, prenom,nom, genre, religion,age);
            listeHumain.Add(roi);
            this.roi = roi;

            listeRoi.Add(roi);

            return roi;
        }

        /// <summary>
        /// Méthode qui permet d'augmenter le temps jusqu'a ce que le roi meurs
        /// </summary>
        /// <returns>Nb d'année qui ont été avancé</returns>
        public int avancerTemps()
        {
            int nbAnnee = 0;
            while (roi.getEstVivant())
            {
                nbAnnee++;
                foreach (Humain humain in this.getListeHumain())
                {
                    humain.vieillir();
                    if (humain.getAge() > 13)
                    {
                        int nbAlea = rnd.Next(100);
                        if (nbAlea < 30 && nbAlea >= 6)
                        {
                            Humain enfantHumain = this.creerPretendant(humain);
                            humain.ajouterEnfant(enfantHumain);
                        }
                        else if(nbAlea < 6 && nbAlea >=2){
                            for (int i = 0; i < 2; i++)
                            {
                                Humain enfantHumain = this.creerPretendant(humain);
                                humain.ajouterEnfant(enfantHumain);
                            }
                        }
                        else if (nbAlea <2)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Humain enfantHumain = this.creerPretendant(humain);
                                humain.ajouterEnfant(enfantHumain);
                            }
                        }
                    }
                    if (rnd.Next(300) < humain.getAge())
                    {
                        mortHumain(humain);
                    }
                }
            }
            return nbAnnee;
        }

        /// <summary>
        /// Méthode qui permet de tuer un humain
        /// </summary>
        /// <param name="humain">L'humain qui doit être tué</param>
        public void mortHumain(Humain humain)
        {
            if (humain != roi || humain.getEnfant().Count != 0)
            {
                humain.setEstVivant();
                listeHumain.Remove(humain);
            }
        }

        /// <summary>
        /// Méthode qui permet d'enlever les humains non géré par l'application de la liste humain
        /// </summary>
        public void nettoyerListeHumain()
        {
            Console.WriteLine("bite");
            listeHumain.RemoveRange(0, listeHumain.Count);
            listeHumain.Add(roi);
            foreach(Humain humain in roi.getEnfant())
            {
                foreach(Humain hum in humain.getEnfant())
                {
                    listeHumain.Add(hum);
                }
                listeHumain.Add(humain);
            }
        }


        /// <summary>
        /// Méthode qui permet de changer le roi en fonction des lois votées
        /// </summary>
        /// <returns>Retourne le prétendant qui va devenir roi</returns>
        public Pretendant changerRoi()
        {
            ArrayList listeHeritier = Lois.trouverHeritier();
            Pretendant heritier;
            if (listeHeritier.Count > 1)
            {
                heritier = (Pretendant)listeHeritier[rnd.Next(listeHeritier.Count)];
                FormJeu.valeurConflit = FormJeu.valeurConflit + listeHeritier.Count * 15;
            }
            else
            {
                heritier = (Pretendant)listeHeritier[0];
            }

            roi.setAnneePassationTrone(FormJeu.anneeJeu);

            this.roi = this.creerRoi(FormJeu.anneeJeu, heritier.getNom(), heritier.getPrenom(),heritier.getGenre(),heritier.getAge());
            this.roi.setEnfant(heritier.getEnfant());
            nettoyerListeHumain();

            return heritier;
        }
    }
}
