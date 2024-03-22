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
    public partial class frm_Order : Form
    {
        public frm_Order()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_cat cat = new frm_cat();
            this.Hide();
            cat.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frm_Products pr = new frm_Products();
            this.Hide();
            pr.ShowDialog();
        }

        private void lbl_cat_Click(object sender, EventArgs e)
        {
            frm_Categories cat = new frm_Categories();
            this.Hide();
            cat.ShowDialog();
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {
            frm_User user = new frm_User();
            this.Hide();
            user.ShowDialog();
        }

        private void llbl_customer_Click(object sender, EventArgs e)
        {
            frm_Customer customer = new frm_Customer();
            this.Hide();
            customer.ShowDialog();
        }

        private void lbl_order_Click(object sender, EventArgs e)
        {
            frm_Order or = new frm_Order();
            this.Hide();
            or.ShowDialog();
        }
    }
}
