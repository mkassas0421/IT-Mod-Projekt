using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsordasBarna_BeadandoDolgozat
{
    class TermekFelelos:Felhasznalo
    {
        private int felvittTermekek; //szamolja hany termeket vitt fel a rendszerbe az adott TermekFelelos


        //KONSTRUKTOROK
        public TermekFelelos(string felhasznalonev,string jelszo,int felvittTermekek):base(felhasznalonev,jelszo)
        {
            this.felvittTermekek = felvittTermekek;
        }
        
        //GET-SET metódusok
        public int FelvittTermekek
        {
            get
            {
                return felvittTermekek;
            }
            set
            {
                //TODO változó eggyel növelésse, ha növekszik a terméklista eggyel
                felvittTermekek = value;
            }
        }
        
        //METÓDUSOK
        protected override string Mentes()
        {
            return this.felhasznalonev + ";" + this.felvittTermekek;
        }

        
    }
}
