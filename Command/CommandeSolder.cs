using System;
using System.Collections.Generic;

namespace MonApplication.Models
{
    public class CommandeSolder
    {
        private double tauxRemise;
        private int dureeStock;

        // Mémorise les prix avant et après remise pour chaque véhicule
        // afin de pouvoir annuler ou rétablir cette commande spécifiquement.
        private Dictionary<Vehicule, (double ancienPrix, double nouveauPrix)> vehiculesModifies;

        private bool commandeActive;

        public CommandeSolder(int dureeStock, double tauxRemise)
        {
            this.dureeStock = dureeStock;
            this.tauxRemise = tauxRemise;
            vehiculesModifies = new Dictionary<Vehicule, (double, double)>();
            commandeActive = false;
        }

        // Applique la remise et stocke les anciens/nouveaux prix
        public void Solde(List<Vehicule> vehicules)
        {
            // Si la commande a déjà été appliquée et non annulée, on évite de la réappliquer
            if (commandeActive) return;

            foreach (var vehicule in vehicules)
            {
                if (vehicule.GetDureeStockage() >= dureeStock)
                {
                    double prixAvant = vehicule.PrixVente;
                    double coefficient = 1 - tauxRemise;
                    vehicule.ModifiePrix(coefficient);
                    double prixApres = vehicule.PrixVente;
                    vehiculesModifies[vehicule] = (prixAvant, prixApres);
                }
            }

            commandeActive = true;
        }

        // Restaure le prix avant remise pour chaque véhicule affecté par CETTE commande
        public void Annule()
        {
            if (!commandeActive) return;
            foreach (var kvp in vehiculesModifies)
            {
                var vehicule = kvp.Key;
                var ancienPrix = kvp.Value.ancienPrix;
                vehicule.SetPrix(ancienPrix);
            }
            commandeActive = false;
            Console.WriteLine("CommandeSolder -> Annule()");
        }

        // Réapplique la remise pour chaque véhicule affecté par CETTE commande
        public void Retablit()
        {
            if (commandeActive) return;
            foreach (var kvp in vehiculesModifies)
            {
                var vehicule = kvp.Key;
                var nouveauPrix = kvp.Value.nouveauPrix;
                vehicule.SetPrix(nouveauPrix);
            }
            commandeActive = true;
            Console.WriteLine("CommandeSolder -> Retablit()");
        }
    }
}
