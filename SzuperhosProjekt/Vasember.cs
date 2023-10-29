using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {

        static Random rand = new Random();


        public Vasember() : base(150, true) { }
        


        

        public void KutyutKeszit()
        {
            
            
            double ero = rand.NextDouble() *10;
            Szuperero += ero;
        }

        public override bool MegmentiAVilagot()
        {
            if (Szuperero>1000)
            {
                return true;
            }
            else
            {
               return false;
            }
            
            
        }


        public override string ToString()
        {
            return "Vasember: " + base.ToString();
        }
    }
}
