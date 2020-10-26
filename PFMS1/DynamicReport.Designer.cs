namespace PFMS1
{
    partial class DynamicReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btngreport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpgto = new System.Windows.Forms.DateTimePicker();
            this.dtpgfrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblgtodate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgfromdate = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtexpensives = new System.Windows.Forms.TextBox();
            this.txtincome = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txteggwaste = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmedicineconsumption = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtfeedconsumption = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbirdmortality = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbirdsale = new System.Windows.Forms.TextBox();
            this.txteggsale = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbirdpurchase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmedicinepurchase = new System.Windows.Forms.TextBox();
            this.txtfeedpurchase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnprintdreport = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btngreport);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpgto);
            this.tabPage1.Controls.Add(this.dtpgfrom);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Report";
            // 
            // btngreport
            // 
            this.btngreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngreport.Location = new System.Drawing.Point(557, 5);
            this.btngreport.Name = "btngreport";
            this.btngreport.Size = new System.Drawing.Size(91, 23);
            this.btngreport.TabIndex = 17;
            this.btngreport.Text = "Make Report";
            this.btngreport.UseVisualStyleBackColor = true;
            this.btngreport.Click += new System.EventHandler(this.btngreport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "From:";
            // 
            // dtpgto
            // 
            this.dtpgto.Location = new System.Drawing.Point(343, 6);
            this.dtpgto.Name = "dtpgto";
            this.dtpgto.Size = new System.Drawing.Size(200, 20);
            this.dtpgto.TabIndex = 7;
            // 
            // dtpgfrom
            // 
            this.dtpgfrom.Location = new System.Drawing.Point(75, 6);
            this.dtpgfrom.Name = "dtpgfrom";
            this.dtpgfrom.Size = new System.Drawing.Size(200, 20);
            this.dtpgfrom.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.lblgtodate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblgfromdate);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 328);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORT";
            // 
            // lblgtodate
            // 
            this.lblgtodate.AutoSize = true;
            this.lblgtodate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblgtodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgtodate.Location = new System.Drawing.Point(200, 16);
            this.lblgtodate.Name = "lblgtodate";
            this.lblgtodate.Size = new System.Drawing.Size(75, 13);
            this.lblgtodate.TabIndex = 15;
            this.lblgtodate.Text = "00/00/0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "To";
            // 
            // lblgfromdate
            // 
            this.lblgfromdate.AutoSize = true;
            this.lblgfromdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblgfromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgfromdate.Location = new System.Drawing.Point(80, 16);
            this.lblgfromdate.Name = "lblgfromdate";
            this.lblgfromdate.Size = new System.Drawing.Size(75, 13);
            this.lblgfromdate.TabIndex = 13;
            this.lblgfromdate.Text = "00/00/0000";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtexpensives);
            this.groupBox6.Controls.Add(this.txtincome);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(434, 220);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 90);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Income/Expensives:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Total Income:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(5, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Total Expensives:";
            // 
            // txtexpensives
            // 
            this.txtexpensives.Location = new System.Drawing.Point(123, 52);
            this.txtexpensives.Name = "txtexpensives";
            this.txtexpensives.ReadOnly = true;
            this.txtexpensives.Size = new System.Drawing.Size(70, 20);
            this.txtexpensives.TabIndex = 6;
            // 
            // txtincome
            // 
            this.txtincome.Location = new System.Drawing.Point(123, 14);
            this.txtincome.Name = "txtincome";
            this.txtincome.ReadOnly = true;
            this.txtincome.Size = new System.Drawing.Size(70, 20);
            this.txtincome.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txteggwaste);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtmedicineconsumption);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtfeedconsumption);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtbirdmortality);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(53, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 163);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consumption Report:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Birds Mortality:";
            // 
            // txteggwaste
            // 
            this.txteggwaste.Location = new System.Drawing.Point(183, 125);
            this.txteggwaste.Name = "txteggwaste";
            this.txteggwaste.ReadOnly = true;
            this.txteggwaste.Size = new System.Drawing.Size(70, 20);
            this.txteggwaste.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(5, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Feed Consumption:";
            // 
            // txtmedicineconsumption
            // 
            this.txtmedicineconsumption.Location = new System.Drawing.Point(183, 89);
            this.txtmedicineconsumption.Name = "txtmedicineconsumption";
            this.txtmedicineconsumption.ReadOnly = true;
            this.txtmedicineconsumption.Size = new System.Drawing.Size(70, 20);
            this.txtmedicineconsumption.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(6, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total Medicine Consumption:";
            // 
            // txtfeedconsumption
            // 
            this.txtfeedconsumption.Location = new System.Drawing.Point(183, 52);
            this.txtfeedconsumption.Name = "txtfeedconsumption";
            this.txtfeedconsumption.ReadOnly = true;
            this.txtfeedconsumption.Size = new System.Drawing.Size(70, 20);
            this.txtfeedconsumption.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(6, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Total Egg Waste:";
            // 
            // txtbirdmortality
            // 
            this.txtbirdmortality.Location = new System.Drawing.Point(183, 18);
            this.txtbirdmortality.Name = "txtbirdmortality";
            this.txtbirdmortality.ReadOnly = true;
            this.txtbirdmortality.Size = new System.Drawing.Size(70, 20);
            this.txtbirdmortality.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtbirdsale);
            this.groupBox4.Controls.Add(this.txteggsale);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(76, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 90);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sale Report:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Egg Sale:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(5, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total Birds Sale:";
            // 
            // txtbirdsale
            // 
            this.txtbirdsale.Location = new System.Drawing.Point(123, 52);
            this.txtbirdsale.Name = "txtbirdsale";
            this.txtbirdsale.ReadOnly = true;
            this.txtbirdsale.Size = new System.Drawing.Size(70, 20);
            this.txtbirdsale.TabIndex = 6;
            // 
            // txteggsale
            // 
            this.txteggsale.Location = new System.Drawing.Point(123, 14);
            this.txteggsale.Name = "txteggsale";
            this.txteggsale.ReadOnly = true;
            this.txteggsale.Size = new System.Drawing.Size(70, 20);
            this.txteggsale.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtbirdpurchase);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtmedicinepurchase);
            this.groupBox3.Controls.Add(this.txtfeedpurchase);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(433, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 163);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Report:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Feed Purchase:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(5, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Medicine Purchase:";
            // 
            // txtbirdpurchase
            // 
            this.txtbirdpurchase.Location = new System.Drawing.Point(159, 85);
            this.txtbirdpurchase.Name = "txtbirdpurchase";
            this.txtbirdpurchase.ReadOnly = true;
            this.txtbirdpurchase.Size = new System.Drawing.Size(70, 20);
            this.txtbirdpurchase.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(6, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total Birds Purchase:";
            // 
            // txtmedicinepurchase
            // 
            this.txtmedicinepurchase.Location = new System.Drawing.Point(159, 52);
            this.txtmedicinepurchase.Name = "txtmedicinepurchase";
            this.txtmedicinepurchase.ReadOnly = true;
            this.txtmedicinepurchase.Size = new System.Drawing.Size(70, 20);
            this.txtmedicinepurchase.TabIndex = 6;
            // 
            // txtfeedpurchase
            // 
            this.txtfeedpurchase.Location = new System.Drawing.Point(159, 18);
            this.txtfeedpurchase.Name = "txtfeedpurchase";
            this.txtfeedpurchase.ReadOnly = true;
            this.txtfeedpurchase.Size = new System.Drawing.Size(70, 20);
            this.txtfeedpurchase.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DAILY REPORT";
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Image = global::PFMS1.Properties.Resources.blue_home_icon;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(5, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(85, 32);
            this.btnhome.TabIndex = 8;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnprintdreport
            // 
            this.btnprintdreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintdreport.Location = new System.Drawing.Point(524, 444);
            this.btnprintdreport.Name = "btnprintdreport";
            this.btnprintdreport.Size = new System.Drawing.Size(91, 30);
            this.btnprintdreport.TabIndex = 9;
            this.btnprintdreport.Text = "Print";
            this.btnprintdreport.UseVisualStyleBackColor = true;
            this.btnprintdreport.Click += new System.EventHandler(this.btnprintdreport_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // DynamicReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 486);
            this.Controls.Add(this.btnprintdreport);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "DynamicReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Report";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpgto;
        private System.Windows.Forms.DateTimePicker dtpgfrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblgtodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgfromdate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtexpensives;
        private System.Windows.Forms.TextBox txtincome;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txteggwaste;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmedicineconsumption;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtfeedconsumption;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbirdmortality;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbirdsale;
        private System.Windows.Forms.TextBox txteggsale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbirdpurchase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmedicinepurchase;
        private System.Windows.Forms.TextBox txtfeedpurchase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btngreport;
        private System.Windows.Forms.Button btnprintdreport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}