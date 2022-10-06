using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsordasBarna_BeadandoDolgozat
{
    public class Admin:Felhasznalo
    {
        //KONSTRUKTOROK
        public Admin(string felhasznalonev, string jelszo):base(felhasznalonev,jelszo)
        {
            this.felhasznalonev = felhasznalonev;
            this.jelszo = jelszo;
        }
        public Admin() { }

        //GET-SET metódusok
        public string Felhasznalonev { get; set; }
        public string Jelszo { get; set; }

    }
}
