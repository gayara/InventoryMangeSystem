namespace InventoryMangeSystem
{
    partial class frm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wellcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.lbl_ord = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_cus = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.lb_num = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_uName = new System.Windows.Forms.Label();
            this.lb_uId = new System.Windows.Forms.Label();
            this.txt_cNum = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uName = new System.Windows.Forms.TextBox();
            this.txt_UId = new System.Windows.Forms.TextBox();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(883, 75);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
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
            this.Wellcome.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Wellcome.Location = new System.Drawing.Point(251, 9);
            this.Wellcome.Name = "Wellcome";
            this.Wellcome.Size = new System.Drawing.Size(371, 60);
            this.Wellcome.TabIndex = 0;
            this.Wellcome.Text = "Manage Users";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lbl_cat);
            this.panel2.Controls.Add(this.lbl_ord);
            this.panel2.Controls.Add(this.lbl_product);
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.lbl_cus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 24);
            this.panel2.TabIndex = 3;
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
            // lbl_ord
            // 
            this.lbl_ord.AutoSize = true;
            this.lbl_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ord.Location = new System.Drawing.Point(695, 3);
            this.lbl_ord.Name = "lbl_ord";
            this.lbl_ord.Size = new System.Drawing.Size(60, 18);
            this.lbl_ord.TabIndex = 10;
            this.lbl_ord.Text = "Orders";
            this.lbl_ord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ord.Click += new System.EventHandler(this.lbl_ord_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.Location = new System.Drawing.Point(102, 3);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(76, 18);
            this.lbl_product.TabIndex = 7;
            this.lbl_product.Text = "Products";
            this.lbl_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_product.Click += new System.EventHandler(this.lbl_product_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(414, 3);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(53, 18);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "Users";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // lbl_cus
            // 
            this.lbl_cus.AutoSize = true;
            this.lbl_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus.Location = new System.Drawing.Point(540, 3);
            this.lbl_cus.Name = "lbl_cus";
            this.lbl_cus.Size = new System.Drawing.Size(82, 18);
            this.lbl_cus.TabIndex = 6;
            this.lbl_cus.Text = "Customer";
            this.lbl_cus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cus.Click += new System.EventHandler(this.lbl_cus_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(197, 326);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 36;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(111, 326);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 35;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(25, 326);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 34;
            this.btn_New.Text = "Add";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // lb_num
            // 
            this.lb_num.AutoSize = true;
            this.lb_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num.Location = new System.Drawing.Point(22, 273);
            this.lb_num.Name = "lb_num";
            this.lb_num.Size = new System.Drawing.Size(110, 17);
            this.lb_num.TabIndex = 31;
            this.lb_num.Text = "Contact Number";
            this.lb_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(22, 247);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(69, 17);
            this.lb_pass.TabIndex = 30;
            this.lb_pass.Text = "Password";
            this.lb_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_uName
            // 
            this.lb_uName.AutoSize = true;
            this.lb_uName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uName.Location = new System.Drawing.Point(22, 221);
            this.lb_uName.Name = "lb_uName";
            this.lb_uName.Size = new System.Drawing.Size(79, 17);
            this.lb_uName.TabIndex = 29;
            this.lb_uName.Text = "User Name";
            this.lb_uName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_uId
            // 
            this.lb_uId.AutoSize = true;
            this.lb_uId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uId.Location = new System.Drawing.Point(22, 193);
            this.lb_uId.Name = "lb_uId";
            this.lb_uId.Size = new System.Drawing.Size(55, 17);
            this.lb_uId.TabIndex = 28;
            this.lb_uId.Text = "User ID";
            this.lb_uId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cNum
            // 
            this.txt_cNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cNum.Location = new System.Drawing.Point(148, 271);
            this.txt_cNum.Multiline = true;
            this.txt_cNum.Name = "txt_cNum";
            this.txt_cNum.Size = new System.Drawing.Size(124, 20);
            this.txt_cNum.TabIndex = 27;
            this.txt_cNum.Tag = "";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(148, 245);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(124, 20);
            this.txt_pass.TabIndex = 26;
            this.txt_pass.Tag = "";
            // 
            // txt_uName
            // 
            this.txt_uName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_uName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uName.Location = new System.Drawing.Point(148, 219);
            this.txt_uName.Multiline = true;
            this.txt_uName.Name = "txt_uName";
            this.txt_uName.Size = new System.Drawing.Size(124, 20);
            this.txt_uName.TabIndex = 25;
            this.txt_uName.Tag = "";
            // 
            // txt_UId
            // 
            this.txt_UId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_UId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UId.Location = new System.Drawing.Point(148, 193);
            this.txt_UId.Multiline = true;
            this.txt_UId.Name = "txt_UId";
            this.txt_UId.Size = new System.Drawing.Size(124, 20);
            this.txt_UId.TabIndex = 24;
            this.txt_UId.Tag = "";
            // 
            // dgv_User
            // 
            this.dgv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_User.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_User.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_User.GridColor = System.Drawing.Color.LightGray;
            this.dgv_User.Location = new System.Drawing.Point(333, 131);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.Size = new System.Drawing.Size(522, 321);
            this.dgv_User.TabIndex = 37;
            this.dgv_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_CellClick);
            this.dgv_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_CellContentClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(111, 364);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 38;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.lb_num);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_uName);
            this.Controls.Add(this.lb_uId);
            this.Controls.Add(this.txt_cNum);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_uName);
            this.Controls.Add(this.txt_UId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(883, 536);
            this.MinimumSize = new System.Drawing.Size(883, 536);
            this.Name = "frm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.frm_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Wellcome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label lbl_ord;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_cus;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label lb_num;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_uName;
        private System.Windows.Forms.Label lb_uId;
        private System.Windows.Forms.TextBox txt_cNum;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_uName;
        private System.Windows.Forms.TextBox txt_UId;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Clear;
    }
}