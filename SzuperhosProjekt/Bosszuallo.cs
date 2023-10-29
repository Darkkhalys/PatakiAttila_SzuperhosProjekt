using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }


        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        

        public abstract bool MegmentiAVilagot();

        public bool LegyoziE(ISzuperhos szuperhos) 
        {
            if (szuperhos.GetType()==typeof(Bosszuallo) )
            {
                Bosszuallo sz = (Bosszuallo)szuperhos;

                if (szuperhos.MekkoraAzEreje() < this.szuperero && sz.vanEGyengesege)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (this.szuperero >= szuperhos.MekkoraAzEreje() * 2 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double MekkoraAzEreje()
        {
            return this.szuperero;
        }


        public override string ToString()
        {
            return $"Szupererő: {this.szuperero}; {(this.vanEGyengesege ?"van gyengesége" : "nincs gyengesége")}";
        }
    }
}
