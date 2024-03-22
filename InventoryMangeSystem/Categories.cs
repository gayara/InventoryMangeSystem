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
            cat.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_Categories_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populate()
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "select * from CatTbl";
                SqlDataAdapter da = new SqlDataAdapter(queary, obj.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_categories.DataSource = ds.Tables[0];
                dgv_categories.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
                dgv_categories.DefaultCellStyle.Font = new Font("arial", 9);
                dgv_categories.Columns[0].HeaderText = "Category ID";
                dgv_categories.Columns[1].HeaderText = "Category Name";
             

                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("insert into CatTbl values('" + txt_catId.Text + "','" + txt_catName.Text + "')", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Do you want to add new categories?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                obj.cmd = new SqlCommand("update CatTbl set CategoryName='" + txt_catName.Text + "' where CategoryID='" + txt_catId.Text + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Do you want to remove category?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_catId.Text == " ")
            {
                MessageBox.Show("Enter user ID");

            }
            else
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "delete from CatTbl where CategoryID='" + txt_catId.Text + "';";
                obj.cmd = new SqlCommand(queary, obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("Do you want to delete?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                populate();
                txt_catId.Text = "";
                txt_catName.Text = "";
            }
        }

        private void dgv_categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dgv_categories.Rows[index];
            txt_catId.Text = selectedrow.Cells[0].Value.ToString();
            txt_catName.Text = selectedrow.Cells[1].Value.ToString();
        }

        private void dgv_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_catId.Text = "";
            txt_catName.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
