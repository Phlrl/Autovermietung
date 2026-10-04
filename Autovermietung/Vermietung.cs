namespace Autovermietung
{
    public class Vermietung
    {
        public Auto? auto{get; set;}
        public Kunde? kunde {get; set;}
        public int AnzahlTage {get; set;} = 0;

        public double BerechnePreis() //einfachere implementierung
        {
            if (kunde.Rabatt != 0)
            {
                double PreisMitRabatt = AnzahlTage * auto.PreisProTag * kunde.Rabatt; 
                return PreisMitRabatt;
            }
            else
            {
                double PreisOhneRabatt = AnzahlTage * auto.PreisProTag;
                return PreisOhneRabatt;
            }
        }
    }
}