namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mymarketDataSet = new WindowsFormsApp2.mymarketDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableAdapter = new WindowsFormsApp2.mymarketDataSetTableAdapters.productTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mymarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductName:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "pname", true));
            this.textBox1.Location = new System.Drawing.Point(197, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.mymarketDataSet;
            // 
            // mymarketDataSet
            // 
            this.mymarketDataSet.DataSetName = "mymarketDataSet";
            this.mymarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quntityDataGridViewTextBoxColumn,
            this.catIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(474, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 277);
            this.dataGridView1.TabIndex = 3;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "pid";
            this.pidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pidDataGridViewTextBoxColumn.Width = 125;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quntityDataGridViewTextBoxColumn
            // 
            this.quntityDataGridViewTextBoxColumn.DataPropertyName = "quntity";
            this.quntityDataGridViewTextBoxColumn.HeaderText = "quntity";
            this.quntityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quntityDataGridViewTextBoxColumn.Name = "quntityDataGridViewTextBoxColumn";
            this.quntityDataGridViewTextBoxColumn.Width = 125;
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            this.catIdDataGridViewTextBoxColumn.DataPropertyName = "catId";
            this.catIdDataGridViewTextBoxColumn.HeaderText = "catId";
            this.catIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            this.catIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "id:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "pid", true));
            this.textBox2.Location = new System.Drawing.Point(197, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(35, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "ProductPrice:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "price", true));
            this.textBox3.Location = new System.Drawing.Point(197, 264);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label5.Location = new System.Drawing.Point(45, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantitiy:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "quntity", true));
            this.textBox4.Location = new System.Drawing.Point(197, 319);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label6.Location = new System.Drawing.Point(35, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category id:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "catId", true));
            this.textBox5.Location = new System.Drawing.Point(197, 377);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 22);
            this.textBox5.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(96, 431);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(126, 40);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Last";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 40);
            this.button4.TabIndex = 17;
            this.button4.Text = "First";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(458, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 40);
            this.button5.TabIndex = 18;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(627, 485);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 40);
            this.button6.TabIndex = 19;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(627, 428);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 43);
            this.button7.TabIndex = 20;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mymarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mymarketDataSet mymarketDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private mymarketDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

