using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentenAblage
{
    internal class Dokument
    {
        protected int nummer;
        protected DateOnly datum;
        protected Ablageort ort;
        protected Verantwortlicher verantwortlicher;
        protected string beschreibung;

        public Dokument(int nummer, DateOnly datum, string beschreibung, Ablageort ort, Verantwortlicher verantwortlicher)
        {
            this.nummer = nummer;
            this.datum = datum;
            this.beschreibung = beschreibung;
            this.ort = ort;
            this.verantwortlicher = verantwortlicher;
        }
        public void Print()
        {
            Console.WriteLine($"DokumentNr. {nummer} vom {datum}.");
            ort.Print_Ort();
            verantwortlicher.Print_Verantwortlicher();
        }
        
    }
}
