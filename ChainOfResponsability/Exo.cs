public class ObjetBase
{
    public string GetDescription();
}

public class Véhicule : ObjetBase
{
    public override string GetDescription()
    {
        return "Véhicule";
    }
}

public class Modèle : ObjetBase
{
    public override string GetDescription()
    {
        return "Modèle";
    }
}

public class Marque : ObjetBase
{
    public override string GetDescription()
    {
        return "Marque";
    }
}

public class DefaultDescription : ObjetBase
{
    public override string GetDescription()
    {
        return "Description par défaut";
    }
}

// Utilisation de la chaîne de responsabilité
public class Exo
{
    public void Run()
    {
        ObjetBase véhicule = new Véhicule();
        ObjetBase modèle = new Modèle();
        ObjetBase marque = new Marque();
        ObjetBase defaultDescription = new DefaultDescription();

        véhicule.SetNext(modèle);
        modèle.SetNext(marque);
        marque.SetNext(defaultDescription);

        Console.WriteLine(véhicule.GetDescription());
    }
}


