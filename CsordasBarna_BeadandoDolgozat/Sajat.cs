using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsordasBarna_BeadandoDolgozat
{
    public class Sajat
    {
        string terméknév;
        string termékkategória;
        int kiszerelés;
        int ár;
        string dátum;

        public virtual string FájlMentes()
        {
            return this.terméknév + ";" + this.termékkategória + ";" + this.kiszerelés.ToString() + ";" + this.ár.ToString() + ";" + this.dátum;
        }

        public virtual string Térköz()
        {
            string s = this.terméknév.PadRight(20) + this.termékkategória.PadRight(20) + (this.kiszerelés + " g").PadRight(15) + (this.ár + " Ft").PadRight(15) + this.dátum.PadRight(20);
            return s;
        }

        public virtual void Courier(System.Windows.Forms.ListView lv, String s)
        {
            lv.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Regular);
            lv.Items.Add(s);
        }

        public Sajat(string terméknév, string termékkategória, int kiszerelés, int ár, string dátum)
        {
            this.terméknév = terméknév;
            this.termékkategória = termékkategória;
            this.kiszerelés = kiszerelés;
            this.ár = ár;
            this.dátum = dátum;
        }

        public string Terméknév
        {
            get
            {
                return terméknév;
            }

            set
            {
                terméknév = value;
            }
        }

        public string Termékkategória
        {
            get
            {
                return termékkategória;
            }

            set
            {
                termékkategória = value;
            }
        }

        public int Kiszerelés
        {
            get
            {
                return kiszerelés;
            }

            set
            {
                kiszerelés = value;
            }
        }

        public int Ár
        {
            get
            {
                return ár;
            }

            set
            {
                ár = value;
            }
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
    }
}