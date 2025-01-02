using System;
using MonApplication.Models;

namespace MonApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemple simple sans passer par un catalogue
            var vehicule1 = new Vehicule(DateTime.Now.AddDays(-10), 20000);
            var vehicule2 = new Vehicule(DateTime.Now.AddDays(-2), 30000);

            // Affichage du temps passé en stock (en jours)
            TimeSpan tempsStockV1 = vehicule1.GetTempsStockage();
            TimeSpan tempsStockV2 = vehicule2.GetTempsStockage();

            Console.WriteLine($"Véhicule 1 : {tempsStockV1.Days} jours en stock (soit environ {tempsStockV1.TotalHours:0.0} heures)");
            Console.WriteLine($"Véhicule 2 : {tempsStockV2.Days} jours en stock (soit environ {tempsStockV2.TotalHours:0.0} heures)");

            Console.WriteLine("\nAppuyez sur une touche pour quitter.");
            Console.ReadKey();
        }
    }
}
