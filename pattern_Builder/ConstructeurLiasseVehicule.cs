namespace Builder;

public abstract class ConstructeurLiasseVehicule
{
    public abstract void ConstruitBonDeCommande(string nomClient);
    public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);
    protected Liasse liasse;
    public Liasse Resultat()
    {
        // Console.WriteLine("Liasse construite");
        return liasse;
    }
}
