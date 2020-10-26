using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelview;
namespace PFMS1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
            
        }
        public Home(String qs)
        {
            InitializeComponent();
          
        }
    
      
       
     
        private void btnstock_Click(object sender, EventArgs e)
        {
            
            Stock s = new Stock();
            this.Hide();
            s.Show();
           

        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            Purhcase p = new Purhcase();
            this.Hide();
            p.Show();
        }

        private void btnexitprogram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            this.Hide();
            sale.Show();
        }

        private void btnconsumption_Click(object sender, EventArgs e)
        {
            Consumption c = new Consumption();
            this.Hide();
            c.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            this.Hide();
            r.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbldt.Text = DateTime.Now.ToString("dddd dd-MMM-yyyy  hh:mm:ss tt");

            lblusername.Text = usernamedatamodel.TextData;   
        }

        private void mistock_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            this.Hide();
            s.Show();
        }

        private void mipurchase_Click(object sender, EventArgs e)
        {
            Purhcase s = new Purhcase();
            this.Hide();
            s.Show();
        }

        private void misale_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            this.Hide();
            s.Show();
        }

        private void miconsumption_Click(object sender, EventArgs e)
        {
            Consumption s = new Consumption();
            this.Hide();
            s.Show();
        }

        private void mireport_Click(object sender, EventArgs e)
        {
            Reports s = new Reports();
            this.Hide();
            s.Show();
        }

        private void miemployees_Click(object sender, EventArgs e)
        {
            Employee s = new Employee();
            this.Hide();
            s.Show();
        }

        private void minotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void micalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void mikeyboard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            
        }

        private void lbldt_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void btndynamicreport_Click(object sender, EventArgs e)
        {
            DynamicReport dr = new DynamicReport();
            this.Hide();
            dr.Show();
        }
    }
}
