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
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_cat cat = new frm_cat();
            this.Hide();
            cat.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_pro_Click(object sender, EventArgs e)
        {
            frm_Products pr = new frm_Products();
            this.Hide();
            pr.ShowDialog();
        }

        private void lbl_cat_Click(object sender, EventArgs e)
        {
            frm_cat c = new frm_cat();
            c.ShowDialog();
            this.Hide();
        }

        private void lbl_usr_Click(object sender, EventArgs e)
        {
            frm_User usr = new frm_User();
            usr.ShowDialog();
            this.Hide();
        }

        private void lbl_cus_Click(object sender, EventArgs e)
        {
            frm_Customer cus = new frm_Customer();
            cus.ShowDialog();
            this.Hide();
            
        }

        private void lbl_ordr_Click(object sender, EventArgs e)
        {
            frm_Order or = new frm_Order();
            or.ShowDialog();
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
