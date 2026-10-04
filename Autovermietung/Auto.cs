using System.Runtime.InteropServices;

namespace Autovermietung
{
    public class Auto
    {
        public string? Marke {get; private set;}
        public double PreisProTag {get; private set;}
        public string? Modell {get; private set;}
        public string? Kennzeichen {get; private set;}
        public bool? IstVermietet {get; private set;}

        public Auto(string marke, string modell, string kennzeichen, bool istvermietet, double preisProTag = 0)
        {
            Marke = marke;
            Modell = modell;
            Kennzeichen = kennzeichen;
            IstVermietet = istvermietet;
            PreisProTag = preisProTag;
        }
        
        public bool mieten()
        {
            if (IstVermietet == true)
            {
                Console.WriteLine("Auto schon vermietet");
                return false;
            }

            IstVermietet = true;
            return true;
        }

        /// <summary>
        /// Call this method to give a car back.
        /// this method checks if a car is rented out and if it is not rented out the method return false and a consolewriteline.
        /// But if this case gets skipped it sets IstVermietet to false and returns true.
        /// </summary>
        /// <returns>returns true if not rented out else false</returns>
        public bool zurueckgeben() 
        {
            if (IstVermietet == false)
            {
                Console.WriteLine("Auto ist nicht vermietet");
                return false;
            }
            IstVermietet = false;
            return true;
        }
    }
}