namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormBeszerzettTermekBevitel
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbMárka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numÁr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiszerelés)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 50);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 90);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 210);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 130);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 170);
            // 
            // tbTerméknév
            // 
            this.tbTerméknév.Location = new System.Drawing.Point(92, 47);
            // 
            // cbKategória
            // 
            this.cbKategória.Items.AddRange(new object[] {
            "Vitaminok",
            "Fehérjék",
            "Testtömegnövelők",
            "Aminosavak",
            "Kreatin",
            "Vitaminok",
            "Fehérjék",
            "Testtömegnövelők",
            "Aminosavak",
            "Kreatin",
            "Vitaminok",
            "Fehérjék",
            "Testtömegnövelők",
            "Aminosavak",
            "Kreatin",
            "Vitaminok",
            "Fehérjék",
            "Testtömegnövelők",
            "Aminosavak",
            "Kreatin",
            "Vitaminok",
            "Fehérjék",
            "Testtömegnövelők",
            "Aminosavak",
            "Kreatin"});
            this.cbKategória.Location = new System.Drawing.Point(92, 87);
            // 
            // dtpDátum
            // 
            this.dtpDátum.Location = new System.Drawing.Point(92, 204);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(217, 230);
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // numÁr
            // 
            this.numÁr.Location = new System.Drawing.Point(93, 168);
            // 
            // numKiszerelés
            // 
            this.numKiszerelés.Location = new System.Drawing.Point(93, 128);
            // 
            // btnMégsem
            // 
            this.btnMégsem.Location = new System.Drawing.Point(217, 259);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Márka";
            // 
            // cbMárka
            // 
            this.cbMárka.FormattingEnabled = true;
            this.cbMárka.Location = new System.Drawing.Point(93, 6);
            this.cbMárka.Name = "cbMárka";
            this.cbMárka.Size = new System.Drawing.Size(121, 21);
            this.cbMárka.TabIndex = 13;
            this.cbMárka.Text = "      -- Válasszon --";
            this.cbMárka.SelectedIndexChanged += new System.EventHandler(this.cbMárka_SelectedIndexChanged);
            // 
            // FormBeszerzettTermekBevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 306);
            this.Controls.Add(this.cbMárka);
            this.Controls.Add(this.label6);
            this.Name = "FormBeszerzettTermekBevitel";
            this.Text = "BeszerzettTermekBevitel";
            this.Load += new System.EventHandler(this.FormBeszerzettTermekBevitel_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbTerméknév, 0);
            this.Controls.SetChildIndex(this.cbKategória, 0);
            this.Controls.SetChildIndex(this.dtpDátum, 0);
            this.Controls.SetChildIndex(this.btnFelvitel, 0);
            this.Controls.SetChildIndex(this.numÁr, 0);
            this.Controls.SetChildIndex(this.numKiszerelés, 0);
            this.Controls.SetChildIndex(this.btnMégsem, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbMárka, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numÁr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiszerelés)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMárka;
    }
}