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
    public partial class FormAdmin : Form
    {
        List<Felhasznalo> adminLista = new List<Felhasznalo>();   //belépéshez felhasznalonev és jelszo : admin/admin az Admin.txt-ben tárolódik 
        List<Felhasznalo> termekFelelosLista = new List<Felhasznalo>(); //belépéshez felhasznalonev és jelszo : termek/termek az TermekFelelos.txt-ben tárolódik
        List<Felhasznalo> crmFelelosLista = new List<Felhasznalo>(); //belépéshez felhasznalonev és jelszo : crm/crm az CRMFelelos.txt-ben tárolódik

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


        public FormAdmin()
        {
            InitializeComponent();

            //form oldalainak kerekítése (formázás)
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void btnBelépés_Click(object sender, EventArgs e)
        {
            tbAdmin.Clear();
            tbAdminJelszo.Clear();
            if (radiobtnAdmin.Checked) {
                Felhasznalo admin = adminLista.Find(x => x.Felhasznalonev.Equals(tbAdmin.Text) && x.Jelszo.Equals(tbAdminJelszo.Text));
                if (admin != null)
                {
                    tbAdminJelszo.Clear();
                    tbAdmin.Clear();
                    FormAdminFelület frm = new FormAdminFelület();
                    frm.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Sikertelen belépés az admin felületre!");
                    tbAdmin.Text = "Azonosító";
                    tbAdminJelszo.Text = "Jelszó";
                }
            }
            else if (radiobtnTermek.Checked)
            {
                Felhasznalo termekFelelos = termekFelelosLista.Find(x => x.Felhasznalonev.Equals(tbAdmin.Text) && x.Jelszo.Equals(tbAdminJelszo.Text));
                if (termekFelelos != null)
                {
                    
                    tbAdminJelszo.Clear();
                    tbAdmin.Clear();
                    FormTermekFelelos frm = new FormTermekFelelos();
                    frm.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Sikertelen belépés a termékek felületére!");
                    tbAdmin.Text = "Azonosító";
                    tbAdminJelszo.Text = "Jelszó";
                }
            }
            else
            {
                Felhasznalo crmFelelos = crmFelelosLista.Find(x => x.Felhasznalonev.Equals(tbAdmin.Text) && x.Jelszo.Equals(tbAdminJelszo.Text));
                if (crmFelelos != null)
                {
                    
                    tbAdminJelszo.Clear();
                    tbAdmin.Clear();
                    FormCRMFelelos frm = new FormCRMFelelos();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sikertelen belépés a CRM felületére!");
                    tbAdmin.Text = "Azonosító";
                    tbAdminJelszo.Text = "Jelszó";
                }
            }


        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (File.Exists("Admin.txt"))
            {
                StreamReader rd = new StreamReader("Admin.txt", Encoding.UTF8);
                while (!rd.EndOfStream)
                {
                    string[] s = rd.ReadLine().Split(';');
                    Felhasznalo admin = new Felhasznalo(s[0], s[1]);
                    adminLista.Add(admin);
                }
                rd.Close();
            }
            if (File.Exists("TermekFelelos.txt"))
            {
                StreamReader rd = new StreamReader("TermekFelelos.txt", Encoding.UTF8);
                while (!rd.EndOfStream)
                {
                    string[] s = rd.ReadLine().Split(';');
                    Felhasznalo termekfelelos = new Felhasznalo(s[0], s[1]);
                    termekFelelosLista.Add(termekfelelos);
                }
                rd.Close();
            }
            if (File.Exists("CRMFelelos.txt"))
            {
                StreamReader rd = new StreamReader("CRMFelelos.txt", Encoding.UTF8);
                while (!rd.EndOfStream)
                {
                    string[] s = rd.ReadLine().Split(';');
                    Felhasznalo crmfelelos = new Felhasznalo(s[0], s[1]);
                    crmFelelosLista.Add(crmfelelos);
                }
                rd.Close();
            }
            
        }

        private void tbAdminNev_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.WhiteSmoke;

            if (tbAdmin.Text != String.Empty && tbAdmin.Text.Equals("Azonosító"))
            {
                tbAdmin.Clear();
            }


            if (tbAdminJelszo.Text == String.Empty)
            {
                tbAdminJelszo.Text = "Jelszó";
            }
        }

        private void tbAdminJelszo_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;

            if (tbAdminJelszo.Text != String.Empty && tbAdminJelszo.Text.Equals("Jelszó"))
            {
                tbAdminJelszo.Clear();
            }


            if (tbAdmin.Text == String.Empty)
            {
                tbAdmin.Text = "Azonosító";
            }
        }

        private void tbAdminJelszo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar == 8 && tbAdminJelszo.Text == String.Empty || tbAdminJelszo.Text.Equals("Jelszó"))) {
                tbAdminJelszo.PasswordChar = '*';
            }
        }

        private void tbAdminJelszo_TextChanged(object sender, EventArgs e)
        {
            if (tbAdminJelszo.Text.Equals("Jelszó"))
            {
                tbAdminJelszo.PasswordChar = '\0';
            }
        }

        private void lblBezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                tbAdminJelszo.TabStop = true;
                tbAdminJelszo.Clear();
                SendKeys.Send("{Tab}");
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.FromArgb(78, 184, 206);        
            }
        }

        private void tbAdminJelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                btnBelépés.TabStop = true;
                //tbAdminJelszo.Clear();
                SendKeys.Send("{Tab}");
                //panel1.BackColor = Color.WhiteSmoke;
                //panel2.BackColor = Color.FromArgb(78, 184, 206);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnAdmin_Leave(object sender, EventArgs e)
        {
            radiobtnAdmin.Checked = false;
        }

        private void radiobtnTermek_Leave(object sender, EventArgs e)
        {
            radiobtnAdmin.Checked = false;
        }

        private void radiobtnCRM_Leave(object sender, EventArgs e)
        {
            radiobtnAdmin.Checked = false;
        }

        private void ss(object sender, EventArgs e)
        {

        }

        private void radiobtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnCRM.Checked == false && radiobtnTermek.Checked == false)
                radiobtnAdmin.Checked = true;
        }

        private void radiobtnTermek_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnAdmin.Checked == false && radiobtnCRM.Checked == false)
                radiobtnTermek.Checked = true;
        }

        private void radiobtnCRM_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnAdmin.Checked == false && radiobtnTermek.Checked == false)
                radiobtnCRM.Checked = true;
        }
    }
}
