using System;

namespace Builder;

public abstract class Liasse
{
    protected IList<string> contenu = new List<string>(); // List<T> est un type generique

    public abstract void ajouteDocument(string document);
    public abstract void imprime();
}
