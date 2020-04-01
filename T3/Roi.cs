using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Roi : Humain
    {
        private int anneeObtentionTrone;
        private int anneePassationTrone;

        /// <summary>
        /// Constructeur de la classe Roi qui hérite de la classe Humain
        /// </summary>
        /// <param name="anneeObtentionTrone">L'année à laquelle le roi a obtenu le trone</param>
        /// <param name="prenom">Le prenom du roi</param>
        /// <param name="nom">Le nom du roi</param>
        /// <param name="genre">Le genre du roi</param>
        /// <param name="religion">La religion du roi</param>
        /// <param name="age">L'age du roi</param>
        public Roi(int anneeObtentionTrone, string prenom, string nom, int genre, int religion,int age) : base(prenom, nom,genre, religion,0,0)
        {
            this.anneeObtentionTrone = anneeObtentionTrone;
            base.setAge(age);
        }

        /// <summary>
        /// Méthode qui permet de récuperer l'année à laquelle le roi a obtenu le trone
        /// </summary>
        /// <returns>L'année à laquelle le roi a obtenu le trone</returns>
        public int getAnneeObtentionTrone()
        {
            return this.anneeObtentionTrone;
        }

        /// <summary>
        /// Méthode qui permet de récuperer l'année à laquelle le roi a passé le trone
        /// </summary>
        /// <returns>L'année à laquelle le roi a passé le trone</returns>
        public int getAnneePassationTrone()
        {
            return this.anneePassationTrone;
        }

        /// <summary>
        /// Méthode qui permet de changer l'année a laquelle le roi a passé le trone
        /// </summary>
        /// <param name="annee">L'année à laquelle le roi a passé le trone</param>
        public void setAnneePassationTrone(int annee) {
            this.anneePassationTrone = annee;
        }
    }
}
