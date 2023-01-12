using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11oop
{
    class Zbozi
    {
        string nazev;
        int cena;
        DateTime datumVyroby;
        int minTrvanlivost;

        public Zbozi(string nazev, int cena, DateTime datumVyroby, int minTrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumVyroby = datumVyroby;
            this.minTrvanlivost = minTrvanlivost;
        }

        public bool Splnuje()
        {
            TimeSpan dny = DateTime.Now - datumVyroby;
            if (dny.TotalDays > minTrvanlivost)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public virtual double CenaDPH()
        {
            double a = cena / 100;
            double cenadph = a * 121;
            return cenadph;
        }

        public override string ToString()
        {
            if (Splnuje() == true)
            {
                return nazev + "s datumem výroby:" + datumVyroby + "s cenou: " + cena + " s cenou s DPH: " + CenaDPH() + " nesplňuje minimální trvanlivost ";
            }
            else
            {
                return nazev + "s datumem výroby:" + datumVyroby + "s cenou: " + cena + " s cenou s DPH: " + CenaDPH() + " splňuje minimální trvanlivost ";
            }
        }
    }
}
