using System;

namespace Builder;

public class Vendeur
{
    protected ConstructeurLiasseVehicule _constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        _constructeur = constructeur; // designe l'instance
        // en cours d'utilisation
    }

    public Liasse Construit(string nomClient)
    {
        _constructeur.ConstruitBonDeCommande(nomClient);
        _constructeur.ConstruitDemandeImmatriculation(nomClient);

        Liasse liasse = _constructeur.Resultat();

        return liasse;
    }
}
