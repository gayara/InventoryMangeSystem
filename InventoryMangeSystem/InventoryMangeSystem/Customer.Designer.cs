namespace InventoryMangeSystem
{
    partial class frm_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wellcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.lbl_ordr = new System.Windows.Forms.Label();
            this.lbl_pro = new System.Windows.Forms.Label();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.lbl_cus = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UTel = new System.Windows.Forms.TextBox();
            this.txt_uPass = new System.Windows.Forms.TextBox();
            this.txt_uName = new System.Windows.Forms.TextBox();
            this.txt_uID = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Wellcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 90);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.Wellcome.ForeColor = System.Drawing.Color.Crimson;
            this.Wellcome.Location = new System.Drawing.Point(195, 9);
            this.Wellcome.Name = "Wellcome";
            this.Wellcome.Size = new System.Drawing.Size(503, 60);
            this.Wellcome.TabIndex = 0;
            this.Wellcome.Text = "Manage Customers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lbl_cat);
            this.panel2.Controls.Add(this.lbl_ordr);
            this.panel2.Controls.Add(this.lbl_pro);
            this.panel2.Controls.Add(this.lbl_usr);
            this.panel2.Controls.Add(this.lbl_cus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
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
            // lbl_ordr
            // 
            this.lbl_ordr.AutoSize = true;
            this.lbl_ordr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordr.Location = new System.Drawing.Point(695, 3);
            this.lbl_ordr.Name = "lbl_ordr";
            this.lbl_ordr.Size = new System.Drawing.Size(60, 18);
            this.lbl_ordr.TabIndex = 10;
            this.lbl_ordr.Text = "Orders";
            this.lbl_ordr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ordr.Click += new System.EventHandler(this.lbl_ordr_Click);
            // 
            // lbl_pro
            // 
            this.lbl_pro.AutoSize = true;
            this.lbl_pro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro.Location = new System.Drawing.Point(102, 3);
            this.lbl_pro.Name = "lbl_pro";
            this.lbl_pro.Size = new System.Drawing.Size(76, 18);
            this.lbl_pro.TabIndex = 7;
            this.lbl_pro.Text = "Products";
            this.lbl_pro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pro.Click += new System.EventHandler(this.lbl_pro_Click);
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usr.Location = new System.Drawing.Point(414, 3);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(53, 18);
            this.lbl_usr.TabIndex = 8;
            this.lbl_usr.Text = "Users";
            this.lbl_usr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_usr.Click += new System.EventHandler(this.lbl_usr_Click);
            // 
            // lbl_cus
            // 
            this.lbl_cus.AutoSize = true;
            this.lbl_cus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus.Location = new System.Drawing.Point(540, 3);
            this.lbl_cus.Name = "lbl_cus";
            this.lbl_cus.Size = new System.Drawing.Size(82, 18);
            this.lbl_cus.TabIndex = 6;
            this.lbl_cus.Text = "Customer";
            this.lbl_cus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cus.Click += new System.EventHandler(this.lbl_cus_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(211, 357);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 84;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(125, 357);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 83;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(39, 357);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 82;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Contact Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "User Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Usee ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_UTel
            // 
            this.txt_UTel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_UTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UTel.Location = new System.Drawing.Point(162, 280);
            this.txt_UTel.Multiline = true;
            this.txt_UTel.Name = "txt_UTel";
            this.txt_UTel.Size = new System.Drawing.Size(124, 20);
            this.txt_UTel.TabIndex = 75;
            this.txt_UTel.Tag = "";
            // 
            // txt_uPass
            // 
            this.txt_uPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_uPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uPass.Location = new System.Drawing.Point(162, 254);
            this.txt_uPass.Multiline = true;
            this.txt_uPass.Name = "txt_uPass";
            this.txt_uPass.Size = new System.Drawing.Size(124, 20);
            this.txt_uPass.TabIndex = 74;
            this.txt_uPass.Tag = "";
            // 
            // txt_uName
            // 
            this.txt_uName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_uName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uName.Location = new System.Drawing.Point(162, 228);
            this.txt_uName.Multiline = true;
            this.txt_uName.Name = "txt_uName";
            this.txt_uName.Size = new System.Drawing.Size(124, 20);
            this.txt_uName.TabIndex = 73;
            this.txt_uName.Tag = "";
            // 
            // txt_uID
            // 
            this.txt_uID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_uID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uID.Location = new System.Drawing.Point(162, 202);
            this.txt_uID.Multiline = true;
            this.txt_uID.Name = "txt_uID";
            this.txt_uID.Size = new System.Drawing.Size(124, 20);
            this.txt_uID.TabIndex = 72;
            this.txt_uID.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(125, 397);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 85;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 351);
            this.dataGridView1.TabIndex = 86;
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_UTel);
            this.Controls.Add(this.txt_uPass);
            this.Controls.Add(this.txt_uName);
            this.Controls.Add(this.txt_uID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(883, 536);
            this.MinimumSize = new System.Drawing.Size(883, 536);
            this.Name = "frm_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Wellcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label lbl_ordr;
        private System.Windows.Forms.Label lbl_pro;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.Label lbl_cus;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UTel;
        private System.Windows.Forms.TextBox txt_uPass;
        private System.Windows.Forms.TextBox txt_uName;
        private System.Windows.Forms.TextBox txt_uID;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}