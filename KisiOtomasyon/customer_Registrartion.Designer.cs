
namespace KisiOtomasyon
{
    partial class customer_Registrartion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_Registrartion));
            this.pnl_cus_regis = new System.Windows.Forms.Panel();
            this.cbb_company = new System.Windows.Forms.ComboBox();
            this.lbl_company = new System.Windows.Forms.Label();
            this.ric_cus_adress = new System.Windows.Forms.RichTextBox();
            this.lbl_cus_adress = new System.Windows.Forms.Label();
            this.txt_cus_tc = new System.Windows.Forms.TextBox();
            this.lbl_cus_tc = new System.Windows.Forms.Label();
            this.txt_cus_phone = new System.Windows.Forms.TextBox();
            this.lbl_cus_phone = new System.Windows.Forms.Label();
            this.txt_cus_surname = new System.Windows.Forms.TextBox();
            this.lcl_cus_surname = new System.Windows.Forms.Label();
            this.txt_cus_name = new System.Windows.Forms.TextBox();
            this.lbl_cus_name = new System.Windows.Forms.Label();
            this.cbb_city = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.pic_customer = new System.Windows.Forms.PictureBox();
            this.btn_customer_add = new System.Windows.Forms.Button();
            this.pnl_top_customerList = new System.Windows.Forms.Panel();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_cus_list = new System.Windows.Forms.Label();
            this.pic_top = new System.Windows.Forms.PictureBox();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.cus_grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_cus_regis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customer)).BeginInit();
            this.pnl_top_customerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_top)).BeginInit();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cus_grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cus_regis
            // 
            this.pnl_cus_regis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cus_regis.Controls.Add(this.cbb_company);
            this.pnl_cus_regis.Controls.Add(this.lbl_company);
            this.pnl_cus_regis.Controls.Add(this.ric_cus_adress);
            this.pnl_cus_regis.Controls.Add(this.lbl_cus_adress);
            this.pnl_cus_regis.Controls.Add(this.txt_cus_tc);
            this.pnl_cus_regis.Controls.Add(this.lbl_cus_tc);
            this.pnl_cus_regis.Controls.Add(this.txt_cus_phone);
            this.pnl_cus_regis.Controls.Add(this.lbl_cus_phone);
            this.pnl_cus_regis.Controls.Add(this.txt_cus_surname);
            this.pnl_cus_regis.Controls.Add(this.lcl_cus_surname);
            this.pnl_cus_regis.Controls.Add(this.txt_cus_name);
            this.pnl_cus_regis.Controls.Add(this.lbl_cus_name);
            this.pnl_cus_regis.Controls.Add(this.cbb_city);
            this.pnl_cus_regis.Controls.Add(this.lbl_city);
            this.pnl_cus_regis.Controls.Add(this.pic_customer);
            this.pnl_cus_regis.Controls.Add(this.btn_customer_add);
            this.pnl_cus_regis.Location = new System.Drawing.Point(27, 32);
            this.pnl_cus_regis.Name = "pnl_cus_regis";
            this.pnl_cus_regis.Size = new System.Drawing.Size(319, 466);
            this.pnl_cus_regis.TabIndex = 9;
            // 
            // cbb_company
            // 
            this.cbb_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_company.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbb_company.FormattingEnabled = true;
            this.cbb_company.Location = new System.Drawing.Point(15, 182);
            this.cbb_company.Name = "cbb_company";
            this.cbb_company.Size = new System.Drawing.Size(289, 29);
            this.cbb_company.TabIndex = 20;
            this.cbb_company.Text = "Seçiniz";
            // 
            // lbl_company
            // 
            this.lbl_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_company.AutoSize = true;
            this.lbl_company.BackColor = System.Drawing.Color.Transparent;
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_company.ForeColor = System.Drawing.Color.White;
            this.lbl_company.Location = new System.Drawing.Point(12, 164);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(40, 15);
            this.lbl_company.TabIndex = 21;
            this.lbl_company.Text = "Firma:";
            // 
            // ric_cus_adress
            // 
            this.ric_cus_adress.Location = new System.Drawing.Point(15, 334);
            this.ric_cus_adress.MaxLength = 500;
            this.ric_cus_adress.Name = "ric_cus_adress";
            this.ric_cus_adress.Size = new System.Drawing.Size(288, 78);
            this.ric_cus_adress.TabIndex = 5;
            this.ric_cus_adress.Text = "";
            // 
            // lbl_cus_adress
            // 
            this.lbl_cus_adress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cus_adress.AutoSize = true;
            this.lbl_cus_adress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cus_adress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cus_adress.ForeColor = System.Drawing.Color.White;
            this.lbl_cus_adress.Location = new System.Drawing.Point(12, 316);
            this.lbl_cus_adress.Name = "lbl_cus_adress";
            this.lbl_cus_adress.Size = new System.Drawing.Size(40, 15);
            this.lbl_cus_adress.TabIndex = 19;
            this.lbl_cus_adress.Text = "Adres:\r\n";
            // 
            // txt_cus_tc
            // 
            this.txt_cus_tc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cus_tc.Location = new System.Drawing.Point(167, 282);
            this.txt_cus_tc.MaxLength = 11;
            this.txt_cus_tc.Name = "txt_cus_tc";
            this.txt_cus_tc.Size = new System.Drawing.Size(136, 29);
            this.txt_cus_tc.TabIndex = 4;
            // 
            // lbl_cus_tc
            // 
            this.lbl_cus_tc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cus_tc.AutoSize = true;
            this.lbl_cus_tc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cus_tc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cus_tc.ForeColor = System.Drawing.Color.White;
            this.lbl_cus_tc.Location = new System.Drawing.Point(164, 264);
            this.lbl_cus_tc.Name = "lbl_cus_tc";
            this.lbl_cus_tc.Size = new System.Drawing.Size(42, 15);
            this.lbl_cus_tc.TabIndex = 17;
            this.lbl_cus_tc.Text = "TC No:";
            // 
            // txt_cus_phone
            // 
            this.txt_cus_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cus_phone.Location = new System.Drawing.Point(15, 282);
            this.txt_cus_phone.MaxLength = 11;
            this.txt_cus_phone.Name = "txt_cus_phone";
            this.txt_cus_phone.Size = new System.Drawing.Size(136, 29);
            this.txt_cus_phone.TabIndex = 3;
            // 
            // lbl_cus_phone
            // 
            this.lbl_cus_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cus_phone.AutoSize = true;
            this.lbl_cus_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cus_phone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cus_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_cus_phone.Location = new System.Drawing.Point(12, 264);
            this.lbl_cus_phone.Name = "lbl_cus_phone";
            this.lbl_cus_phone.Size = new System.Drawing.Size(67, 15);
            this.lbl_cus_phone.TabIndex = 15;
            this.lbl_cus_phone.Text = "Telefon No:";
            // 
            // txt_cus_surname
            // 
            this.txt_cus_surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cus_surname.Location = new System.Drawing.Point(167, 231);
            this.txt_cus_surname.MaxLength = 20;
            this.txt_cus_surname.Name = "txt_cus_surname";
            this.txt_cus_surname.Size = new System.Drawing.Size(136, 29);
            this.txt_cus_surname.TabIndex = 2;
            // 
            // lcl_cus_surname
            // 
            this.lcl_cus_surname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcl_cus_surname.AutoSize = true;
            this.lcl_cus_surname.BackColor = System.Drawing.Color.Transparent;
            this.lcl_cus_surname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lcl_cus_surname.ForeColor = System.Drawing.Color.White;
            this.lcl_cus_surname.Location = new System.Drawing.Point(164, 213);
            this.lcl_cus_surname.Name = "lcl_cus_surname";
            this.lcl_cus_surname.Size = new System.Drawing.Size(54, 15);
            this.lcl_cus_surname.TabIndex = 13;
            this.lcl_cus_surname.Text = "Soy İsim:";
            // 
            // txt_cus_name
            // 
            this.txt_cus_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cus_name.Location = new System.Drawing.Point(14, 231);
            this.txt_cus_name.MaxLength = 20;
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.Size = new System.Drawing.Size(137, 29);
            this.txt_cus_name.TabIndex = 1;
            // 
            // lbl_cus_name
            // 
            this.lbl_cus_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cus_name.AutoSize = true;
            this.lbl_cus_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cus_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cus_name.ForeColor = System.Drawing.Color.White;
            this.lbl_cus_name.Location = new System.Drawing.Point(12, 213);
            this.lbl_cus_name.Name = "lbl_cus_name";
            this.lbl_cus_name.Size = new System.Drawing.Size(32, 15);
            this.lbl_cus_name.TabIndex = 11;
            this.lbl_cus_name.Text = "İsim:";
            // 
            // cbb_city
            // 
            this.cbb_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_city.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbb_city.FormattingEnabled = true;
            this.cbb_city.Location = new System.Drawing.Point(14, 133);
            this.cbb_city.Name = "cbb_city";
            this.cbb_city.Size = new System.Drawing.Size(289, 29);
            this.cbb_city.TabIndex = 0;
            this.cbb_city.Text = "Seçiniz";
            // 
            // lbl_city
            // 
            this.lbl_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_city.AutoSize = true;
            this.lbl_city.BackColor = System.Drawing.Color.Transparent;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(11, 115);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(36, 15);
            this.lbl_city.TabIndex = 9;
            this.lbl_city.Text = "Şehir:";
            // 
            // pic_customer
            // 
            this.pic_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_customer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customer.Image")));
            this.pic_customer.Location = new System.Drawing.Point(116, 24);
            this.pic_customer.Name = "pic_customer";
            this.pic_customer.Size = new System.Drawing.Size(81, 71);
            this.pic_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customer.TabIndex = 8;
            this.pic_customer.TabStop = false;
            // 
            // btn_customer_add
            // 
            this.btn_customer_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(1)))), ((int)(((byte)(83)))));
            this.btn_customer_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customer_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_customer_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(1)))), ((int)(((byte)(83)))));
            this.btn_customer_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(1)))), ((int)(((byte)(83)))));
            this.btn_customer_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_customer_add.ForeColor = System.Drawing.Color.White;
            this.btn_customer_add.Location = new System.Drawing.Point(0, 428);
            this.btn_customer_add.Name = "btn_customer_add";
            this.btn_customer_add.Size = new System.Drawing.Size(319, 38);
            this.btn_customer_add.TabIndex = 6;
            this.btn_customer_add.Text = "Müşteri Ekle";
            this.btn_customer_add.UseVisualStyleBackColor = false;
            this.btn_customer_add.Click += new System.EventHandler(this.btn_customer_add_Click);
            // 
            // pnl_top_customerList
            // 
            this.pnl_top_customerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_top_customerList.BackColor = System.Drawing.Color.Transparent;
            this.pnl_top_customerList.Controls.Add(this.pic_search);
            this.pnl_top_customerList.Controls.Add(this.txt_search);
            this.pnl_top_customerList.Controls.Add(this.lbl_cus_list);
            this.pnl_top_customerList.Controls.Add(this.pic_top);
            this.pnl_top_customerList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_top_customerList.Location = new System.Drawing.Point(357, 32);
            this.pnl_top_customerList.Name = "pnl_top_customerList";
            this.pnl_top_customerList.Size = new System.Drawing.Size(722, 56);
            this.pnl_top_customerList.TabIndex = 12;
            // 
            // pic_search
            // 
            this.pic_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_search.Image = ((System.Drawing.Image)(resources.GetObject("pic_search.Image")));
            this.pic_search.Location = new System.Drawing.Point(495, 13);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(29, 29);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 7;
            this.pic_search.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(495, 13);
            this.txt_search.MaxLength = 50;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(209, 29);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_cus_list
            // 
            this.lbl_cus_list.AutoSize = true;
            this.lbl_cus_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cus_list.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cus_list.ForeColor = System.Drawing.Color.White;
            this.lbl_cus_list.Location = new System.Drawing.Point(73, 12);
            this.lbl_cus_list.Name = "lbl_cus_list";
            this.lbl_cus_list.Size = new System.Drawing.Size(148, 30);
            this.lbl_cus_list.TabIndex = 3;
            this.lbl_cus_list.Text = "Müşteri Listesi";
            // 
            // pic_top
            // 
            this.pic_top.Image = ((System.Drawing.Image)(resources.GetObject("pic_top.Image")));
            this.pic_top.Location = new System.Drawing.Point(19, 11);
            this.pic_top.Name = "pic_top";
            this.pic_top.Size = new System.Drawing.Size(37, 34);
            this.pic_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_top.TabIndex = 0;
            this.pic_top.TabStop = false;
            // 
            // pnl_grid
            // 
            this.pnl_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_grid.BackColor = System.Drawing.Color.Transparent;
            this.pnl_grid.Controls.Add(this.cus_grid);
            this.pnl_grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_grid.Location = new System.Drawing.Point(357, 94);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(722, 440);
            this.pnl_grid.TabIndex = 13;
            // 
            // cus_grid
            // 
            this.cus_grid.AllowUserToAddRows = false;
            this.cus_grid.AllowUserToDeleteRows = false;
            this.cus_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cus_grid.BackgroundColor = System.Drawing.Color.White;
            this.cus_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cus_grid.ContextMenuStrip = this.contextMenuStrip1;
            this.cus_grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cus_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cus_grid.Location = new System.Drawing.Point(0, 0);
            this.cus_grid.Name = "cus_grid";
            this.cus_grid.ReadOnly = true;
            this.cus_grid.Size = new System.Drawing.Size(722, 440);
            this.cus_grid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 78);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripMenuItem.Image")));
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("güncelleToolStripMenuItem.Image")));
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // customer_Registrartion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 557);
            this.Controls.Add(this.pnl_grid);
            this.Controls.Add(this.pnl_top_customerList);
            this.Controls.Add(this.pnl_cus_regis);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1119, 596);
            this.Name = "customer_Registrartion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Activated += new System.EventHandler(this.customer_Registrartion_Activated);
            this.Load += new System.EventHandler(this.customer_Registrartion_Load);
            this.pnl_cus_regis.ResumeLayout(false);
            this.pnl_cus_regis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customer)).EndInit();
            this.pnl_top_customerList.ResumeLayout(false);
            this.pnl_top_customerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_top)).EndInit();
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cus_grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cus_regis;
        private System.Windows.Forms.RichTextBox ric_cus_adress;
        private System.Windows.Forms.Label lbl_cus_adress;
        private System.Windows.Forms.TextBox txt_cus_tc;
        private System.Windows.Forms.Label lbl_cus_tc;
        private System.Windows.Forms.TextBox txt_cus_phone;
        private System.Windows.Forms.Label lbl_cus_phone;
        private System.Windows.Forms.TextBox txt_cus_surname;
        private System.Windows.Forms.Label lcl_cus_surname;
        private System.Windows.Forms.TextBox txt_cus_name;
        private System.Windows.Forms.Label lbl_cus_name;
        private System.Windows.Forms.ComboBox cbb_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.PictureBox pic_customer;
        private System.Windows.Forms.Button btn_customer_add;
        private System.Windows.Forms.Panel pnl_top_customerList;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_cus_list;
        private System.Windows.Forms.PictureBox pic_top;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.DataGridView cus_grid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbb_company;
        private System.Windows.Forms.Label lbl_company;
    }
}