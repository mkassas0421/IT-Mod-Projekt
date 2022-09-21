namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormRendeles
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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFizetes = new System.Windows.Forms.ComboBox();
            this.btnMegrendelem = new System.Windows.Forms.Button();
            this.btnMégsem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(26, 25);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(119, 20);
            this.tbNev.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fizetési mód";
            // 
            // cbFizetes
            // 
            this.cbFizetes.FormattingEnabled = true;
            this.cbFizetes.Items.AddRange(new object[] {
            "készpénz",
            "bankkártya"});
            this.cbFizetes.Location = new System.Drawing.Point(26, 77);
            this.cbFizetes.Name = "cbFizetes";
            this.cbFizetes.Size = new System.Drawing.Size(121, 21);
            this.cbFizetes.TabIndex = 4;
            this.cbFizetes.Text = "      -- Válasszon --";
            this.cbFizetes.SelectedIndexChanged += new System.EventHandler(this.cbFizetes_SelectedIndexChanged);
            // 
            // btnMegrendelem
            // 
            this.btnMegrendelem.Enabled = false;
            this.btnMegrendelem.Location = new System.Drawing.Point(131, 104);
            this.btnMegrendelem.Name = "btnMegrendelem";
            this.btnMegrendelem.Size = new System.Drawing.Size(88, 23);
            this.btnMegrendelem.TabIndex = 6;
            this.btnMegrendelem.Text = "Megrendelem";
            this.btnMegrendelem.UseVisualStyleBackColor = true;
            this.btnMegrendelem.Click += new System.EventHandler(this.btnMegrendelem_Click);
            // 
            // btnMégsem
            // 
            this.btnMégsem.Location = new System.Drawing.Point(131, 133);
            this.btnMégsem.Name = "btnMégsem";
            this.btnMégsem.Size = new System.Drawing.Size(88, 23);
            this.btnMégsem.TabIndex = 7;
            this.btnMégsem.Text = "Mégsem";
            this.btnMégsem.UseVisualStyleBackColor = true;
            this.btnMégsem.Click += new System.EventHandler(this.btnMégsem_Click);
            // 
            // FormRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 168);
            this.Controls.Add(this.btnMégsem);
            this.Controls.Add(this.btnMegrendelem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFizetes);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "FormRendeles";
            this.Text = "Rendeles";
            this.Load += new System.EventHandler(this.FormRendeles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFizetes;
        private System.Windows.Forms.Button btnMegrendelem;
        private System.Windows.Forms.Button btnMégsem;
    }
}