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
            this.tbFelhasznalonev.Location = new System.Drawing.Point(73, 116);
            this.tbFelhasznalonev.Name = "tbFelhasznalonev";
            this.tbFelhasznalonev.Size = new System.Drawing.Size(171, 14);
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
            this.tbJelszo.Location = new System.Drawing.Point(73, 167);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(171, 14);
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
            this.btnBejelentkezes.Location = new System.Drawing.Point(46, 242);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(204, 36);
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
            this.lbAdmin.Location = new System.Drawing.Point(126, 344);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(36, 13);
            this.lbAdmin.TabIndex = 8;
            this.lbAdmin.Text = "Admin";
            this.lbAdmin.Click += new System.EventHandler(this.lbAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(48, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(48, 185);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 11;
            // 
            // btnRegisztracio
            // 
            this.btnRegisztracio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegisztracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisztracio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegisztracio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisztracio.Location = new System.Drawing.Point(48, 283);
            this.btnRegisztracio.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisztracio.Name = "btnRegisztracio";
            this.btnRegisztracio.Size = new System.Drawing.Size(200, 36);
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
            this.lblX.Location = new System.Drawing.Point(270, 7);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 15;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(47, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(47, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // FormBejelentkezés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(295, 397);
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

