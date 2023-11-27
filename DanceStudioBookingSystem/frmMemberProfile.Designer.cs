namespace DanceStudioBookingSystem
{
    partial class frmMemberProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberProfile));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblWriteGender = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblWriteEmail = new System.Windows.Forms.Label();
            this.lblWritePhone = new System.Windows.Forms.Label();
            this.lblWriteDOB = new System.Windows.Forms.Label();
            this.lblWriteUsername = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpBookedClasses = new System.Windows.Forms.GroupBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.pnlBlueLine = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpBookedClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.lblProfile);
            this.pnlHeader.Location = new System.Drawing.Point(177, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(624, 72);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(218, 16);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(176, 40);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "- PROFILE -";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(549, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.White;
            this.grpDetails.Controls.Add(this.lblWriteGender);
            this.grpDetails.Controls.Add(this.lblGender);
            this.grpDetails.Controls.Add(this.lblWriteEmail);
            this.grpDetails.Controls.Add(this.lblWritePhone);
            this.grpDetails.Controls.Add(this.lblWriteDOB);
            this.grpDetails.Controls.Add(this.lblWriteUsername);
            this.grpDetails.Controls.Add(this.lblDOB);
            this.grpDetails.Controls.Add(this.lblEmail);
            this.grpDetails.Controls.Add(this.lblPhone);
            this.grpDetails.Controls.Add(this.lblUsername);
            this.grpDetails.Controls.Add(this.btnEdit);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.ForeColor = System.Drawing.Color.Black;
            this.grpDetails.Location = new System.Drawing.Point(183, 78);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(611, 189);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // lblWriteGender
            // 
            this.lblWriteGender.AutoSize = true;
            this.lblWriteGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteGender.Location = new System.Drawing.Point(111, 89);
            this.lblWriteGender.Name = "lblWriteGender";
            this.lblWriteGender.Size = new System.Drawing.Size(106, 19);
            this.lblWriteGender.TabIndex = 12;
            this.lblWriteGender.Text = "MemberGender";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(19, 89);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 19);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender: ";
            // 
            // lblWriteEmail
            // 
            this.lblWriteEmail.AutoSize = true;
            this.lblWriteEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteEmail.Location = new System.Drawing.Point(111, 151);
            this.lblWriteEmail.Name = "lblWriteEmail";
            this.lblWriteEmail.Size = new System.Drawing.Size(93, 19);
            this.lblWriteEmail.TabIndex = 10;
            this.lblWriteEmail.Text = "MemberEmail";
            // 
            // lblWritePhone
            // 
            this.lblWritePhone.AutoSize = true;
            this.lblWritePhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWritePhone.Location = new System.Drawing.Point(111, 119);
            this.lblWritePhone.Name = "lblWritePhone";
            this.lblWritePhone.Size = new System.Drawing.Size(100, 19);
            this.lblWritePhone.TabIndex = 9;
            this.lblWritePhone.Text = "MemberPhone";
            // 
            // lblWriteDOB
            // 
            this.lblWriteDOB.AutoSize = true;
            this.lblWriteDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteDOB.Location = new System.Drawing.Point(111, 61);
            this.lblWriteDOB.Name = "lblWriteDOB";
            this.lblWriteDOB.Size = new System.Drawing.Size(90, 19);
            this.lblWriteDOB.TabIndex = 8;
            this.lblWriteDOB.Text = "MemberDOB";
            // 
            // lblWriteUsername
            // 
            this.lblWriteUsername.AutoSize = true;
            this.lblWriteUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteUsername.Location = new System.Drawing.Point(111, 30);
            this.lblWriteUsername.Name = "lblWriteUsername";
            this.lblWriteUsername.Size = new System.Drawing.Size(97, 19);
            this.lblWriteUsername.TabIndex = 7;
            this.lblWriteUsername.Text = "MemberName";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(19, 61);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(45, 19);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "DOB: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email: ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(19, 119);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 19);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(19, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // grpBookedClasses
            // 
            this.grpBookedClasses.BackColor = System.Drawing.Color.White;
            this.grpBookedClasses.Controls.Add(this.dgvClasses);
            this.grpBookedClasses.Controls.Add(this.btnCancelClass);
            this.grpBookedClasses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookedClasses.ForeColor = System.Drawing.Color.Black;
            this.grpBookedClasses.Location = new System.Drawing.Point(183, 273);
            this.grpBookedClasses.Name = "grpBookedClasses";
            this.grpBookedClasses.Size = new System.Drawing.Size(611, 244);
            this.grpBookedClasses.TabIndex = 4;
            this.grpBookedClasses.TabStop = false;
            this.grpBookedClasses.Text = "Booked Classes";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.date,
            this.time,
            this.instructor,
            this.price});
            this.dgvClasses.Location = new System.Drawing.Point(12, 30);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.Size = new System.Drawing.Size(491, 206);
            this.dgvClasses.TabIndex = 30;
            // 
            // Name
            // 
            this.Name.FillWeight = 50F;
            this.Name.HeaderText = "NAME";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            // 
            // date
            // 
            this.date.FillWeight = 50F;
            this.date.HeaderText = "DATE";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.Width = 80;
            // 
            // time
            // 
            this.time.HeaderText = "TIME";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.Width = 80;
            // 
            // instructor
            // 
            this.instructor.HeaderText = "INSTRUCTOR";
            this.instructor.MinimumWidth = 8;
            this.instructor.Name = "instructor";
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 50;
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.BackColor = System.Drawing.Color.White;
            this.btnCancelClass.FlatAppearance.BorderSize = 0;
            this.btnCancelClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Location = new System.Drawing.Point(509, 114);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(84, 32);
            this.btnCancelClass.TabIndex = 15;
            this.btnCancelClass.Text = "Cancel Class";
            this.btnCancelClass.UseVisualStyleBackColor = false;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // pnlBlueLine
            // 
            this.pnlBlueLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlBlueLine.Location = new System.Drawing.Point(157, -1);
            this.pnlBlueLine.Name = "pnlBlueLine";
            this.pnlBlueLine.Size = new System.Drawing.Size(22, 523);
            this.pnlBlueLine.TabIndex = 20;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(43, 481);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(76, 28);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.mnuMainMenu.TabIndex = 18;
            this.mnuMainMenu.Text = "menuStrip1";
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
            // 
            // mnuBook
            // 
            this.mnuBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mnuBook.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.mnuBook.Size = new System.Drawing.Size(163, 51);
            this.mnuBook.Text = "Book";
            this.mnuBook.Click += new System.EventHandler(this.mnuBook_Click);
            // 
            // frmMemberProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.pnlBlueLine);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.grpBookedClasses);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "frmMemberProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Profile";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpBookedClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grpBookedClasses;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWriteEmail;
        private System.Windows.Forms.Label lblWritePhone;
        private System.Windows.Forms.Label lblWriteDOB;
        private System.Windows.Forms.Label lblWriteUsername;
        private System.Windows.Forms.Panel pnlBlueLine;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.Label lblWriteGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}