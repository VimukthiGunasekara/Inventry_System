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
    public partial class StockDamage : MetroForm
    {
        public StockDamage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void StockDamage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ItemDamageTable' table. You can move, or remove it, as needed.
            this.itemDamageTableTableAdapter.Fill(this.database1DataSet1.ItemDamageTable);
            // TODO: This line of code loads data into the 'database1DataSet.ItemRegistationTable' table. You can move, or remove it, as needed.
            this.itemRegistationTableTableAdapter.Fill(this.database1DataSet.ItemRegistationTable);

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
