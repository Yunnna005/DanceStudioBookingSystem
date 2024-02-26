namespace DanceStudioBookingSystem
{
    partial class frmCancelClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelClass));
            this.grpSelectClass = new System.Windows.Forms.GroupBox();
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dgvCancelClassesAdmin = new System.Windows.Forms.DataGridView();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatisticsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCancelClass = new System.Windows.Forms.Label();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliable_places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSelectClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelClassesAdmin)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectClass
            // 
            this.grpSelectClass.BackColor = System.Drawing.Color.White;
            this.grpSelectClass.Controls.Add(this.btnCancelClass);
            this.grpSelectClass.Controls.Add(this.label1);
            this.grpSelectClass.Controls.Add(this.cboType);
            this.grpSelectClass.Controls.Add(this.dgvCancelClassesAdmin);
            this.grpSelectClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectClass.Location = new System.Drawing.Point(5, 81);
            this.grpSelectClass.Name = "grpSelectClass";
            this.grpSelectClass.Size = new System.Drawing.Size(701, 351);
            this.grpSelectClass.TabIndex = 2;
            this.grpSelectClass.TabStop = false;
            this.grpSelectClass.Text = "Select Class ";
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnCancelClass.FlatAppearance.BorderSize = 0;
            this.btnCancelClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.ForeColor = System.Drawing.Color.White;
            this.btnCancelClass.Location = new System.Drawing.Point(279, 307);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(113, 31);
            this.btnCancelClass.TabIndex = 4;
            this.btnCancelClass.Text = "Cancel Class";
            this.btnCancelClass.UseVisualStyleBackColor = false;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownHeight = 80;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(336, 25);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(126, 29);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // dgvCancelClassesAdmin
            // 
            this.dgvCancelClassesAdmin.AllowUserToAddRows = false;
            this.dgvCancelClassesAdmin.AllowUserToDeleteRows = false;
            this.dgvCancelClassesAdmin.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCancelClassesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelClassesAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id,
            this.CLASSNAME,
            this.Type,
            this.Date,
            this.Time,
            this.avaliable_places,
            this.CAPACITY,
            this.INSTRUCTOR,
            this.PRICE});
            this.dgvCancelClassesAdmin.Location = new System.Drawing.Point(6, 66);
            this.dgvCancelClassesAdmin.Name = "dgvCancelClassesAdmin";
            this.dgvCancelClassesAdmin.ReadOnly = true;
            this.dgvCancelClassesAdmin.RowHeadersWidth = 62;
            this.dgvCancelClassesAdmin.Size = new System.Drawing.Size(690, 227);
            this.dgvCancelClassesAdmin.TabIndex = 3;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.mnuMainMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClasses,
            this.mnuStatisticsTool,
            this.mnuBack});
            this.mnuMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuMainMenu.Size = new System.Drawing.Size(709, 31);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "Menu";
            // 
            // mnuClasses
            // 
            this.mnuClasses.Checked = true;
            this.mnuClasses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuClasses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuScheduleClass,
            this.tmnuModifyClass,
            this.tmnuCancelClass});
            this.mnuClasses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuClasses.Name = "mnuClasses";
            this.mnuClasses.Size = new System.Drawing.Size(85, 29);
            this.mnuClasses.Text = "Classes";
            // 
            // tmnuScheduleClass
            // 
            this.tmnuScheduleClass.Name = "tmnuScheduleClass";
            this.tmnuScheduleClass.Size = new System.Drawing.Size(209, 30);
            this.tmnuScheduleClass.Text = "Schedule Class";
            this.tmnuScheduleClass.Click += new System.EventHandler(this.tmnuScheduleClass_Click);
            // 
            // tmnuModifyClass
            // 
            this.tmnuModifyClass.Name = "tmnuModifyClass";
            this.tmnuModifyClass.Size = new System.Drawing.Size(209, 30);
            this.tmnuModifyClass.Text = "Modify Class";
            this.tmnuModifyClass.Click += new System.EventHandler(this.tmnuModifyClass_Click);
            // 
            // tmnuCancelClass
            // 
            this.tmnuCancelClass.Checked = true;
            this.tmnuCancelClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tmnuCancelClass.Name = "tmnuCancelClass";
            this.tmnuCancelClass.Size = new System.Drawing.Size(209, 30);
            this.tmnuCancelClass.Text = "Cancel Class";
            this.tmnuCancelClass.Click += new System.EventHandler(this.tmnuCancelClass_Click);
            // 
            // mnuStatisticsTool
            // 
            this.mnuStatisticsTool.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStatisticsTool.Name = "mnuStatisticsTool";
            this.mnuStatisticsTool.Size = new System.Drawing.Size(96, 29);
            this.mnuStatisticsTool.Text = "Statistics";
            this.mnuStatisticsTool.Click += new System.EventHandler(this.mnuStatisticsTool_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(63, 29);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblCancelClass
            // 
            this.lblCancelClass.AutoSize = true;
            this.lblCancelClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelClass.Location = new System.Drawing.Point(321, 53);
            this.lblCancelClass.Name = "lblCancelClass";
            this.lblCancelClass.Size = new System.Drawing.Size(118, 25);
            this.lblCancelClass.TabIndex = 1;
            this.lblCancelClass.Text = "Cancel Class";
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
            this.Type.Width = 50;
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
            // avaliable_places
            // 
            this.avaliable_places.HeaderText = "AvaliablePlaces";
            this.avaliable_places.Name = "avaliable_places";
            this.avaliable_places.ReadOnly = true;
            // 
            // CAPACITY
            // 
            this.CAPACITY.HeaderText = "Capacity";
            this.CAPACITY.Name = "CAPACITY";
            this.CAPACITY.ReadOnly = true;
            this.CAPACITY.Width = 80;
            // 
            // INSTRUCTOR
            // 
            this.INSTRUCTOR.HeaderText = "Instructor";
            this.INSTRUCTOR.Name = "INSTRUCTOR";
            this.INSTRUCTOR.ReadOnly = true;
            this.INSTRUCTOR.Width = 120;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Price";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 60;
            // 
            // frmCancelClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(709, 437);
            this.Controls.Add(this.grpSelectClass);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.lblCancelClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCancelClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Class";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCancelClass_FormClosed);
            this.grpSelectClass.ResumeLayout(false);
            this.grpSelectClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelClassesAdmin)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectClass;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem tmnuScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem tmnuModifyClass;
        private System.Windows.Forms.ToolStripMenuItem tmnuCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuStatisticsTool;
        private System.Windows.Forms.Label lblCancelClass;
        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.DataGridView dgvCancelClassesAdmin;
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