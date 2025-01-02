using System;

public class AssHabitation : Document
{
  public override void affiche(string name)
  {
    Console.WriteLine(
      "Affiche la demande d'Assurance Habitation : " + name);
  }
}
