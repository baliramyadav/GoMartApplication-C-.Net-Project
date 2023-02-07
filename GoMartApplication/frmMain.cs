using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoMartApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Form1.loginname!=null)
            {
                toolStripStatusLabel2.Text = Form1.loginname;
            }
            if(Form1.logintype!=null && Form1.logintype=="Seller")
            {
                masterToolStripMenuItem.Enabled = false;
                masterToolStripMenuItem.ForeColor = Color.Red;
                productToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.ForeColor = Color.Red;
                addUserToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.ForeColor = Color.Red;
            }
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory fcat = new frmCategory();
            fcat.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewSeller fseller = new frmAddNewSeller();
            fseller.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin aaf = new AddAdmin();
            aaf.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }

        private void sellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.ShowDialog();
        }
    }
}
