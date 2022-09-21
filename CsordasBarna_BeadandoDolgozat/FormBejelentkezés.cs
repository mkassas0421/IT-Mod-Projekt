using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormBejelentkezés : Form
    {
        List<Felhasznalo> felhasznalolista = new List<Felhasznalo>();
        
        //form oldalainak kerekítése (formázás)
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


        public FormBejelentkezés()
        {
            InitializeComponent();
            //form oldalainak kerekítése (formázás)
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            if (File.Exists("Regisztraltak.txt"))
            {
                StreamReader rd = new StreamReader("Regisztraltak.txt", Encoding.UTF8);
                while (!rd.EndOfStream)
                {
                    string[] s = rd.ReadLine().Split(';');
                    Felhasznalo f = new Felhasznalo(s[0],s[1]);
                    felhasznalolista.Add(f);
                }
                rd.Close();
            }
        }       

        private void btnMégsem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Figyelem!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbRegisztrálok_Click(object sender, EventArgs e)
        {
            tbFelhasznalonev.Clear();
            tbJelszo.Clear();

            FormRegisztráció frm = new FormRegisztráció(felhasznalolista);
            frm.ShowDialog();
        }

        //private void closeform() {
        //    this.Close();
        //}

        private void btnBelépés_Click(object sender, EventArgs e)
        {
            Felhasznalo f = felhasznalolista.Find(x => x.Felhasznalonev.Equals(tbFelhasznalonev.Text) && x.Jelszo.Equals(tbJelszo.Text));
            if (f!=null)
            {                
                tbFelhasznalonev.Clear();
                tbJelszo.Clear();
                //closeform();
                this.Hide();
                FormFelhasznaloFelulet frm = new FormFelhasznaloFelulet();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó");
                tbFelhasznalonev.Clear();
                tbJelszo.Clear();
                tbFelhasznalonev.Text = "Felhasználónév";
                 tbJelszo.Text = "Jelszó";
                
                this.DialogResult= DialogResult.Cancel;
            }
        }

        private void lbAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin frm = new FormAdmin();
            frm.ShowDialog();

            //this.Hide();
            //FormAdmin form = new FormAdmin();
            //form.FormClosed += (s, args) => this.Close();
            //form.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbFelhasznalonev_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormBejelentkezés_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.Empty;
        }

        private void tbJelszo_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void tbJelszo_Click(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            if (tbJelszo.Text != String.Empty && tbJelszo.Text.Equals("Jelszó"))
            {
                tbJelszo.Clear();
            }          
            if (tbFelhasznalonev.Text == String.Empty)
            {
                tbFelhasznalonev.Text = "Felhasználónév";
            }
        }

        private void tbFelhasznalonev_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.WhiteSmoke;

            if (tbFelhasznalonev.Text != String.Empty && tbFelhasznalonev.Text.Equals("Felhasználónév"))
            {
                tbFelhasznalonev.Clear();
            }

            
            if (tbJelszo.Text == String.Empty)
            {
                tbJelszo.Text = "Jelszó";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFelhasznalonev.Clear();
            tbJelszo.Clear();
            tbFelhasznalonev.Text = "Felhasználónév";
            tbJelszo.Text = "Jelszó";

            FormRegisztráció frm = new FormRegisztráció(felhasznalolista);
            frm.ShowDialog();
        }

        private void lblX_Click(object sender, EventArgs e)
        {          
            this.Close();
        }


        private void tbJelszo_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!(e.KeyChar == 8 && tbJelszo.Text==String.Empty || tbJelszo.Text.Equals("Jelszó"))) {
                tbJelszo.PasswordChar = '*';
            }
        }

        private void TbJelszo_TextChanged(object sender, EventArgs e)
        {
            if (tbJelszo.Text.Equals("Jelszó")) {
                tbJelszo.PasswordChar = '\0';
            }
        }

        private void tbFelhasznalonev_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.Equals(Keys.Enter)) {
            //    tbJelszo_Click;
            //}
        }

        private void tbFelhasznalonev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter || e.KeyData == Keys.Tab) {
                tbJelszo.TabStop = true;
                tbJelszo.Clear();
                SendKeys.Send("{Tab}");
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.FromArgb(78, 184, 206);
            }
        }

        private void tbJelszo_TabStopChanged(object sender, EventArgs e)
        {
        }

        private void tbJelszo_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbJelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData==Keys.Tab)
            {

                SendKeys.Send("{Tab}");
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.WhiteSmoke;
            }
        }


    }
}
