namespace InventoryMangeSystem
{
    partial class frm_cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cat));
            this.panel_welcome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frm_category = new System.Windows.Forms.Label();
            this.lb_product = new System.Windows.Forms.Label();
            this.lb_customer = new System.Windows.Forms.Label();
            this.lb_order = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_categories = new System.Windows.Forms.Label();
            this.pb_customer = new System.Windows.Forms.PictureBox();
            this.pb_cat = new System.Windows.Forms.PictureBox();
            this.pb_product = new System.Windows.Forms.PictureBox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.pb_ord = new System.Windows.Forms.PictureBox();
            this.panel_welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_welcome
            // 
            this.panel_welcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_welcome.BackgroundImage")));
            this.panel_welcome.Controls.Add(this.pictureBox1);
            this.panel_welcome.Controls.Add(this.frm_category);
            this.panel_welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_welcome.Location = new System.Drawing.Point(0, 0);
            this.panel_welcome.Name = "panel_welcome";
            this.panel_welcome.Size = new System.Drawing.Size(659, 100);
            this.panel_welcome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_category
            // 
            this.frm_category.AccessibleName = "frm_category";
            this.frm_category.AutoSize = true;
            this.frm_category.BackColor = System.Drawing.Color.Transparent;
            this.frm_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frm_category.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm_category.ForeColor = System.Drawing.Color.Beige;
            this.frm_category.Location = new System.Drawing.Point(173, 21);
            this.frm_category.Name = "frm_category";
            this.frm_category.Size = new System.Drawing.Size(314, 67);
            this.frm_category.TabIndex = 0;
            this.frm_category.Text = "WELLCOME";
            // 
            // lb_product
            // 
            this.lb_product.AutoSize = true;
            this.lb_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_product.Location = new System.Drawing.Point(154, 204);
            this.lb_product.Name = "lb_product";
            this.lb_product.Size = new System.Drawing.Size(105, 25);
            this.lb_product.TabIndex = 2;
            this.lb_product.Text = "Products";
            this.lb_product.Click += new System.EventHandler(this.lb_product_Click);
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customer.Location = new System.Drawing.Point(64, 341);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(112, 25);
            this.lb_customer.TabIndex = 3;
            this.lb_customer.Text = "Customer";
            this.lb_customer.Click += new System.EventHandler(this.lb_customer_Click);
            // 
            // lb_order
            // 
            this.lb_order.AutoSize = true;
            this.lb_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order.Location = new System.Drawing.Point(524, 341);
            this.lb_order.Name = "lb_order";
            this.lb_order.Size = new System.Drawing.Size(83, 25);
            this.lb_order.TabIndex = 4;
            this.lb_order.Text = "Orders";
            this.lb_order.Click += new System.EventHandler(this.lb_order_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(418, 204);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(73, 25);
            this.lb_user.TabIndex = 5;
            this.lb_user.Text = "Users";
            this.lb_user.Click += new System.EventHandler(this.lb_user_Click);
            // 
            // lb_categories
            // 
            this.lb_categories.AutoSize = true;
            this.lb_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categories.Location = new System.Drawing.Point(287, 341);
            this.lb_categories.Name = "lb_categories";
            this.lb_categories.Size = new System.Drawing.Size(126, 25);
            this.lb_categories.TabIndex = 6;
            this.lb_categories.Text = "Categories";
            this.lb_categories.Click += new System.EventHandler(this.lb_categories_Click);
            // 
            // pb_customer
            // 
            this.pb_customer.Image = ((System.Drawing.Image)(resources.GetObject("pb_customer.Image")));
            this.pb_customer.Location = new System.Drawing.Point(82, 276);
            this.pb_customer.Name = "pb_customer";
            this.pb_customer.Size = new System.Drawing.Size(64, 59);
            this.pb_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_customer.TabIndex = 7;
            this.pb_customer.TabStop = false;
            this.pb_customer.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb_cat
            // 
            this.pb_cat.Image = ((System.Drawing.Image)(resources.GetObject("pb_cat.Image")));
            this.pb_cat.Location = new System.Drawing.Point(322, 276);
            this.pb_cat.Name = "pb_cat";
            this.pb_cat.Size = new System.Drawing.Size(64, 59);
            this.pb_cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cat.TabIndex = 8;
            this.pb_cat.TabStop = false;
            // 
            // pb_product
            // 
            this.pb_product.Image = ((System.Drawing.Image)(resources.GetObject("pb_product.Image")));
            this.pb_product.Location = new System.Drawing.Point(529, 279);
            this.pb_product.Name = "pb_product";
            this.pb_product.Size = new System.Drawing.Size(64, 59);
            this.pb_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_product.TabIndex = 9;
            this.pb_product.TabStop = false;
            // 
            // pb_user
            // 
            this.pb_user.Image = ((System.Drawing.Image)(resources.GetObject("pb_user.Image")));
            this.pb_user.Location = new System.Drawing.Point(418, 142);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(64, 59);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 10;
            this.pb_user.TabStop = false;
            // 
            // pb_ord
            // 
            this.pb_ord.Image = ((System.Drawing.Image)(resources.GetObject("pb_ord.Image")));
            this.pb_ord.Location = new System.Drawing.Point(171, 142);
            this.pb_ord.Name = "pb_ord";
            this.pb_ord.Size = new System.Drawing.Size(64, 59);
            this.pb_ord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ord.TabIndex = 11;
            this.pb_ord.TabStop = false;
            // 
            // frm_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 398);
            this.Controls.Add(this.pb_ord);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.pb_product);
            this.Controls.Add(this.lb_categories);
            this.Controls.Add(this.pb_cat);
            this.Controls.Add(this.pb_customer);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_order);
            this.Controls.Add(this.lb_customer);
            this.Controls.Add(this.lb_product);
            this.Controls.Add(this.panel_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(659, 398);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(659, 398);
            this.Name = "frm_cat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel_welcome.ResumeLayout(false);
            this.panel_welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_welcome;
        private System.Windows.Forms.Label frm_category;
        private System.Windows.Forms.Label lb_product;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label lb_order;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_categories;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_customer;
        private System.Windows.Forms.PictureBox pb_cat;
        private System.Windows.Forms.PictureBox pb_product;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.PictureBox pb_ord;
    }
}