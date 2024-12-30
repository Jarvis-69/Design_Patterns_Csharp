namespace Builder;

public class Vendeur
{
    protected ConstructeurLiasseVehicule _constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this._constructeur = constructeur;
        // Or _constructeur = constructeur;
    }

    public Liasse construit(string nomClient)
    {
        _constructeur.construitBonDeCommande(nomClient);
        _constructeur.construitDemandeImmatriculation(nomDemandeur);
        Liasse liasse = _constructeur.resultat();
        return liasse;
    }
}