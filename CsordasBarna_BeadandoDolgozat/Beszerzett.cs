using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsordasBarna_BeadandoDolgozat
{
    public class Beszerzett:Sajat
    {
        string márka;

        public override string FájlMentes()
        {
            return base.FájlMentes()+";"+this.márka;
        }

        public override string Térköz()
        {
            return base.Térköz()+this.márka.PadRight(15);
        }

        public string Térköz(Beszerzett obj)
        {
            return base.Térköz(obj)+obj.Márka.PadRight(15);
        }
        public override string LegutobbiListabaKiiratas()
        {
            return base.LegutobbiListabaKiiratas()+this.márka.PadRight(15);
        }

        public override string LegutobbiListabaKiiratas(Sajat obj)
        {
            return base.LegutobbiListabaKiiratas(obj)+this.márka.PadRight(15);
        }
        public Beszerzett(string terméknév, string termékkategória, int kiszerelés, int ár, string dátum, string márka):base(terméknév,termékkategória,kiszerelés,ár,dátum)
        {
            this.márka = márka;
        }

        public string Márka
        {
            get
            {
                return márka;
            }

            set
            {
                márka = value;
            }
        }
    }
}