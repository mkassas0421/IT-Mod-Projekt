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
using System.Runtime.InteropServices;

namespace CsordasBarna_BeadandoDolgozat
{
    public partial class FormRegisztráció : Form
    {
        protected List<Felhasznalo> lista;
        //public FormRegisztráció()
        //{
        //    InitializeComponent();
        //}

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



        public FormRegisztráció(List<Felhasznalo> felhasznalolista)
        {
            InitializeComponent();
            this.lista = felhasznalolista;

            //form oldalainak kerekítése (formázás)
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbJelszo.Text.Equals(tbUjra.Text)&& tbFelhasznalo.Text!=String.Empty && tbJelszo.Text!=String.Empty && tbEmail.Text!=String.Empty && tbFelhasznalo.Text != "Felhasználónév" && tbJelszo.Text != "Jelszó" && tbUjra.Text != "Jelszó újra" && tbEmail.Text != "Email")
            {
                Felhasznalo felhasznalo = lista.Find(x => x.Felhasznalonev.Equals(tbFelhasznalo.Text));
                if (felhasznalo !=null)
                {
                    MessageBox.Show("A megadott felhasználónévvel már létezik felhasználó!");
                    //tbFelhasznalo.Clear();
                }
                else
                {
                Felhasznalo f = new Felhasznalo(tbFelhasznalo.Text, tbJelszo.Text);
                lista.Add(f);

                lbMegegyeznek.Visible = true;
                btnBelépés.Visible = true;
                    //tbFelhasznalo.Clear();
                    //tbJelszo.Clear();
                    //tbUjra.Clear();
                    //tbEmail.Clear();
                    MessageBox.Show("Sikeres regisztráció");
                 
                StreamWriter wr = new StreamWriter("Regisztraltak.txt", true, Encoding.UTF8);
                wr.WriteLine(f.Mentes());
                wr.Close();
                }
            }
            else
            {
                if (tbFelhasznalo.Text == String.Empty || tbJelszo.Text == String.Empty || tbUjra.Text == String.Empty || tbEmail.Text == String.Empty || tbFelhasznalo.Text == "Felhasználónév" || tbJelszo.Text == "Jelszó" || tbUjra.Text == "Jelszó újra" || tbEmail.Text == "Email")
                {
                    MessageBox.Show("Töltsön ki minden mezőt!");
                }
                else {
                    //btnBelépés.Visible = false;
                    lbNemegyeznek.Visible = true;
                    tbJelszo.Clear();
                    tbUjra.Clear();
                    MessageBox.Show("Sikertelen regisztráció");
                }
                
            }
        }

        private void btnBelépés_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbJelszo_TextChanged(object sender, EventArgs e)
        {
            if (tbJelszo.Text.Equals("Jelszó"))
            {
                tbJelszo.PasswordChar = '\0';
            }
        }

        private void tbJelszo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 && tbJelszo.Text == String.Empty || tbJelszo.Text.Equals("Jelszó")))
            {
                tbJelszo.PasswordChar = '*';
            }

            lbMegegyeznek.Visible = false;
            lbNemegyeznek.Visible = false;
        }

        private void tbFelhasznalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbMegegyeznek.Visible = false;
            btnBelépés.Visible = false;

        }

        private void rdr(object sender, EventArgs e)
        {

        }

        private void FormRegisztráció_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFelhasznalo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFelhasznalo_Click(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            if (tbFelhasznalo.Text!=String.Empty && tbFelhasznalo.Text.Equals("Felhasználónév")) {
                tbFelhasznalo.Clear();
            }
            if (tbJelszo.Text == String.Empty) {
                tbJelszo.Text ="Jelszó";
            }
            if (tbUjra.Text == String.Empty)
            {
                tbUjra.Text = "Jelszó újra";
            }
            if (tbEmail.Text == String.Empty)
            {
                tbEmail.Text = "Email";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbJelszo_Click(object sender, EventArgs e)
        {
            lbNemegyeznek.Visible = false;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            if (tbJelszo.Text != String.Empty && tbJelszo.Text.Equals("Jelszó"))
            {
                tbJelszo.Clear();
            }
            if (tbFelhasznalo.Text == String.Empty)
            {
                tbFelhasznalo.Text = "Felhasználónév";
            }
            if (tbUjra.Text == String.Empty)
            {
                tbUjra.Text = "Jelszó újra";
            }
            if (tbEmail.Text == String.Empty)
            {
                tbEmail.Text = "Email";
            }
        }

        private void tbUjra_Click(object sender, EventArgs e)
        {
            lbNemegyeznek.Visible = false;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            if (tbUjra.Text != String.Empty && tbUjra.Text.Equals("Jelszó újra"))
            {
                tbUjra.Clear();
            }
            if (tbFelhasznalo.Text == String.Empty)
            {
                tbFelhasznalo.Text = "Felhasználónév";
            }
            if (tbJelszo.Text == String.Empty)
            {
                tbJelszo.Text = "Jelszó";
            }
            if (tbEmail.Text == String.Empty)
            {
                tbEmail.Text = "Email";
            }
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            if (tbEmail.Text != String.Empty && tbEmail.Text.Equals("Email"))
            {
                tbEmail.Clear();
            }
            if (tbFelhasznalo.Text == String.Empty)
            {
                tbFelhasznalo.Text = "Felhasználónév";
            }
            if (tbUjra.Text == String.Empty)
            {
                tbUjra.Text = "Jelszó újra";
            }
            if (tbJelszo.Text == String.Empty)
            {
                tbJelszo.Text = "Jelszó";
            }
        }

        private void btnBelépés_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbUjra_TextChanged(object sender, EventArgs e)
        {
            if (tbUjra.Text.Equals("Jelszó újra"))
            {
                tbUjra.PasswordChar = '\0';
            }
        }

        private void tbUjra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 && tbUjra.Text == String.Empty || tbUjra.Text.Equals("Jelszó újra")))
            {
                tbUjra.PasswordChar = '*';
            }
        }

        private void tbFelhasznalo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                tbJelszo.TabStop = true;
                tbJelszo.Clear();
                SendKeys.Send("{Tab}");
                panel1.BackColor = Color.WhiteSmoke;
                panel3.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.FromArgb(78, 184, 206);
                panel4.BackColor = Color.WhiteSmoke;
            }
        }

        private void tbJelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                tbUjra.TabStop = true;
                tbUjra.Clear();
                SendKeys.Send("{Tab}");
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.WhiteSmoke;
                panel3.BackColor = Color.FromArgb(78, 184, 206);
                panel4.BackColor = Color.WhiteSmoke;
            }
        }

        private void tbUjra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                tbEmail.TabStop = true;
                tbEmail.Clear();
                SendKeys.Send("{Tab}");
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.WhiteSmoke;
                panel4.BackColor = Color.FromArgb(78, 184, 206);
                panel3.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
