using System;

public class RIBProfessionnel : IRIB
{
    public void Generate()
    {
        Console.WriteLine("RIB Professionnel généré");
    }
}

public class AttestationProfessionnel : IAttestation
{
    public void Generate()
    {
        Console.WriteLine("Attestation Professionnel générée");
    }
}

public class ProfessionnelDocumentFactory : IBankingDocumentFactory
{
    public IRIB CreateRIB()
    {
        return new RIBProfessionnel();
    }

    public IAttestation CreateAttestation()
    {
        return new AttestationProfessionnel();
    }
}