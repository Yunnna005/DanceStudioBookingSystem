﻿namespace DanceStudioBookingSystem
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
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatisticsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCancelClass = new System.Windows.Forms.Label();
            this.grpSelectedClassDetails = new System.Windows.Forms.GroupBox();
            this.lblWritePrice = new System.Windows.Forms.Label();
            this.lblWriteCapacity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblWriteInstructor = new System.Windows.Forms.Label();
            this.lblWriteDate = new System.Windows.Forms.Label();
            this.lblWriteTime = new System.Windows.Forms.Label();
            this.lblWriteType = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblDateSelected = new System.Windows.Forms.Label();
            this.lblTimeSelected = new System.Windows.Forms.Label();
            this.lblTypeSelected = new System.Windows.Forms.Label();
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.grpSelectClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.grpSelectedClassDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectClass
            // 
            this.grpSelectClass.BackColor = System.Drawing.Color.White;
            this.grpSelectClass.Controls.Add(this.dgvClasses);
            this.grpSelectClass.Controls.Add(this.btnSelect);
            this.grpSelectClass.Controls.Add(this.lblType);
            this.grpSelectClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectClass.Location = new System.Drawing.Point(16, 81);
            this.grpSelectClass.Name = "grpSelectClass";
            this.grpSelectClass.Size = new System.Drawing.Size(540, 261);
            this.grpSelectClass.TabIndex = 17;
            this.grpSelectClass.TabStop = false;
            this.grpSelectClass.Text = "Select Class ";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.date,
            this.time});
            this.dgvClasses.Location = new System.Drawing.Point(35, 27);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.Size = new System.Drawing.Size(470, 184);
            this.dgvClasses.TabIndex = 30;
            // 
            // type
            // 
            this.type.HeaderText = "TYPE";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
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
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(224, 218);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 31);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(106, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 21);
            this.lblType.TabIndex = 16;
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
            this.mnuMainMenu.Size = new System.Drawing.Size(573, 31);
            this.mnuMainMenu.TabIndex = 14;
            this.mnuMainMenu.Text = "Menu";
            // 
            // mnuClasses
            // 
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
            this.lblCancelClass.Location = new System.Drawing.Point(227, 52);
            this.lblCancelClass.Name = "lblCancelClass";
            this.lblCancelClass.Size = new System.Drawing.Size(118, 25);
            this.lblCancelClass.TabIndex = 15;
            this.lblCancelClass.Text = "Cancel Class";
            // 
            // grpSelectedClassDetails
            // 
            this.grpSelectedClassDetails.BackColor = System.Drawing.Color.White;
            this.grpSelectedClassDetails.Controls.Add(this.lblWritePrice);
            this.grpSelectedClassDetails.Controls.Add(this.lblWriteCapacity);
            this.grpSelectedClassDetails.Controls.Add(this.lblPrice);
            this.grpSelectedClassDetails.Controls.Add(this.lblCapacity);
            this.grpSelectedClassDetails.Controls.Add(this.lblWriteInstructor);
            this.grpSelectedClassDetails.Controls.Add(this.lblWriteDate);
            this.grpSelectedClassDetails.Controls.Add(this.lblWriteTime);
            this.grpSelectedClassDetails.Controls.Add(this.lblWriteType);
            this.grpSelectedClassDetails.Controls.Add(this.lblInstructor);
            this.grpSelectedClassDetails.Controls.Add(this.lblDateSelected);
            this.grpSelectedClassDetails.Controls.Add(this.lblTimeSelected);
            this.grpSelectedClassDetails.Controls.Add(this.lblTypeSelected);
            this.grpSelectedClassDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectedClassDetails.Location = new System.Drawing.Point(17, 349);
            this.grpSelectedClassDetails.Name = "grpSelectedClassDetails";
            this.grpSelectedClassDetails.Size = new System.Drawing.Size(539, 277);
            this.grpSelectedClassDetails.TabIndex = 18;
            this.grpSelectedClassDetails.TabStop = false;
            this.grpSelectedClassDetails.Text = "Selected Class Details";
            // 
            // lblWritePrice
            // 
            this.lblWritePrice.AutoSize = true;
            this.lblWritePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWritePrice.Location = new System.Drawing.Point(92, 234);
            this.lblWritePrice.Name = "lblWritePrice";
            this.lblWritePrice.Size = new System.Drawing.Size(44, 21);
            this.lblWritePrice.TabIndex = 27;
            this.lblWritePrice.Text = "price";
            // 
            // lblWriteCapacity
            // 
            this.lblWriteCapacity.AutoSize = true;
            this.lblWriteCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteCapacity.Location = new System.Drawing.Point(89, 196);
            this.lblWriteCapacity.Name = "lblWriteCapacity";
            this.lblWriteCapacity.Size = new System.Drawing.Size(66, 21);
            this.lblWriteCapacity.TabIndex = 26;
            this.lblWriteCapacity.Text = "capacity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(11, 234);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(8, 196);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(76, 21);
            this.lblCapacity.TabIndex = 24;
            this.lblCapacity.Text = "Capacity: ";
            // 
            // lblWriteInstructor
            // 
            this.lblWriteInstructor.AutoSize = true;
            this.lblWriteInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteInstructor.Location = new System.Drawing.Point(92, 157);
            this.lblWriteInstructor.Name = "lblWriteInstructor";
            this.lblWriteInstructor.Size = new System.Drawing.Size(139, 21);
            this.lblWriteInstructor.TabIndex = 23;
            this.lblWriteInstructor.Text = "Selected Instructor";
            // 
            // lblWriteDate
            // 
            this.lblWriteDate.AutoSize = true;
            this.lblWriteDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteDate.Location = new System.Drawing.Point(92, 80);
            this.lblWriteDate.Name = "lblWriteDate";
            this.lblWriteDate.Size = new System.Drawing.Size(104, 21);
            this.lblWriteDate.TabIndex = 22;
            this.lblWriteDate.Text = "Selected Date";
            // 
            // lblWriteTime
            // 
            this.lblWriteTime.AutoSize = true;
            this.lblWriteTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteTime.Location = new System.Drawing.Point(92, 118);
            this.lblWriteTime.Name = "lblWriteTime";
            this.lblWriteTime.Size = new System.Drawing.Size(106, 21);
            this.lblWriteTime.TabIndex = 21;
            this.lblWriteTime.Text = "Selected Time";
            // 
            // lblWriteType
            // 
            this.lblWriteType.AutoSize = true;
            this.lblWriteType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteType.Location = new System.Drawing.Point(92, 37);
            this.lblWriteType.Name = "lblWriteType";
            this.lblWriteType.Size = new System.Drawing.Size(104, 21);
            this.lblWriteType.TabIndex = 20;
            this.lblWriteType.Text = "Selected Type";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(8, 157);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(80, 21);
            this.lblInstructor.TabIndex = 19;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblDateSelected
            // 
            this.lblDateSelected.AutoSize = true;
            this.lblDateSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSelected.Location = new System.Drawing.Point(8, 80);
            this.lblDateSelected.Name = "lblDateSelected";
            this.lblDateSelected.Size = new System.Drawing.Size(45, 21);
            this.lblDateSelected.TabIndex = 17;
            this.lblDateSelected.Text = "Date:";
            // 
            // lblTimeSelected
            // 
            this.lblTimeSelected.AutoSize = true;
            this.lblTimeSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSelected.Location = new System.Drawing.Point(8, 118);
            this.lblTimeSelected.Name = "lblTimeSelected";
            this.lblTimeSelected.Size = new System.Drawing.Size(47, 21);
            this.lblTimeSelected.TabIndex = 15;
            this.lblTimeSelected.Text = "Time:";
            // 
            // lblTypeSelected
            // 
            this.lblTypeSelected.AutoSize = true;
            this.lblTypeSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSelected.Location = new System.Drawing.Point(7, 37);
            this.lblTypeSelected.Name = "lblTypeSelected";
            this.lblTypeSelected.Size = new System.Drawing.Size(49, 21);
            this.lblTypeSelected.TabIndex = 14;
            this.lblTypeSelected.Text = "Type: ";
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnCancelClass.FlatAppearance.BorderSize = 0;
            this.btnCancelClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.ForeColor = System.Drawing.Color.White;
            this.btnCancelClass.Location = new System.Drawing.Point(223, 642);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(113, 31);
            this.btnCancelClass.TabIndex = 19;
            this.btnCancelClass.Text = "Cancel Class";
            this.btnCancelClass.UseVisualStyleBackColor = false;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // frmCancelClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(573, 682);
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.grpSelectedClassDetails);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpSelectedClassDetails.ResumeLayout(false);
            this.grpSelectedClassDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectClass;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem tmnuScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem tmnuModifyClass;
        private System.Windows.Forms.ToolStripMenuItem tmnuCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuStatisticsTool;
        private System.Windows.Forms.Label lblCancelClass;
        private System.Windows.Forms.GroupBox grpSelectedClassDetails;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblDateSelected;
        private System.Windows.Forms.Label lblTimeSelected;
        private System.Windows.Forms.Label lblTypeSelected;
        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.Label lblWriteInstructor;
        private System.Windows.Forms.Label lblWriteDate;
        private System.Windows.Forms.Label lblWriteTime;
        private System.Windows.Forms.Label lblWriteType;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblWritePrice;
        private System.Windows.Forms.Label lblWriteCapacity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}