namespace CsordasBarna_BeadandoDolgozat
{
    partial class FormAdminFelület
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminFelület));
            this.lvOutput = new System.Windows.Forms.ListView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUjidegentermek = new System.Windows.Forms.Button();
            this.btnUjtermek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKezdolap = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblFelhasznalo = new System.Windows.Forms.Label();
            this.pnlFelvitel = new System.Windows.Forms.Panel();
            this.lvLegutobbi = new System.Windows.Forms.ListView();
            this.lblLegutobbFelvitt = new System.Windows.Forms.Label();
            this.comboboxFelvitt = new System.Windows.Forms.ComboBox();
            this.lblSzures = new System.Windows.Forms.Label();
            this.pnlTerméklista = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlTerméklista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvOutput
            // 
            this.lvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.lvOutput.ForeColor = System.Drawing.Color.White;
            this.lvOutput.HideSelection = false;
            this.lvOutput.Location = new System.Drawing.Point(0, 0);
            this.lvOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size(773, 568);
            this.lvOutput.TabIndex = 1;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.List;
            this.lvOutput.Visible = false;
            this.lvOutput.SelectedIndexChanged += new System.EventHandler(this.lvOutput_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(195, 574);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Összes termék";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(328, 574);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 23);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Saját termék";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(448, 574);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(147, 23);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Beszerzett termék";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlButtons.Controls.Add(this.pnlNav);
            this.pnlButtons.Controls.Add(this.pictureBox1);
            this.pnlButtons.Controls.Add(this.btnUjidegentermek);
            this.pnlButtons.Controls.Add(this.btnUjtermek);
            this.pnlButtons.Controls.Add(this.button1);
            this.pnlButtons.Controls.Add(this.pictureBox6);
            this.pnlButtons.Controls.Add(this.pictureBox4);
            this.pnlButtons.Controls.Add(this.pictureBox5);
            this.pnlButtons.Controls.Add(this.button4);
            this.pnlButtons.Controls.Add(this.btnKezdolap);
            this.pnlButtons.Controls.Add(this.button3);
            this.pnlButtons.Controls.Add(this.button2);
            this.pnlButtons.Controls.Add(this.panel4);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(220, 639);
            this.pnlButtons.TabIndex = 11;
            this.pnlButtons.Click += new System.EventHandler(this.button2_Click);
            this.pnlButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 149);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 200);
            this.pnlNav.TabIndex = 25;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 213);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnUjidegentermek
            // 
            this.btnUjidegentermek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnUjidegentermek.FlatAppearance.BorderSize = 0;
            this.btnUjidegentermek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjidegentermek.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjidegentermek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUjidegentermek.Location = new System.Drawing.Point(0, 400);
            this.btnUjidegentermek.Margin = new System.Windows.Forms.Padding(4);
            this.btnUjidegentermek.Name = "btnUjidegentermek";
            this.btnUjidegentermek.Size = new System.Drawing.Size(220, 50);
            this.btnUjidegentermek.TabIndex = 23;
            this.btnUjidegentermek.Text = "  Beszerzett termék felvitel";
            this.btnUjidegentermek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUjidegentermek.UseVisualStyleBackColor = false;
            this.btnUjidegentermek.Visible = false;
            this.btnUjidegentermek.Click += new System.EventHandler(this.btnUjidegentermek_Click);
            this.btnUjidegentermek.Leave += new System.EventHandler(this.btnUjidegentermek_Leave);
            // 
            // btnUjtermek
            // 
            this.btnUjtermek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnUjtermek.FlatAppearance.BorderSize = 0;
            this.btnUjtermek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjtermek.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjtermek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUjtermek.Location = new System.Drawing.Point(0, 350);
            this.btnUjtermek.Margin = new System.Windows.Forms.Padding(4);
            this.btnUjtermek.Name = "btnUjtermek";
            this.btnUjtermek.Size = new System.Drawing.Size(220, 50);
            this.btnUjtermek.TabIndex = 22;
            this.btnUjtermek.Text = "  Termék felvitel";
            this.btnUjtermek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUjtermek.UseVisualStyleBackColor = false;
            this.btnUjtermek.Visible = false;
            this.btnUjtermek.Click += new System.EventHandler(this.btnUjtermek_Click);
            this.btnUjtermek.Leave += new System.EventHandler(this.btnUjtermek_Leave);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = " Terméklista";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(175, 163);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(175, 313);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(175, 263);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 587);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 52);
            this.button4.TabIndex = 17;
            this.button4.Text = "Beállítások";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Leave += new System.EventHandler(this.button4_Leave);
            // 
            // btnKezdolap
            // 
            this.btnKezdolap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKezdolap.FlatAppearance.BorderSize = 0;
            this.btnKezdolap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKezdolap.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKezdolap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnKezdolap.Location = new System.Drawing.Point(0, 150);
            this.btnKezdolap.Margin = new System.Windows.Forms.Padding(4);
            this.btnKezdolap.Name = "btnKezdolap";
            this.btnKezdolap.Size = new System.Drawing.Size(220, 50);
            this.btnKezdolap.TabIndex = 13;
            this.btnKezdolap.Text = " Kezdőlap";
            this.btnKezdolap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKezdolap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKezdolap.UseVisualStyleBackColor = true;
            this.btnKezdolap.Click += new System.EventHandler(this.btnKezdolap_Click);
            this.btnKezdolap.Leave += new System.EventHandler(this.btnKezdolap_Leave);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(0, 300);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 50);
            this.button3.TabIndex = 16;
            this.button3.Text = " Kapcsolatok";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Leave += new System.EventHandler(this.button3_Leave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(0, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = " Naptár  ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblFelhasznalo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 150);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(68, 36);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblFelhasznalo
            // 
            this.lblFelhasznalo.AutoSize = true;
            this.lblFelhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFelhasznalo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFelhasznalo.Location = new System.Drawing.Point(85, 118);
            this.lblFelhasznalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFelhasznalo.Name = "lblFelhasznalo";
            this.lblFelhasznalo.Size = new System.Drawing.Size(54, 18);
            this.lblFelhasznalo.TabIndex = 1;
            this.lblFelhasznalo.Text = "Admin";
            this.lblFelhasznalo.Click += new System.EventHandler(this.lblFelhasznalo_Click);
            // 
            // pnlFelvitel
            // 
            this.pnlFelvitel.Location = new System.Drawing.Point(784, 3);
            this.pnlFelvitel.Name = "pnlFelvitel";
            this.pnlFelvitel.Size = new System.Drawing.Size(503, 281);
            this.pnlFelvitel.TabIndex = 12;
            this.pnlFelvitel.Visible = false;
            // 
            // lvLegutobbi
            // 
            this.lvLegutobbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.lvLegutobbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLegutobbi.Enabled = false;
            this.lvLegutobbi.ForeColor = System.Drawing.Color.White;
            this.lvLegutobbi.Location = new System.Drawing.Point(784, 318);
            this.lvLegutobbi.Name = "lvLegutobbi";
            this.lvLegutobbi.Size = new System.Drawing.Size(503, 250);
            this.lvLegutobbi.TabIndex = 0;
            this.lvLegutobbi.UseCompatibleStateImageBehavior = false;
            this.lvLegutobbi.View = System.Windows.Forms.View.List;
            this.lvLegutobbi.Visible = false;
            // 
            // lblLegutobbFelvitt
            // 
            this.lblLegutobbFelvitt.AutoSize = true;
            this.lblLegutobbFelvitt.Enabled = false;
            this.lblLegutobbFelvitt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLegutobbFelvitt.ForeColor = System.Drawing.Color.White;
            this.lblLegutobbFelvitt.Location = new System.Drawing.Point(780, 293);
            this.lblLegutobbFelvitt.Name = "lblLegutobbFelvitt";
            this.lblLegutobbFelvitt.Size = new System.Drawing.Size(248, 22);
            this.lblLegutobbFelvitt.TabIndex = 13;
            this.lblLegutobbFelvitt.Text = "Legutóbb felvitt termékek";
            this.lblLegutobbFelvitt.Visible = false;
            // 
            // comboboxFelvitt
            // 
            this.comboboxFelvitt.BackColor = System.Drawing.Color.White;
            this.comboboxFelvitt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboboxFelvitt.ForeColor = System.Drawing.Color.Black;
            this.comboboxFelvitt.FormattingEnabled = true;
            this.comboboxFelvitt.Items.AddRange(new object[] {
            "Összes",
            "Legutóbbi 5 termék",
            "Legutóbbi 10 termék",
            "Legutóbbi 20 termék"});
            this.comboboxFelvitt.Location = new System.Drawing.Point(1158, 290);
            this.comboboxFelvitt.Name = "comboboxFelvitt";
            this.comboboxFelvitt.Size = new System.Drawing.Size(129, 25);
            this.comboboxFelvitt.TabIndex = 14;
            this.comboboxFelvitt.Text = "       --összes--";
            this.comboboxFelvitt.Visible = false;
            this.comboboxFelvitt.SelectedIndexChanged += new System.EventHandler(this.comboboxFelvitt_SelectedIndexChanged);
            // 
            // lblSzures
            // 
            this.lblSzures.AutoSize = true;
            this.lblSzures.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzures.Location = new System.Drawing.Point(1101, 293);
            this.lblSzures.Name = "lblSzures";
            this.lblSzures.Size = new System.Drawing.Size(51, 19);
            this.lblSzures.TabIndex = 15;
            this.lblSzures.Text = "szűrés:";
            this.lblSzures.Visible = false;
            // 
            // pnlTerméklista
            // 
            this.pnlTerméklista.Controls.Add(this.lblSzures);
            this.pnlTerméklista.Controls.Add(this.lvOutput);
            this.pnlTerméklista.Controls.Add(this.radioButton1);
            this.pnlTerméklista.Controls.Add(this.radioButton2);
            this.pnlTerméklista.Controls.Add(this.radioButton3);
            this.pnlTerméklista.Controls.Add(this.pnlFelvitel);
            this.pnlTerméklista.Controls.Add(this.lvLegutobbi);
            this.pnlTerméklista.Controls.Add(this.lblLegutobbFelvitt);
            this.pnlTerméklista.Controls.Add(this.comboboxFelvitt);
            this.pnlTerméklista.Location = new System.Drawing.Point(231, 15);
            this.pnlTerméklista.Name = "pnlTerméklista";
            this.pnlTerméklista.Size = new System.Drawing.Size(1306, 614);
            this.pnlTerméklista.TabIndex = 16;
            // 
            // FormAdminFelület
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1542, 639);
            this.Controls.Add(this.pnlTerméklista);
            this.Controls.Add(this.pnlButtons);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminFelület";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFelület";
            this.Load += new System.EventHandler(this.FormAdminFelület_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlTerméklista.ResumeLayout(false);
            this.pnlTerméklista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnKezdolap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFelhasznalo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnUjtermek;
        private System.Windows.Forms.Button btnUjidegentermek;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlFelvitel;
        private System.Windows.Forms.Label lblLegutobbFelvitt;
        public System.Windows.Forms.ListView lvLegutobbi;
        private System.Windows.Forms.ComboBox comboboxFelvitt;
        private System.Windows.Forms.Label lblSzures;
        private System.Windows.Forms.Panel pnlTerméklista;
    }
}