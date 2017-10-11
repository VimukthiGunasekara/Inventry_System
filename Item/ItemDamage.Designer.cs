namespace Guru_Pro
{
    partial class ItemDamage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDamageTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Guru_Pro.Database1DataSet1();
            this.textDiscription = new System.Windows.Forms.TextBox();
            this.Discription = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.SellPrice = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.BuyPrice = new System.Windows.Forms.Label();
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.Catagory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.ItemID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.itemDamageTableTableAdapter = new Guru_Pro.Database1DataSet1TableAdapters.ItemDamageTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDamageTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn,
            this.buyPriceDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemDamageTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 377);
            this.dataGridView1.TabIndex = 98;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            this.catagoryDataGridViewTextBoxColumn.Width = 130;
            // 
            // buyPriceDataGridViewTextBoxColumn
            // 
            this.buyPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyPrice";
            this.buyPriceDataGridViewTextBoxColumn.HeaderText = "BuyPrice";
            this.buyPriceDataGridViewTextBoxColumn.Name = "buyPriceDataGridViewTextBoxColumn";
            this.buyPriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // sellPriceDataGridViewTextBoxColumn
            // 
            this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice";
            this.sellPriceDataGridViewTextBoxColumn.HeaderText = "SellPrice";
            this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
            this.sellPriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.Width = 130;
            // 
            // itemDamageTableBindingSource
            // 
            this.itemDamageTableBindingSource.DataMember = "ItemDamageTable";
            this.itemDamageTableBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textDiscription
            // 
            this.textDiscription.Location = new System.Drawing.Point(719, 124);
            this.textDiscription.Multiline = true;
            this.textDiscription.Name = "textDiscription";
            this.textDiscription.Size = new System.Drawing.Size(142, 44);
            this.textDiscription.TabIndex = 96;
            // 
            // Discription
            // 
            this.Discription.AutoSize = true;
            this.Discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discription.Location = new System.Drawing.Point(608, 124);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(97, 24);
            this.Discription.TabIndex = 97;
            this.Discription.Text = "Discription";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(550, 583);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 43);
            this.btnNew.TabIndex = 87;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 584);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 43);
            this.button4.TabIndex = 88;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(769, 587);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(719, 79);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(138, 20);
            this.txtSellPrice.TabIndex = 86;
            // 
            // SellPrice
            // 
            this.SellPrice.AutoSize = true;
            this.SellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPrice.Location = new System.Drawing.Point(616, 76);
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Size = new System.Drawing.Size(89, 24);
            this.SellPrice.TabIndex = 95;
            this.SellPrice.Text = "Sell Price";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(421, 79);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(138, 20);
            this.txtBuyPrice.TabIndex = 85;
            this.txtBuyPrice.Text = "\r\n";
            // 
            // BuyPrice
            // 
            this.BuyPrice.AutoSize = true;
            this.BuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyPrice.Location = new System.Drawing.Point(316, 76);
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.Size = new System.Drawing.Size(90, 24);
            this.BuyPrice.TabIndex = 94;
            this.BuyPrice.Text = "Buy Price";
            // 
            // txtCatagory
            // 
            this.txtCatagory.Location = new System.Drawing.Point(422, 126);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(138, 20);
            this.txtCatagory.TabIndex = 84;
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catagory.Location = new System.Drawing.Point(318, 124);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(84, 24);
            this.Catagory.TabIndex = 93;
            this.Catagory.Text = "Catagory";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 83;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(51, 125);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(61, 24);
            this.lName.TabIndex = 92;
            this.lName.Text = "Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(137, 79);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(138, 20);
            this.txtItemID.TabIndex = 82;
            // 
            // ItemID
            // 
            this.ItemID.AutoSize = true;
            this.ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemID.Location = new System.Drawing.Point(51, 79);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(67, 24);
            this.ItemID.TabIndex = 91;
            this.ItemID.Text = "Item ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 583);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 40);
            this.btnSave.TabIndex = 90;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // itemDamageTableTableAdapter
            // 
            this.itemDamageTableTableAdapter.ClearBeforeFill = true;
            // 
            // ItemDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textDiscription);
            this.Controls.Add(this.Discription);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.SellPrice);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.BuyPrice);
            this.Controls.Add(this.txtCatagory);
            this.Controls.Add(this.Catagory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.ItemID);
            this.Controls.Add(this.btnSave);
            this.Name = "ItemDamage";
            this.Text = "ItemDamage";
            this.Load += new System.EventHandler(this.ItemDamage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDamageTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textDiscription;
        private System.Windows.Forms.Label Discription;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label SellPrice;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label BuyPrice;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.Label Catagory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label ItemID;
        private System.Windows.Forms.Button btnSave;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource itemDamageTableBindingSource;
        private Database1DataSet1TableAdapters.ItemDamageTableTableAdapter itemDamageTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
    }
}