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
    public partial class Item : MetroForm
    {
        public Item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Item_Registation fmm = new Item_Registation();
            fmm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ItemView fmm = new ItemView();
            fmm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ItemDamage fmm = new ItemDamage();
            fmm.ShowDialog();
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
    }
}
