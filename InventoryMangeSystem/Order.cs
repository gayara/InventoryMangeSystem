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

        private void panel2_Paint(object sender, PaintEventArgs e)
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
                dgv_cus.DataSource = ds.Tables[0];
                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void populateProducts()
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
                dgv_product.DataSource = ds.Tables[0];
                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void fillcategory()
        {
            Connect obj = new Connect();
            obj.con.ConnectionString = obj.locate;
            
            obj.cmd.Connection = obj.con;
            string queary = "select * from CatTbl";
            SqlCommand cmd = new SqlCommand(queary, obj.con);
            SqlDataReader dr;
            try
            {
                obj.con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                //cbx_category.ValueMember = "CategoryName";
                //cbx_category.DataSource = dt;
                cmb_search.ValueMember = "CategoryName";
                cmb_search.DataSource = dt;
                obj.con.Close();
            }
            catch
            {

            }
        }


        private void dgv_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void frm_Order_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            fillcategory();
           
           
           
        }
        
        private void cmb_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
                string queary = "select * from productTbl where PCate = '" + cmb_search.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(queary, obj.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_product.DataSource = ds.Tables[0];
                obj.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        int flag = 0;
        int stock = 0;
        int num = 0;
        int uprice, totprice, qty;
        string product;
        int sum, id = 0;
        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            product = dgv_product.Rows[e.RowIndex].Cells[1].Value.ToString();
           // qty = Convert.ToInt32(txt_Qty.Text);
            stock = Convert.ToInt32(dgv_product.Rows[e.RowIndex].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(dgv_product.Rows[e.RowIndex].Cells[3].Value.ToString());
            id = Convert.ToInt32(dgv_product.Rows[e.RowIndex].Cells[0].Value.ToString());


            flag = 1;
        }

        
        private void btn_addOrdr_Click(object sender, EventArgs e)
        {
            
            if(txt_Qty.Text=="" )
            {
                MessageBox.Show("Enter Quentity of product");

            }else if(flag == 0)
            {
                MessageBox.Show("Select product");
            }
            else if(Convert.ToInt32(txt_Qty.Text) > stock)
            {
                MessageBox.Show("Out of Stock");
            }
            else
            {
               
                qty = Convert.ToInt32(txt_Qty.Text);
                totprice = qty * uprice;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_order);
                newRow.Cells[0].Value = num + 1;
                newRow.Cells[1].Value = product;
                newRow.Cells[2].Value = txt_Qty.Text;
                newRow.Cells[3].Value = uprice;
                newRow.Cells[4].Value = totprice;
                sum = sum + totprice;

                txt_amount.Text = sum.ToString();
                dgv_order.Rows.Add(newRow);
               
                num++;
                
                updateProduct();
               

                flag = 0;
            }
            

        }
        
        private void updateProduct()
        {
            try
            {
                int newstock = stock - Convert.ToInt32(txt_Qty.Text);
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                obj.cmd.Connection = obj.con;
               
                obj.cmd = new SqlCommand("update productTbl set PQty ="+newstock+" where PID = "+id+" ; ", obj.con);
                obj.cmd.ExecuteNonQuery();
                
                obj.con.Close();
               
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(txt_oid.Text =="" || txt_cID.Text == "" || txt_cucname.Text == "" || txt_amount.Text == "")
            {
                MessageBox.Show("fill the data correctly");
            }
            else
            {
                try
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    obj.cmd.Connection = obj.con;
                    obj.cmd = new SqlCommand("insert into OrderTbl values('" + txt_oid.Text + "','" + txt_cID.Text + "','" + txt_cucname.Text + "','" + date.Text + "','" + txt_amount.Text + "')", obj.con);
                    obj.cmd.ExecuteNonQuery();
                    MessageBox.Show("order Succesfully saved");
                    populateProducts();
                    obj.con.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            populateProducts();
            cmb_search.SelectedValue = "";
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            frm_view view = new frm_view();
            this.Hide();
            view.Show();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_cus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cID.Text = dgv_cus.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_cucname.Text = dgv_cus.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txt_cID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
