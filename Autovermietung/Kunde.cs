namespace Autovermietung
{
    public class Kunde
    {
        public string? KundenName {get; private set;}
        public int KundenNummer {get; private set;} = 0; 
        public double Rabatt {get; private set;} = 0; //setter so das man double nur zwiaschen 0 und 1 setten kann 
    }
}