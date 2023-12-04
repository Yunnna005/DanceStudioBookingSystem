namespace DanceStudioBookingSystem
{
    partial class frmScheduleClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleClass));
            this.pnlScheduleClass = new System.Windows.Forms.Panel();
            this.cboInstructor = new System.Windows.Forms.ComboBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblScheduleClass = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlScheduleClass.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScheduleClass
            // 
            this.pnlScheduleClass.BackColor = System.Drawing.Color.White;
            this.pnlScheduleClass.Controls.Add(this.cboInstructor);
            this.pnlScheduleClass.Controls.Add(this.cboTime);
            this.pnlScheduleClass.Controls.Add(this.txtName);
            this.pnlScheduleClass.Controls.Add(this.lblName);
            this.pnlScheduleClass.Controls.Add(this.dtpDate);
            this.pnlScheduleClass.Controls.Add(this.txtType);
            this.pnlScheduleClass.Controls.Add(this.lblInstructor);
            this.pnlScheduleClass.Controls.Add(this.txtCapacity);
            this.pnlScheduleClass.Controls.Add(this.lblCapacity);
            this.pnlScheduleClass.Controls.Add(this.lblDate);
            this.pnlScheduleClass.Controls.Add(this.btnAdd);
            this.pnlScheduleClass.Controls.Add(this.txtPrice);
            this.pnlScheduleClass.Controls.Add(this.lblPrice);
            this.pnlScheduleClass.Controls.Add(this.lblTime);
            this.pnlScheduleClass.Controls.Add(this.lblType);
            this.pnlScheduleClass.Location = new System.Drawing.Point(11, 73);
            this.pnlScheduleClass.Name = "pnlScheduleClass";
            this.pnlScheduleClass.Size = new System.Drawing.Size(420, 312);
            this.pnlScheduleClass.TabIndex = 8;
            // 
            // cboInstructor
            // 
            this.cboInstructor.DropDownHeight = 80;
            this.cboInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstructor.DropDownWidth = 124;
            this.cboInstructor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInstructor.FormattingEnabled = true;
            this.cboInstructor.IntegralHeight = false;
            this.cboInstructor.Location = new System.Drawing.Point(199, 176);
            this.cboInstructor.MaxDropDownItems = 4;
            this.cboInstructor.Name = "cboInstructor";
            this.cboInstructor.Size = new System.Drawing.Size(124, 25);
            this.cboInstructor.Sorted = true;
            this.cboInstructor.TabIndex = 5;
            // 
            // cboTime
            // 
            this.cboTime.DropDownHeight = 80;
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.IntegralHeight = false;
            this.cboTime.Location = new System.Drawing.Point(199, 137);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(124, 25);
            this.cboTime.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(199, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(199, 94);
            this.dtpDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 29);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2023, 10, 18, 0, 0, 0, 0);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(199, 56);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(124, 25);
            this.txtType.TabIndex = 2;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(96, 176);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(80, 21);
            this.lblInstructor.TabIndex = 12;
            this.lblInstructor.Text = "Instructor:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(134, 225);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(52, 25);
            this.txtCapacity.TabIndex = 6;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(51, 229);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 21);
            this.lblCapacity.TabIndex = 10;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(96, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 21);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(154, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(280, 225);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(66, 25);
            this.txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(227, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(96, 137);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(96, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 21);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type: ";
            // 
            // lblScheduleClass
            // 
            this.lblScheduleClass.AutoSize = true;
            this.lblScheduleClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleClass.Location = new System.Drawing.Point(146, 45);
            this.lblScheduleClass.Name = "lblScheduleClass";
            this.lblScheduleClass.Size = new System.Drawing.Size(140, 25);
            this.lblScheduleClass.TabIndex = 7;
            this.lblScheduleClass.Text = "Schedule Class";
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
            this.mnuMainMenu.Size = new System.Drawing.Size(442, 31);
            this.mnuMainMenu.TabIndex = 6;
            this.mnuMainMenu.Text = "Menu";
            // 
            // mnuClasses
            // 
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
            // frmScheduleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(442, 387);
            this.Controls.Add(this.pnlScheduleClass);
            this.Controls.Add(this.lblScheduleClass);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Class";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScheduleClass_FormClosed);
            this.pnlScheduleClass.ResumeLayout(false);
            this.pnlScheduleClass.PerformLayout();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlScheduleClass;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblScheduleClass;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem mnutScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem mnutModifyClass;
        private System.Windows.Forms.ToolStripMenuItem mnutCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboInstructor;
        private System.Windows.Forms.ComboBox cboTime;
    }
}