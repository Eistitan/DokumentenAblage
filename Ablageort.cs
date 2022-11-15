using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DokumentenAblage
{
    internal class Ablageort
    {
        protected string stockwerk;
        protected string raumnummer;
        protected string regalnummer;
        protected string fach;

        public Ablageort(string stockwerk, string raumnummer, string regalnummer, string fach)
        {
            this.stockwerk = stockwerk;
            this.raumnummer = raumnummer;
            this.regalnummer = regalnummer;
            this.fach = fach;
        }   
        
        public void Print_Ort()
        {
            Console.WriteLine($"Das Dokument befindet sich im Raum {raumnummer}({stockwerk}), Regal {regalnummer}, Fach {fach}.");
        }
    }
}
