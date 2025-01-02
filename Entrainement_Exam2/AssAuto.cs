using System;

public class AssAuto : Document
{
  public override void affiche(string name)
  {
    Console.WriteLine(
      "Affiche la demande d'Assurance Auto : " + name);
  }
}
