namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormSajatTermekBevitel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTerméknév = new System.Windows.Forms.TextBox();
            this.cbKategória = new System.Windows.Forms.ComboBox();
            this.dtpDátum = new System.Windows.Forms.DateTimePicker();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.numÁr = new System.Windows.Forms.NumericUpDown();
            this.numKiszerelés = new System.Windows.Forms.NumericUpDown();
            this.btnMégsem = new System.Windows.Forms.Button();
            this.lblFelirat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numÁr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiszerelés)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terméknév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategória";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(54, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Felvételi dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(263, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kiszerelés (g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(263, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ár (db)";
            // 
            // tbTerméknév
            // 
            this.tbTerméknév.BackColor = System.Drawing.Color.White;
            this.tbTerméknév.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTerméknév.ForeColor = System.Drawing.Color.Black;
            this.tbTerméknév.Location = new System.Drawing.Point(56, 78);
            this.tbTerméknév.Name = "tbTerméknév";
            this.tbTerméknév.Size = new System.Drawing.Size(177, 22);
            this.tbTerméknév.TabIndex = 5;
            this.tbTerméknév.TextChanged += new System.EventHandler(this.tbTerméknév_TextChanged);
            // 
            // cbKategória
            // 
            this.cbKategória.BackColor = System.Drawing.Color.White;
            this.cbKategória.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKategória.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKategória.ForeColor = System.Drawing.Color.Black;
            this.cbKategória.FormattingEnabled = true;
            this.cbKategória.Location = new System.Drawing.Point(56, 134);
            this.cbKategória.Name = "cbKategória";
            this.cbKategória.Size = new System.Drawing.Size(177, 25);
            this.cbKategória.TabIndex = 6;
            this.cbKategória.Text = "              -- Válasszon --";
            this.cbKategória.SelectedIndexChanged += new System.EventHandler(this.cbKategória_SelectedIndexChanged);
            // 
            // dtpDátum
            // 
            this.dtpDátum.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDátum.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDátum.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpDátum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDátum.Location = new System.Drawing.Point(56, 201);
            this.dtpDátum.Name = "dtpDátum";
            this.dtpDátum.Size = new System.Drawing.Size(256, 22);
            this.dtpDátum.TabIndex = 7;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFelvitel.Enabled = false;
            this.btnFelvitel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFelvitel.ForeColor = System.Drawing.Color.Black;
            this.btnFelvitel.Location = new System.Drawing.Point(344, 200);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(99, 23);
            this.btnFelvitel.TabIndex = 8;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // numÁr
            // 
            this.numÁr.BackColor = System.Drawing.Color.White;
            this.numÁr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numÁr.ForeColor = System.Drawing.Color.Black;
            this.numÁr.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numÁr.Location = new System.Drawing.Point(266, 137);
            this.numÁr.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numÁr.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numÁr.Name = "numÁr";
            this.numÁr.Size = new System.Drawing.Size(177, 22);
            this.numÁr.TabIndex = 9;
            this.numÁr.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numÁr.ValueChanged += new System.EventHandler(this.numÁr_ValueChanged);
            // 
            // numKiszerelés
            // 
            this.numKiszerelés.BackColor = System.Drawing.Color.White;
            this.numKiszerelés.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numKiszerelés.ForeColor = System.Drawing.Color.Black;
            this.numKiszerelés.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numKiszerelés.Location = new System.Drawing.Point(266, 78);
            this.numKiszerelés.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numKiszerelés.Name = "numKiszerelés";
            this.numKiszerelés.Size = new System.Drawing.Size(177, 22);
            this.numKiszerelés.TabIndex = 10;
            this.numKiszerelés.ValueChanged += new System.EventHandler(this.numKiszerelés_ValueChanged);
            // 
            // btnMégsem
            // 
            this.btnMégsem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMégsem.ForeColor = System.Drawing.Color.Black;
            this.btnMégsem.Location = new System.Drawing.Point(344, 230);
            this.btnMégsem.Name = "btnMégsem";
            this.btnMégsem.Size = new System.Drawing.Size(99, 23);
            this.btnMégsem.TabIndex = 11;
            this.btnMégsem.Text = "Mégsem ";
            this.btnMégsem.UseVisualStyleBackColor = true;
            this.btnMégsem.Click += new System.EventHandler(this.btnMégsem_Click);
            // 
            // lblFelirat
            // 
            this.lblFelirat.AutoSize = true;
            this.lblFelirat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFelirat.Location = new System.Drawing.Point(53, 21);
            this.lblFelirat.Name = "lblFelirat";
            this.lblFelirat.Size = new System.Drawing.Size(224, 22);
            this.lblFelirat.TabIndex = 12;
            this.lblFelirat.Text = "Termék adatok felvitele";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(477, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FormSajatTermekBevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(503, 281);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFelirat);
            this.Controls.Add(this.btnMégsem);
            this.Controls.Add(this.numKiszerelés);
            this.Controls.Add(this.numÁr);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.dtpDátum);
            this.Controls.Add(this.cbKategória);
            this.Controls.Add(this.tbTerméknév);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1008, 15);
            this.Name = "FormSajatTermekBevitel";
            this.Text = "SajatTermekBevitel";
            this.Load += new System.EventHandler(this.FormSajatTermekBevitel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numÁr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiszerelés)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox tbTerméknév;
        protected System.Windows.Forms.ComboBox cbKategória;
        protected System.Windows.Forms.DateTimePicker dtpDátum;
        protected System.Windows.Forms.Button btnFelvitel;
        protected System.Windows.Forms.NumericUpDown numÁr;
        protected System.Windows.Forms.NumericUpDown numKiszerelés;
        protected System.Windows.Forms.Button btnMégsem;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label lblFelirat;
    }
}