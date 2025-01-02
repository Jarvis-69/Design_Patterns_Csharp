using System;

public class AssVie : Document
{
  public override void affiche(string name)
  {
    Console.WriteLine(
      "Affiche la demande d'Assurance Vie : " + name);
  }
}
