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
    public partial class ItemDamage : MetroForm
    {
        public ItemDamage()
        {
            InitializeComponent();
        }

        private void ItemDamage_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'database1DataSet1.ItemDamageTable' table. You can move, or remove it, as needed.
            //this.itemDamageTableTableAdapter.Fill(this.database1DataSet1.ItemDamageTable);

        }

        Class1 Obj = new Class1();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                Obj.addCustomer(int.Parse(txtItemID.Text), txtName.Text, txtCatagory.Text, txtBuyPrice.Text, txtSellPrice.Text, textDiscription.Text);
                MessageBox.Show("OK");


            }
            catch (Exception ex)
            {

            }
        }
    }
}
