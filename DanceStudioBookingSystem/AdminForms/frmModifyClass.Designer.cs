﻿namespace DanceStudioBookingSystem
{
    partial class frmModifyClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyClass));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblModifyClass = new System.Windows.Forms.Label();
            this.grpUpdateDetails = new System.Windows.Forms.GroupBox();
            this.cboType2 = new System.Windows.Forms.ComboBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.cboInstructor = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.grpSelectClass = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dgvModifyClassesAdmin = new System.Windows.Forms.DataGridView();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliable_places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.mnuMainMenu.SuspendLayout();
            this.grpUpdateDetails.SuspendLayout();
            this.grpSelectClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyClassesAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.mnuMainMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClasses,
            this.mnuStatistics,
            this.mnuBack});
            this.mnuMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuMainMenu.Size = new System.Drawing.Size(652, 31);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "Menu";
            // 
            // mnuClasses
            // 
            this.mnuClasses.Checked = true;
            this.mnuClasses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuClasses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutScheduleClass,
            this.mnutModifyClass,
            this.mnutCancelClass});
            this.mnuClasses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuClasses.Name = "mnuClasses";
            this.mnuClasses.Size = new System.Drawing.Size(85, 29);
            this.mnuClasses.Text = "Classes";
            // 
            // mnutScheduleClass
            // 
            this.mnutScheduleClass.Name = "mnutScheduleClass";
            this.mnutScheduleClass.Size = new System.Drawing.Size(209, 30);
            this.mnutScheduleClass.Text = "Schedule Class";
            this.mnutScheduleClass.Click += new System.EventHandler(this.mnutScheduleClass_Click);
            // 
            // mnutModifyClass
            // 
            this.mnutModifyClass.Checked = true;
            this.mnutModifyClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnutModifyClass.Name = "mnutModifyClass";
            this.mnutModifyClass.Size = new System.Drawing.Size(209, 30);
            this.mnutModifyClass.Text = "Modify Class";
            this.mnutModifyClass.Click += new System.EventHandler(this.mnutModifyClass_Click);
            // 
            // mnutCancelClass
            // 
            this.mnutCancelClass.Name = "mnutCancelClass";
            this.mnutCancelClass.Size = new System.Drawing.Size(209, 30);
            this.mnutCancelClass.Text = "Cancel Class";
            this.mnutCancelClass.Click += new System.EventHandler(this.mnutCancelClass_Click);
            // 
            // mnuStatistics
            // 
            this.mnuStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStatistics.Name = "mnuStatistics";
            this.mnuStatistics.Size = new System.Drawing.Size(96, 29);
            this.mnuStatistics.Text = "Statistics";
            this.mnuStatistics.Click += new System.EventHandler(this.mnuStatistics_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(63, 29);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblModifyClass
            // 
            this.lblModifyClass.AutoSize = true;
            this.lblModifyClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyClass.Location = new System.Drawing.Point(276, 46);
            this.lblModifyClass.Name = "lblModifyClass";
            this.lblModifyClass.Size = new System.Drawing.Size(124, 25);
            this.lblModifyClass.TabIndex = 1;
            this.lblModifyClass.Text = "Modify Class";
            // 
            // grpUpdateDetails
            // 
            this.grpUpdateDetails.BackColor = System.Drawing.Color.White;
            this.grpUpdateDetails.Controls.Add(this.cboType2);
            this.grpUpdateDetails.Controls.Add(this.txtMinute);
            this.grpUpdateDetails.Controls.Add(this.lblSymbol);
            this.grpUpdateDetails.Controls.Add(this.txtHour);
            this.grpUpdateDetails.Controls.Add(this.cboInstructor);
            this.grpUpdateDetails.Controls.Add(this.txtName);
            this.grpUpdateDetails.Controls.Add(this.lblName);
            this.grpUpdateDetails.Controls.Add(this.dtpDate);
            this.grpUpdateDetails.Controls.Add(this.txtCapacity);
            this.grpUpdateDetails.Controls.Add(this.lblCapacity);
            this.grpUpdateDetails.Controls.Add(this.txtPrice);
            this.grpUpdateDetails.Controls.Add(this.lblPrice);
            this.grpUpdateDetails.Controls.Add(this.lblInstructor);
            this.grpUpdateDetails.Controls.Add(this.lblDate);
            this.grpUpdateDetails.Controls.Add(this.btnUpdate);
            this.grpUpdateDetails.Controls.Add(this.lblTime);
            this.grpUpdateDetails.Controls.Add(this.lblType);
            this.grpUpdateDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateDetails.Location = new System.Drawing.Point(16, 415);
            this.grpUpdateDetails.Name = "grpUpdateDetails";
            this.grpUpdateDetails.Size = new System.Drawing.Size(627, 284);
            this.grpUpdateDetails.TabIndex = 3;
            this.grpUpdateDetails.TabStop = false;
            this.grpUpdateDetails.Text = "Update Current Class Details";
            this.grpUpdateDetails.Visible = false;
            // 
            // cboType2
            // 
            this.cboType2.DropDownHeight = 80;
            this.cboType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType2.FormattingEnabled = true;
            this.cboType2.IntegralHeight = false;
            this.cboType2.Location = new System.Drawing.Point(150, 119);
            this.cboType2.Name = "cboType2";
            this.cboType2.Size = new System.Drawing.Size(143, 25);
            this.cboType2.TabIndex = 22;
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtMinute.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(458, 44);
            this.txtMinute.MaxLength = 2;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(39, 25);
            this.txtMinute.TabIndex = 8;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(443, 43);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(17, 25);
            this.lblSymbol.TabIndex = 14;
            this.lblSymbol.Text = ":";
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtHour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(408, 43);
            this.txtHour.MaxLength = 2;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(39, 25);
            this.txtHour.TabIndex = 7;
            // 
            // cboInstructor
            // 
            this.cboInstructor.DropDownHeight = 80;
            this.cboInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstructor.FormattingEnabled = true;
            this.cboInstructor.IntegralHeight = false;
            this.cboInstructor.Location = new System.Drawing.Point(432, 94);
            this.cboInstructor.Name = "cboInstructor";
            this.cboInstructor.Size = new System.Drawing.Size(125, 29);
            this.cboInstructor.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(151, 77);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(151, 156);
            this.dtpDate.MaxDate = new System.DateTime(2095, 7, 14, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2004, 1, 28, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(142, 29);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2024, 3, 8, 0, 0, 0, 0);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(441, 140);
            this.txtCapacity.MaxLength = 2;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(116, 25);
            this.txtCapacity.TabIndex = 12;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(352, 144);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 21);
            this.lblCapacity.TabIndex = 11;
            this.lblCapacity.Text = "Capacity:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(441, 182);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 25);
            this.txtPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(352, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(352, 97);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(80, 21);
            this.lblInstructor.TabIndex = 9;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(71, 162);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(265, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 31);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(352, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(71, 119);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 21);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type: ";
            // 
            // grpSelectClass
            // 
            this.grpSelectClass.BackColor = System.Drawing.Color.White;
            this.grpSelectClass.Controls.Add(this.label1);
            this.grpSelectClass.Controls.Add(this.cboType);
            this.grpSelectClass.Controls.Add(this.dgvModifyClassesAdmin);
            this.grpSelectClass.Controls.Add(this.btnSelect);
            this.grpSelectClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectClass.Location = new System.Drawing.Point(16, 74);
            this.grpSelectClass.Name = "grpSelectClass";
            this.grpSelectClass.Size = new System.Drawing.Size(627, 335);
            this.grpSelectClass.TabIndex = 2;
            this.grpSelectClass.TabStop = false;
            this.grpSelectClass.Text = "Select Class ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownHeight = 80;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(311, 19);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 25);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // dgvModifyClassesAdmin
            // 
            this.dgvModifyClassesAdmin.AllowUserToAddRows = false;
            this.dgvModifyClassesAdmin.AllowUserToDeleteRows = false;
            this.dgvModifyClassesAdmin.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModifyClassesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyClassesAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id,
            this.CLASSNAME,
            this.Type,
            this.Date,
            this.Time,
            this.avaliable_places,
            this.CAPACITY,
            this.INSTRUCTOR,
            this.PRICE});
            this.dgvModifyClassesAdmin.Location = new System.Drawing.Point(6, 52);
            this.dgvModifyClassesAdmin.Name = "dgvModifyClassesAdmin";
            this.dgvModifyClassesAdmin.ReadOnly = true;
            this.dgvModifyClassesAdmin.RowHeadersVisible = false;
            this.dgvModifyClassesAdmin.RowHeadersWidth = 62;
            this.dgvModifyClassesAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModifyClassesAdmin.Size = new System.Drawing.Size(615, 231);
            this.dgvModifyClassesAdmin.TabIndex = 2;
            // 
            // class_id
            // 
            this.class_id.HeaderText = "ID";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Width = 50;
            // 
            // CLASSNAME
            // 
            this.CLASSNAME.HeaderText = "Class Name";
            this.CLASSNAME.MinimumWidth = 6;
            this.CLASSNAME.Name = "CLASSNAME";
            this.CLASSNAME.ReadOnly = true;
            this.CLASSNAME.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 80;
            // 
            // avaliable_places
            // 
            this.avaliable_places.HeaderText = "AvaliablePlaces";
            this.avaliable_places.Name = "avaliable_places";
            this.avaliable_places.ReadOnly = true;
            // 
            // CAPACITY
            // 
            this.CAPACITY.HeaderText = "Capacity";
            this.CAPACITY.MinimumWidth = 6;
            this.CAPACITY.Name = "CAPACITY";
            this.CAPACITY.ReadOnly = true;
            this.CAPACITY.Width = 125;
            // 
            // INSTRUCTOR
            // 
            this.INSTRUCTOR.HeaderText = "Instructor";
            this.INSTRUCTOR.MinimumWidth = 6;
            this.INSTRUCTOR.Name = "INSTRUCTOR";
            this.INSTRUCTOR.ReadOnly = true;
            this.INSTRUCTOR.Width = 120;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Price";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 60;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(281, 289);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 31);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmModifyClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(652, 705);
            this.Controls.Add(this.grpSelectClass);
            this.Controls.Add(this.grpUpdateDetails);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.lblModifyClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Class";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModifyClass_FormClosed);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpUpdateDetails.ResumeLayout(false);
            this.grpUpdateDetails.PerformLayout();
            this.grpSelectClass.ResumeLayout(false);
            this.grpSelectClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyClassesAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem mnutScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem mnutModifyClass;
        private System.Windows.Forms.ToolStripMenuItem mnutCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.Label lblModifyClass;
        private System.Windows.Forms.GroupBox grpUpdateDetails;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grpSelectClass;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboInstructor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.DataGridView dgvModifyClassesAdmin;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ComboBox cboType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliable_places;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPACITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTRUCTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}