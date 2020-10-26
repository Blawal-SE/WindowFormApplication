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
using Modelview;
using System.Text.RegularExpressions;

namespace PFMS1
{
    public partial class Consumption : Form
    {
        FeedConsumptionBl fcbl = new FeedConsumptionBl();
        MedicineConsumptionBl mcbl = new MedicineConsumptionBl();
        BirdsMortalityBl bcbl = new BirdsMortalityBl();
        EggWasteBl ecbl = new EggWasteBl();
        public Consumption()
        {
            InitializeComponent();
        }

        private void Consumption_Load(object sender, EventArgs e)
        {
                   //   feed consumption 
            dgvfeedconsume.DataSource = fcbl.showall();
            cbFeedtype.DataSource = fcbl.combobox();
            cbFeedtype.DisplayMember = "F_Type";
            cbFeedtype.ValueMember = "F_SrNo";
            btnfcupdate.Enabled = false;
                   // medicine consumption
            dgvmconsumtion.DataSource = mcbl.showall();
            cbmctype.DataSource = mcbl.combobox();
            cbmctype.DisplayMember = "M_Type";
            cbmctype.ValueMember = "M_SrNo";
            btnmcupdate.Enabled = false;
                  // birds mortality
            dgvbc.DataSource = bcbl.showall();
            cbbcbirdtype.DataSource = bcbl.combobox();
            cbbcbirdtype.DisplayMember = "B_Type";
            cbbcbirdtype.ValueMember = "B_SrNo";
            btnbcupdate.Enabled = false;
                // eggs waste
            dgvec.DataSource = ecbl.showall();
            cbeceggtype.DataSource = ecbl.combobox();
            cbeceggtype.DisplayMember = "E_Type";
            cbeceggtype.ValueMember = "E_SrNo";
            btnecupdate.Enabled = false;
        }

                
                // feed consumption click methods
        
        private void btnfeedconsume_Click(object sender, EventArgs e)
        {
           
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
           
            if (!numb.IsMatch(txtfintake.Text))
            {
                errorProvider1.SetError(txtfintake, "enter numeric values");

            }
            else if (txtfintake.Text == "")
            {
                errorProvider1.SetError(txtfintake, "Enter Value");
            }
            
            else
            {
                int fintake = Convert.ToInt32(txtfintake.Text);
                int sr = Convert.ToInt32(cbFeedtype.SelectedValue.ToString());
                if (!(fcbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtfintake, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtfintake, "");
                    FeedConsumptionModel fcmodel = new FeedConsumptionModel();
                    fcmodel.Date = dtpfeedc.Value;
                    fcmodel.F_serialno = Convert.ToInt32(cbFeedtype.SelectedValue.ToString());
                    fcmodel.Feed_type = cbFeedtype.Text;
                    fcmodel.Feed_intake = Convert.ToInt32(txtfintake.Text);
                    fcbl.insert(fcmodel);
                    dgvfeedconsume.DataSource = fcbl.showall();
                    MessageBox.Show("Consumed done!","Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
        }

        private void btnfhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void btnfcloadall_Click(object sender, EventArgs e)
        {
            dgvfeedconsume.DataSource = fcbl.showall();
        }

        private void btnfcsearch_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
        if (txtfcsearch.Text == "")
        {
            errorProvider1.SetError(txtfcsearch, "Enter Feed Type");
        }
        else
        {
            String s = txtfcsearch.Text;
            dgvfeedconsume.DataSource = fcbl.find(s);
        }
      }

        private void dgvfeedconsume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               // birdstockbl b = new birdstockbl();
              //  List<birdstockmodel> m = new List<birdstockmodel>();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvfeedconsume.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblfcserialno.Text = row.Cells[0].Value.ToString();
                cbFeedtype.Text = row.Cells[1].Value.ToString();
                txtfintake.Text = row.Cells[2].Value.ToString();
                dtpfeedc.Text = row.Cells[3].Value.ToString();
                btnfeedconsume.Enabled = false;
                btnfcupdate.Enabled = true;
                


            }
        }

        private void btnfccancel_Click(object sender, EventArgs e)
        {
            dtpfeedc.Value = DateTime.Now;
            txtfintake.Text = "";
            lblfcserialno.Text = "";
            btnfcupdate.Enabled = false;
            btnfeedconsume.Enabled = true;
        }

        private void btnfcupdate_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
          
            if (!numb.IsMatch(txtfintake.Text))
            {
                errorProvider1.SetError(txtfintake, "enter numeric values");

            }
            else if (txtfintake.Text == "")
            {
                errorProvider1.SetError(txtfintake, "Enter Value");
            }
            else
            {
                int fintake = Convert.ToInt32(txtfintake.Text);
                int sr = Convert.ToInt32(cbFeedtype.SelectedValue.ToString());
                if (!(fcbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtfintake, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtfintake, "");
                    FeedConsumptionModel fcmodel = new FeedConsumptionModel();
                    fcmodel.Fc_serialno = Convert.ToInt32(lblfcserialno.Text);
                    fcmodel.Date = dtpfeedc.Value;
                    fcmodel.F_serialno = Convert.ToInt32(cbFeedtype.SelectedValue.ToString());
                    fcmodel.Feed_type = cbFeedtype.Text;
                    fcmodel.Feed_intake = Convert.ToInt32(txtfintake.Text);
                    if (fcbl.update(fcmodel))
                    {
                        dgvfeedconsume.DataSource = fcbl.showall();
                        MessageBox.Show("Update done!");
                    }
                    else { MessageBox.Show("Not Updated!"); }
                }
            }

        }
          
                  // medicine consumption click methods

        private void btnmconsume_Click(object sender, EventArgs e)
        {

            Regex numb = new Regex(@"^([0-9]*|\d*)$");
          
            if (!numb.IsMatch(txtmcintake.Text))
            {
                errorProvider1.SetError(txtmcintake, "enter numeric values");

            }
            else if (txtmcintake.Text == "")
            {
                errorProvider1.SetError(txtmcintake, "Enter Value");
            }
            else
            {
                int fintake = Convert.ToInt32(txtmcintake.Text);
                int sr = Convert.ToInt32(cbmctype.SelectedValue.ToString());
                if (!(mcbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtmcintake, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtmcintake, "");
                    MedicineConsumptionModel fcmodel = new MedicineConsumptionModel();
                    fcmodel.Date = dtpmc.Value;
                    fcmodel.M_serialno = Convert.ToInt32(cbmctype.SelectedValue.ToString());
                    fcmodel.Medicine_type = cbmctype.Text;
                    fcmodel.Medicine_intake = Convert.ToInt32(txtmcintake.Text);
                    mcbl.insert(fcmodel);
                    dgvmconsumtion.DataSource = mcbl.showall();
                    MessageBox.Show("consumed done!");
                 }
             }
        }

        private void btnmcupdate_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
            int fintake = Convert.ToInt32(txtmcintake.Text);
            int sr = Convert.ToInt32(cbmctype.SelectedValue.ToString());
            if (!numb.IsMatch(txtmcintake.Text))
            {
                errorProvider1.SetError(txtmcintake, "enter numeric values");

            }
            else if (txtmcintake.Text == "")
            {
                errorProvider1.SetError(txtmcintake, "Enter Value");
            }
            else if (!(mcbl.stocklimitation(sr) >= fintake))
            {
                errorProvider1.SetError(txtmcintake, "out of stock");
            }
            else
            {
                errorProvider1.SetError(txtmcintake, "");
                MedicineConsumptionModel fcmodel = new MedicineConsumptionModel();
                fcmodel.Mc_serialno = Convert.ToInt32(lblmcserialno.Text);
                fcmodel.Date = dtpmc.Value;
                fcmodel.M_serialno = Convert.ToInt32(cbmctype.SelectedValue.ToString());
                fcmodel.Medicine_type = cbmctype.Text;
                fcmodel.Medicine_intake = Convert.ToInt32(txtmcintake.Text);
                if (mcbl.update(fcmodel))
                {
                    dgvmconsumtion.DataSource = mcbl.showall();
                    MessageBox.Show("Update done!");
                }
                else { MessageBox.Show("Not Updated!"); }
            }

        }

        private void btnmccancel_Click(object sender, EventArgs e)
        {
           dtpmc.Value = DateTime.Now;
            txtmcintake.Text = "";
            lblmcserialno.Text = "";
            btnmcupdate.Enabled = false;
           btnmconsume.Enabled = true;

        }

        private void dgvmconsumtion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // birdstockbl b = new birdstockbl();
                //  List<birdstockmodel> m = new List<birdstockmodel>();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvmconsumtion.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblmcserialno.Text = row.Cells[0].Value.ToString();
                cbmctype.Text = row.Cells[1].Value.ToString();
                txtmcintake.Text = row.Cells[2].Value.ToString();
                dtpfeedc.Text = row.Cells[3].Value.ToString();
                btnmconsume.Enabled = false;
                btnmcupdate.Enabled = true;



            }

        }

        private void btnmcloadall_Click(object sender, EventArgs e)
        {
            dgvmconsumtion.DataSource = mcbl.showall();
        }

        private void btnmcfind_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
            if (txtmcsearch.Text == "")
            {
                errorProvider1.SetError(txtmcsearch, "Enter medicine Type");
            }
            else
            {
                String s = txtmcsearch.Text;
                dgvmconsumtion.DataSource = mcbl.find(s);
            }
        }
                  
                  // Birds consumption click methods

        private void btnbcdied_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");

            if (!numb.IsMatch(txtbcquanity.Text))
            {
                errorProvider1.SetError(txtbcquanity, "enter numeric values");

            }
            else if (txtbcquanity.Text == "")
            {
                errorProvider1.SetError(txtbcquanity, "Enter Value");
            }
            else
            {
                int fintake = Convert.ToInt32(txtbcquanity.Text);
                int sr = Convert.ToInt32(cbbcbirdtype.SelectedValue.ToString());
                if (!(bcbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtbcquanity, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtbcquanity, "");
                    BirdsMortalityModel fcmodel = new BirdsMortalityModel();
                    fcmodel.Date = dtpbc.Value;
                    fcmodel.B_serialno = Convert.ToInt32(cbbcbirdtype.SelectedValue.ToString());
                    fcmodel.Bird_type = cbbcbirdtype.Text;
                    fcmodel.Quantity = Convert.ToInt32(txtbcquanity.Text);
                    bcbl.insert(fcmodel);
                   dgvbc.DataSource = bcbl.showall();
                    MessageBox.Show("successfuly done!");
                }
            }
        }

        private void btnbccancel_Click(object sender, EventArgs e)
        {
            dtpbc.Value = DateTime.Now;
            txtbcquanity.Text = "";
            lblbcserialno.Text = "";
            btnbcupdate.Enabled = false;
           btnbcdied.Enabled = true;

        }

        private void btnbcupdate_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
           
            if (!numb.IsMatch(txtbcquanity.Text))
            {
                errorProvider1.SetError(txtbcquanity, "enter numeric values");

            }
            else if (txtbcquanity.Text == "")
            {
                errorProvider1.SetError(txtbcquanity, "Enter Value");
            }
            
            else
            {
                int fintake = Convert.ToInt32(txtbcquanity.Text);
                int sr = Convert.ToInt32(cbbcbirdtype.SelectedValue.ToString());
                if (!(bcbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtbcquanity, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtbcquanity, "");
                    BirdsMortalityModel fcmodel = new BirdsMortalityModel();
                    fcmodel.Bc_serialno = Convert.ToInt32(lblbcserialno.Text);
                    fcmodel.Date = dtpbc.Value;
                    fcmodel.B_serialno = Convert.ToInt32(cbbcbirdtype.SelectedValue.ToString());
                    fcmodel.Bird_type = cbbcbirdtype.Text;
                    fcmodel.Quantity = Convert.ToInt32(txtbcquanity.Text);
                    if (bcbl.update(fcmodel))
                    {
                        dgvbc.DataSource = bcbl.showall();
                        MessageBox.Show("Update done!");
                    }
                    else { MessageBox.Show("Not Updated!"); }
                }
            }

            

        }

        private void btnbcloadall_Click(object sender, EventArgs e)
        {
            dgvbc.DataSource = mcbl.showall();
        }

        private void btnbcfind_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
            if (txtbcsearch.Text == "")
            {
                errorProvider1.SetError(txtbcsearch, "Enter medicine Type");
            }
            else
            {
                String s = txtbcsearch.Text;
                dgvbc.DataSource = bcbl.find(s);
            }

        }

        private void dgvbc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // birdstockbl b = new birdstockbl();
                //  List<birdstockmodel> m = new List<birdstockmodel>();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvbc.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblbcserialno.Text = row.Cells[0].Value.ToString();
                cbbcbirdtype.Text = row.Cells[1].Value.ToString();
                txtbcquanity.Text = row.Cells[2].Value.ToString();
                dtpbc.Text = row.Cells[3].Value.ToString();
                btnbcdied.Enabled = false;
                btnbcupdate.Enabled = true;



            }
        }
       
                      // Eggs consumption click methods

        private void btnecwaste_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");

            if (!numb.IsMatch(txtecquanity.Text))
            {
                errorProvider1.SetError(txtecquanity, "enter numeric values");

            }
            else if (txtecquanity.Text == "")
            {
                errorProvider1.SetError(txtecquanity, "Enter Value");
            }
            else
            {
                int fintake = Convert.ToInt32(txtecquanity.Text);
                int sr = Convert.ToInt32(cbeceggtype.SelectedValue.ToString());
                if (!(ecbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtecquanity, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtecquanity, "");
                    EggsWasteModel fcmodel = new EggsWasteModel();
                    fcmodel.Date = dtpec.Value;
                    fcmodel.E_serialno = Convert.ToInt32(cbeceggtype.SelectedValue.ToString());
                    fcmodel.Egg_type = cbeceggtype.Text;
                    fcmodel.Quantity = Convert.ToInt32(txtecquanity.Text);
                    ecbl.insert(fcmodel);
                    dgvec.DataSource = ecbl.showall();
                    MessageBox.Show("successfuly done!");
                }
            }

        }

        private void btnecupdate_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");

            if (!numb.IsMatch(txtecquanity.Text))
            {
                errorProvider1.SetError(txtecquanity, "enter numeric values");

            }
            else if (txtecquanity.Text == "")
            {
                errorProvider1.SetError(txtecquanity, "Enter Value");
            }

            else
            {
                int fintake = Convert.ToInt32(txtecquanity.Text);
                int sr = Convert.ToInt32(cbeceggtype.SelectedValue.ToString());
                if (!(ecbl.stocklimitation(sr) >= fintake))
                {
                    errorProvider1.SetError(txtecquanity, "out of stock");
                }
                else
                {
                    errorProvider1.SetError(txtecquanity, "");
                    EggsWasteModel fcmodel = new EggsWasteModel();
                    fcmodel.Ec_serialno = Convert.ToInt32(lblecserialno.Text);
                    fcmodel.Date = dtpec.Value;
                    fcmodel.E_serialno = Convert.ToInt32(cbeceggtype.SelectedValue.ToString());
                    fcmodel.Egg_type = cbeceggtype.Text;
                    fcmodel.Quantity = Convert.ToInt32(txtecquanity.Text);
                    if (ecbl.update(fcmodel))
                    {
                        dgvec.DataSource = ecbl.showall();
                        MessageBox.Show("Update done!");
                    }
                    else { MessageBox.Show("Not Updated!"); }
                }
            }

            

        }

        private void btneccancel_Click(object sender, EventArgs e)
        {
            dtpec.Value = DateTime.Now;
            txtecquanity.Text = "";
            lblecserialno.Text = "";
            btnecupdate.Enabled = false;
            btnecwaste.Enabled = true;
        }

        private void btnecloadall_Click(object sender, EventArgs e)
        {
            dgvec.DataSource = ecbl.showall();
        }

        private void btnecfind_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");
            if (txtecsearch.Text == "")
            {
                errorProvider1.SetError(txtecsearch, "Enter egg Type");
            }
            else
            {
                String s = txtecsearch.Text;
                dgvec.DataSource = ecbl.find(s);
            }
        }

        private void dgvec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // birdstockbl b = new birdstockbl();
                //  List<birdstockmodel> m = new List<birdstockmodel>();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvec.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblecserialno.Text = row.Cells[0].Value.ToString();
                cbeceggtype.Text = row.Cells[1].Value.ToString();
                txtecquanity.Text = row.Cells[2].Value.ToString();
                dtpec.Text = row.Cells[3].Value.ToString();
                btnecwaste.Enabled = false;
                btnecupdate.Enabled = true;



            }
        }
    }
}

