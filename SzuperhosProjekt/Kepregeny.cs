using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

        public static void Beolv ( string filename)
        {
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                
                string[] darabok = sr.ReadLine().Split(' ');
                int kutyu = Convert.ToInt32(darabok[1]);
                if (darabok[0] == "Vasember")
                {
                    Vasember vas = new Vasember();
                    for (int i = 0; i < kutyu; i++)
                    {
                        vas.KutyutKeszit();
                    }
                    szuperhosok.Add(vas);
                }
                else
                {
                    Batman bat = new Batman();
                    for (int i = 0; i < kutyu; i++)
                    {
                        bat.KutyutKeszit();
                    }
                    szuperhosok.Add(bat);
                }



            }
            
        }

        public static void Szuperhosok()
        {
            for (int i = 0; i < szuperhosok.Count; i++)
            {
                Console.WriteLine(szuperhosok[i]);
            }
        }

    }
}
