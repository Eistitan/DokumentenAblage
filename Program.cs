namespace DokumentenAblage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch2();
        }
       
        static int Eingabe() //Eingabe der Zahl
        {
            int wahl = 0;
            bool check;
            Console.WriteLine("Daten: 13517, 17742, 14521, 23517, 24747\n");
            do
            {
                Console.WriteLine("Dokument Nummer wählen:");
                check = int.TryParse(Console.ReadLine(), out wahl);
                if (!check)
                    Console.WriteLine("Nur die Ziffern eingeben.\n");
                if (check==false )
                    Console.WriteLine("Sie haben sich verklickt.\n");
            } while (!check);
            return wahl;
        }
        static void Switch2()
        {
            Verantwortlicher v1 = new("Kaln", "Brauer", "Kosten-K15", "K135");
            Verantwortlicher v2 = new("Anna", "Montana", "Support-S1", "S35");
            Verantwortlicher v3 = new("Albert", "von Abundzu", "Management-R6", "M96");


            int wahl =Eingabe();
            switch (wahl)
            {
                case 13517:
                    Dokument d1 = new(13517, new DateOnly(2020, 10, 15), "Abrechnung m-221",
                new Ablageort("B12", "B124", "A53", "M4"), v1);
                    d1.Print();
                    break;
                case 17742:
                    Dokument d2 = new(17742, new DateOnly(2017, 1, 24), "Abrechnung ak-12",
                new Ablageort("B15", "B155", "A3", "K1"), v1);
                    d2.Print();
                    break;
                case 14521:
                    Dokument d3 = new(14521, new DateOnly(2022, 5, 25), "Support-Protokoll si-12",
                new Ablageort("B07", "B77", "C19", "A6"), v2);
                    d3.Print();
                    break;
                case 23517:
                    Dokument d4 = new(23517, new DateOnly(2021, 7, 18), "Support-Protokoll si-81",
               new Ablageort("B07", "B76", "L52", "K2"), v2);
                    d4.Print();
                    break;
                case 24747:
                    Dokument d5 = new(24747, new DateOnly(2019, 2, 11), "Besprechung b-74",
                new Ablageort("B02", "B22", "M8", "M12"), v3);
                    d5.Print();
                    break;
                default:
                    Console.WriteLine("Dokument mit dieser Nummer existiert nicht.");
                    break;
            }
        }
    }
}