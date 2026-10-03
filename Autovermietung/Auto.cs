namespace Autovermietung
{
    public class Auto
    {
        public string? Marke {get; private set;}
        public double PreisProTag {get; private set;} = 0;
        public string? Modell {get; private set;}
        public string? Kennzeichen {get; private set;}
        public bool? IstVermietet {get; private set;}

        public Auto(string marke, string modell, string kennzeichen, bool istvermietet)
        {
            Marke = marke;
            Modell = modell;
            Kennzeichen = kennzeichen;
            IstVermietet = istvermietet;
        }
        
        public void vermieten(bool mieten)
        {
            if(mieten = true)
            {
                IstVermietet = true;
            }
            else
            {
                Console.WriteLine("Auto ist nicht vermietet");
            }

        }

        public void zurueckgeben(bool nichtmehrmieten)
        {
            if(nichtmehrmieten = true)
            {
                IstVermietet = false;
            }
            else
            {
                Console.WriteLine("Auto ist aktuell leider vermietet");
            }
        }
    }
}