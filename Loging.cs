using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Guru_Pro
{
    public partial class Loging : MetroForm
    {
        public Loging()
        {
            InitializeComponent();
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string UserName = "admin";
            string PassWord = "admin";

            if (UserName == txtUserName.Text && PassWord == txtPassWord.Text)
            {
                MessageBox.Show("  Welcome to New World  ");
                Home fmm = new Home();
                fmm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter Valid UserName or PaasWord....!");
            }

            //Home fmm = new Home();
           // fmm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           Sing_Up fmm = new Sing_Up ();
           fmm.ShowDialog();
        }
    }
}
