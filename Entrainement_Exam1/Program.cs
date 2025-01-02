class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Voulez-vous un document pour un Particulier (1) ou un Professionnel (2) :");
      string choix = Console.ReadLine() ?? string.Empty;
        if (choix == "1")
        {
          IBankingDocumentFactory factoryParticulier = new ParticulierDocumentFactory();
          IRIB ribParticulier = factoryParticulier.CreateRIB();
          IAttestation attestationParticulier = factoryParticulier.CreateAttestation();

          ribParticulier.Generate();
          attestationParticulier.Generate();
        }
        else
        {
          IBankingDocumentFactory factoryProfessionnel = new ProfessionnelDocumentFactory();
          IRIB ribProfessionnel = factoryProfessionnel.CreateRIB();
          IAttestation attestationProfessionnel = factoryProfessionnel.CreateAttestation();

          ribProfessionnel.Generate();
          attestationProfessionnel.Generate();
        }
    }
}