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
    public partial class AddProduct : Form
    {
        DBConnect dbCon = new DBConnect();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            BindCategory();
            BindProductList();
            lblProdID.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            SearcgBy_Category();
        }

        private void BindCategory()
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
        private void SearcgBy_Category()
        {
            SqlCommand cmd = new SqlCommand("spGetCategory", dbCon.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbsearch.DataSource = dt;
            cmbsearch.DisplayMember = "CategoryName";
            cmbsearch.ValueMember = "CatID";
            dbCon.CloseCon();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProdName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProdName.Focus();
                    return;
                }
                else if (Convert.ToInt32(txtPrice.Text) < 0 || txtPrice.Text == String.Empty )
                {
                    MessageBox.Show("Please Enter valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                else if (txtQty.Text == String.Empty || Convert.ToInt32(txtQty.Text)< 0)
                {
                    MessageBox.Show("Please Enter valid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("spCheckDuplicateProduct", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@ProdName", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Product Name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("spInsertProduct", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@ProdName", txtProdName.Text);
                        cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@ProdPrice", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@ProdQty", Convert.ToInt32(txtQty.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Product Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindProductList();
                        }
                    }
                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindProductList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProductList", dbCon.GetCon());
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

        private void txtClear()
        {
            txtProdName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProdID.Text=="" && txtProdName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter ProductID and name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProdName.Focus();
                    return;
                }
                else if (txtPrice.Text == String.Empty && Convert.ToInt32(txtPrice.Text) >= 0)
                {
                    MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                else if (txtQty.Text == String.Empty && Convert.ToInt32(txtQty.Text) >= 0)
                {
                    MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                else
                {
                    //SqlCommand cmd = new SqlCommand("spCheckDuplicateProduct", dbCon.GetCon());
                    //cmd.Parameters.AddWithValue("@ProdName", txtProdName.Text);
                    //cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //dbCon.OpenCon();
                    //var result = cmd.ExecuteScalar();
                    //if (result != null)
                    //{
                    //    MessageBox.Show("Product Name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    txtClear();
                    //}
                    //else
                    //{
                        
                    //}
                    SqlCommand cmd = new SqlCommand("spUpdateProduct", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@ProdName", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@ProdPrice", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@ProdQty", Convert.ToInt32(txtQty.Text));
                    cmd.Parameters.AddWithValue("@ProdID", Convert.ToInt32(lblProdID.Text));
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Product Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindProductList();
                        lblProdID.Visible = false;
                        btnAdd.Visible = true;
                        btnUpdate.Visible = false;
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Updation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                lblProdID.Visible = true;
                btnAdd.Visible = false;

                lblProdID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtProdName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cmbCategory.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtQty.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProdID.Text == String.Empty)
                {
                    MessageBox.Show("Please select Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblProdID.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("spDeleteProduct", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@ProdID", Convert.ToInt32(lblProdID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Product Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindProductList();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAdd.Visible = true;
                            lblProdID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Delete failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
                        }
                        dbCon.CloseCon();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Searched_ProductList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProductList_SearchByCat", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@ProdCatID",cmbsearch.SelectedValue);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Searched_ProductList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindProductList();
        }
    }
}
