namespace Builder;


public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse; // Composition : mecanisme qui permet a une clasee
    // de contenir une instance de cette meme classe d'une autre


    public abstract void ConstruitBonDeCommande(string nomClient);

    public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);


    public Liasse Resultat()
    {
        return liasse;
    }
}