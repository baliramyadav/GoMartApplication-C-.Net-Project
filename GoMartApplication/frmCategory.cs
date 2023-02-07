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
    public partial class frmCategory : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            lblCatID.Visible = false;
            BindCategory();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtCatname.Text == String.Empty)
            {
                MessageBox.Show("Please Enter CategoryName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatname.Focus();
                return;
            }
            else if (rtbCatDesc.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbCatDesc.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName=@CategoryName", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@CategoryName", txtCatname.Text);
                dbCon.OpenCon();
                var result = cmd.ExecuteScalar();
                if(result!=null)
                {
                    MessageBox.Show("CategoryName already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClear();
                }
                else
                {
                    cmd = new SqlCommand("spCatInsert", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@CategoryName", txtCatname.Text);
                    cmd.Parameters.AddWithValue("@CategoryDesc", rtbCatDesc.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();   
                    if(i>0)
                    {
                        MessageBox.Show("Category Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindCategory();
                    }
                }
                dbCon.CloseCon(); 
            }

        }
        private void txtClear()
        {
            txtCatname.Clear(); rtbCatDesc.Clear();
        }
        private void BindCategory()
        {
            SqlCommand cmd = new SqlCommand("select  CatID as CategoryID,CategoryName,CategoryDesc as CategoryDescription from tblCategory", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            dbCon.CloseCon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            lblCatID.Visible = true;
            btnAddCat.Visible = false;

            lblCatID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtCatname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            rtbCatDesc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCatID.Text == String.Empty)
                {
                    MessageBox.Show("Please select CategoryID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatname.Focus();
                    return;
                }
                if (txtCatname.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter CategoryName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatname.Focus();
                    return;
                }
                else if (rtbCatDesc.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbCatDesc.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName=@CategoryName", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@CategoryName", txtCatname.Text);
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("CategoryName already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("spCatUpdate", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(lblCatID.Text));
                        cmd.Parameters.AddWithValue("@CategoryName", txtCatname.Text);
                        cmd.Parameters.AddWithValue("@CategoryDesc", rtbCatDesc.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        dbCon.CloseCon();
                        if (i > 0)
                        {
                            MessageBox.Show("Category updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindCategory();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAddCat.Visible = true;
                            lblCatID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("update failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCatID.Text == String.Empty)
                {
                    MessageBox.Show("Please select CategoryID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(lblCatID.Text != String.Empty)
                {
                    if(DialogResult.Yes==MessageBox.Show("Do You Want to Delete?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("spCatDelete", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(lblCatID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindCategory();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAddCat.Visible = true;
                            lblCatID.Visible = false;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
