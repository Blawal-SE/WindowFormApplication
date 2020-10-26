using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace PFMS1
{
    public partial class DynamicReport : Form
    {
        public DynamicReport()
        {
            InitializeComponent();
        }
        ReportBl rbl = new ReportBl();
        private void btngreport_Click(object sender, EventArgs e)
        {
            DateTime date,date1;
            date = dtpgfrom.Value.Date;
            date1 = dtpgto.Value.Date;
            int a;
            txtbirdpurchase.Text = rbl.birdpurchase(date,date1).ToString();
            txtfeedpurchase.Text = rbl.Feedpurchase(date,date1).ToString();
            txtmedicinepurchase.Text = rbl.medicinepurchase(date,date1).ToString();
            txtbirdmortality.Text = rbl.birdconsumption(date,date1).ToString();
            txteggwaste.Text = rbl.eggconsumption(date,date1).ToString();
            txtmedicineconsumption.Text = rbl.medicineconsumption(date,date1).ToString();
            txtfeedconsumption.Text = rbl.feedconsumption(date,date1).ToString();
            txtbirdsale.Text = rbl.birdsale(date,date1).ToString();
            txteggsale.Text = rbl.eggsale(date,date1).ToString();
            txtincome.Text = rbl.totalincom(date,date1).ToString();
            a = rbl.expbirdpurchase(date,date1) + rbl.expFeedpurchase(date,date1) + rbl.expmedicinepurchase(date,date1);
            txtexpensives.Text = a.ToString();
            lblgfromdate.Text = Convert.ToString(dtpgfrom.Value.Date);
            lblgtodate.Text = Convert.ToString(dtpgto.Value.Date);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
        Bitmap bmp;
        private void btnprintdreport_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
