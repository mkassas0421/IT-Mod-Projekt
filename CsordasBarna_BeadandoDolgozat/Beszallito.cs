using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsordasBarna_BeadandoDolgozat
{
    class Beszallito
    {
        private string nev;
        private int beszerzettTermekek;    //ettől a beszállítótól származó termékek száma
        private string felvetelDatum;      //partnerség kezdete
                        

        //KONSTRUKTOROK
        public Beszallito(int beszerzettTermekek, string felvetelDatum, string nev)
        {
            this.beszerzettTermekek = beszerzettTermekek;
            this.felvetelDatum = felvetelDatum;
            this.nev = nev;
        }
        public Beszallito() { }

        //GET-SET metódusok 
        public int BeszerzettTermekek
        {
            get
            {
                return beszerzettTermekek;
            }

            set
            {
                beszerzettTermekek = value;
            }
        }
        public string FelvetelDatum
        {
            get
            {
                return felvetelDatum;
            }

            set
            {
                felvetelDatum = value;
            }
        }
        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }
    }
}
