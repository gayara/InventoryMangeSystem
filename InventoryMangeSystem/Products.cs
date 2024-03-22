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
        void fillcategory()
        {
            Connect obj = new Connect();
            obj.con.ConnectionString = obj.locate;
            string queary = "select * from CatTbl";
            SqlCommand cmd = new SqlCommand(queary, obj.con);
            SqlDataReader dr;
            try
            {
                
                obj.con.Open();
                obj.cmd.Connection = obj.con;
              
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                cbx_category.ValueMember = "CategoryName";
                cbx_category.DataSource = dt;
                cmb_search.ValueMember = "CategoryName";
                cmb_search.DataSource = dt;
                obj.con.Close();
            }
            catch
            {

            }
        }
        
        void populate()
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "select * from productTbl";
                SqlDataAdapter da = new SqlDataAdapter(queary, obj.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_Product.DataSource = ds.Tables[0];
                dgv_Product.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
                dgv_Product.DefaultCellStyle.Font = new Font("arial", 9);
               // dgv_Product.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_Product.Columns[0].HeaderText = "ID";
                dgv_Product.Columns[1].HeaderText = "Name";
                dgv_Product.Columns[2].HeaderText = "Quantity";
                dgv_Product.Columns[3].HeaderText = "Price(Rs.)";
                dgv_Product.Columns[4].HeaderText = "Description";
                dgv_Product.Columns[5].HeaderText = "Category";

                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void datafilter()
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "select * from productTbl where PCate = '"+cmb_search.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(queary, obj.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_Product.DataSource = ds.Tables[0];
                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_pId.Text = "";
            txt_pName.Text = "";
            txt_pQty.Text = "";
            txt_pPrice.Text = "";
            txt_dis.Text = "";
            cbx_category.SelectedValue = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("insert into productTbl values('" + txt_pId.Text + "','" + txt_pName.Text + "','" + txt_pQty.Text + "','" + txt_pPrice.Text + "','"+txt_dis.Text+"','"+cbx_category.SelectedValue.ToString()+"')", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Do you want to add new product?","message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.productTbl' table. You can move, or remove it, as needed.
            populate();
            fillcategory();


        }
        private void Edit(bool value)
        {
            
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_pId.Text == " ")
            {
                MessageBox.Show("Enter product ID");

            }
            else
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                
                string queary = "delete from productTbl where PID='" + txt_pId.Text + "';";
                obj.cmd = new SqlCommand(queary, obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("Do you want to remove product?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                populate();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                obj.cmd = new SqlCommand("update productTbl set PName='" + txt_pName.Text + "',PQty='" + txt_pQty.Text + "',PPrice='" + txt_pPrice.Text + "',Des='" + txt_dis.Text + "',PCate='" + cbx_category.SelectedValue.ToString() + "' where PID='" + txt_pId.Text + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                MessageBox.Show("Do you want to update product?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                obj.con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //txt_pId.Text = dgv_Product.SelectedRows[0].Cells[0].Value.ToString();
          //  txt_pName.Text = dgv_Product.SelectedRows[0].Cells[1].Value.ToString();
          //  txt_pQty.Text = dgv_Product.SelectedRows[0].Cells[2].Value.ToString();
          //  txt_pPrice.Text = dgv_Product.SelectedRows[0].Cells[3].Value.ToString();
           // txt_dis.Text = dgv_Product.SelectedRows[0].Cells[4].Value.ToString();
          //  cbx_category.SelectedValue = dgv_Product.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            datafilter();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dgv_Product.Rows[index];
            txt_pId.Text = selectedrow.Cells[0].Value.ToString();
            txt_pName.Text = selectedrow.Cells[1].Value.ToString();
            txt_pQty.Text= selectedrow.Cells[2].Value.ToString();
             txt_pPrice.Text= selectedrow.Cells[3].Value.ToString();
             txt_dis.Text= selectedrow.Cells[4].Value.ToString();
            cbx_category.SelectedValue = selectedrow.Cells[5].Value.ToString();
        }
    }
}
