namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormFelhasznaloFelulet
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
            this.lvEladas = new System.Windows.Forms.ListView();
            this.btnKilép = new System.Windows.Forms.Button();
            this.cbFizetes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnMegrendel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEladas
            // 
            this.lvEladas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEladas.Location = new System.Drawing.Point(15, 12);
            this.lvEladas.Name = "lvEladas";
            this.lvEladas.Size = new System.Drawing.Size(752, 226);
            this.lvEladas.TabIndex = 0;
            this.lvEladas.UseCompatibleStateImageBehavior = false;
            this.lvEladas.View = System.Windows.Forms.View.List;
            this.lvEladas.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnKilép
            // 
            this.btnKilép.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKilép.Location = new System.Drawing.Point(682, 289);
            this.btnKilép.Name = "btnKilép";
            this.btnKilép.Size = new System.Drawing.Size(83, 27);
            this.btnKilép.TabIndex = 1;
            this.btnKilép.Text = "Kilép";
            this.btnKilép.UseVisualStyleBackColor = true;
            this.btnKilép.Click += new System.EventHandler(this.btnKilép_Click);
            // 
            // cbFizetes
            // 
            this.cbFizetes.FormattingEnabled = true;
            this.cbFizetes.Items.AddRange(new object[] {
            "készpénz",
            "bankkártya"});
            this.cbFizetes.Location = new System.Drawing.Point(12, 301);
            this.cbFizetes.Name = "cbFizetes";
            this.cbFizetes.Size = new System.Drawing.Size(121, 21);
            this.cbFizetes.TabIndex = 2;
            this.cbFizetes.Text = "      -- Válasszon --";
            this.cbFizetes.Visible = false;
            this.cbFizetes.SelectedIndexChanged += new System.EventHandler(this.cbFizetes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fizetési mód";
            this.label1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 244);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Összes termék";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(115, 244);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "PureProtein termékek";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(248, 244);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Egyéb termékek";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnMegrendel
            // 
            this.btnMegrendel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMegrendel.Location = new System.Drawing.Point(564, 289);
            this.btnMegrendel.Name = "btnMegrendel";
            this.btnMegrendel.Size = new System.Drawing.Size(111, 27);
            this.btnMegrendel.TabIndex = 7;
            this.btnMegrendel.Text = "Megrendel";
            this.btnMegrendel.UseVisualStyleBackColor = true;
            this.btnMegrendel.Click += new System.EventHandler(this.btnMegrendel_Click);
            // 
            // FormFelhasznaloFelulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 333);
            this.Controls.Add(this.btnMegrendel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFizetes);
            this.Controls.Add(this.btnKilép);
            this.Controls.Add(this.lvEladas);
            this.Name = "FormFelhasznaloFelulet";
            this.Text = "FelhasznaloFelulet";
            this.Load += new System.EventHandler(this.FormFelhasznaloFelulet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEladas;
        private System.Windows.Forms.Button btnKilép;
        private System.Windows.Forms.ComboBox cbFizetes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnMegrendel;
    }
}