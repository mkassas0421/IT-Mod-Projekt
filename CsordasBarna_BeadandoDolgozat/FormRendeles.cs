using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormRendeles : Form
    {
        public FormRendeles()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormRendeles_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMégsem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan megszakítja a rendelést?","Figyelem!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbFizetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbNev.Text!=String.Empty)
            {
                btnMegrendelem.Enabled = true;
            }         
        }

        private void btnMegrendelem_Click(object sender, EventArgs e)
        {
            Rendeles r = new Rendeles(DateTime.Now.ToLongDateString(), tbNev.Text, cbFizetes.SelectedItem.ToString());
            StreamWriter wr = new StreamWriter("Rendelesek.txt", true, Encoding.UTF8);
            wr.WriteLine(r.Dátum + ";" + r.Név + ";" + r.Fizetés);
            wr.Close();
            MessageBox.Show("Sikeres fizetés");
            this.Close();
        }
    }
}
