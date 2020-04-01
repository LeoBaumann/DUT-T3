using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Pretendant : Humain
    {
        private Humain parent;

        private int valReligion;
        private int valArmee;
        private int valPeuple;

        /// <summary>
        /// Constructeur de la classe Pretendant qui hérite de la classe Humain
        /// </summary>
        /// <param name="parent">Le parent du prétendant</param>
        /// <param name="prenom">Le prénom du prétendant</param>
        /// <param name="nom">Le nom du prétendant</param>
        /// <param name="genre">Le genre du prétendant</param>
        /// <param name="religion">La religion du prétendant</param>
        /// <param name="nationalite">La nationalite du prétendant</param>
        /// <param name="mariage">L'état relationnelle du prétendant</param>
        /// <param name="valReligion">La valeur de proximité avec la religion du prétendant</param>
        /// <param name="valArmee">La valeur de proximité avec l'armée du prétendant</param>
        /// <param name="valPeuple">La valeur de proximité avec le peuple du prétendant</param>
        public Pretendant(Humain parent, string prenom, string nom, int genre, int religion, int nationalite, int mariage, int valReligion, int valArmee, int valPeuple) : base(prenom, nom, genre, religion,nationalite,mariage)
        {
            this.parent = parent;
            this.valReligion = valReligion;
            this.valArmee = valArmee;
            this.valPeuple = valPeuple;
        }

        /// <summary>
        /// Méthode qui permet de récuperer la valeur de proximité du prétendant avec l'église
        /// </summary>
        /// <returns>La valeur de proximité avec le peuple
        /// 0 si faible, 1 si moyen et 2 si fort</returns>
        public int getValReligion()
        {
            return this.valReligion;
        }

        /// <summary>
        /// Méthode qui permet de récuperer la valeur de proximité du prétendant avec l'armée
        /// </summary>
        /// <returns>La valeur de proximité avec l'armée
        /// 0 si faible, 1 si moyen et 2 si fort</returns>
        public int getValArmee()
        {
            return this.valArmee;
        }

        /// <summary>
        /// Méthode qui permet de récuperer la valeur de proximité du prétendant avec le peuple
        /// </summary>
        /// <returns>La valeur de proximité avec le peuple
        /// 0 si faible, 1 si moyen et 2 si fort</returns>
        public int getValPeuple()
        {
            return this.valPeuple;
        }
    }
}
