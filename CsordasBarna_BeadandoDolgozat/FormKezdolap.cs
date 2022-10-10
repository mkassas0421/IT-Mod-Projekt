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
    public partial class FormKezdolap : Form
    {
        public FormKezdolap()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKezdolap_Load(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                StreamReader rd = new StreamReader("Regisztraltak.txt", Encoding.UTF8);
                while (!rd.EndOfStream)
                {
                    rd.ReadLine();
                    count++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült a termékek beolvasása a Regisztraltak.txt fájlból!");
                throw;
            }
            string s = count.ToString();
            lblOsszesVasarlo.Text = s;
        }
    }
}
