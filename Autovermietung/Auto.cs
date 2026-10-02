namespace Autovermietung
{
    public class Auto
    {
        public string? Marke {get; private set;}
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
        
        public void vermieten()
        {
            
        }

        public void zurueckgeben()
        {
            
        }
    }
}