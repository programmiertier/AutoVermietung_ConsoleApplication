using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutoVermietung_ConsoleApplication
{
    class Fahrzeug
    {
        public bool hamsterjohannes;
        public bool ledersitze;
        public string farbe;
        public string woisserher;

        public Fahrzeug(bool h, bool l, string fa, string wih)
        {
            hamsterjohannes = h;
            ledersitze = l;
            farbe = fa;
            woisserher = wih;
            // WriteLine("Hamsterjohannes: {0}\tLedersitze: {1}\t Farbe: {2}\tWoIsserHer: {3}", h, l, fa, wih);
            WriteLine("Audo mit {0:10} steht am Hof", wih);
        }
    }
}
