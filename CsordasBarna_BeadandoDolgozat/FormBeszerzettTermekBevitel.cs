using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormBeszerzettTermekBevitel : FormSajatTermekBevitel
    {
        public FormBeszerzettTermekBevitel()
        {
            InitializeComponent();
        }
        public FormBeszerzettTermekBevitel(List<Sajat> lista)
        {
            InitializeComponent();
            this.termekek = lista;
        }

        private void FormBeszerzettTermekBevitel_Load(object sender, EventArgs e)
        {
            string[] s = Enum.GetNames(typeof(Márka));
            foreach (string item in s)
            {
                cbMárka.Items.Add(item);
            }
            if (cbKategória.Items.Count!=5)
            {
                cbKategória.Items.Clear();
                string[] t = Enum.GetNames(typeof(Kategória));
                foreach (string item in t)
                {
                    cbKategória.Items.Add(item);
                }
            }
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            Beszerzett t = new Beszerzett(tbTerméknév.Text, cbKategória.SelectedItem.ToString(), (int)numKiszerelés.Value, (int)numÁr.Value, dtpDátum.Value.ToShortDateString(), cbMárka.SelectedItem.ToString());
            termekek.Add(t);
        }

        private void cbMárka_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFelvitel.Enabled = true;
        }

        private void lblFelirat_Click(object sender, EventArgs e)
        {

        }
    }
}
