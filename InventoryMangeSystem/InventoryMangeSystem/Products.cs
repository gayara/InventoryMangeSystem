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
    public partial class frm_Products : Form
    {
        public frm_Products()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_cat cat = new frm_cat();
            this.Hide();
            cat.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frm_Products pro = new frm_Products();  
            this.Hide();
            pro.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frm_Categories cat = new frm_Categories();
            this.Hide();
            cat.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_User user = new frm_User();
            this.Hide();
            user.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frm_Customer cus = new frm_Customer();
            this.Hide();
            cus.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frm_User usr = new frm_User();
            usr.ShowDialog();
            usr.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
