using System;

class Program 
{
    static void Main(string [] args)
    {
        Console.WriteLine("Voulez-vous une Assurance Habitation (1), une Assurance Automobile (2) ou une Assurance Vie (3) :");
        string choix = Console.ReadLine() ?? string.Empty;
        if (choix == "1")
        {
            Document AssHabitation = new AssHabitation();
            AssHabitation.affiche("TOTO");
        }
        if (choix == "2")
        {
            Document AssAuto = new AssAuto();
            AssAuto.affiche("TOTO2");
        }
        if (choix == "3")
        {
            Document AssVie = new AssVie();
            AssVie.affiche("TOTO3");
        }

    
    }
}