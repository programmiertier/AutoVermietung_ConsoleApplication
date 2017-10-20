using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutoVermietung_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug desAudoMagIch = new Fahrzeug(true, true, "Blau", "K-MH-120");
            Fahrzeug audo2 = new Fahrzeug(true, false, "Pissgelb", "RO-FL-1");
            Fahrzeug audo3 = new Fahrzeug(false, false, "Speigrün", "TÖL-Z-45");
            Fahrzeug audo4 = new Fahrzeug(false, true, "Magenta", "M-UH-300");
            Fahrzeug audo5 = new Fahrzeug(true, true, "Grellorange", "NÖ-RD-120");
            Fahrzeug audo6 = new Fahrzeug(true, true, "Black", "DON-ER-120");

            ReadLine();
            Parkplatz daHintenUmDieEcke = new Parkplatz();
            daHintenUmDieEcke.hinstellen(desAudoMagIch);

            WriteLine("Auf dem Parkplatz Nummer 9 steht ein {0}es Fahrzeug", desAudoMagIch.farbe);
            WriteLine("Das Kennzeichen ist: {0}", daHintenUmDieEcke.hierwirdgeparkt[9].woisserher);
            ReadLine();
        }
    }
}
