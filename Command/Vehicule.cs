using System;

namespace MonApplication.Models
{
    public class Vehicule
    {
        private DateTime dateEntreeStock;
        private double prixVente;

        public Vehicule(DateTime dateEntreeStock, double prixVente)
        {
            this.dateEntreeStock = dateEntreeStock;
            this.prixVente = prixVente;
        }

        public int GetDureeStockage()
        {
            return (DateTime.Now - dateEntreeStock).Days;
        }

        public double PrixVente
        {
            get { return prixVente; }
        }

        public void ModifiePrix(double coefficient)
        {
            prixVente *= coefficient;
        }

        public void SetPrix(double nouveauPrix)
        {
            prixVente = nouveauPrix;
        }
    }
}
