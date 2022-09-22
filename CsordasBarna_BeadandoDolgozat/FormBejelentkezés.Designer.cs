namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormBejelentkezés
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBejelentkezés));
            this.tbFelhasznalonev = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegisztracio = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFelhasznalonev
            // 
            this.tbFelhasznalonev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFelhasznalonev.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFelhasznalonev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbFelhasznalonev.Location = new System.Drawing.Point(91, 145);
            this.tbFelhasznalonev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFelhasznalonev.Name = "tbFelhasznalonev";
            this.tbFelhasznalonev.Size = new System.Drawing.Size(214, 18);
            this.tbFelhasznalonev.TabIndex = 4;
            this.tbFelhasznalonev.TabStop = false;
            this.tbFelhasznalonev.Text = "Felhasználónév";
            this.tbFelhasznalonev.Click += new System.EventHandler(this.tbFelhasznalonev_Click);
            this.tbFelhasznalonev.TextChanged += new System.EventHandler(this.tbFelhasznalonev_TextChanged);
            this.tbFelhasznalonev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFelhasznalonev_KeyDown);
            this.tbFelhasznalonev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFelhasznalonev_KeyPress);
            // 
            // tbJelszo
            // 
            this.tbJelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbJelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJelszo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbJelszo.ForeColor = System.Drawing.SystemColors.Window;
            this.tbJelszo.Location = new System.Drawing.Point(91, 196);
            this.tbJelszo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(214, 18);
            this.tbJelszo.TabIndex = 5;
            this.tbJelszo.TabStop = false;
            this.tbJelszo.Text = "Jelszó";
            this.tbJelszo.Click += new System.EventHandler(this.tbJelszo_Click);
            this.tbJelszo.TabIndexChanged += new System.EventHandler(this.tbJelszo_TabIndexChanged);
            this.tbJelszo.TabStopChanged += new System.EventHandler(this.tbJelszo_TabStopChanged);
            this.tbJelszo.TextChanged += new System.EventHandler(this.TbJelszo_TextChanged);
            this.tbJelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJelszo_KeyDown);
            this.tbJelszo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJelszo_KeyPress);
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnBejelentkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBejelentkezes.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBejelentkezes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBejelentkezes.Location = new System.Drawing.Point(60, 259);
            this.btnBejelentkezes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(255, 45);
            this.btnBejelentkezes.TabIndex = 6;
            this.btnBejelentkezes.TabStop = false;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = false;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBelépés_Click);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lbAdmin.Location = new System.Drawing.Point(157, 401);
            this.lbAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(47, 17);
            this.lbAdmin.TabIndex = 8;
            this.lbAdmin.Text = "Admin";
            this.lbAdmin.Click += new System.EventHandler(this.lbAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(60, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(60, 219);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 11;
            // 
            // btnRegisztracio
            // 
            this.btnRegisztracio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegisztracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisztracio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegisztracio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisztracio.Location = new System.Drawing.Point(62, 310);
            this.btnRegisztracio.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisztracio.Name = "btnRegisztracio";
            this.btnRegisztracio.Size = new System.Drawing.Size(250, 45);
            this.btnRegisztracio.TabIndex = 14;
            this.btnRegisztracio.TabStop = false;
            this.btnRegisztracio.Text = "Regisztrálok";
            this.btnRegisztracio.UseVisualStyleBackColor = false;
            this.btnRegisztracio.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(326, 11);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 15;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(59, 132);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(59, 184);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // FormBejelentkezés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(361, 444);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnRegisztracio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.btnBejelentkezes);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalonev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBejelentkezés";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormBejelentkezés_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbFelhasznalonev;
        public System.Windows.Forms.TextBox tbJelszo;
        public System.Windows.Forms.Button btnBejelentkezes;
        public System.Windows.Forms.Label lbAdmin;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnRegisztracio;
        public System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

