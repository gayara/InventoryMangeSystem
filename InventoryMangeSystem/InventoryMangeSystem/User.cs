using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangeSystem
{
    public partial class frm_User : Form
    {
        public frm_User()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_cat cat = new frm_cat();
            this.Hide();
            cat.ShowDialog();
        }

        private void lbl_product_Click(object sender, EventArgs e)
        {
            frm_Products pr = new frm_Products();  
            this.Hide();
            pr.ShowDialog();
        }

        private void lbl_cat_Click(object sender, EventArgs e)
        {
            frm_Categories cat = new frm_Categories();
            this.Hide();
            cat.Show();
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {
            frm_User user = new frm_User();
            this.Hide();
            user.ShowDialog();
        }

        private void lbl_cus_Click(object sender, EventArgs e)
        {
            frm_Customer customer = new frm_Customer();
            this.Hide();
            customer.ShowDialog();
        }

        private void lbl_ord_Click(object sender, EventArgs e)
        {
            frm_Order order = new frm_Order();
            this.Hide();
            order.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }
    }
}
