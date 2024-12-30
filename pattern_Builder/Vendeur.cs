public class Vendeur
{
    public LiasseDocument construit(string nomClient)
    {
        constructeur.construitBonDeCommande(nomClient);
        constructeur.construitDemandeImmatriculation(nomClient);
        return constructeur.resultat();
    }
}