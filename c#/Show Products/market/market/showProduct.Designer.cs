namespace market
{
    partial class showProduct
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
            this.supermarketDataSet = new market.supermarketDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new market.supermarketDataSetTableAdapters.productTableAdapter();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.catIdDataGridViewTextBoxColumn,
            this.quntityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 731);
            this.dataGridView1.TabIndex = 0;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.supermarketDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "pid";
            this.pidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            this.catIdDataGridViewTextBoxColumn.DataPropertyName = "catId";
            this.catIdDataGridViewTextBoxColumn.HeaderText = "catId";
            this.catIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            // 
            // quntityDataGridViewTextBoxColumn
            // 
            this.quntityDataGridViewTextBoxColumn.DataPropertyName = "quntity";
            this.quntityDataGridViewTextBoxColumn.HeaderText = "quntity";
            this.quntityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quntityDataGridViewTextBoxColumn.Name = "quntityDataGridViewTextBoxColumn";
            // 
            // showProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 755);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showProduct";
            this.Text = "showProduct";
            this.Load += new System.EventHandler(this.showProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private supermarketDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntityDataGridViewTextBoxColumn;
    }
}