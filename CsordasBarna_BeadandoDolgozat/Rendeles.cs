using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsordasBarna_BeadandoDolgozat
{
    public class Rendeles
    {
        string dátum;
        string név;
        string fizetés;

        public Rendeles(string dátum, string név, string fizetés)
        {
            this.dátum = dátum;
            this.név = név;
            this.fizetés = fizetés;
        }

        public string Dátum
        {
            get
            {
                return dátum;
            }

            set
            {
                dátum = value;
            }
        }

        public string Név
        {
            get
            {
                return név;
            }

            set
            {
                név = value;
            }
        }

        public string Fizetés
        {
            get
            {
                return fizetés;
            }

            set
            {
                fizetés = value;
            }
        }
    }
}