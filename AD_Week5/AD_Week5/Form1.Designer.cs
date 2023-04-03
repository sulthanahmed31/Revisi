namespace AD_Week5
{
    partial class Form1
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
            this.dataproduk = new System.Windows.Forms.DataGridView();
            this.datacategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_list = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namakategori = new System.Windows.Forms.TextBox();
            this.tambah_category = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datastock = new System.Windows.Forms.TextBox();
            this.dataharga = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.addproduct = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataproduk
            // 
            this.dataproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproduk.Location = new System.Drawing.Point(32, 72);
            this.dataproduk.Name = "dataproduk";
            this.dataproduk.RowHeadersWidth = 62;
            this.dataproduk.RowTemplate.Height = 28;
            this.dataproduk.Size = new System.Drawing.Size(545, 352);
            this.dataproduk.TabIndex = 0;
            this.dataproduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduk_CellContentClick);
            // 
            // datacategory
            // 
            this.datacategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacategory.Location = new System.Drawing.Point(636, 72);
            this.datacategory.Name = "datacategory";
            this.datacategory.RowHeadersWidth = 62;
            this.datacategory.RowTemplate.Height = 28;
            this.datacategory.Size = new System.Drawing.Size(382, 180);
            this.datacategory.TabIndex = 1;
            this.datacategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filter :";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_list
            // 
            this.cb_list.FormattingEnabled = true;
            this.cb_list.Location = new System.Drawing.Point(371, 38);
            this.cb_list.Name = "cb_list";
            this.cb_list.Size = new System.Drawing.Size(147, 28);
            this.cb_list.TabIndex = 6;
            this.cb_list.SelectedIndexChanged += new System.EventHandler(this.cb_list_SelectedIndexChanged);
            this.cb_list.SelectionChangeCommitted += new System.EventHandler(this.cb_list_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama :";
            // 
            // namakategori
            // 
            this.namakategori.Location = new System.Drawing.Point(731, 306);
            this.namakategori.Name = "namakategori";
            this.namakategori.Size = new System.Drawing.Size(193, 26);
            this.namakategori.TabIndex = 8;
            // 
            // tambah_category
            // 
            this.tambah_category.BackColor = System.Drawing.Color.Gainsboro;
            this.tambah_category.Location = new System.Drawing.Point(740, 374);
            this.tambah_category.Name = "tambah_category";
            this.tambah_category.Size = new System.Drawing.Size(85, 68);
            this.tambah_category.TabIndex = 9;
            this.tambah_category.Text = "Add Category";
            this.tambah_category.UseVisualStyleBackColor = false;
            this.tambah_category.Click += new System.EventHandler(this.tambah_category_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(843, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 68);
            this.button4.TabIndex = 10;
            this.button4.Text = "Remove Category";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stock :";
            // 
            // datastock
            // 
            this.datastock.Location = new System.Drawing.Point(140, 570);
            this.datastock.Name = "datastock";
            this.datastock.Size = new System.Drawing.Size(193, 26);
            this.datastock.TabIndex = 16;
            this.datastock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datastock_KeyPress);
            // 
            // dataharga
            // 
            this.dataharga.Location = new System.Drawing.Point(140, 539);
            this.dataharga.Name = "dataharga";
            this.dataharga.Size = new System.Drawing.Size(193, 26);
            this.dataharga.TabIndex = 17;
            this.dataharga.TextChanged += new System.EventHandler(this.dataharga_TextChanged);
            this.dataharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataharga_KeyPress);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(140, 477);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(498, 26);
            this.nama.TabIndex = 18;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(140, 507);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(193, 28);
            this.cb_category.TabIndex = 19;
            // 
            // addproduct
            // 
            this.addproduct.BackColor = System.Drawing.Color.Gainsboro;
            this.addproduct.Location = new System.Drawing.Point(371, 507);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(85, 68);
            this.addproduct.TabIndex = 20;
            this.addproduct.Text = "Add Product";
            this.addproduct.UseVisualStyleBackColor = false;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(462, 507);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 68);
            this.button6.TabIndex = 21;
            this.button6.Text = "Edit Product";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(553, 507);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 68);
            this.button7.TabIndex = 22;
            this.button7.Text = "Remove Product\r\n";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1081, 608);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.dataharga);
            this.Controls.Add(this.datastock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tambah_category);
            this.Controls.Add(this.namakategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datacategory);
            this.Controls.Add(this.dataproduk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataproduk;
        private System.Windows.Forms.DataGridView datacategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namakategori;
        private System.Windows.Forms.Button tambah_category;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox datastock;
        private System.Windows.Forms.TextBox dataharga;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

