using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormSajatTermekBevitel : Form
    {
        protected List<Sajat> termekek;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public FormSajatTermekBevitel()
        {
            InitializeComponent();
            //form oldalainak kerekítése (formázás)
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }
        public FormSajatTermekBevitel(List<Sajat>lista)
        {
            InitializeComponent();
            this.termekek = lista;
        }

        private void FormSajatTermekBevitel_Load(object sender, EventArgs e)
        {
            string[] s = Enum.GetNames(typeof(Kategória));
            foreach (string item in s)
            {
                cbKategória.Items.Add(item);
            }
        }

        private void btnMégsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {            
            Sajat t = new Sajat(tbTerméknév.Text, cbKategória.SelectedItem.ToString(), (int)numKiszerelés.Value, (int)numÁr.Value, dtpDátum.Value.ToShortDateString());
            termekek.Add(t);
        }

        private void cbKategória_SelectedIndexChanged(object sender, EventArgs e)
        {
                btnFelvitel.Enabled = true;
            
        }

        private void tbTerméknév_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numKiszerelés_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numÁr_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
