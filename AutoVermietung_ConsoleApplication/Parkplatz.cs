using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutoVermietung_ConsoleApplication
{
    class Parkplatz
    {
        public Fahrzeug[] hierwirdgeparkt = new Fahrzeug[10];
        public void hinstellen(Fahrzeug audo)
        {
            int zaehler = hierwirdgeparkt.Length - 1;
            WriteLine("Fahrzeug wird gestellt auf Platz {0}",zaehler);
            hierwirdgeparkt[zaehler] = audo;
        }
    }
}
