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
    public partial class frm_Categories : Form
    {
        public frm_Categories()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frm_Products p = new frm_Products();
            this.Hide();
            p.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_User u = new frm_User();
            this.Hide();
            u.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frm_Customer cust = new frm_Customer();
            this.Hide();
            cust.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frm_Order or = new frm_Order();
            this.Hide();
            or.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frm_Categories cate = new frm_Categories();
            this.Hide();
            cate.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_cat cat = new frm_cat();
            this.Hide();
            cat.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
