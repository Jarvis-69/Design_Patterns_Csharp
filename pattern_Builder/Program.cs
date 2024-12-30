using System;

public class Catalogue
{
    public static void Main()
    {
        ConstructeurLiasseVehicule constructeur;
        Console.WriteLine("Voulez-vous construire des liasses HTML (1) ou PDF (2) :");
        string choix = Console.ReadLine();
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }
        Vendeur vendeur = new Vendeur(constructeur);
        LiasseDocument liasse = vendeur.construit("Martin");
        liasse.imprime();
    }
}