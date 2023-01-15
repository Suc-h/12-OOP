using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public virtual double CenaDPH()
        {
            

            return (Convert.ToDouble(cena) / 100) * 121;
        }

        public override string ToString()
        {
            if (Splnuje() == false)
            {
                return nazev + "s datumem výroby:" + datumVyroby + "s cenou: " + cena + " s cenou s DPH: " + CenaDPH() + " nesplňuje minimální trvanlivost ";
            }
            else
            {
                return nazev + "s datumem výroby: " + datumVyroby + " s cenou: " + cena + "kč s cenou s DPH: " + CenaDPH() + "kč  splňuje minimální trvanlivost! ";
            }
        }
    }
}
