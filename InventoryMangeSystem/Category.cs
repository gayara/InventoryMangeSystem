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
    public partial class frm_cat : Form
    {
        public frm_cat()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lb_product_Click(object sender, EventArgs e)
        {
            frm_Products pr = new frm_Products();
            this.Hide();
            pr.ShowDialog();
        }

        private void lb_categories_Click(object sender, EventArgs e)
        {
            frm_Categories ct = new frm_Categories();
            this.Hide();
            ct.ShowDialog();
        }

        private void lb_user_Click(object sender, EventArgs e)
        {
            frm_User usr = new frm_User();
            this.Hide();
            usr.ShowDialog();
            
        }

        private void lb_customer_Click(object sender, EventArgs e)
        {
            frm_Customer cus = new frm_Customer();
            this.Hide();
            cus.ShowDialog();
        }

        private void lb_order_Click(object sender, EventArgs e)
        {
            frm_Order order = new frm_Order();
            this.Hide();
            order.ShowDialog();
        }
    }
}
