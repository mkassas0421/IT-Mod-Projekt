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
        List<Felhasznalo> adminlista = new List<Felhasznalo>();

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
            Felhasznalo admin = adminlista.Find(x => x.Felhasznalonev.Equals(tbAdmin.Text) && x.Jelszo.Equals(tbAdminJelszo.Text));
            if (admin !=null)
            {
                tbAdminJelszo.Clear();
                tbAdmin.Clear();
                FormAdminFelület frm = new FormAdminFelület();
                frm.ShowDialog();
                this.Close();
                
                
            }
            else
            {
                MessageBox.Show("Sikertelen belépés");
                tbAdminJelszo.Clear();
                tbAdmin.Clear();
            }

        }

        private void btnMégsem_Click(object sender, EventArgs e)
        {
            
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
                    adminlista.Add(admin);
                }
                rd.Close();
            }
        }

        private void tbAdminNev_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.WhiteSmoke;

            if (tbAdmin.Text != String.Empty && tbAdmin.Text.Equals("Admin"))
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
                tbAdmin.Text = "Admin";
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

        private void label3_Click(object sender, EventArgs e)
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
    }
}
