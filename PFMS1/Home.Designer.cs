namespace PFMS1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnstock = new System.Windows.Forms.Button();
            this.btnexitprogram = new System.Windows.Forms.Button();
            this.btnconsumption = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mistock = new System.Windows.Forms.ToolStripMenuItem();
            this.mipurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.misale = new System.Windows.Forms.ToolStripMenuItem();
            this.miconsumption = new System.Windows.Forms.ToolStripMenuItem();
            this.mireport = new System.Windows.Forms.ToolStripMenuItem();
            this.miemployees = new System.Windows.Forms.ToolStripMenuItem();
            this.miexit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.micalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.minotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.mikeyboard = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.lbldt = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.btndynamicreport = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnstock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.White;
            this.btnstock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnstock.Location = new System.Drawing.Point(12, 27);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(133, 45);
            this.btnstock.TabIndex = 0;
            this.btnstock.Text = "Stock";
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnexitprogram
            // 
            this.btnexitprogram.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnexitprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitprogram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexitprogram.Location = new System.Drawing.Point(812, 411);
            this.btnexitprogram.Name = "btnexitprogram";
            this.btnexitprogram.Size = new System.Drawing.Size(77, 32);
            this.btnexitprogram.TabIndex = 3;
            this.btnexitprogram.Text = "Close";
            this.btnexitprogram.UseVisualStyleBackColor = false;
            this.btnexitprogram.Click += new System.EventHandler(this.btnexitprogram_Click);
            // 
            // btnconsumption
            // 
            this.btnconsumption.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnconsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsumption.ForeColor = System.Drawing.Color.White;
            this.btnconsumption.Location = new System.Drawing.Point(12, 208);
            this.btnconsumption.Name = "btnconsumption";
            this.btnconsumption.Size = new System.Drawing.Size(133, 45);
            this.btnconsumption.TabIndex = 4;
            this.btnconsumption.Text = "Consumption";
            this.btnconsumption.UseVisualStyleBackColor = false;
            this.btnconsumption.Click += new System.EventHandler(this.btnconsumption_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mistock,
            this.mipurchase,
            this.misale,
            this.miconsumption,
            this.mireport,
            this.miemployees,
            this.miexit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mistock
            // 
            this.mistock.Name = "mistock";
            this.mistock.Size = new System.Drawing.Size(152, 22);
            this.mistock.Text = "Stock";
            this.mistock.Click += new System.EventHandler(this.mistock_Click);
            // 
            // mipurchase
            // 
            this.mipurchase.Name = "mipurchase";
            this.mipurchase.Size = new System.Drawing.Size(152, 22);
            this.mipurchase.Text = "Purchase";
            this.mipurchase.Click += new System.EventHandler(this.mipurchase_Click);
            // 
            // misale
            // 
            this.misale.Name = "misale";
            this.misale.Size = new System.Drawing.Size(152, 22);
            this.misale.Text = "Sale";
            this.misale.Click += new System.EventHandler(this.misale_Click);
            // 
            // miconsumption
            // 
            this.miconsumption.Name = "miconsumption";
            this.miconsumption.Size = new System.Drawing.Size(152, 22);
            this.miconsumption.Text = "Consumption";
            this.miconsumption.Click += new System.EventHandler(this.miconsumption_Click);
            // 
            // mireport
            // 
            this.mireport.Name = "mireport";
            this.mireport.Size = new System.Drawing.Size(152, 22);
            this.mireport.Text = "Report";
            this.mireport.Click += new System.EventHandler(this.mireport_Click);
            // 
            // miemployees
            // 
            this.miemployees.Name = "miemployees";
            this.miemployees.Size = new System.Drawing.Size(152, 22);
            this.miemployees.Text = "Employees";
            this.miemployees.Click += new System.EventHandler(this.miemployees_Click);
            // 
            // miexit
            // 
            this.miexit.Name = "miexit";
            this.miexit.Size = new System.Drawing.Size(152, 22);
            this.miexit.Text = "Exit";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.micalculator,
            this.minotepad,
            this.mikeyboard});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // micalculator
            // 
            this.micalculator.Name = "micalculator";
            this.micalculator.Size = new System.Drawing.Size(128, 22);
            this.micalculator.Text = "Calculator";
            this.micalculator.Click += new System.EventHandler(this.micalculator_Click);
            // 
            // minotepad
            // 
            this.minotepad.Name = "minotepad";
            this.minotepad.Size = new System.Drawing.Size(128, 22);
            this.minotepad.Text = "Notepad";
            this.minotepad.Click += new System.EventHandler(this.minotepad_Click);
            // 
            // mikeyboard
            // 
            this.mikeyboard.Name = "mikeyboard";
            this.mikeyboard.Size = new System.Drawing.Size(128, 22);
            this.mikeyboard.Text = "Keyboard";
            this.mikeyboard.Click += new System.EventHandler(this.mikeyboard_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.Location = new System.Drawing.Point(12, 390);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(133, 45);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.Color.White;
            this.btnreports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreports.Location = new System.Drawing.Point(12, 268);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(133, 45);
            this.btnreports.TabIndex = 5;
            this.btnreports.Text = "Daily Report";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnsale
            // 
            this.btnsale.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsale.ForeColor = System.Drawing.Color.White;
            this.btnsale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsale.Location = new System.Drawing.Point(12, 148);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(133, 45);
            this.btnsale.TabIndex = 2;
            this.btnsale.Text = "Sale";
            this.btnsale.UseVisualStyleBackColor = false;
            this.btnsale.Click += new System.EventHandler(this.btnsale_Click);
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.ForeColor = System.Drawing.Color.White;
            this.btnpurchase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpurchase.Location = new System.Drawing.Point(12, 87);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(133, 45);
            this.btnpurchase.TabIndex = 1;
            this.btnpurchase.Text = "Purchase";
            this.btnpurchase.UseVisualStyleBackColor = false;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.Location = new System.Drawing.Point(416, 427);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(51, 16);
            this.lbldt.TabIndex = 15;
            this.lbldt.Text = "label7";
            this.lbldt.Click += new System.EventHandler(this.lbldt_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(764, 36);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(51, 16);
            this.lblusername.TabIndex = 16;
            this.lblusername.Text = "label7";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Image = global::PFMS1.Properties.Resources.logout_button_png_svg_hi;
            this.btnlogout.Location = new System.Drawing.Point(840, 32);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(50, 25);
            this.btnlogout.TabIndex = 17;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.Control;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregister.Image = global::PFMS1.Properties.Resources.images__1_;
            this.btnregister.Location = new System.Drawing.Point(812, 63);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(78, 28);
            this.btnregister.TabIndex = 18;
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btndynamicreport
            // 
            this.btndynamicreport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btndynamicreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndynamicreport.ForeColor = System.Drawing.Color.White;
            this.btndynamicreport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndynamicreport.Location = new System.Drawing.Point(12, 331);
            this.btndynamicreport.Name = "btndynamicreport";
            this.btndynamicreport.Size = new System.Drawing.Size(133, 45);
            this.btndynamicreport.TabIndex = 19;
            this.btndynamicreport.Text = "Dynamic Report";
            this.btndynamicreport.UseVisualStyleBackColor = false;
            this.btndynamicreport.Click += new System.EventHandler(this.btndynamicreport_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(421, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 42);
            this.label8.TabIndex = 21;
            this.label8.Text = "Welcome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(473, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 42);
            this.label9.TabIndex = 22;
            this.label9.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(232, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(622, 42);
            this.label10.TabIndex = 23;
            this.label10.Text = "Poultry Farm Management System";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::PFMS1.Properties.Resources.poultry_chicken;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 452);
            this.Controls.Add(this.btnstock);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.btnsale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnconsumption);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndynamicreport);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbldt);
            this.Controls.Add(this.btnexitprogram);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Button btnsale;
        private System.Windows.Forms.Button btnexitprogram;
        private System.Windows.Forms.Button btnconsumption;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mistock;
        private System.Windows.Forms.ToolStripMenuItem mipurchase;
        private System.Windows.Forms.ToolStripMenuItem misale;
        private System.Windows.Forms.ToolStripMenuItem miconsumption;
        private System.Windows.Forms.ToolStripMenuItem mireport;
        private System.Windows.Forms.ToolStripMenuItem miemployees;
        private System.Windows.Forms.ToolStripMenuItem miexit;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem micalculator;
        private System.Windows.Forms.ToolStripMenuItem minotepad;
        private System.Windows.Forms.ToolStripMenuItem mikeyboard;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btndynamicreport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}