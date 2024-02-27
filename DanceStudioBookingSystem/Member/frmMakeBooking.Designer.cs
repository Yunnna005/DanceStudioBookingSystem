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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cboYearCard = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
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
            this.CLASSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlHeader.Location = new System.Drawing.Point(171, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(630, 72);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblBookYourClass
            // 
            this.lblBookYourClass.AutoSize = true;
            this.lblBookYourClass.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookYourClass.ForeColor = System.Drawing.Color.White;
            this.lblBookYourClass.Location = new System.Drawing.Point(154, 18);
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
            this.pnlBookClass.Location = new System.Drawing.Point(185, 79);
            this.pnlBookClass.Name = "pnlBookClass";
            this.pnlBookClass.Size = new System.Drawing.Size(609, 436);
            this.pnlBookClass.TabIndex = 3;
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
            this.pnlPayment.Location = new System.Drawing.Point(3, 3);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(603, 433);
            this.pnlPayment.TabIndex = 0;
            this.pnlPayment.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlCVC
            // 
            this.pnlCVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlCVC.Controls.Add(this.txtCVC);
            this.pnlCVC.Controls.Add(this.pictureBox5);
            this.pnlCVC.Location = new System.Drawing.Point(310, 295);
            this.pnlCVC.Name = "pnlCVC";
            this.pnlCVC.Size = new System.Drawing.Size(119, 37);
            this.pnlCVC.TabIndex = 8;
            // 
            // txtCVC
            // 
            this.txtCVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCVC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.Location = new System.Drawing.Point(7, 6);
            this.txtCVC.MaxLength = 3;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(105, 26);
            this.txtCVC.TabIndex = 0;
            this.txtCVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(368, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.Location = new System.Drawing.Point(353, 271);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(40, 21);
            this.lblCVC.TabIndex = 6;
            this.lblCVC.Text = "CVC";
            // 
            // pnlExpireDate
            // 
            this.pnlExpireDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlExpireDate.Controls.Add(this.cboYearCard);
            this.pnlExpireDate.Controls.Add(this.cboMonth);
            this.pnlExpireDate.Location = new System.Drawing.Point(172, 295);
            this.pnlExpireDate.Name = "pnlExpireDate";
            this.pnlExpireDate.Size = new System.Drawing.Size(119, 37);
            this.pnlExpireDate.TabIndex = 7;
            // 
            // cboYearCard
            // 
            this.cboYearCard.DropDownHeight = 80;
            this.cboYearCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYearCard.FormattingEnabled = true;
            this.cboYearCard.IntegralHeight = false;
            this.cboYearCard.Location = new System.Drawing.Point(61, 3);
            this.cboYearCard.Margin = new System.Windows.Forms.Padding(2);
            this.cboYearCard.Name = "cboYearCard";
            this.cboYearCard.Size = new System.Drawing.Size(55, 29);
            this.cboYearCard.TabIndex = 1;
            this.cboYearCard.Text = "Year";
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownHeight = 80;
            this.cboMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.IntegralHeight = false;
            this.cboMonth.Location = new System.Drawing.Point(2, 3);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(55, 29);
            this.cboMonth.TabIndex = 0;
            this.cboMonth.Text = "Month";
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(186, 271);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(86, 21);
            this.lblExpireDate.TabIndex = 5;
            this.lblExpireDate.Text = "Expire date";
            // 
            // pnlCardHolder
            // 
            this.pnlCardHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlCardHolder.Controls.Add(this.txtCardHolder);
            this.pnlCardHolder.Controls.Add(this.pictureBox7);
            this.pnlCardHolder.Location = new System.Drawing.Point(164, 217);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(272, 41);
            this.pnlCardHolder.TabIndex = 4;
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardHolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolder.Location = new System.Drawing.Point(8, 9);
            this.txtCardHolder.MaxLength = 25;
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(257, 26);
            this.txtCardHolder.TabIndex = 0;
            this.txtCardHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(368, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardHolder.Location = new System.Drawing.Point(247, 193);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(92, 21);
            this.lblCardHolder.TabIndex = 3;
            this.lblCardHolder.Text = "Card holder";
            // 
            // pnlCardNumber
            // 
            this.pnlCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.pnlCardNumber.Controls.Add(this.txtCardNumber);
            this.pnlCardNumber.Controls.Add(this.pictureBox8);
            this.pnlCardNumber.Location = new System.Drawing.Point(164, 139);
            this.pnlCardNumber.Name = "pnlCardNumber";
            this.pnlCardNumber.Size = new System.Drawing.Size(272, 41);
            this.pnlCardNumber.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(9, 8);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(257, 26);
            this.txtCardNumber.TabIndex = 0;
            this.txtCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(368, 33);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(247, 115);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(102, 21);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card number";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(256, 351);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(83, 39);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(251, 64);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(98, 30);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLASSNAME,
            this.date,
            this.time,
            this.instructor,
            this.price});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClasses.Location = new System.Drawing.Point(16, 149);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.Size = new System.Drawing.Size(587, 184);
            this.dgvClasses.TabIndex = 3;
            // 
            // CLASSNAME
            // 
            this.CLASSNAME.HeaderText = "Class Name";
            this.CLASSNAME.MinimumWidth = 6;
            this.CLASSNAME.Name = "CLASSNAME";
            this.CLASSNAME.ReadOnly = true;
            this.CLASSNAME.Width = 150;
            // 
            // date
            // 
            this.date.FillWeight = 50F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 80;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 80;
            // 
            // instructor
            // 
            this.instructor.HeaderText = "Instructor";
            this.instructor.MinimumWidth = 8;
            this.instructor.Name = "instructor";
            this.instructor.ReadOnly = true;
            this.instructor.Width = 130;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // lblBookAClass
            // 
            this.lblBookAClass.AutoSize = true;
            this.lblBookAClass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAClass.Location = new System.Drawing.Point(245, 37);
            this.lblBookAClass.Name = "lblBookAClass";
            this.lblBookAClass.Size = new System.Drawing.Size(132, 30);
            this.lblBookAClass.TabIndex = 0;
            this.lblBookAClass.Text = "Book a class";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(259, 358);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(94, 39);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "BOOK";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblTYpe
            // 
            this.lblTYpe.AutoSize = true;
            this.lblTYpe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTYpe.Location = new System.Drawing.Point(187, 107);
            this.lblTYpe.Name = "lblTYpe";
            this.lblTYpe.Size = new System.Drawing.Size(42, 21);
            this.lblTYpe.TabIndex = 1;
            this.lblTYpe.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(277, 107);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 25);
            this.cboType.TabIndex = 2;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
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
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(6, 100, 10, 2);
            this.mnuMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMainMenu.ShowItemToolTips = true;
            this.mnuMainMenu.Size = new System.Drawing.Size(179, 522);
            this.mnuMainMenu.TabIndex = 0;
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
            this.pnlBlueLine.Location = new System.Drawing.Point(157, 0);
            this.pnlBlueLine.Name = "pnlBlueLine";
            this.pnlBlueLine.Size = new System.Drawing.Size(22, 523);
            this.pnlBlueLine.TabIndex = 1;
            // 
            // frmBookClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.pnlBlueLine);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.pnlBookClass);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Class";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBookClass_FormClosed);
            this.Load += new System.EventHandler(this.frmBookClass_Load);
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
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel pnlCVC;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Panel pnlExpireDate;
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
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYearCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}