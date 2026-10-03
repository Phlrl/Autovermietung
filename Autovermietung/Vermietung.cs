namespace Autovermietung
{
    public class Vermietung
    {
        public Auto? auto{get; private set;}
        public Kunde? kunde {get; private set;}
        public int AnzahlTage {get; private set;} = 0;

        public double BerechnePreis()
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