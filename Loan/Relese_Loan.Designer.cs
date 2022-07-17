namespace Loan
{
    partial class Relese_Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relese_Loan));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCenter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSathiyatWarikaya = new System.Windows.Forms.TextBox();
            this.txtPoliAnupathaya = new System.Windows.Forms.TextBox();
            this.txtLoanNumber = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtWarikaGanan = new System.Windows.Forms.TextBox();
            this.txtLoneAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbladdres = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMemId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPoli_muda = new System.Windows.Forms.Label();
            this.txtpoliyaSahaLoan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblfulpament = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Center";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(96, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // cmbCenter
            // 
            this.cmbCenter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCenter.FormattingEnabled = true;
            this.cmbCenter.Location = new System.Drawing.Point(96, 24);
            this.cmbCenter.Name = "cmbCenter";
            this.cmbCenter.Size = new System.Drawing.Size(264, 25);
            this.cmbCenter.TabIndex = 0;
            this.cmbCenter.Leave += new System.EventHandler(this.cmbCenter_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCenter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(7, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information about the Member";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(354, 85);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select Group";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(95, 53);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(264, 25);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSathiyatWarikaya);
            this.groupBox2.Controls.Add(this.txtPoliAnupathaya);
            this.groupBox2.Controls.Add(this.txtLoanNumber);
            this.groupBox2.Controls.Add(this.txtDocument);
            this.groupBox2.Controls.Add(this.txtWarikaGanan);
            this.groupBox2.Controls.Add(this.txtLoneAmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblNic);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbladdres);
            this.groupBox2.Controls.Add(this.lblname);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblMemId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(7, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Loan Detils";
            // 
            // txtSathiyatWarikaya
            // 
            this.txtSathiyatWarikaya.BackColor = System.Drawing.Color.White;
            this.txtSathiyatWarikaya.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSathiyatWarikaya.Location = new System.Drawing.Point(193, 285);
            this.txtSathiyatWarikaya.Name = "txtSathiyatWarikaya";
            this.txtSathiyatWarikaya.ReadOnly = true;
            this.txtSathiyatWarikaya.Size = new System.Drawing.Size(167, 25);
            this.txtSathiyatWarikaya.TabIndex = 5;
            this.txtSathiyatWarikaya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSathiyatWarikaya_KeyPress);
            // 
            // txtPoliAnupathaya
            // 
            this.txtPoliAnupathaya.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPoliAnupathaya.Location = new System.Drawing.Point(192, 226);
            this.txtPoliAnupathaya.Name = "txtPoliAnupathaya";
            this.txtPoliAnupathaya.Size = new System.Drawing.Size(167, 25);
            this.txtPoliAnupathaya.TabIndex = 3;
            this.txtPoliAnupathaya.Text = "0";
            this.txtPoliAnupathaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPoliAnupathaya.TextChanged += new System.EventHandler(this.txtPoliAnupathaya_TextChanged);
            this.txtPoliAnupathaya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoliAnupathaya_KeyPress);
            // 
            // txtLoanNumber
            // 
            this.txtLoanNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoanNumber.Location = new System.Drawing.Point(193, 136);
            this.txtLoanNumber.Name = "txtLoanNumber";
            this.txtLoanNumber.Size = new System.Drawing.Size(167, 25);
            this.txtLoanNumber.TabIndex = 0;
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDocument.Location = new System.Drawing.Point(192, 166);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(167, 25);
            this.txtDocument.TabIndex = 1;
            // 
            // txtWarikaGanan
            // 
            this.txtWarikaGanan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtWarikaGanan.Location = new System.Drawing.Point(192, 196);
            this.txtWarikaGanan.Name = "txtWarikaGanan";
            this.txtWarikaGanan.Size = new System.Drawing.Size(167, 25);
            this.txtWarikaGanan.TabIndex = 2;
            this.txtWarikaGanan.Text = "0";
            this.txtWarikaGanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWarikaGanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWarikaGanan_KeyPress);
            // 
            // txtLoneAmount
            // 
            this.txtLoneAmount.Enabled = false;
            this.txtLoneAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoneAmount.Location = new System.Drawing.Point(192, 255);
            this.txtLoneAmount.Name = "txtLoneAmount";
            this.txtLoneAmount.Size = new System.Drawing.Size(167, 25);
            this.txtLoneAmount.TabIndex = 4;
            this.txtLoneAmount.TextChanged += new System.EventHandler(this.txtLoneAmount_TextChanged);
            this.txtLoneAmount.Enter += new System.EventHandler(this.txtLoneAmount_Enter);
            this.txtLoneAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoneAmount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(11, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Weekly installment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(10, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Interest Rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label16.Location = new System.Drawing.Point(9, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Member NIC No";
            this.label16.Click += new System.EventHandler(this.label11_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label14.Location = new System.Drawing.Point(9, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Member Addres";
            this.label14.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNic.Location = new System.Drawing.Point(190, 107);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(31, 17);
            this.lblNic.TabIndex = 3;
            this.lblNic.Text = "N/A";
            this.lblNic.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.Location = new System.Drawing.Point(9, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Member Name";
            this.label12.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbladdres
            // 
            this.lbladdres.AutoSize = true;
            this.lbladdres.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbladdres.Location = new System.Drawing.Point(190, 78);
            this.lbladdres.Name = "lbladdres";
            this.lbladdres.Size = new System.Drawing.Size(31, 17);
            this.lbladdres.TabIndex = 3;
            this.lbladdres.Text = "N/A";
            this.lbladdres.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblname.Location = new System.Drawing.Point(190, 49);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(31, 17);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "N/A";
            this.lblname.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Member ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblMemId
            // 
            this.lblMemId.AutoSize = true;
            this.lblMemId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMemId.Location = new System.Drawing.Point(190, 22);
            this.lblMemId.Name = "lblMemId";
            this.lblMemId.Size = new System.Drawing.Size(31, 17);
            this.lblMemId.TabIndex = 3;
            this.lblMemId.Text = "N/A";
            this.lblMemId.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(10, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Loan Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(9, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Document Pepar Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(9, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of installments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loan Amount";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(388, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 502);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last Loan Detils";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(413, 474);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(573, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Issue of loan";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "RILESE LONE";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblPoli_muda
            // 
            this.lblPoli_muda.AutoSize = true;
            this.lblPoli_muda.Location = new System.Drawing.Point(8, 607);
            this.lblPoli_muda.Name = "lblPoli_muda";
            this.lblPoli_muda.Size = new System.Drawing.Size(41, 13);
            this.lblPoli_muda.TabIndex = 9;
            this.lblPoli_muda.Text = "label13";
            // 
            // txtpoliyaSahaLoan
            // 
            this.txtpoliyaSahaLoan.AutoSize = true;
            this.txtpoliyaSahaLoan.Location = new System.Drawing.Point(44, 607);
            this.txtpoliyaSahaLoan.Name = "txtpoliyaSahaLoan";
            this.txtpoliyaSahaLoan.Size = new System.Drawing.Size(41, 13);
            this.txtpoliyaSahaLoan.TabIndex = 10;
            this.txtpoliyaSahaLoan.Text = "label13";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 31);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(799, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(723, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cleare";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lblfulpament
            // 
            this.lblfulpament.AutoSize = true;
            this.lblfulpament.Location = new System.Drawing.Point(431, 566);
            this.lblfulpament.Name = "lblfulpament";
            this.lblfulpament.Size = new System.Drawing.Size(41, 13);
            this.lblfulpament.TabIndex = 12;
            this.lblfulpament.Text = "label13";
            this.lblfulpament.Visible = false;
            this.lblfulpament.Click += new System.EventHandler(this.label13_Click);
            // 
            // Relese_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 622);
            this.Controls.Add(this.lblfulpament);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtpoliyaSahaLoan);
            this.Controls.Add(this.lblPoli_muda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relese_Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relese_Loan";
            this.Load += new System.EventHandler(this.Relese_Loan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPoliAnupathaya;
        private System.Windows.Forms.TextBox txtWarikaGanan;
        private System.Windows.Forms.TextBox txtLoneAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSathiyatWarikaya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoanNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMemId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbladdres;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPoli_muda;
        private System.Windows.Forms.Label txtpoliyaSahaLoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblfulpament;
    }
}