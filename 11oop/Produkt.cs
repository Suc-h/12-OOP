using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11oop
{
    class Produkt : Zbozi
    {
        bool lzezlevnit;
        public Produkt(bool zlezlevnit,string nazev, int cena, DateTime datumVyroby, int minTrvanlivost) : base(nazev, cena, datumVyroby, minTrvanlivost)
        {
            this.lzezlevnit = lzezlevnit;
        }

        public override double CenaDPH()
        {
            
            if(Splnuje()==true)
            {
                double cenadphlater = base.CenaDPH() / 100;
                double cenadphnow = cenadphlater * 60;
                return cenadphnow;
            }
           /*else
            {
                double cenadphlater = base.CenaDPH() / 100;
                double cenadphnow = cenadphlater * 60;
                return cenadphnow;
            }*/
            
        }
    }
}
