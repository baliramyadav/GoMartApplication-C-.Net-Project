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
    public partial class Form1 : Form
    {
        DBConnect dbCon = new DBConnect();
        public static string loginname, logintype;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 1;
            txtUsername.Text = "Coder";
            txtPass.Text = "12345";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbRole.SelectedIndex>0)
                {
                    if (txtUsername.Text == String.Empty)
                    {
                        MessageBox.Show("Please Enter valid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                        return;
                    }
                    if (txtPass.Text==String.Empty)
                    {
                        MessageBox.Show("Please Enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Focus();
                        return;
                    }

                    if (cmbRole.SelectedIndex > 0 && txtUsername.Text != String.Empty && txtPass.Text != String.Empty)
                    {
                        //login code
                        if(cmbRole.Text=="Admin")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 AdminID,Password,FullName from tblAdmin where AdminID=@AdminID and Password=@Password", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@AdminID", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if(dt.Rows.Count>0)
                            {
                                MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loginname = txtUsername.Text;
                                logintype = cmbRole.Text;
                                clrValue();
                                this.Hide();
                                frmMain fm = new frmMain();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Please check userName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            

                        }
                        else if(cmbRole.Text == "Seller")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 SellerName,SellerPass from tblSeller where SellerName=@SellerName and SellerPass=@SellerPass", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@SellerName", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@SellerPass", txtPass.Text);
                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loginname = txtUsername.Text;
                                logintype = cmbRole.Text;
                                clrValue();
                                this.Hide();
                                frmMain fm = new frmMain();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Please check userName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clrValue();
                    }

                }
                else
                {
                    MessageBox.Show("Please select any role","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clrValue();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void clrValue()
        {
            cmbRole.SelectedIndex = 0;
            txtUsername.Clear();
            txtPass.Clear();
        }
    }
}
