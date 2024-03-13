namespace exo_2_PPo
{
    
    /// <summary>
    /// Class compte
    /// </summary>
    class Compte 
    {
        /// <summary>
        /// numéro du compte
        /// </summary>
        private int numeroCompte;
        /// <summary>
        /// nom du compte
        /// </summary>
        private string nomCompte;
        /// <summary>
        /// prenom du compte
        /// </summary>
        private string prenomCompte;
        /// <summary>
        /// solde du compte
        /// </summary>
        private int soldeCompte;

        /// <summary>
        /// Constructeur initialisant l'objet
        /// </summary>
        /// <param name="monNumero"></param>
        /// <param name="monNom"></param>
        /// <param name="monPrenom"></param>
        public Compte(int monNumero, string monNom, string monPrenom) 
        {
            numeroCompte = monNumero;
            nomCompte = monNom;
            prenomCompte = monPrenom;
            soldeCompte = 0;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="monNumero"></param>
        /// <param name="monNom"></param>
        /// <param name="monPrenom"></param>
        /// <param name="monSolde"></param>
        public Compte(int monNumero, string monNom, string monPrenom, int monSolde) 
        {
            numeroCompte = monNumero;
            nomCompte = monNom;
            prenomCompte = monPrenom;
            soldeCompte = monSolde;
        }
     
        
        /// <summary>
        /// Crédite le montant ajouté au solde de base
        /// </summary>
        /// <param name="montant_Ajoute"></param>

        
        public void CrediterCompte(int montant_Ajoute)
        {
            soldeCompte = soldeCompte + montant_Ajoute;

        }

        /// <summary>
        /// Débite le montant soustrait au solde de base
        /// </summary>
        /// <param name="montant_Soustrait"></param>
        public void DebiterCompte(int montant_Soustrait)
        {

            soldeCompte = soldeCompte - montant_Soustrait;

        }

        /// <summary>
        /// getter sur numéro
        /// </summary>
        /// <returns>numéro du compte</returns>
        public int GetNumero()
        {
            return numeroCompte;
        }

        /// <summary>
        /// getter sur nom
        /// </summary>
        /// <returns>nom du compte</returns>
        public string GetNom()
        {
            return nomCompte;
        }
        /// <summary>
        /// getter sur prénom
        /// </summary>
        /// <returns>prénom du compte</returns>
        public string GetPrenom()
        {
            return prenomCompte;
        }

        /// <summary>
        /// getter sur solde
        /// </summary>
        /// <returns>retourne le solde du compte</returns>
        public int GetSolde()
        {

            return soldeCompte;
        }
    }
}
