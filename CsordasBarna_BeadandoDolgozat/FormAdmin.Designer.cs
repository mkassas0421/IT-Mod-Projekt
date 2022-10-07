namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormAdmin
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
            this.tbAdmin = new System.Windows.Forms.TextBox();
            this.tbAdminJelszo = new System.Windows.Forms.TextBox();
            this.btnBelépés = new System.Windows.Forms.Button();
            this.lblBezaras = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiobtnAdmin = new System.Windows.Forms.RadioButton();
            this.radiobtnTermek = new System.Windows.Forms.RadioButton();
            this.radiobtnCRM = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbAdmin
            // 
            this.tbAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdmin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdmin.ForeColor = System.Drawing.Color.White;
            this.tbAdmin.Location = new System.Drawing.Point(35, 23);
            this.tbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Size = new System.Drawing.Size(160, 18);
            this.tbAdmin.TabIndex = 2;
            this.tbAdmin.TabStop = false;
            this.tbAdmin.Text = "Azonosító";
            this.tbAdmin.Click += new System.EventHandler(this.tbAdminNev_Click);
            this.tbAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdmin_KeyDown);
            // 
            // tbAdminJelszo
            // 
            this.tbAdminJelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbAdminJelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdminJelszo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdminJelszo.ForeColor = System.Drawing.Color.White;
            this.tbAdminJelszo.Location = new System.Drawing.Point(35, 58);
            this.tbAdminJelszo.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdminJelszo.Name = "tbAdminJelszo";
            this.tbAdminJelszo.Size = new System.Drawing.Size(160, 18);
            this.tbAdminJelszo.TabIndex = 3;
            this.tbAdminJelszo.TabStop = false;
            this.tbAdminJelszo.Text = "Jelszó";
            this.tbAdminJelszo.Click += new System.EventHandler(this.tbAdminJelszo_Click);
            this.tbAdminJelszo.TextChanged += new System.EventHandler(this.tbAdminJelszo_TextChanged);
            this.tbAdminJelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdminJelszo_KeyDown);
            this.tbAdminJelszo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdminJelszo_KeyPress);
            // 
            // btnBelépés
            // 
            this.btnBelépés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnBelépés.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBelépés.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBelépés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBelépés.Location = new System.Drawing.Point(23, 131);
            this.btnBelépés.Margin = new System.Windows.Forms.Padding(2);
            this.btnBelépés.Name = "btnBelépés";
            this.btnBelépés.Size = new System.Drawing.Size(255, 45);
            this.btnBelépés.TabIndex = 4;
            this.btnBelépés.Text = "Belépés";
            this.btnBelépés.UseVisualStyleBackColor = false;
            this.btnBelépés.Click += new System.EventHandler(this.btnBelépés_Click);
            // 
            // lblBezaras
            // 
            this.lblBezaras.AutoSize = true;
            this.lblBezaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblBezaras.ForeColor = System.Drawing.Color.White;
            this.lblBezaras.Location = new System.Drawing.Point(282, 9);
            this.lblBezaras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBezaras.Name = "lblBezaras";
            this.lblBezaras.Size = new System.Drawing.Size(20, 20);
            this.lblBezaras.TabIndex = 5;
            this.lblBezaras.Text = "X";
            this.lblBezaras.Click += new System.EventHandler(this.lblBezaras_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(23, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 7;
            // 
            // radiobtnAdmin
            // 
            this.radiobtnAdmin.AutoSize = true;
            this.radiobtnAdmin.Checked = true;
            this.radiobtnAdmin.ForeColor = System.Drawing.Color.White;
            this.radiobtnAdmin.Location = new System.Drawing.Point(23, 91);
            this.radiobtnAdmin.Name = "radiobtnAdmin";
            this.radiobtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.radiobtnAdmin.TabIndex = 8;
            this.radiobtnAdmin.TabStop = true;
            this.radiobtnAdmin.Text = "Admin";
            this.radiobtnAdmin.UseVisualStyleBackColor = true;
            this.radiobtnAdmin.CheckedChanged += new System.EventHandler(this.radiobtnAdmin_CheckedChanged);
            this.radiobtnAdmin.Leave += new System.EventHandler(this.radiobtnAdmin_Leave);
            // 
            // radiobtnTermek
            // 
            this.radiobtnTermek.AutoSize = true;
            this.radiobtnTermek.ForeColor = System.Drawing.Color.White;
            this.radiobtnTermek.Location = new System.Drawing.Point(109, 92);
            this.radiobtnTermek.Name = "radiobtnTermek";
            this.radiobtnTermek.Size = new System.Drawing.Size(92, 21);
            this.radiobtnTermek.TabIndex = 9;
            this.radiobtnTermek.Text = "Termekek";
            this.radiobtnTermek.UseVisualStyleBackColor = true;
            this.radiobtnTermek.CheckedChanged += new System.EventHandler(this.radiobtnTermek_CheckedChanged);
            this.radiobtnTermek.Leave += new System.EventHandler(this.radiobtnTermek_Leave);
            // 
            // radiobtnCRM
            // 
            this.radiobtnCRM.AutoSize = true;
            this.radiobtnCRM.ForeColor = System.Drawing.Color.White;
            this.radiobtnCRM.Location = new System.Drawing.Point(219, 91);
            this.radiobtnCRM.Name = "radiobtnCRM";
            this.radiobtnCRM.Size = new System.Drawing.Size(59, 21);
            this.radiobtnCRM.TabIndex = 10;
            this.radiobtnCRM.Text = "CRM";
            this.radiobtnCRM.UseVisualStyleBackColor = true;
            this.radiobtnCRM.CheckedChanged += new System.EventHandler(this.radiobtnCRM_CheckedChanged);
            this.radiobtnCRM.Leave += new System.EventHandler(this.radiobtnCRM_Leave);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(313, 192);
            this.Controls.Add(this.radiobtnCRM);
            this.Controls.Add(this.radiobtnTermek);
            this.Controls.Add(this.radiobtnAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBezaras);
            this.Controls.Add(this.btnBelépés);
            this.Controls.Add(this.tbAdminJelszo);
            this.Controls.Add(this.tbAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "23";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAdmin;
        private System.Windows.Forms.TextBox tbAdminJelszo;
        private System.Windows.Forms.Button btnBelépés;
        private System.Windows.Forms.Label lblBezaras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radiobtnAdmin;
        private System.Windows.Forms.RadioButton radiobtnTermek;
        private System.Windows.Forms.RadioButton radiobtnCRM;
    }
}