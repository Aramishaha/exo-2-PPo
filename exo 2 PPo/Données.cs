namespace exo_2_PPo
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Donnée
    /// </summary>
    class Données 
    {
        /// <summary>
        /// Créer une liste de type Compte appelé NouveauxCompte
        /// </summary>
        private List<Compte> NouveauxCompte;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Données()
        {
            NouveauxCompte  = new List<Compte>();
        }
        
        /// <summary>
        /// Ajoute un nouveau compte dans la liste des comptes
        /// </summary>
        /// <param name="compte"></param>

        public void AjouterCompte(Compte compte) 
        {
            NouveauxCompte.Add(compte);
        }

        /// <summary>
        /// Supprime un compte existant de la liste des comptes
        /// </summary>
        /// <param name="compte"></param>
        public void SupprimerCompte(Compte compte)
        {
            NouveauxCompte.Remove(compte);
        }

        /// <summary>
        /// Affiche la liste des comptes
        /// </summary>
        /// <returns>NouveauxComptes</returns>
        public List<Compte> GetListeComptes()
        {
            return NouveauxCompte;
        }

        /// <summary>
        /// Recherhce un compte dans la liste des comptes
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>compte si le compte existe sinon null</returns>
        public Compte RechercheCompte(int numero)
        {
            foreach (Compte compte in NouveauxCompte)
            {
                if (compte.GetNumero() == numero)
                {
                    return compte;
                }
                
            }

            return null;

        }

    }
}
