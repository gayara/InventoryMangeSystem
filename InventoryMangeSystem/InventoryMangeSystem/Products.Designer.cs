namespace InventoryMangeSystem
{
    partial class frm_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wellcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pId = new System.Windows.Forms.TextBox();
            this.txt_pName = new System.Windows.Forms.TextBox();
            this.txt_pQty = new System.Windows.Forms.TextBox();
            this.txt_pPrice = new System.Windows.Forms.TextBox();
            this.lb_pId = new System.Windows.Forms.Label();
            this.lb_pName = new System.Windows.Forms.Label();
            this.lb_pQty = new System.Windows.Forms.Label();
            this.lb_pPrice = new System.Windows.Forms.Label();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.lb_pCategory = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.lb_pDes = new System.Windows.Forms.Label();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Wellcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 90);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(862, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Wellcome
            // 
            this.Wellcome.AutoSize = true;
            this.Wellcome.BackColor = System.Drawing.Color.Transparent;
            this.Wellcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wellcome.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wellcome.ForeColor = System.Drawing.Color.Silver;
            this.Wellcome.Location = new System.Drawing.Point(222, 9);
            this.Wellcome.Name = "Wellcome";
            this.Wellcome.Size = new System.Drawing.Size(476, 60);
            this.Wellcome.TabIndex = 0;
            this.Wellcome.Text = "Manage Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 24);
            this.panel2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Categories";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Orders";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 8;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pId
            // 
            this.txt_pId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_pId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pId.Location = new System.Drawing.Point(138, 167);
            this.txt_pId.Multiline = true;
            this.txt_pId.Name = "txt_pId";
            this.txt_pId.Size = new System.Drawing.Size(124, 20);
            this.txt_pId.TabIndex = 9;
            this.txt_pId.Tag = "";
            // 
            // txt_pName
            // 
            this.txt_pName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_pName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pName.Location = new System.Drawing.Point(138, 193);
            this.txt_pName.Multiline = true;
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.Size = new System.Drawing.Size(124, 20);
            this.txt_pName.TabIndex = 10;
            this.txt_pName.Tag = "";
            // 
            // txt_pQty
            // 
            this.txt_pQty.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_pQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pQty.Location = new System.Drawing.Point(138, 219);
            this.txt_pQty.Multiline = true;
            this.txt_pQty.Name = "txt_pQty";
            this.txt_pQty.Size = new System.Drawing.Size(124, 20);
            this.txt_pQty.TabIndex = 11;
            this.txt_pQty.Tag = "";
            // 
            // txt_pPrice
            // 
            this.txt_pPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_pPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pPrice.Location = new System.Drawing.Point(138, 245);
            this.txt_pPrice.Multiline = true;
            this.txt_pPrice.Name = "txt_pPrice";
            this.txt_pPrice.Size = new System.Drawing.Size(124, 20);
            this.txt_pPrice.TabIndex = 12;
            this.txt_pPrice.Tag = "";
            // 
            // lb_pId
            // 
            this.lb_pId.AutoSize = true;
            this.lb_pId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pId.Location = new System.Drawing.Point(12, 167);
            this.lb_pId.Name = "lb_pId";
            this.lb_pId.Size = new System.Drawing.Size(74, 17);
            this.lb_pId.TabIndex = 13;
            this.lb_pId.Text = "Product ID";
            this.lb_pId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pName
            // 
            this.lb_pName.AutoSize = true;
            this.lb_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pName.Location = new System.Drawing.Point(12, 195);
            this.lb_pName.Name = "lb_pName";
            this.lb_pName.Size = new System.Drawing.Size(98, 17);
            this.lb_pName.TabIndex = 14;
            this.lb_pName.Text = "Product Name";
            this.lb_pName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pQty
            // 
            this.lb_pQty.AutoSize = true;
            this.lb_pQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pQty.Location = new System.Drawing.Point(12, 221);
            this.lb_pQty.Name = "lb_pQty";
            this.lb_pQty.Size = new System.Drawing.Size(83, 17);
            this.lb_pQty.TabIndex = 15;
            this.lb_pQty.Text = "Product Qty";
            this.lb_pQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pPrice
            // 
            this.lb_pPrice.AutoSize = true;
            this.lb_pPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pPrice.Location = new System.Drawing.Point(12, 247);
            this.lb_pPrice.Name = "lb_pPrice";
            this.lb_pPrice.Size = new System.Drawing.Size(93, 17);
            this.lb_pPrice.TabIndex = 16;
            this.lb_pPrice.Text = "Product Price";
            this.lb_pPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_category
            // 
            this.cbx_category.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Items.AddRange(new object[] {
            "Mobile",
            "Laptop",
            "Battry"});
            this.cbx_category.Location = new System.Drawing.Point(138, 297);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(124, 21);
            this.cbx_category.TabIndex = 17;
            this.cbx_category.Text = "  select";
            // 
            // lb_pCategory
            // 
            this.lb_pCategory.AutoSize = true;
            this.lb_pCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pCategory.Location = new System.Drawing.Point(9, 300);
            this.lb_pCategory.Name = "lb_pCategory";
            this.lb_pCategory.Size = new System.Drawing.Size(118, 17);
            this.lb_pCategory.TabIndex = 18;
            this.lb_pCategory.Text = "Product Category";
            this.lb_pCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 344);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 19;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(98, 344);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Edit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(184, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Descrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Descrip.Location = new System.Drawing.Point(138, 271);
            this.txt_Descrip.Multiline = true;
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(124, 20);
            this.txt_Descrip.TabIndex = 22;
            this.txt_Descrip.Tag = "";
            // 
            // lb_pDes
            // 
            this.lb_pDes.AutoSize = true;
            this.lb_pDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pDes.Location = new System.Drawing.Point(12, 273);
            this.lb_pDes.Name = "lb_pDes";
            this.lb_pDes.Size = new System.Drawing.Size(79, 17);
            this.lb_pDes.TabIndex = 23;
            this.lb_pDes.Text = "Description";
            this.lb_pDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(285, 167);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.Size = new System.Drawing.Size(572, 344);
            this.dgv_Product.TabIndex = 24;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(105, 384);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.lb_pDes);
            this.Controls.Add(this.txt_Descrip);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.lb_pCategory);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.lb_pPrice);
            this.Controls.Add(this.lb_pQty);
            this.Controls.Add(this.lb_pName);
            this.Controls.Add(this.lb_pId);
            this.Controls.Add(this.txt_pPrice);
            this.Controls.Add(this.txt_pQty);
            this.Controls.Add(this.txt_pName);
            this.Controls.Add(this.txt_pId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(883, 536);
            this.MinimumSize = new System.Drawing.Size(883, 536);
            this.Name = "frm_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Wellcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pId;
        private System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.TextBox txt_pQty;
        private System.Windows.Forms.TextBox txt_pPrice;
        private System.Windows.Forms.Label lb_pId;
        private System.Windows.Forms.Label lb_pName;
        private System.Windows.Forms.Label lb_pQty;
        private System.Windows.Forms.Label lb_pPrice;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Label lb_pCategory;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.Label lb_pDes;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_save;
    }
}