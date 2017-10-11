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
    public partial class Sing_Up : MetroForm
    {
        public Sing_Up()
        {
            InitializeComponent();
        }

        private void Sing_Up_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Loging fmm = new Loging();
            fmm.ShowDialog();
        }
    }
}
