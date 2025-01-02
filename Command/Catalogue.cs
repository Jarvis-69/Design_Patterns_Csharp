using System.Collections.Generic;
using MonApplication.Models;

namespace MonApplication.Services
{
    public class Catalogue
    {
        private List<CommandeSolder> commandes;
        private List<Vehicule> vehiculesStock;

        public Catalogue()
        {
            commandes = new List<CommandeSolder>();
            vehiculesStock = new List<Vehicule>();
        }

        public void AjouteVehicule(Vehicule vehicule)
        {
            vehiculesStock.Add(vehicule);
        }

        public void LanceCommandeSolder(CommandeSolder commande)
        {
            if (commande == null) return;
            commandes.Add(commande);
            commande.Solde(vehiculesStock);
        }

        public void AnnuleCommandeSolder(int ordre)
        {
            if (ordre >= 0 && ordre < commandes.Count)
            {
                commandes[ordre].Annule();
            }
        }

        public void RetablitCommandeSolder(int ordre)
        {
            if (ordre >= 0 && ordre < commandes.Count)
            {
                commandes[ordre].Retablit();
            }
        }

        public List<Vehicule> VehiculesStock
        {
            get { return vehiculesStock; }
        }
    }
}
