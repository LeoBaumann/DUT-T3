using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Humain
    {
        private string prenom;
        private string nom;
        private int genre;
        private int age =0;
        private int religion;
        private int nationalite;
        private int mariage;
        private int id;
        private Boolean estVivant = true;

        private ArrayList listeEnfant = new ArrayList();

        private static int nextId = 0;

        /// <summary>
        /// Constructeur de la classe Humain
        /// </summary>
        /// <param name="prenom">Prenom de l'humain</param>
        /// <param name="nom">Nom de l'humain</param>
        /// <param name="genre">Genre de l'humain
        /// 0 est le genre masculin
        /// 1 est le genre féminin </param>
        /// <param name="religion">Religion de l'humain
        /// 0 est la religion catholique
        /// 1 est la religion protestante</param>
        /// <param name="nationalite">Nationalite de l'humain
        /// 0 est la nationalite française
        /// 1 est la nationalite espagnole
        /// 2 est la nationalite anglaise</param>
        /// <param name="mariage">Relation de l'humain</param>
        public Humain(string prenom, string nom, int genre, int religion,int nationalite,int mariage)
        {
            nextId++;

            this.prenom = prenom;
            this.nom = nom;
            this.genre = genre;
            this.religion = religion;
            this.id = nextId;
            this.nationalite = nationalite;
            this.mariage = mariage;
        }

        /// <summary>
        /// Méthode qui permet d'augmenter l'age d'un an
        /// </summary>
        public void vieillir()
        {
            this.age++;
        }

        /// <summary>
        /// Méthode qui permet de changer la liste des enfants de l'humain
        /// </summary>
        /// <param name="listeEnfant">Nouvelle liste des enfants</param>
        public void setEnfant(ArrayList listeEnfant)
        {
            this.listeEnfant = listeEnfant;
        }

        /// <summary>
        /// Méthode qui permet de recuperer la liste des enfants de l'humain
        /// </summary>
        /// <returns> listeEnfant et la liste des enfants de l'humain de type ArrayList</returns>
        public ArrayList getEnfant()
        {
            return new ArrayList(listeEnfant);
        }

        /// <summary>
        /// Méthode qui permet de recuperer l'enfant de la liste des enfants a un certain index
        /// </summary>
        /// <param name="index">Position de l'enfant</param>
        /// <returns>Enfant a l'index indiqué</returns>
        public Humain getEnfant(int index)
        {
            int i = 0;
            Humain humainIndex = null;
            foreach (Humain humain in listeEnfant)
            {
                i++;
                if (i == index)
                {
                    humainIndex = humain;
                    break;
                }
            }
            return humainIndex;
        }

        /// <summary>
        /// Méthode qui permet de récuperer le nom de l'humain
        /// </summary>
        /// <returns>Retourne le nom de l'humain</returns>
        public String getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Méthode qui permet de récuperer le prenom de l'humain
        /// </summary>
        /// <returns>Retourne le prenom de l'humain</returns>
        public String getPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// Méthode qui permet de récuperer l'age de l'humain
        /// </summary>
        /// <returns>Retourne l'age de l'humain</returns>
        public int getAge()
        {
            return this.age;
        }

        /// <summary>
        /// Méthode qui permet de modifier l'age de l'humain
        /// </summary>
        /// <param name="age">Le paramètre age correspond au nouvelle age de l'humain</param>
        public void setAge(int age)
        {
            this.age=age;
        }

        /// <summary>
        /// Méthode qui permet de récuperer la religion de l'humain
        /// </summary>
        /// <returns>Retourne la religion de l'humain</returns>
        public int getReligion()
        {
            return this.religion;
        }

        /// <summary>
        /// Méthode qui permet de savoir si l'humain est encore vivant ou non
        /// </summary>
        /// <returns>Retourne l'attribut boolean estVivant </returns>
        public Boolean getEstVivant()
        {
            return this.estVivant;
        }

        /// <summary>
        /// Methode qui permet de tuer un humain
        /// </summary>
        public void setEstVivant()
        {
            this.estVivant = false;
        }

        /// <summary>
        /// Méthode qui permet de récuperer l'identifiant de l'humain
        /// </summary>
        /// <returns>Retourne l'identifiant de l'humain</returns>
        public int getId()
        {
            return this.id;
        }

        /// <summary>
        /// Méthode qui permet de récuperer le genre de l'humain
        /// </summary>
        /// <returns>Retourne le genre de l'humain</returns>
        public int getGenre()
        {
            return this.genre;
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un humain a la liste des enfants de l'humain instancié
        /// </summary>
        /// <param name="humain">Nouvel humain à ajouter à la liste des enfants</param>
        public void ajouterEnfant(Humain humain)
        {
            listeEnfant.Add(humain);
        }

        /// <summary>
        /// Méthode qui permet de récuperer la nationalite de l'humain
        /// </summary>
        /// <returns>Retourne la nationalite de l'humain</returns>
        public int getNationalite()
        {
            return this.nationalite;
        }
        
    }
}
