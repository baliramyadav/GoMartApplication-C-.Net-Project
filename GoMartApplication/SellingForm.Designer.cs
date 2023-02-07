namespace GoMartApplication
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.dataGridView1_Order = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnRefCat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGrandTot = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2_Product = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.btnAddBill_Details = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(681, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate.Location = new System.Drawing.Point(734, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Jan 2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity:";
            // 
            // txtProdID
            // 
            this.txtProdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.ForeColor = System.Drawing.Color.Maroon;
            this.txtProdID.Location = new System.Drawing.Point(115, 52);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(193, 24);
            this.txtProdID.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Maroon;
            this.txtProductName.Location = new System.Drawing.Point(115, 82);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(193, 24);
            this.txtProductName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txtPrice.Location = new System.Drawing.Point(115, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(193, 24);
            this.txtPrice.TabIndex = 2;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Maroon;
            this.txtQty.Location = new System.Drawing.Point(115, 145);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(193, 24);
            this.txtQty.TabIndex = 2;
            // 
            // dataGridView1_Order
            // 
            this.dataGridView1_Order.AllowUserToAddRows = false;
            this.dataGridView1_Order.AllowUserToResizeColumns = false;
            this.dataGridView1_Order.AllowUserToResizeRows = false;
            this.dataGridView1_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_Order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridView1_Order.Location = new System.Drawing.Point(333, 52);
            this.dataGridView1_Order.Name = "dataGridView1_Order";
            this.dataGridView1_Order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1_Order.RowHeadersVisible = false;
            this.dataGridView1_Order.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Order.Size = new System.Drawing.Size(569, 149);
            this.dataGridView1_Order.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(115, 184);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(96, 37);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(6, 239);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 26);
            this.cmbCategory.TabIndex = 5;
            // 
            // btnRefCat
            // 
            this.btnRefCat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefCat.ForeColor = System.Drawing.Color.White;
            this.btnRefCat.Location = new System.Drawing.Point(257, 236);
            this.btnRefCat.Name = "btnRefCat";
            this.btnRefCat.Size = new System.Drawing.Size(72, 31);
            this.btnRefCat.TabIndex = 4;
            this.btnRefCat.Text = "Refresh";
            this.btnRefCat.UseVisualStyleBackColor = false;
            this.btnRefCat.Click += new System.EventHandler(this.btnRefCat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 153);
            this.dataGridView1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Brown;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(347, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sells List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(607, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Amount:";
            // 
            // lblGrandTot
            // 
            this.lblGrandTot.AutoSize = true;
            this.lblGrandTot.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTot.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTot.Location = new System.Drawing.Point(760, 204);
            this.lblGrandTot.Name = "lblGrandTot";
            this.lblGrandTot.Size = new System.Drawing.Size(33, 18);
            this.lblGrandTot.TabIndex = 1;
            this.lblGrandTot.Text = "0.0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(805, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(180, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2_Product
            // 
            this.dataGridView2_Product.AllowUserToAddRows = false;
            this.dataGridView2_Product.AllowUserToDeleteRows = false;
            this.dataGridView2_Product.AllowUserToResizeRows = false;
            this.dataGridView2_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2_Product.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2_Product.Location = new System.Drawing.Point(6, 284);
            this.dataGridView2_Product.Name = "dataGridView2_Product";
            this.dataGridView2_Product.RowHeadersVisible = false;
            this.dataGridView2_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_Product.ShowEditingIcon = false;
            this.dataGridView2_Product.Size = new System.Drawing.Size(293, 210);
            this.dataGridView2_Product.TabIndex = 8;
            this.dataGridView2_Product.Click += new System.EventHandler(this.dataGridView2_Product_Click);
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProdID";
            this.ProdID.Name = "ProdID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // txtBillNo
            // 
            this.txtBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(684, 274);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(101, 24);
            this.txtBillNo.TabIndex = 9;
            // 
            // btnAddBill_Details
            // 
            this.btnAddBill_Details.BackColor = System.Drawing.Color.Orange;
            this.btnAddBill_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBill_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill_Details.ForeColor = System.Drawing.Color.Black;
            this.btnAddBill_Details.Location = new System.Drawing.Point(806, 262);
            this.btnAddBill_Details.Name = "btnAddBill_Details";
            this.btnAddBill_Details.Size = new System.Drawing.Size(75, 36);
            this.btnAddBill_Details.TabIndex = 10;
            this.btnAddBill_Details.Text = "Add";
            this.btnAddBill_Details.UseVisualStyleBackColor = false;
            this.btnAddBill_Details.Click += new System.EventHandler(this.btnAddBill_Details_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(580, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bill_Number";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.btnAddBill_Details);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.dataGridView2_Product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRefCat);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dataGridView1_Order);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGrandTot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridView dataGridView1_Order;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnRefCat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGrandTot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Button btnAddBill_Details;
        private System.Windows.Forms.Label label9;
    }
}