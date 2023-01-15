using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11oop
{
    class Produkt : Zbozi
    {
        int lzezlevnit;
        public Produkt(int zlezlevnit,string nazev, int cena, DateTime datumVyroby, int minTrvanlivost) : base(nazev, cena, datumVyroby, minTrvanlivost)
        {
            this.lzezlevnit = zlezlevnit;
        }

        public override double CenaDPH()
        {
            if(lzezlevnit==1)
            {

           
                if(Splnuje()==true)
                {
                    
                 return (base.CenaDPH() / 100) * 60;
             
                }
                else
                {
                return base.CenaDPH();
                }
            }
            else
            {
                return base.CenaDPH();
            }

        }
    }
}
