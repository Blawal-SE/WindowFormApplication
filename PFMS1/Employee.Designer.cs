namespace PFMS1
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnemploadall = new System.Windows.Forms.Button();
            this.btnempfind = new System.Windows.Forms.Button();
            this.txtempfind = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvemployee = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnedelete = new System.Windows.Forms.Button();
            this.txtesalary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtxtecnic = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnempcancel = new System.Windows.Forms.Button();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.btneadd = new System.Windows.Forms.Button();
            this.mtxtephone = new System.Windows.Forms.MaskedTextBox();
            this.dtpehire = new System.Windows.Forms.DateTimePicker();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtedeignation = new System.Windows.Forms.TextBox();
            this.txteaddress = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbleserialno = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsloadall = new System.Windows.Forms.Button();
            this.btnsfind = new System.Windows.Forms.Button();
            this.txtsfind = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvsalary = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnscancel = new System.Windows.Forms.Button();
            this.btnsupdate = new System.Windows.Forms.Button();
            this.btnmakesalary = new System.Windows.Forms.Button();
            this.cbsstatus = new System.Windows.Forms.ComboBox();
            this.cbempname = new System.Windows.Forms.ComboBox();
            this.dtpspaydate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblssrialno = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnhome = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 421);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.btnemploadall);
            this.groupBox5.Controls.Add(this.btnempfind);
            this.groupBox5.Controls.Add(this.txtempfind);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.dgvemployee);
            this.groupBox5.Location = new System.Drawing.Point(484, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 383);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee Record Info.";
            // 
            // btnemploadall
            // 
            this.btnemploadall.Location = new System.Drawing.Point(63, 15);
            this.btnemploadall.Name = "btnemploadall";
            this.btnemploadall.Size = new System.Drawing.Size(90, 23);
            this.btnemploadall.TabIndex = 21;
            this.btnemploadall.Text = "Load All Rec";
            this.btnemploadall.UseVisualStyleBackColor = true;
            this.btnemploadall.Click += new System.EventHandler(this.btnemploadall_Click);
            // 
            // btnempfind
            // 
            this.btnempfind.Location = new System.Drawing.Point(356, 13);
            this.btnempfind.Name = "btnempfind";
            this.btnempfind.Size = new System.Drawing.Size(75, 20);
            this.btnempfind.TabIndex = 20;
            this.btnempfind.Text = "Find";
            this.btnempfind.UseVisualStyleBackColor = true;
            this.btnempfind.Click += new System.EventHandler(this.btnempfind_Click);
            // 
            // txtempfind
            // 
            this.txtempfind.Location = new System.Drawing.Point(250, 13);
            this.txtempfind.Name = "txtempfind";
            this.txtempfind.Size = new System.Drawing.Size(100, 20);
            this.txtempfind.TabIndex = 19;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(159, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(105, 13);
            this.label33.TabIndex = 18;
            this.label33.Text = "Employee  Name:";
            // 
            // dgvemployee
            // 
            this.dgvemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployee.Location = new System.Drawing.Point(6, 44);
            this.dgvemployee.Name = "dgvemployee";
            this.dgvemployee.Size = new System.Drawing.Size(454, 339);
            this.dgvemployee.TabIndex = 0;
            this.dgvemployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemployee_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Silver;
            this.groupBox6.Controls.Add(this.btnedelete);
            this.groupBox6.Controls.Add(this.txtesalary);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.mtxtecnic);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnempcancel);
            this.groupBox6.Controls.Add(this.btnempupdate);
            this.groupBox6.Controls.Add(this.btneadd);
            this.groupBox6.Controls.Add(this.mtxtephone);
            this.groupBox6.Controls.Add(this.dtpehire);
            this.groupBox6.Controls.Add(this.txtename);
            this.groupBox6.Controls.Add(this.txtedeignation);
            this.groupBox6.Controls.Add(this.txteaddress);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.lbleserialno);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(472, 383);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Employee Record";
            // 
            // btnedelete
            // 
            this.btnedelete.Location = new System.Drawing.Point(226, 329);
            this.btnedelete.Name = "btnedelete";
            this.btnedelete.Size = new System.Drawing.Size(75, 23);
            this.btnedelete.TabIndex = 30;
            this.btnedelete.Text = "Delete";
            this.btnedelete.UseVisualStyleBackColor = true;
            this.btnedelete.Click += new System.EventHandler(this.btnedelete_Click);
            // 
            // txtesalary
            // 
            this.txtesalary.Location = new System.Drawing.Point(285, 240);
            this.txtesalary.Name = "txtesalary";
            this.txtesalary.Size = new System.Drawing.Size(100, 20);
            this.txtesalary.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Salary";
            // 
            // mtxtecnic
            // 
            this.mtxtecnic.Location = new System.Drawing.Point(108, 186);
            this.mtxtecnic.Mask = "00000-0000000-0";
            this.mtxtecnic.Name = "mtxtecnic";
            this.mtxtecnic.Size = new System.Drawing.Size(100, 20);
            this.mtxtecnic.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "CNIC";
            // 
            // btnempcancel
            // 
            this.btnempcancel.Location = new System.Drawing.Point(310, 329);
            this.btnempcancel.Name = "btnempcancel";
            this.btnempcancel.Size = new System.Drawing.Size(75, 23);
            this.btnempcancel.TabIndex = 24;
            this.btnempcancel.Text = "Cancel";
            this.btnempcancel.UseVisualStyleBackColor = true;
            this.btnempcancel.Click += new System.EventHandler(this.btnempcancel_Click);
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(144, 329);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(75, 23);
            this.btnempupdate.TabIndex = 23;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // btneadd
            // 
            this.btneadd.Location = new System.Drawing.Point(54, 329);
            this.btneadd.Name = "btneadd";
            this.btneadd.Size = new System.Drawing.Size(75, 23);
            this.btneadd.TabIndex = 22;
            this.btneadd.Text = "Add";
            this.btneadd.UseVisualStyleBackColor = true;
            this.btneadd.Click += new System.EventHandler(this.btneadd_Click);
            // 
            // mtxtephone
            // 
            this.mtxtephone.Location = new System.Drawing.Point(108, 142);
            this.mtxtephone.Mask = "0000-0000000";
            this.mtxtephone.Name = "mtxtephone";
            this.mtxtephone.Size = new System.Drawing.Size(100, 20);
            this.mtxtephone.TabIndex = 17;
            // 
            // dtpehire
            // 
            this.dtpehire.Location = new System.Drawing.Point(285, 99);
            this.dtpehire.Name = "dtpehire";
            this.dtpehire.Size = new System.Drawing.Size(181, 20);
            this.dtpehire.TabIndex = 16;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(108, 96);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 14;
            // 
            // txtedeignation
            // 
            this.txtedeignation.Location = new System.Drawing.Point(108, 240);
            this.txtedeignation.Name = "txtedeignation";
            this.txtedeignation.Size = new System.Drawing.Size(100, 20);
            this.txtedeignation.TabIndex = 13;
            // 
            // txteaddress
            // 
            this.txteaddress.Location = new System.Drawing.Point(285, 148);
            this.txteaddress.Multiline = true;
            this.txteaddress.Name = "txteaddress";
            this.txteaddress.Size = new System.Drawing.Size(141, 58);
            this.txteaddress.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(214, 148);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Address";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 145);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Phone Number";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(214, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "Hiring Date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 248);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 13);
            this.label28.TabIndex = 5;
            this.label28.Text = "Designation";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Name";
            // 
            // lbleserialno
            // 
            this.lbleserialno.AutoSize = true;
            this.lbleserialno.Location = new System.Drawing.Point(79, 38);
            this.lbleserialno.Name = "lbleserialno";
            this.lbleserialno.Size = new System.Drawing.Size(14, 13);
            this.lbleserialno.TabIndex = 1;
            this.lbleserialno.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 38);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "Employee Id.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salary ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnsloadall);
            this.groupBox1.Controls.Add(this.btnsfind);
            this.groupBox1.Controls.Add(this.txtsfind);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dgvsalary);
            this.groupBox1.Location = new System.Drawing.Point(482, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 443);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Record Info.";
            // 
            // btnsloadall
            // 
            this.btnsloadall.Location = new System.Drawing.Point(59, 15);
            this.btnsloadall.Name = "btnsloadall";
            this.btnsloadall.Size = new System.Drawing.Size(90, 23);
            this.btnsloadall.TabIndex = 21;
            this.btnsloadall.Text = "Load All Rec";
            this.btnsloadall.UseVisualStyleBackColor = true;
            this.btnsloadall.Click += new System.EventHandler(this.btnsloadall_Click);
            // 
            // btnsfind
            // 
            this.btnsfind.Location = new System.Drawing.Point(352, 13);
            this.btnsfind.Name = "btnsfind";
            this.btnsfind.Size = new System.Drawing.Size(75, 20);
            this.btnsfind.TabIndex = 20;
            this.btnsfind.Text = "Find";
            this.btnsfind.UseVisualStyleBackColor = true;
            this.btnsfind.Click += new System.EventHandler(this.btnsfind_Click);
            // 
            // txtsfind
            // 
            this.txtsfind.Location = new System.Drawing.Point(262, 13);
            this.txtsfind.Name = "txtsfind";
            this.txtsfind.Size = new System.Drawing.Size(84, 20);
            this.txtsfind.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Employee Name:";
            // 
            // dgvsalary
            // 
            this.dgvsalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalary.Location = new System.Drawing.Point(3, 44);
            this.dgvsalary.Name = "dgvsalary";
            this.dgvsalary.Size = new System.Drawing.Size(453, 344);
            this.dgvsalary.TabIndex = 0;
            this.dgvsalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalary_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnscancel);
            this.groupBox2.Controls.Add(this.btnsupdate);
            this.groupBox2.Controls.Add(this.btnmakesalary);
            this.groupBox2.Controls.Add(this.cbsstatus);
            this.groupBox2.Controls.Add(this.cbempname);
            this.groupBox2.Controls.Add(this.dtpspaydate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblssrialno);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 388);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Record";
            // 
            // btnscancel
            // 
            this.btnscancel.Location = new System.Drawing.Point(322, 340);
            this.btnscancel.Name = "btnscancel";
            this.btnscancel.Size = new System.Drawing.Size(75, 23);
            this.btnscancel.TabIndex = 24;
            this.btnscancel.Text = "Cancel";
            this.btnscancel.UseVisualStyleBackColor = true;
            this.btnscancel.Click += new System.EventHandler(this.btnscancel_Click);
            // 
            // btnsupdate
            // 
            this.btnsupdate.Location = new System.Drawing.Point(201, 340);
            this.btnsupdate.Name = "btnsupdate";
            this.btnsupdate.Size = new System.Drawing.Size(75, 23);
            this.btnsupdate.TabIndex = 23;
            this.btnsupdate.Text = "Update";
            this.btnsupdate.UseVisualStyleBackColor = true;
            this.btnsupdate.Click += new System.EventHandler(this.btnsupdate_Click);
            // 
            // btnmakesalary
            // 
            this.btnmakesalary.Location = new System.Drawing.Point(91, 340);
            this.btnmakesalary.Name = "btnmakesalary";
            this.btnmakesalary.Size = new System.Drawing.Size(75, 23);
            this.btnmakesalary.TabIndex = 22;
            this.btnmakesalary.Text = "Make Salary";
            this.btnmakesalary.UseVisualStyleBackColor = true;
            this.btnmakesalary.Click += new System.EventHandler(this.btnmakesalary_Click);
            // 
            // cbsstatus
            // 
            this.cbsstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsstatus.FormattingEnabled = true;
            this.cbsstatus.Items.AddRange(new object[] {
            "Paid",
            "Un-Paid"});
            this.cbsstatus.Location = new System.Drawing.Point(199, 229);
            this.cbsstatus.Name = "cbsstatus";
            this.cbsstatus.Size = new System.Drawing.Size(100, 21);
            this.cbsstatus.TabIndex = 21;
            // 
            // cbempname
            // 
            this.cbempname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbempname.FormattingEnabled = true;
            this.cbempname.Location = new System.Drawing.Point(201, 125);
            this.cbempname.Name = "cbempname";
            this.cbempname.Size = new System.Drawing.Size(100, 21);
            this.cbempname.TabIndex = 19;
            // 
            // dtpspaydate
            // 
            this.dtpspaydate.Location = new System.Drawing.Point(199, 177);
            this.dtpspaydate.Name = "dtpspaydate";
            this.dtpspaydate.Size = new System.Drawing.Size(181, 20);
            this.dtpspaydate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pay Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pay Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Employee Name";
            // 
            // lblssrialno
            // 
            this.lblssrialno.AutoSize = true;
            this.lblssrialno.Location = new System.Drawing.Point(170, 58);
            this.lblssrialno.Name = "lblssrialno";
            this.lblssrialno.Size = new System.Drawing.Size(14, 13);
            this.lblssrialno.TabIndex = 1;
            this.lblssrialno.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Serial No.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Image = global::PFMS1.Properties.Resources.blue_home_icon;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(3, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(85, 32);
            this.btnhome.TabIndex = 28;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 483);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnemploadall;
        private System.Windows.Forms.Button btnempfind;
        private System.Windows.Forms.TextBox txtempfind;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvemployee;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnempcancel;
        private System.Windows.Forms.Button btnempupdate;
        private System.Windows.Forms.Button btneadd;
        private System.Windows.Forms.MaskedTextBox mtxtephone;
        private System.Windows.Forms.DateTimePicker dtpehire;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtedeignation;
        private System.Windows.Forms.TextBox txteaddress;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbleserialno;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsloadall;
        private System.Windows.Forms.Button btnsfind;
        private System.Windows.Forms.TextBox txtsfind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvsalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnscancel;
        private System.Windows.Forms.Button btnsupdate;
        private System.Windows.Forms.Button btnmakesalary;
        private System.Windows.Forms.ComboBox cbsstatus;
        private System.Windows.Forms.ComboBox cbempname;
        private System.Windows.Forms.DateTimePicker dtpspaydate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblssrialno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnedelete;
        private System.Windows.Forms.TextBox txtesalary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtxtecnic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}