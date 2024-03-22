using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


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
        void populate()
        {
            try {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "select * from userTbl";
                SqlDataAdapter da = new SqlDataAdapter(queary, obj.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_User.DataSource = ds.Tables[0];
                dgv_User.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
                dgv_User.DefaultCellStyle.Font = new Font("arial", 9);
                dgv_User.Columns[0].HeaderText = "User ID";
                dgv_User.Columns[1].HeaderText = "User Name";
                dgv_User.Columns[2].HeaderText = "Password";
                dgv_User.Columns[3].HeaderText = "Contact No.";
             
                obj.con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("insert into userTbl values('" + txt_UId.Text + "','" + txt_uName.Text + "','" + txt_pass.Text + "','" + txt_cNum.Text + "')", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully saved");
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_User_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(txt_UId.Text == " ")
            {
                MessageBox.Show("Enter user ID");

            }
            else
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "delete from userTbl where UserID='" + txt_UId.Text + "';";
                obj.cmd = new SqlCommand(queary, obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("delete successfully");
                populate();
            }
        }

        private void dgv_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txt_UId.Text = dgv_User.SelectedRows[0].Cells[0].Value.ToString();
           // txt_uName.Text = dgv_User.SelectedRows[1].Cells[0].Value.ToString();
           // txt_pass.Text = dgv_User.SelectedRows[2].Cells[0].Value.ToString();
           // txt_cNum.Text = dgv_User.SelectedRows[3].Cells[0].Value.ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("update userTbl set UName='"+txt_uName.Text+"',Password='"+txt_pass.Text+"',TelNo='"+txt_cNum.Text+ "' where UserID='" + txt_UId.Text + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully updated");
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dgv_User.Rows[index];
            txt_UId.Text = selectedrow.Cells[0].Value.ToString();
            txt_uName.Text = selectedrow.Cells[1].Value.ToString();
            txt_pass.Text = selectedrow.Cells[2].Value.ToString();  
            txt_cNum.Text  = selectedrow.Cells[3].Value.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_UId.Text = "";
            txt_uName.Text = "";
            txt_cNum.Text = "";
            txt_pass.Text = "";

        }
    }
}
