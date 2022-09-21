using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsordasBarna_BeadandoDolgozat
{
    public class Felhasznalo
    {
        string felhasznalonev;
        string jelszo;
        string email;

        public string Mentes()
        {
            return this.felhasznalonev + ";" + this.jelszo;
        }

        public Felhasznalo(string felhasznalonev, string jelszo)
        {
            this.felhasznalonev = felhasznalonev;
            this.jelszo = jelszo;
        }

        //get - set metódusok
        public string Felhasznalonev
        {
            get
            {
                return felhasznalonev;
            }

            set
            {
                felhasznalonev = value;
            }
        }

        public string Jelszo
        {
            get
            {
                return jelszo;
            }

            set
            {
                jelszo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}