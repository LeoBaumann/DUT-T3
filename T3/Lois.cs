using System;
using System.Collections;

namespace T3
{
    public static class Lois
    {
        public static String[] listeLois = { "Droit d'aînesse", "Homme", "Femme", "Catholique", "Protestant","Français","Espagnol","Anglais"};
        public static ArrayList listeLoisNonVote;
        public static ArrayList listeLoisVote;

        /// <summary>
        /// Méthode qui permet de trouver les héritiers au roi par rapport aux lois en vigueur
        /// </summary>
        /// <returns>Liste des héritiers</returns>
        public static ArrayList trouverHeritier()
        {
            Roi roi = CtrlHumain.getInstance().getRoi();

            trierList();
            foreach (String lois in Lois.listeLoisVote)
            {
                roi.setEnfant(affectationLois(lois));
            }

            return roi.getEnfant();
        }

        /// <summary>
        /// Méthode qui permet de faire un test pour avoir les héritiers au roi par rapport aux lois en vigueur
        /// </summary>
        /// <returns>Liste des héritiers</returns>
        public static ArrayList testTrouverHeritier()
        {
            Roi roi = CtrlHumain.getInstance().getRoi();
            ArrayList listePretendantPossible;
            ArrayList enfantRoi = new ArrayList(roi.getEnfant());

            trierList();
            foreach (String lois in Lois.listeLoisVote)
            {
                roi.setEnfant(affectationLois(lois));
            }

            listePretendantPossible = new ArrayList(roi.getEnfant());
            roi.setEnfant(enfantRoi);
            
            return listePretendantPossible;
        }

        /// <summary>
        /// Méthode qui permet d'affecter une loi a une liste de prétendant 
        /// </summary>
        /// <param name="lois">La loi affecter a la liste de prétendant</param>
        /// <returns>Liste des héritiers probables</returns>
        public static ArrayList affectationLois(String lois)
        {
            ArrayList listePretendant = new ArrayList(CtrlHumain.getInstance().getRoi().getEnfant());
            ArrayList nouveauListePretendant = new ArrayList();

            if (lois == (String)Lois.listeLois.GetValue(0))
            {
                int max = 0;

                foreach (Humain humain in listePretendant)
                {
                    if (humain.getAge()>max)
                    {
                        max = humain.getAge();
                    }
                }

                foreach (Humain humain in listePretendant)
                {
                    if (humain.getAge() == max)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(1))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getGenre() == 0)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(2))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getGenre() == 1)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(3))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getReligion() == 0)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(4))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getReligion() == 1)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(5))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getNationalite() == 0)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(6))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getNationalite() == 1)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            if (lois == (String)Lois.listeLois.GetValue(7))
            {
                foreach (Humain humain in listePretendant)
                {
                    if (humain.getNationalite() == 2)
                    {
                        nouveauListePretendant.Add(humain);
                    }
                }

            }
            return nouveauListePretendant;
        }

        /// <summary>
        /// Permet de trier la liste des lois votés
        /// </summary>
        public static void trierList()
        {
            for (int i=0;i<Lois.listeLoisVote.Count;i++)
            {
                if (Lois.listeLoisVote[i] == Lois.listeLois.GetValue(0) && i != listeLoisVote.Count - 1)
                {
                    Object tmp = Lois.listeLoisVote[i];
                    Lois.listeLoisVote[i] = Lois.listeLoisVote[listeLoisVote.Count - 1];
                    Lois.listeLoisVote[listeLoisVote.Count - 1] = tmp;
                }
            }
        }

        /// <summary>
        /// Méthode qui test si une loi est présente dans une liste de loi
        /// </summary>
        /// <param name="loi">La loi dont on test la présence</param>
        /// <param name="listeLoi">La liste des lois dans laquelle on cherche la loi</param>
        /// <returns>True si la loi est présente, False sinon</returns>
        public static bool testPresenceLoi(String loi,ArrayList listeLoi)
        {
            bool test = false;
            foreach (String loiTest in listeLoi)
            {
                if (loiTest == loi)
                {
                    test = true;
                }
            }
            return test;
        }
    }
}
