﻿namespace DanceStudioBookingSystem
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.cboInstructor = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
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
            this.pnlScheduleClass.Controls.Add(this.cboType);
            this.pnlScheduleClass.Controls.Add(this.txtMinute);
            this.pnlScheduleClass.Controls.Add(this.lblSymbol);
            this.pnlScheduleClass.Controls.Add(this.txtHour);
            this.pnlScheduleClass.Controls.Add(this.cboInstructor);
            this.pnlScheduleClass.Controls.Add(this.txtName);
            this.pnlScheduleClass.Controls.Add(this.lblName);
            this.pnlScheduleClass.Controls.Add(this.dtpDate);
            this.pnlScheduleClass.Controls.Add(this.lblInstructor);
            this.pnlScheduleClass.Controls.Add(this.txtCapacity);
            this.pnlScheduleClass.Controls.Add(this.lblCapacity);
            this.pnlScheduleClass.Controls.Add(this.lblDate);
            this.pnlScheduleClass.Controls.Add(this.btnAdd);
            this.pnlScheduleClass.Controls.Add(this.txtPrice);
            this.pnlScheduleClass.Controls.Add(this.lblPrice);
            this.pnlScheduleClass.Controls.Add(this.lblTime);
            this.pnlScheduleClass.Controls.Add(this.lblType);
            this.pnlScheduleClass.Location = new System.Drawing.Point(15, 90);
            this.pnlScheduleClass.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScheduleClass.Name = "pnlScheduleClass";
            this.pnlScheduleClass.Size = new System.Drawing.Size(560, 384);
            this.pnlScheduleClass.TabIndex = 2;
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(265, 69);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(195, 29);
            this.cboType.TabIndex = 18;
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtMinute.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(332, 170);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinute.MaxLength = 2;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(51, 29);
            this.txtMinute.TabIndex = 9;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(312, 169);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(22, 32);
            this.lblSymbol.TabIndex = 16;
            this.lblSymbol.Text = ":";
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtHour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(265, 169);
            this.txtHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtHour.MaxLength = 2;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(51, 29);
            this.txtHour.TabIndex = 7;
            // 
            // cboInstructor
            // 
            this.cboInstructor.DropDownHeight = 80;
            this.cboInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstructor.DropDownWidth = 124;
            this.cboInstructor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInstructor.FormattingEnabled = true;
            this.cboInstructor.IntegralHeight = false;
            this.cboInstructor.Location = new System.Drawing.Point(265, 217);
            this.cboInstructor.Margin = new System.Windows.Forms.Padding(4);
            this.cboInstructor.MaxDropDownItems = 4;
            this.cboInstructor.Name = "cboInstructor";
            this.cboInstructor.Size = new System.Drawing.Size(195, 29);
            this.cboInstructor.Sorted = true;
            this.cboInstructor.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(265, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(128, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(265, 116);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(195, 34);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2023, 10, 18, 0, 0, 0, 0);
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(128, 217);
            this.lblInstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(100, 28);
            this.lblInstructor.TabIndex = 8;
            this.lblInstructor.Text = "Instructor:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(179, 277);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.MaxLength = 2;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(68, 29);
            this.txtCapacity.TabIndex = 12;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(68, 282);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(91, 28);
            this.lblCapacity.TabIndex = 11;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(128, 122);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 28);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(205, 334);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(373, 277);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(87, 29);
            this.txtPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(303, 282);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 28);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(128, 169);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 28);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(128, 69);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 28);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type: ";
            // 
            // lblScheduleClass
            // 
            this.lblScheduleClass.AutoSize = true;
            this.lblScheduleClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleClass.Location = new System.Drawing.Point(213, 55);
            this.lblScheduleClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduleClass.Name = "lblScheduleClass";
            this.lblScheduleClass.Size = new System.Drawing.Size(181, 32);
            this.lblScheduleClass.TabIndex = 1;
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
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnuMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuMainMenu.Size = new System.Drawing.Size(589, 38);
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
            this.mnuClasses.Size = new System.Drawing.Size(105, 36);
            this.mnuClasses.Text = "Classes";
            // 
            // mnutScheduleClass
            // 
            this.mnutScheduleClass.Checked = true;
            this.mnutScheduleClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnutScheduleClass.Name = "mnutScheduleClass";
            this.mnutScheduleClass.Size = new System.Drawing.Size(262, 36);
            this.mnutScheduleClass.Text = "Schedule Class";
            this.mnutScheduleClass.Click += new System.EventHandler(this.mnutScheduleClass_Click);
            // 
            // mnutModifyClass
            // 
            this.mnutModifyClass.Name = "mnutModifyClass";
            this.mnutModifyClass.Size = new System.Drawing.Size(262, 36);
            this.mnutModifyClass.Text = "Modify Class";
            this.mnutModifyClass.Click += new System.EventHandler(this.mnutModifyClass_Click);
            // 
            // mnutCancelClass
            // 
            this.mnutCancelClass.Name = "mnutCancelClass";
            this.mnutCancelClass.Size = new System.Drawing.Size(262, 36);
            this.mnutCancelClass.Text = "Cancel Class";
            this.mnutCancelClass.Click += new System.EventHandler(this.mnutCancelClass_Click);
            // 
            // mnuStatistics
            // 
            this.mnuStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStatistics.Name = "mnuStatistics";
            this.mnuStatistics.Size = new System.Drawing.Size(120, 36);
            this.mnuStatistics.Text = "Statistics";
            this.mnuStatistics.Click += new System.EventHandler(this.mnuStatistics_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(78, 36);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmScheduleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(589, 476);
            this.Controls.Add(this.pnlScheduleClass);
            this.Controls.Add(this.lblScheduleClass);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboInstructor;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ComboBox cboType;
    }
}