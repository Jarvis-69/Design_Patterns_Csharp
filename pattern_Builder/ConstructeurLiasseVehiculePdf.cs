using System;

public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public void construitBonDeCommande(string nomClient);
    public void construitDemandeImmatriculation(string nomDemandeur);
    public LiasseDocument resultat();
}