namespace InventoryMangeSystem
{
    partial class frm_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wellcome = new System.Windows.Forms.Label();
            this.dgv_cus = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.lbl_cutId = new System.Windows.Forms.Label();
            this.txt_cID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.lbl_order = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.llbl_customer = new System.Windows.Forms.Label();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.btn_addOrdr = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cucname = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Wellcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 90);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 90);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(862, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";
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
            // dgv_cus
            // 
            this.dgv_cus.AllowUserToAddRows = false;
            this.dgv_cus.AllowUserToDeleteRows = false;
            this.dgv_cus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cus.Location = new System.Drawing.Point(19, 157);
            this.dgv_cus.Name = "dgv_cus";
            this.dgv_cus.ReadOnly = true;
            this.dgv_cus.Size = new System.Drawing.Size(347, 167);
            this.dgv_cus.TabIndex = 72;
            this.dgv_cus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellClick);
            this.dgv_cus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellContentClick);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_view.Location = new System.Drawing.Point(184, 487);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(91, 25);
            this.btn_view.TabIndex = 68;
            this.btn_view.Text = "View Order";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insert.Location = new System.Drawing.Point(57, 487);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(93, 25);
            this.btn_insert.TabIndex = 67;
            this.btn_insert.Text = "Insert Order";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Product Category";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_search
            // 
            this.cmb_search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "Mobile",
            "Laptop",
            "Battry"});
            this.cmb_search.Location = new System.Drawing.Point(633, 125);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(124, 21);
            this.cmb_search.TabIndex = 65;
            this.cmb_search.Text = "  select";
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            this.cmb_search.SelectionChangeCommitted += new System.EventHandler(this.cmb_search_SelectionChangeCommitted);
            // 
            // lbl_cutId
            // 
            this.lbl_cutId.AutoSize = true;
            this.lbl_cutId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cutId.Location = new System.Drawing.Point(48, 374);
            this.lbl_cutId.Name = "lbl_cutId";
            this.lbl_cutId.Size = new System.Drawing.Size(85, 17);
            this.lbl_cutId.TabIndex = 61;
            this.lbl_cutId.Text = "Customer ID\r\n";
            this.lbl_cutId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cID
            // 
            this.txt_cID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cID.Location = new System.Drawing.Point(139, 373);
            this.txt_cID.Multiline = true;
            this.txt_cID.Name = "txt_cID";
            this.txt_cID.Size = new System.Drawing.Size(171, 20);
            this.txt_cID.TabIndex = 57;
            this.txt_cID.Tag = "";
            this.txt_cID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cID.TextChanged += new System.EventHandler(this.txt_cID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lbl_cat);
            this.panel3.Controls.Add(this.lbl_order);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_user);
            this.panel3.Controls.Add(this.llbl_customer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 24);
            this.panel3.TabIndex = 73;
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat.Location = new System.Drawing.Point(251, 3);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(90, 18);
            this.lbl_cat.TabIndex = 11;
            this.lbl_cat.Text = "Categories";
            this.lbl_cat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cat.Click += new System.EventHandler(this.lbl_cat_Click);
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order.Location = new System.Drawing.Point(695, 3);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(60, 18);
            this.lbl_order.TabIndex = 10;
            this.lbl_order.Text = "Orders";
            this.lbl_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_order.Click += new System.EventHandler(this.lbl_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(414, 3);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(53, 18);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "Users";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // llbl_customer
            // 
            this.llbl_customer.AutoSize = true;
            this.llbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_customer.Location = new System.Drawing.Point(540, 3);
            this.llbl_customer.Name = "llbl_customer";
            this.llbl_customer.Size = new System.Drawing.Size(82, 18);
            this.llbl_customer.TabIndex = 6;
            this.llbl_customer.Text = "Customer";
            this.llbl_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbl_customer.Click += new System.EventHandler(this.llbl_customer_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(381, 157);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(490, 167);
            this.dgv_product.TabIndex = 74;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            this.dgv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellContentClick);
            // 
            // dgv_order
            // 
            this.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Product,
            this.Quantity,
            this.UPrice,
            this.TotPrice});
            this.dgv_order.Location = new System.Drawing.Point(347, 360);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.Size = new System.Drawing.Size(524, 144);
            this.dgv_order.TabIndex = 75;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UPrice
            // 
            this.UPrice.HeaderText = "Uprice";
            this.UPrice.Name = "UPrice";
            // 
            // TotPrice
            // 
            this.TotPrice.HeaderText = "TotPrice";
            this.TotPrice.Name = "TotPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 76;
            this.label7.Text = "Customer List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Quantity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Qty
            // 
            this.txt_Qty.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Qty.Location = new System.Drawing.Point(668, 337);
            this.txt_Qty.Multiline = true;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(99, 20);
            this.txt_Qty.TabIndex = 78;
            this.txt_Qty.Tag = "";
            // 
            // btn_addOrdr
            // 
            this.btn_addOrdr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_addOrdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrdr.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrdr.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addOrdr.Location = new System.Drawing.Point(773, 337);
            this.btn_addOrdr.Name = "btn_addOrdr";
            this.btn_addOrdr.Size = new System.Drawing.Size(98, 20);
            this.btn_addOrdr.TabIndex = 79;
            this.btn_addOrdr.Text = "Add  to Order";
            this.btn_addOrdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addOrdr.UseVisualStyleBackColor = false;
            this.btn_addOrdr.Click += new System.EventHandler(this.btn_addOrdr_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(139, 433);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(173, 20);
            this.date.TabIndex = 80;
            this.date.Value = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Enter Order ID\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_oid
            // 
            this.txt_oid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_oid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_oid.Location = new System.Drawing.Point(139, 343);
            this.txt_oid.Multiline = true;
            this.txt_oid.Name = "txt_oid";
            this.txt_oid.Size = new System.Drawing.Size(171, 20);
            this.txt_oid.TabIndex = 83;
            this.txt_oid.Tag = "";
            this.txt_oid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Customer Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cucname
            // 
            this.txt_cucname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cucname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cucname.Location = new System.Drawing.Point(139, 403);
            this.txt_cucname.Multiline = true;
            this.txt_cucname.Name = "txt_cucname";
            this.txt_cucname.Size = new System.Drawing.Size(171, 20);
            this.txt_cucname.TabIndex = 85;
            this.txt_cucname.Tag = "";
            this.txt_cucname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amount.Location = new System.Drawing.Point(748, 510);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(123, 20);
            this.txt_amount.TabIndex = 87;
            this.txt_amount.Tag = "";
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(619, 513);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(123, 17);
            this.lblamount.TabIndex = 86;
            this.lblamount.Text = "Total Amount (Rs)";
            this.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(773, 125);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(63, 23);
            this.btn_refresh.TabIndex = 88;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.txt_cucname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_oid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date);
            this.Controls.Add(this.btn_addOrdr);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_cus);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.lbl_cutId);
            this.Controls.Add(this.txt_cID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(883, 536);
            this.MinimumSize = new System.Drawing.Size(883, 536);
            this.Name = "frm_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Wellcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgv_cus;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label lbl_cutId;
        private System.Windows.Forms.TextBox txt_cID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label llbl_customer;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Button btn_addOrdr;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_oid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cucname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotPrice;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Button btn_refresh;
    }
}