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
    public partial class FormBeszerzettTermekBevitel : FormSajatTermekBevitel
    {
        private bool markaIndexChanged = false;

        public FormBeszerzettTermekBevitel()
        {
            InitializeComponent();
        }
        public FormBeszerzettTermekBevitel(List<Sajat> lista)
        {
            InitializeComponent();
            this.termekek = lista;
        }
        private List<string> importMarka()
        {

            List<string> allLinesText = File.ReadAllLines("marka.txt").ToList();
            Console.WriteLine(allLinesText.Count());
            return allLinesText;
        }
        private void FormBeszerzettTermekBevitel_Load(object sender, EventArgs e)
        {
            kategoriaIndexChanged = false;
            string[] s = Enum.GetNames(typeof(Márka));
            if (importMarka().Count()==0)
            {
                foreach (string item in s)
                {
                    cbMárka.Items.Add(item);
                }
            }
            else
            {
                foreach (string item in importMarka())
                {
                    cbMárka.Items.Add(item);
                }
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

        private void cbMárka_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFelvitel.Enabled = true;
            markaIndexChanged = true;
        }

        private void lblFelirat_Click(object sender, EventArgs e)
        {

        }

        
        private void btnFelvitelBeszerzett_Click(object sender, EventArgs e)
        {
            if (tbTerméknév.Text != String.Empty && cbKategória.SelectedIndex.ToString() != String.Empty && numKiszerelés.Value != 0 && markaIndexChanged && kategoriaIndexChanged)
            {
                Beszerzett t = new Beszerzett(tbTerméknév.Text, cbKategória.SelectedItem.ToString(), (int)numKiszerelés.Value, (int)numÁr.Value, dtpDátum.Value.ToShortDateString(), cbMárka.SelectedItem.ToString());
                using (StreamWriter w = File.AppendText("Termekek.txt"))
                {
                    w.WriteLine(t.FájlMentes());
                    w.Close();
                }
                FormAdminFelület fa = new FormAdminFelület();
                MessageBox.Show("Sikeres adatfelvitel");
            }
            else {
                MessageBox.Show("Hiányzó adatok! Töltsön ki minden mezőt!", "Hibás felvitel!");
            }
        }

        private void cbKategória_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriaIndexChanged = true;
        }
    }
}
