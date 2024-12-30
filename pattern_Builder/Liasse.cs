public class LiasseDocument
{
    public void ajouteDocument(string document)
    {
        contenu.Add(document);
    }

    public void imprime()
    {
        foreach (string s in contenu)
        {
            Console.WriteLine(s);
        }
    }
}