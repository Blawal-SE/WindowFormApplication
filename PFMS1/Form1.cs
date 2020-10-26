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
namespace PFMS1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
     

        LoginBl lbl = new LoginBl();
       
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "") 
            {
                errorProvider1.SetError(txtusername,"Enter user name Please!");
                errorProvider1.SetError(txtpasswword, "");
            }
            else if (txtpasswword.Text == "")
            {
                errorProvider1.SetError(txtpasswword, "Enter password Please!");
                errorProvider1.SetError(txtusername, "");
            }
            else
            {
                errorProvider1.SetError(txtusername, "");
                errorProvider1.SetError(txtpasswword, "");
                String u, p;
                u = txtusername.Text;
                p = txtpasswword.Text;

                if (lbl.login(u, p))
                {
                    Home f = new Home();
                    usernamedatamodel.TextData = u;
                     this.Hide();

                    f.Show();
                }
                else 
                {
                    MessageBox.Show("User name or Password is wrong!","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogin.FlatStyle = FlatStyle.Flat;
          btnlogin.FlatAppearance.BorderColor = Color.Red;
         btnlogin.FlatAppearance.BorderSize = 1;
           
        }

        private void btnloginexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
