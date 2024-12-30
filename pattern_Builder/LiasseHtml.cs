public class LiasseHtml : LiasseDocument
{
    protected string contenu;

    public LiasseHtml()
    {
        contenu = "<HTML>Contenu de la liasse HTML</HTML>";
    }

    public void ajouteDocument(string document)
    {
        contenu += document;
    }

    public void imprime()
    {
        Console.WriteLine("Liasse HTML");
        Console.WriteLine(contenu);
    }
}