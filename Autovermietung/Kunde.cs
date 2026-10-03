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

        public void setRabatt(double rabbat)
        {
            if (Rabatt > 0 && Rabatt <= 1)
            {
                Rabatt = rabbat;
            }
        }

        public void autoMieten()
        {
            
        }
    }
}