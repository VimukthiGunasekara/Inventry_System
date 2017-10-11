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
    public partial class StockView : MetroForm
    {
        public StockView()
        {
            InitializeComponent();
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ItemRegistationTable' table. You can move, or remove it, as needed.
            this.itemRegistationTableTableAdapter.Fill(this.database1DataSet.ItemRegistationTable);

        }
    }
}
