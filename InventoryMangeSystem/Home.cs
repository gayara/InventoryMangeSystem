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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
            
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Enabled = true;
            progressBar1.Increment(2);
            if(progressBar1.Value == 100)
            {
               timer1.Enabled = false;
                frm_login login = new frm_login();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
