using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Autovermietung
{
    public class Program
    {
        // public double berechenPreis()
        // {
        //     return 0;
        // }
        static void Main(string[] args)
        {
            Auto i330 = new Auto("bmw","i330","SU FN 1234", false, 100);
            Auto cl63 = new Auto("mercedes","cl63","B LN 4587", true, 500);
            Auto gwagon = new Auto("mercedes","gklasse","M UH 4589", true, 670);

            Kunde MarkForster = new Kunde("Mark Forster", 123273456);
            Kunde ThomasMueller = new Kunde("Thomas Müller", 235783457);

        }
    }
}