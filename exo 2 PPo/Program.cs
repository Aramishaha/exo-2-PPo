using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_2_PPo
{
    
    class Program
    {
        
        static void Main(string[] args)  
        {
            Données mesDonnees = new Données();

            int option = 100;
;           while (option != 0)
            {

                Console.WriteLine(" Menu\n ");
            Console.WriteLine(" Taper 1 pour si vous voulez créer un compte : \n" + " Taper 2 pour si vous voulez créditer un compte : \n"+ " Taper 3 pour si vous voulez débiter un compte : \n" + " Taper 4 pour si vous voulez consulter un compte : \n" + " Taper 5 pour si vous voulez supprimer un compte : \n" +" Taper 6 pour afficher la liste des comptes: \n " + " Taper 0 pour quittez :");
            option = Convert.ToInt32(Console.ReadLine());

           

           

            

                if (option == 1)

                {
                    Console.WriteLine(" Saisissez les valeurs pour le compte que vous voulez créer : ");
                    Console.WriteLine("Saisissez le numéro de compte : ");
                    int unNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Saisissez le nom du compte : ");
                    string unNom = (Console.ReadLine());
                    Console.WriteLine("Saisissez le prénom du compte : ");
                    string unPrenom = (Console.ReadLine());
                    Console.WriteLine("Saisissez le solde du compte : ");
                    int unSolde = int.Parse(Console.ReadLine());
                    Compte c3 = new Compte(unNumero, unNom, unPrenom, unSolde);
                    mesDonnees.AjouterCompte(c3);
                }

                else if (option == 2) 
                {

                    Console.WriteLine("Saisissez le numéro de compte à créditer : ");
                    int leNumero = int.Parse(Console.ReadLine());

                    Compte compteCredit = mesDonnees.RechercheCompte(leNumero);

                    if (compteCredit != null)
                    {
                        Console.WriteLine("Saisissez le montant à créditer : ");
                        int leMontant = int.Parse(Console.ReadLine());
                        compteCredit.CrediterCompte(leMontant);
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }
                }

                else if (option == 3)
                {
                    Console.WriteLine("Saisissez le numéro de compte à débiter : ");
                    int leNumero = int.Parse(Console.ReadLine());

                    Compte compteCredit = mesDonnees.RechercheCompte(leNumero);

                    if (compteCredit != null)
                    {
                        Console.WriteLine("Saisissez le montant à débiter : ");
                        int leMontant = int.Parse(Console.ReadLine());
                        compteCredit.DebiterCompte(leMontant);
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }

                }

                else if (option == 4)
                {
                    Console.WriteLine("Saisissez le numéro de compte à afficher : ");
                    int leNumero = int.Parse(Console.ReadLine());

                    Compte compteCredit = mesDonnees.RechercheCompte(leNumero);

                    if (compteCredit != null)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" Compte numéro : " + compteCredit.GetNumero());
                        Console.WriteLine(" nom : " + compteCredit.GetNom());
                        Console.WriteLine(" prénom : " + compteCredit.GetPrenom());
                        Console.WriteLine(" solde : " + compteCredit.GetSolde());
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("Saisissez le numéro de compte à afficher : ");
                    int leNumero = int.Parse(Console.ReadLine());

                    Compte compteCredit = mesDonnees.RechercheCompte(leNumero);

                    if (compteCredit != null)
                    {
                        Console.WriteLine("Saisissez le numéro de compte à supprimer : ");
                        int leMontant = int.Parse(Console.ReadLine());
                        mesDonnees.SupprimerCompte(compteCredit);
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }

                }







                else if (option == 6)
                {

                    Console.WriteLine("Voici la liste des compte : ");


                    foreach (Compte unCompte in mesDonnees.GetListeComptes())
                    {

                        Console.WriteLine(" ");
                        Console.WriteLine(" Compte numéro : " + unCompte.GetNumero());
                        Console.WriteLine(" nom : " + unCompte.GetNom());
                        Console.WriteLine(" prénom : " + unCompte.GetPrenom());
                        Console.WriteLine(" solde : " + unCompte.GetSolde());
                        Console.WriteLine(" ");


                    }
                }
            
            } 


            Console.ReadKey();
        }
        

    }
}
