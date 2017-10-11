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
    public partial class Stock : MetroForm
    {
        public Stock()
        {
            InitializeComponent();
        }

        

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            StockDamage fmm = new StockDamage();
            fmm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StockView fmm = new StockView();
            fmm.ShowDialog();
        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
