namespace InventoryMangeSystem
{
    partial class frm_Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Categories));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_Home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_category = new System.Windows.Forms.Label();
            this.label_order = new System.Windows.Forms.Label();
            this.label_product = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_catId = new System.Windows.Forms.Label();
            this.txt_catName = new System.Windows.Forms.TextBox();
            this.txt_catId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Home)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pb_Home);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 84);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(859, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pb_Home
            // 
            this.pb_Home.BackColor = System.Drawing.Color.Transparent;
            this.pb_Home.Image = ((System.Drawing.Image)(resources.GetObject("pb_Home.Image")));
            this.pb_Home.Location = new System.Drawing.Point(12, 3);
            this.pb_Home.Name = "pb_Home";
            this.pb_Home.Size = new System.Drawing.Size(37, 34);
            this.pb_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Home.TabIndex = 10;
            this.pb_Home.TabStop = false;
            this.pb_Home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Categoriess";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label_category);
            this.panel2.Controls.Add(this.label_order);
            this.panel2.Controls.Add(this.label_product);
            this.panel2.Controls.Add(this.label_user);
            this.panel2.Controls.Add(this.label_customer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 24);
            this.panel2.TabIndex = 3;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(251, 3);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(90, 18);
            this.label_category.TabIndex = 11;
            this.label_category.Text = "Categories";
            this.label_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_category.Click += new System.EventHandler(this.label12_Click);
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_order.Location = new System.Drawing.Point(695, 3);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(60, 18);
            this.label_order.TabIndex = 10;
            this.label_order.Text = "Orders";
            this.label_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_order.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.BackColor = System.Drawing.Color.Transparent;
            this.label_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(102, 3);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(76, 18);
            this.label_product.TabIndex = 7;
            this.label_product.Text = "Products";
            this.label_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_product.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(414, 3);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(53, 18);
            this.label_user.TabIndex = 8;
            this.label_user.Text = "Users";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_user.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.Location = new System.Drawing.Point(540, 3);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(82, 18);
            this.label_customer.TabIndex = 6;
            this.label_customer.Text = "Customer";
            this.label_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_customer.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(190, 334);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(104, 334);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 36;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(18, 334);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "New";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Category Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_catId
            // 
            this.lb_catId.AutoSize = true;
            this.lb_catId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_catId.Location = new System.Drawing.Point(15, 248);
            this.lb_catId.Name = "lb_catId";
            this.lb_catId.Size = new System.Drawing.Size(82, 17);
            this.lb_catId.TabIndex = 29;
            this.lb_catId.Text = "Category ID";
            this.lb_catId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_catName
            // 
            this.txt_catName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_catName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_catName.Location = new System.Drawing.Point(141, 274);
            this.txt_catName.Multiline = true;
            this.txt_catName.Name = "txt_catName";
            this.txt_catName.Size = new System.Drawing.Size(124, 20);
            this.txt_catName.TabIndex = 26;
            this.txt_catName.Tag = "";
            // 
            // txt_catId
            // 
            this.txt_catId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_catId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_catId.Location = new System.Drawing.Point(141, 248);
            this.txt_catId.Multiline = true;
            this.txt_catId.Name = "txt_catId";
            this.txt_catId.Size = new System.Drawing.Size(124, 20);
            this.txt_catId.TabIndex = 25;
            this.txt_catId.Tag = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(204, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 24;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_categories
            // 
            this.dgv_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categories.Location = new System.Drawing.Point(299, 143);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.Size = new System.Drawing.Size(572, 358);
            this.dgv_categories.TabIndex = 40;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(103, 387);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // frm_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_categories);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_catId);
            this.Controls.Add(this.txt_catName);
            this.Controls.Add(this.txt_catId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(883, 536);
            this.MinimumSize = new System.Drawing.Size(883, 536);
            this.Name = "frm_Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Home)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_catId;
        private System.Windows.Forms.TextBox txt_catName;
        private System.Windows.Forms.TextBox txt_catId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pb_Home;
        private System.Windows.Forms.DataGridView dgv_categories;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_save;
    }
}