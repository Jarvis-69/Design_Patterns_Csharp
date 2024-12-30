public class LiassePdf : LiasseDocument
{
    private IList<string> contenu = new List<string>();

    public void ajouteDocument(string document)
    {
        contenu.Add(document);
    }

    public void imprime()
    {
        Console.WriteLine("Liasse PDF");
        foreach (string s in contenu)
        {
            Console.WriteLine(s);
        }
    }
}