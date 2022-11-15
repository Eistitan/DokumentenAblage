using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentenAblage
{
    internal class Verantwortlicher
    {
        protected string vorname;
        protected string nachname;
        protected string abteilung;
        protected string buero_nummer;

        public Verantwortlicher(string vorname, string nachname, string abteilung, string buero_nummer)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.abteilung = abteilung;
            this.buero_nummer = buero_nummer;
        }

        public Verantwortlicher GetV() //Übergabe der protected Felder an andere Klassen
        {
            return new Verantwortlicher(vorname, nachname, abteilung, buero_nummer);
        }

        public void Print_Verantwortlicher()
        {
            Console.WriteLine($"Die verantwortliche Person ist {vorname} {nachname} aus der Abteilung {abteilung}, Raum {buero_nummer}. ");
        }
    }
}
