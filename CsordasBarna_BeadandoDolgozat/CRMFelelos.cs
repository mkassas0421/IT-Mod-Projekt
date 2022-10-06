using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsordasBarna_BeadandoDolgozat
{
    class CRMFelelos:Felhasznalo
    {
        private int lekerdezesSzam; //tarolja a lekérdezések, összesítések számát

        
        //KONSTRUKTOROK
        public CRMFelelos(string felhasznalonev,string jelszo,int lekerdezesSzam):base(felhasznalonev,jelszo)
        {
            this.LekerdezesSzam = lekerdezesSzam;
        }

        //GET-SET metódusok
        public int LekerdezesSzam
        {
            get
            {
                return lekerdezesSzam;
            }

            set
            {
                //TODO eggyel növelni az értékét, ha keszit ujabb lekerdezest?
                lekerdezesSzam = value;
            }
        }

        //METÓDUSOK
        public override string Mentes()
        {
            return this.felhasznalonev + ";" + this.lekerdezesSzam;
        }

        
    }
}
