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
using System.Data.SqlClient;

namespace Guru_Pro
{
    public partial class Item_Registation : MetroForm
    {
        Class1 Obj = new Class1();
        DataTable dt;
        SqlDataAdapter sda;
     

        public Item_Registation()
        {
            InitializeComponent();
        }

        //private void Item_Registation_Load(object sender, EventArgs e)
        //{
            
        //}

        //private void metroLabel1_Click(object sender, EventArgs e)
        //{

        //}

        //private void metroTextBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void metroButton1_Click(object sender, EventArgs e)
        //{
            
        //}

        private void Item_Registation_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ItemRegistationTable' table. You can move, or remove it, as needed.
            this.itemRegistationTableTableAdapter.Fill(this.database1DataSet.ItemRegistationTable);          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                Obj.addCustomer(int.Parse(txtItemID.Text), txtName.Text, txtCatagory.Text, txtBuyPrice.Text, txtSellPrice.Text, textDiscription.Text);
                MessageBox.Show("OK");

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {

            }
        }

        //private void Edit(bool value)
        //{
        //    txtItemID.Enabled = value;
        //    txtName.Enabled = value;
        //    txtBuyPrice.Enabled = value;
        //    txtSellPrice.Enabled = value;
        //}
        private void btnNew_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Edit(true);
            //    database1DataSet.ItemRegistationTable.AddItemRegistationTableRow(database1DataSet.ItemRegistationTable.NewItemRegistationTableRow());
            //    itemRegistationTableBindingSource.MoveLast();
            //    txtItemID.Focus();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    database1DataSet.ItemRegistationTable.RejectChanges();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //scb 
        }
    }
}
