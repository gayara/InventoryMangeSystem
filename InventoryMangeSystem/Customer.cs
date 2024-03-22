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

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void populate()
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(queary, obj.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_Customer.DataSource = ds.Tables[0];
                dgv_Customer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
                dgv_Customer.DefaultCellStyle.Font = new Font("arial", 9);
                dgv_Customer.Columns[0].HeaderText = "Customer ID";
                dgv_Customer.Columns[1].HeaderText = "Customer Name";
                dgv_Customer.Columns[2].HeaderText = "Contact No.";

                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("insert into CustomerTbl values('" + txt_cID.Text + "','" + txt_cName.Text + "','" + txt_cTel.Text + "')", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Do you want to add new customer?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("update CustomerTbl set CustomerName='" + txt_cName.Text + "',ContactNumber='" + txt_cTel.Text + "' where CustomerID='" + txt_cID.Text + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Do you want to edit?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // txt_cID.Text = dgv_Customer.SelectedRows[0].Cells[0].Value.ToString();
             //txt_cName.Text = dgv_Customer.SelectedRows[0].Cells[1].Value.ToString();
            // txt_cTel.Text = dgv_Customer.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_cID.Text == " ")
            {
                MessageBox.Show("Enter customer ID");

            }
            else
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "delete from CustomerTbl where CustomerID='" + txt_cID.Text + "';";
                obj.cmd = new SqlCommand(queary, obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("Do you want to delete?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                populate();
            }
        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow =dgv_Customer.Rows[index];
            txt_cID.Text= selectedrow.Cells[0].Value.ToString();
            txt_cName.Text= selectedrow.Cells[1].Value.ToString();
            txt_cTel.Text= selectedrow.Cells[2].Value.ToString();

        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_cID.Text = "";
            txt_cName.Text = "";
            txt_cTel.Text = "";
        }
    }
}
