using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsordasBarna_BeadandoDolgozat
{
    class Kosar
    {
        private int termekDarab;
        private int osszeg;
        Felhasznalo felhasznalo;
        List<Sajat> kosarLista; //hogy lesz benne Beszerzett termek?

        //KONSTRUKTOROK
        public Kosar(int termekDarab, int osszeg, Felhasznalo felhasznalo, List<Sajat> kosarLista)
        {
            this.termekDarab = termekDarab;
            this.osszeg = osszeg;
            this.felhasznalo = felhasznalo;
            this.kosarLista = kosarLista;
        }

        //GET-SET metódusok
    }
}
