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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        EmployeeBl ebl = new EmployeeBl();
        SalaryBl sbl = new SalaryBl();
        private void Employee_Load(object sender, EventArgs e)
        {       //employee 
            dgvemployee.DataSource = ebl.showall();
            btnempupdate.Enabled = false;
            btnedelete.Enabled = false;
               //salary
            dgvsalary.DataSource = sbl.showall();
            btnsupdate.Enabled = false;
         
            
        }

        private void btneadd_Click(object sender, EventArgs e)
        {
             Regex numb = new Regex(@"^([0-9]*|\d*)$");

             if (!numb.IsMatch(txtesalary.Text)) 
             {
                 errorProvider1.SetError(txtesalary, "enter numeric value!");
             }
             else if (txtesalary.Text == "")
             {
                 errorProvider1.SetError(txtename, "enter Salary Please!");
             }
             else if (txtename.Text == "") 
             {
                 errorProvider1.SetError(txtename, "enter Name Please!");
             }
             else if (txtedeignation.Text == "")
             {
                 errorProvider1.SetError(txtedeignation, "enter Designation Please!");
             }
             else
             {
                 EmployeeModel emodel = new EmployeeModel();
                 emodel.Ename = txtename.Text;
                 emodel.Addres = txteaddress.Text;
                 emodel.Phoneno = mtxtephone.Text;
                 emodel.Cnic = mtxtecnic.Text;
                 emodel.Designation = txtedeignation.Text;
                 emodel.Hdate = dtpehire.Value;
                 emodel.Salary = Convert.ToInt32(txtesalary.Text);
                 if (ebl.insert(emodel))
                 {
                     MessageBox.Show("Employee is Inserted Succesfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     dgvemployee.DataSource=ebl.showall();

                 }
                 else
                 {
                     MessageBox.Show("employee is not inserted succesfully!");
                 }
             }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void dgvemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // birdstockbl b = new birdstockbl();
                //  List<birdstockmodel> m = new List<birdstockmodel>();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvemployee.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lbleserialno.Text = row.Cells[0].Value.ToString();
               txtename.Text = row.Cells[1].Value.ToString();
                txteaddress.Text = row.Cells[2].Value.ToString();
                mtxtephone.Text = row.Cells[3].Value.ToString();
                mtxtecnic.Text = row.Cells[4].Value.ToString();
                txtedeignation.Text = row.Cells[5].Value.ToString();
               dtpehire.Text= row.Cells[6].Value.ToString();
               txtesalary.Text = row.Cells[7].Value.ToString();
               btneadd.Enabled = false;
               btnedelete.Enabled = true;
               btnempupdate.Enabled = true;
               



            }
        }

        private void btnempupdate_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");

            if (!numb.IsMatch(txtesalary.Text))
            {
                errorProvider1.SetError(txtesalary, "enter numeric value!");
            }
            else if (txtesalary.Text == "")
            {
                errorProvider1.SetError(txtename, "enter Salary Please!");
            }
            else if (txtename.Text == "")
            {
                errorProvider1.SetError(txtename, "enter Name Please!");
            }
            else if (txtedeignation.Text == "")
            {
                errorProvider1.SetError(txtedeignation, "enter Designation Please!");
            }
            else
            {
                EmployeeModel emodel = new EmployeeModel();
                emodel.Ename = txtename.Text;
                emodel.Addres = txteaddress.Text;
                emodel.Phoneno = mtxtephone.Text;
                emodel.Cnic = mtxtecnic.Text;
                emodel.Designation = txtedeignation.Text;
                emodel.Hdate = dtpehire.Value;
                emodel.Salary = Convert.ToInt32(txtesalary.Text);
                ebl.update(emodel);
                
                 MessageBox.Show("employee record updated succesfully!");
                 dgvemployee.DataSource = ebl.showall();

               
            }
        }

        private void btnemploadall_Click(object sender, EventArgs e)
        {
            dgvemployee.DataSource = ebl.showall();
        }

        private void btnempfind_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");

            if (numb.IsMatch(txtempfind.Text))
            {
                errorProvider1.SetError(txtempfind, "enter employee name!");
            }
            else if (txtempfind.Text == "")
            {
                errorProvider1.SetError(txtempfind, "enter employee name!");

            }
            else 
            {
                String s;
                s=txtempfind.Text;
                dgvemployee.DataSource=ebl.find(s);
            
            }
        }

        private void btnempcancel_Click(object sender, EventArgs e)
        {
            lbleserialno.Text = "0";
            txtename.Text = "";
            txtesalary.Text = "";
            txtempfind.Text = "";
            txtedeignation.Text = "";
            txteaddress.Text = "";
            dtpehire.Value = dtpehire.Value.Date;

        }

        private void btnedelete_Click(object sender, EventArgs e)
        {
            EmployeeModel emodel = new EmployeeModel();
            emodel.Employeeid = Convert.ToInt32(lbleserialno.Text);
            ebl.delete(emodel);
            MessageBox.Show("employee record deleted");
            dgvemployee.DataSource = ebl.showall();
        }
                          //    Salary methods
        private void btnmakesalary_Click(object sender, EventArgs e)
        {
            SalaryModel smodel = new SalaryModel();
            smodel.Employeeid = Convert.ToInt32(cbempname.SelectedValue.ToString());
            smodel.Date = dtpspaydate.Value;
            smodel.Name = cbempname.Text;
            smodel.Status = cbsstatus.Text;
            if (sbl.insert(smodel))
            {
                MessageBox.Show("salary paid!");
                dgvsalary.DataSource = sbl.showall();
            }
            else { MessageBox.Show("salary not paid!"); }
        }

        private void btnsupdate_Click(object sender, EventArgs e)
        {
            SalaryModel smodel = new SalaryModel();
            smodel.Srno = Convert.ToInt32(lblssrialno.Text);
            smodel.Employeeid = Convert.ToInt32(cbempname.SelectedValue.ToString());
            smodel.Date = dtpspaydate.Value;
            smodel.Name = cbempname.Text;
            smodel.Status = cbsstatus.Text;
            sbl.insert(smodel);
            MessageBox.Show("updated succesfully!");
            dgvsalary.DataSource = sbl.showall();
        }

        private void btnscancel_Click(object sender, EventArgs e)
        {
            lblssrialno.Text = "0";
            txtsfind.Text = "";
            dtpspaydate.Value = dtpehire.Value.Date;
        }

        private void btnsloadall_Click(object sender, EventArgs e)
        {
            dgvsalary.DataSource = sbl.showall();
        }

        private void dgvsalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // birdstockbl b = new birdstockbl();
                //  List<birdstockmodel> m = new List<birdstockmodel>();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvsalary.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lbleserialno.Text = row.Cells[0].Value.ToString();
               // txtename.Text = row.Cells[1].Value.ToString();
                dtpspaydate.Text = row.Cells[2].Value.ToString();
                cbempname.Text = row.Cells[3].Value.ToString();
                cbsstatus.Text = row.Cells[4].Value.ToString();
               
                btneadd.Enabled = false;
                btnedelete.Enabled = true;
                btnempupdate.Enabled = true;

                btnmakesalary.Enabled = false;
                btnsupdate.Enabled = true;


            }
        }

        private void btnsfind_Click(object sender, EventArgs e)
        {
            Regex numb = new Regex(@"^([0-9]*|\d*)$");

            if (numb.IsMatch(txtsfind.Text))
            {
                errorProvider1.SetError(txtsfind, "enter employee name!");
            }
            else if (txtsfind.Text == "")
            {
                errorProvider1.SetError(txtsfind, "enter employee name!");

            }
            else
            {
                String s;
                s = txtsfind.Text;
                dgvsalary.DataSource = sbl.find(s);

            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            cbempname.DataSource = sbl.combobox();
            cbempname.DisplayMember = "Ename";
            cbempname.ValueMember = "Employee_Id";
        }
    }
}
