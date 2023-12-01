namespace DanceStudioBookingSystem
{
    partial class frmMainMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenuAdmin));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpClasses = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dgvClassesAdmin = new System.Windows.Forms.DataGridView();
            this.CLASSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuMainMenu.SuspendLayout();
            this.grpClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesAdmin)).BeginInit();
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
            this.mnuLogOut});
            this.mnuMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuMainMenu.Size = new System.Drawing.Size(770, 31);
            this.mnuMainMenu.TabIndex = 0;
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
            // mnuLogOut
            // 
            this.mnuLogOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuLogOut.Size = new System.Drawing.Size(91, 29);
            this.mnuLogOut.Text = "Log Out";
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpClasses
            // 
            this.grpClasses.BackColor = System.Drawing.Color.White;
            this.grpClasses.Controls.Add(this.lblType);
            this.grpClasses.Controls.Add(this.cboType);
            this.grpClasses.Controls.Add(this.dgvClassesAdmin);
            this.grpClasses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClasses.Location = new System.Drawing.Point(0, 47);
            this.grpClasses.Name = "grpClasses";
            this.grpClasses.Size = new System.Drawing.Size(770, 330);
            this.grpClasses.TabIndex = 2;
            this.grpClasses.TabStop = false;
            this.grpClasses.Text = "Classes";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(271, 25);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 21);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "K-pop",
            "Latin",
            "Ballet",
            "Hip-Hop"});
            this.cboType.Location = new System.Drawing.Point(361, 25);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 29);
            this.cboType.TabIndex = 2;
            this.cboType.Text = "Choose type";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // dgvClassesAdmin
            // 
            this.dgvClassesAdmin.AllowUserToAddRows = false;
            this.dgvClassesAdmin.AllowUserToDeleteRows = false;
            this.dgvClassesAdmin.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClassesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassesAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLASSNAME,
            this.Type,
            this.Date,
            this.Time,
            this.INSTRUCTOR,
            this.CAPACITY,
            this.PRICE});
            this.dgvClassesAdmin.Location = new System.Drawing.Point(6, 60);
            this.dgvClassesAdmin.Name = "dgvClassesAdmin";
            this.dgvClassesAdmin.ReadOnly = true;
            this.dgvClassesAdmin.RowHeadersWidth = 62;
            this.dgvClassesAdmin.Size = new System.Drawing.Size(752, 257);
            this.dgvClassesAdmin.TabIndex = 0;
            // 
            // CLASSNAME
            // 
            this.CLASSNAME.HeaderText = "Class Name";
            this.CLASSNAME.Name = "CLASSNAME";
            this.CLASSNAME.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
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
            // 
            // INSTRUCTOR
            // 
            this.INSTRUCTOR.HeaderText = "Instructor";
            this.INSTRUCTOR.Name = "INSTRUCTOR";
            this.INSTRUCTOR.ReadOnly = true;
            // 
            // CAPACITY
            // 
            this.CAPACITY.HeaderText = "Capacity";
            this.CAPACITY.Name = "CAPACITY";
            this.CAPACITY.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Price";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // frmMainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(770, 387);
            this.Controls.Add(this.grpClasses);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenuAdmin_FormClosed);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpClasses.ResumeLayout(false);
            this.grpClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnutScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem mnutModifyClass;
        private System.Windows.Forms.ToolStripMenuItem mnutCancelClass;
        private System.Windows.Forms.GroupBox grpClasses;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTRUCTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPACITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
    }
}