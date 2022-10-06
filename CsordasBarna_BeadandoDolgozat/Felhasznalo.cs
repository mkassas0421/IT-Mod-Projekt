using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsordasBarna_BeadandoDolgozat
{
    public class Felhasznalo

    {
        //változók
        private string email;
        private string lakcim;
        private string teljesNev;

        protected string felhasznalonev;
        protected string jelszo;

        //KONSTRUKTOROK
        public Felhasznalo() { }
        public Felhasznalo(string felhasznalonev, string jelszo)
        {
            this.felhasznalonev = felhasznalonev;
            this.jelszo = jelszo;
        }

        public Felhasznalo(string email, string lakcim, string teljesNev, string felhasznalonev, string jelszo)
        {
            this.email = email;
            this.lakcim = lakcim;
            this.teljesNev = teljesNev;
            this.felhasznalonev = felhasznalonev;
            this.jelszo = jelszo;
        }

        //GET-SET metódusok
        public string Email { get; set; }
        public string Lakcim { get; set; }

        public string TeljesNev { get; set; }

        //METÓDUSOK
        protected virtual string Mentes()
        {
            return this.teljesNev+";"+this.felhasznalonev + ";" + this.jelszo+";"+this.email+";"+this.lakcim;
        }

        
    }
}