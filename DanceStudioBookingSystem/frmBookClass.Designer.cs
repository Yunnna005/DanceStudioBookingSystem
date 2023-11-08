namespace DanceStudioBookingSystem
{
    partial class frmBookClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookClass));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBookYourClass = new System.Windows.Forms.Label();
            this.pnlBookClass = new System.Windows.Forms.Panel();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCVC = new System.Windows.Forms.Panel();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.pnlExpireDate = new System.Windows.Forms.Panel();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.pnlCardHolder = new System.Windows.Forms.Panel();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.pnlCardNumber = new System.Windows.Forms.Panel();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookAClass = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblTYpe = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBlueLine = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBookClass.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlCVC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlExpireDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnlCardHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlCardNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.lblBookYourClass);
            this.pnlHeader.Location = new System.Drawing.Point(256, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(945, 111);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblBookYourClass
            // 
            this.lblBookYourClass.AutoSize = true;
            this.lblBookYourClass.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookYourClass.ForeColor = System.Drawing.Color.White;
            this.lblBookYourClass.Location = new System.Drawing.Point(231, 28);
            this.lblBookYourClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookYourClass.Name = "lblBookYourClass";
            this.lblBookYourClass.Size = new System.Drawing.Size(329, 40);
            this.lblBookYourClass.TabIndex = 0;
            this.lblBookYourClass.Text = "- BOOK YOUR CLASS -";
            // 
            // pnlBookClass
            // 
            this.pnlBookClass.BackColor = System.Drawing.Color.White;
            this.pnlBookClass.Controls.Add(this.pnlPayment);
            this.pnlBookClass.Controls.Add(this.dgvClasses);
            this.pnlBookClass.Controls.Add(this.lblBookAClass);
            this.pnlBookClass.Controls.Add(this.btnBook);
            this.pnlBookClass.Controls.Add(this.lblTYpe);
            this.pnlBookClass.Controls.Add(this.cboType);
            this.pnlBookClass.ForeColor = System.Drawing.Color.Black;
            this.pnlBookClass.Location = new System.Drawing.Point(277, 121);
            this.pnlBookClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBookClass.Name = "pnlBookClass";
            this.pnlBookClass.Size = new System.Drawing.Size(914, 671);
            this.pnlBookClass.TabIndex = 4;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.btnBack);
            this.pnlPayment.Controls.Add(this.pnlCVC);
            this.pnlPayment.Controls.Add(this.lblCVC);
            this.pnlPayment.Controls.Add(this.pnlExpireDate);
            this.pnlPayment.Controls.Add(this.lblExpireDate);
            this.pnlPayment.Controls.Add(this.pnlCardHolder);
            this.pnlPayment.Controls.Add(this.lblCardHolder);
            this.pnlPayment.Controls.Add(this.pnlCardNumber);
            this.pnlPayment.Controls.Add(this.lblCardNumber);
            this.pnlPayment.Controls.Add(this.btnPay);
            this.pnlPayment.Controls.Add(this.lblPayment);
            this.pnlPayment.Location = new System.Drawing.Point(6, 5);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(904, 666);
            this.pnlPayment.TabIndex = 30;
            this.pnlPayment.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(19, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 35);
            this.btnBack.TabIndex = 39;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlCVC
            // 
            this.pnlCVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlCVC.Controls.Add(this.txtCVC);
            this.pnlCVC.Controls.Add(this.pictureBox5);
            this.pnlCVC.Location = new System.Drawing.Point(465, 454);
            this.pnlCVC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCVC.Name = "pnlCVC";
            this.pnlCVC.Size = new System.Drawing.Size(178, 57);
            this.pnlCVC.TabIndex = 38;
            // 
            // txtCVC
            // 
            this.txtCVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCVC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.Location = new System.Drawing.Point(10, 9);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(158, 26);
            this.txtCVC.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(552, 51);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.Location = new System.Drawing.Point(530, 417);
            this.lblCVC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(40, 21);
            this.lblCVC.TabIndex = 37;
            this.lblCVC.Text = "CVC";
            // 
            // pnlExpireDate
            // 
            this.pnlExpireDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlExpireDate.Controls.Add(this.txtExpireDate);
            this.pnlExpireDate.Controls.Add(this.pictureBox6);
            this.pnlExpireDate.Location = new System.Drawing.Point(258, 454);
            this.pnlExpireDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlExpireDate.Name = "pnlExpireDate";
            this.pnlExpireDate.Size = new System.Drawing.Size(178, 57);
            this.pnlExpireDate.TabIndex = 36;
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpireDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpireDate.Location = new System.Drawing.Point(10, 9);
            this.txtExpireDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(158, 26);
            this.txtExpireDate.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(552, 51);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(279, 417);
            this.lblExpireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(86, 21);
            this.lblExpireDate.TabIndex = 35;
            this.lblExpireDate.Text = "Expire date";
            // 
            // pnlCardHolder
            // 
            this.pnlCardHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlCardHolder.Controls.Add(this.txtCardHolder);
            this.pnlCardHolder.Controls.Add(this.pictureBox7);
            this.pnlCardHolder.Location = new System.Drawing.Point(246, 334);
            this.pnlCardHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(408, 63);
            this.pnlCardHolder.TabIndex = 34;
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardHolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolder.Location = new System.Drawing.Point(12, 14);
            this.txtCardHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(386, 26);
            this.txtCardHolder.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(552, 51);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardHolder.Location = new System.Drawing.Point(370, 297);
            this.lblCardHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(92, 21);
            this.lblCardHolder.TabIndex = 33;
            this.lblCardHolder.Text = "Card holder";
            // 
            // pnlCardNumber
            // 
            this.pnlCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlCardNumber.Controls.Add(this.txtCardNumber);
            this.pnlCardNumber.Controls.Add(this.pictureBox8);
            this.pnlCardNumber.Location = new System.Drawing.Point(246, 214);
            this.pnlCardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCardNumber.Name = "pnlCardNumber";
            this.pnlCardNumber.Size = new System.Drawing.Size(408, 63);
            this.pnlCardNumber.TabIndex = 32;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(14, 12);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(386, 26);
            this.txtCardNumber.TabIndex = 1;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(552, 51);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(370, 177);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(102, 21);
            this.lblCardNumber.TabIndex = 29;
            this.lblCardNumber.Text = "Card number";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(384, 540);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 60);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(376, 98);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(98, 30);
            this.lblPayment.TabIndex = 30;
            this.lblPayment.Text = "Payment";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time,
            this.instructor,
            this.price});
            this.dgvClasses.Location = new System.Drawing.Point(135, 237);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.Size = new System.Drawing.Size(661, 231);
            this.dgvClasses.TabIndex = 29;
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // time
            // 
            this.time.HeaderText = "TIME";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 150;
            // 
            // instructor
            // 
            this.instructor.HeaderText = "INSTRUCTOR";
            this.instructor.MinimumWidth = 8;
            this.instructor.Name = "instructor";
            this.instructor.ReadOnly = true;
            this.instructor.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // lblBookAClass
            // 
            this.lblBookAClass.AutoSize = true;
            this.lblBookAClass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAClass.Location = new System.Drawing.Point(368, 57);
            this.lblBookAClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAClass.Name = "lblBookAClass";
            this.lblBookAClass.Size = new System.Drawing.Size(132, 30);
            this.lblBookAClass.TabIndex = 11;
            this.lblBookAClass.Text = "Book a class";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(392, 498);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(141, 60);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "BOOK";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblTYpe
            // 
            this.lblTYpe.AutoSize = true;
            this.lblTYpe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTYpe.Location = new System.Drawing.Point(280, 165);
            this.lblTYpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTYpe.Name = "lblTYpe";
            this.lblTYpe.Size = new System.Drawing.Size(42, 21);
            this.lblTYpe.TabIndex = 1;
            this.lblTYpe.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(416, 165);
            this.cboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(180, 28);
            this.cboType.TabIndex = 0;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.mnuMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuMainMenu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainMenu.GripMargin = new System.Windows.Forms.Padding(2, 10, 0, 2);
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfile,
            this.mnuBook});
            this.mnuMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(9, 154, 15, 3);
            this.mnuMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMainMenu.ShowItemToolTips = true;
            this.mnuMainMenu.Size = new System.Drawing.Size(187, 803);
            this.mnuMainMenu.TabIndex = 12;
            this.mnuMainMenu.Text = "Menu";
            // 
            // mnuProfile
            // 
            this.mnuProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mnuProfile.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProfile.ForeColor = System.Drawing.Color.Black;
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.mnuProfile.Size = new System.Drawing.Size(152, 51);
            this.mnuProfile.Text = "Profile ";
            this.mnuProfile.Click += new System.EventHandler(this.mnuProfile_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mnuBook.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.mnuBook.Size = new System.Drawing.Size(163, 51);
            this.mnuBook.Text = "Book";
            // 
            // pnlBlueLine
            // 
            this.pnlBlueLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlBlueLine.Location = new System.Drawing.Point(236, 0);
            this.pnlBlueLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBlueLine.Name = "pnlBlueLine";
            this.pnlBlueLine.Size = new System.Drawing.Size(33, 805);
            this.pnlBlueLine.TabIndex = 13;
            // 
            // frmBookClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1200, 803);
            this.Controls.Add(this.pnlBlueLine);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.pnlBookClass);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBookClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Class";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBookClass.ResumeLayout(false);
            this.pnlBookClass.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlCVC.ResumeLayout(false);
            this.pnlCVC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlExpireDate.ResumeLayout(false);
            this.pnlExpireDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnlCardHolder.ResumeLayout(false);
            this.pnlCardHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlCardNumber.ResumeLayout(false);
            this.pnlCardNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBookYourClass;
        private System.Windows.Forms.Panel pnlBookClass;
        private System.Windows.Forms.Label lblBookAClass;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblTYpe;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.Panel pnlBlueLine;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel pnlCVC;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Panel pnlExpireDate;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Panel pnlCardHolder;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Panel pnlCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnBack;
    }
}