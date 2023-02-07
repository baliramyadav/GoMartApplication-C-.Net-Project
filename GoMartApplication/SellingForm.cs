using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoMartApplication
{
    public partial class SellingForm : Form
    {
        DBConnect dbCon = new DBConnect();
        public SellingForm()
        {
            InitializeComponent();
        }
        double GrandTotal = 0.0;
        int n = 0;
        private void SellingForm_Load(object sender, EventArgs e)
        {
            BindCategory();
            lblDate.Text = DateTime.Now.ToShortDateString();
            BindBillList();
        }
        private void Searched_ProductList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProductList_SearchByCat", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2_Product.DataSource = dt;
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BindCategory()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetCategory", dbCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CatID";
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Searched_ProductList();
        }

        private void dataGridView2_Product_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_Product_Click(object sender, EventArgs e)
        {
            try
            {
                txtProdID.Clear();
                txtProdID.Text = dataGridView2_Product.SelectedRows[0].Cells[0].Value.ToString();
                txtProductName.Clear();
                txtProductName.Text = dataGridView2_Product.SelectedRows[0].Cells[1].Value.ToString();
                //cmbCategory.SelectedValue = dataGridView2_Product.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Clear();
                txtPrice.Text = dataGridView2_Product.SelectedRows[0].Cells[4].Value.ToString();
                //txtQty.Text = dataGridView2_Product.SelectedRows[0].Cells[5].Value.ToString();
                txtQty.Clear();
                txtQty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPrice.Text=="" || txtQty.Text=="")
                {
                    MessageBox.Show("Enter valid Qty or Prince", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double Total = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text);
                    DataGridViewRow addrow = new DataGridViewRow();
                    addrow.CreateCells(dataGridView1_Order);
                    addrow.Cells[0].Value = ++n;
                    addrow.Cells[1].Value = txtProductName.Text;
                    addrow.Cells[2].Value = txtPrice.Text;
                    addrow.Cells[3].Value = txtQty.Text;
                    addrow.Cells[4].Value = Total;
                    dataGridView1_Order.Rows.Add(addrow);
                    GrandTotal += Total;
                    lblGrandTot.Text = "Rs." + GrandTotal;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefCat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddBill_Details_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBillNo.Text=="")
                {
                    MessageBox.Show("Enter Bill Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("spInsertBill", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@Bill_ID", txtBillNo.Text);
                    cmd.Parameters.AddWithValue("@SellerID", Form1.loginname);
                    cmd.Parameters.AddWithValue("@SellDate", lblDate.Text);
                    cmd.Parameters.AddWithValue("@TotalAmt", Convert.ToDouble(txtQty.Text));
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        BindBillList();
                        MessageBox.Show("Bill Added Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clrtext();
                    }
                    dbCon.CloseCon();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clrtext()
        {
            txtBillNo.Clear();
            dataGridView1_Order.DataSource = null;
            txtPrice.Clear();
            txtProdID.Clear();
            txtProductName.Clear();
            txtQty.Clear();
            lblGrandTot.Text = "0.0";
        }
            
        private void BindBillList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetBillList", dbCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
