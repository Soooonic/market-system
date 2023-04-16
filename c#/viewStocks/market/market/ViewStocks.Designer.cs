namespace market
{
    partial class ViewStocks
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
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new market.supermarketDataSetTableAdapters.stockTableAdapter();
            this.stIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.storeidDataGridViewTextBoxColumn,
            this.prIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 609);
            this.dataGridView1.TabIndex = 0;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.supermarketDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // stIdDataGridViewTextBoxColumn
            // 
            this.stIdDataGridViewTextBoxColumn.DataPropertyName = "stId";
            this.stIdDataGridViewTextBoxColumn.HeaderText = "stId";
            this.stIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stIdDataGridViewTextBoxColumn.Name = "stIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "store_id";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "store_id";
            this.storeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            // 
            // prIdDataGridViewTextBoxColumn
            // 
            this.prIdDataGridViewTextBoxColumn.DataPropertyName = "prId";
            this.prIdDataGridViewTextBoxColumn.HeaderText = "prId";
            this.prIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prIdDataGridViewTextBoxColumn.Name = "prIdDataGridViewTextBoxColumn";
            // 
            // ViewStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 624);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewStocks";
            this.Text = "ViewStocks";
            this.Load += new System.EventHandler(this.ViewStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private supermarketDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prIdDataGridViewTextBoxColumn;
    }
}