namespace Autovermietung
{
    public class Kunde
    {
        public string? KundenName {get; private set;}
        public int KundenNummer {get; private set;} = 0; 
        public double Rabatt {get; private set;} = 0; 

        public Kunde(string name, int nummer)
        {
            KundenName = name;
            KundenNummer = nummer;
        }

        public void setRabatt(double rabatt)
        {
            if (rabatt > 0 && rabatt <= 1)
            {
                Rabatt = rabatt;
            }
        }
    }
}