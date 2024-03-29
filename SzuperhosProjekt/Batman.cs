﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Batman : ISzuperhos, IMilliardos
    {

        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public void KutyutKeszit()
        {
            lelemenyesseg += 50;
        }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            Bosszuallo sz = (Bosszuallo)szuperhos;
            if (sz.Szuperero<this.lelemenyesseg*2)
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
            return this.lelemenyesseg;
        }


        public override string ToString()
        {
            return $"Batman: leleményesség: {this.lelemenyesseg}";
        }



    }

}
