public class RIBParticulier : IRIB
{
    public void Generate()
    {
        Console.WriteLine("RIB Particulier généré");
    }
}

public class AttestationParticulier : IAttestation
{
    public void Generate()
    {
        Console.WriteLine("Attestation Particulier générée");
    }
}

public class ParticulierDocumentFactory : IBankingDocumentFactory
{
    public IRIB CreateRIB()
    {
        return new RIBParticulier();
    }

    public IAttestation CreateAttestation()
    {
        return new AttestationParticulier();
    }
}