namespace DanceStudioBookingSystem
{
    partial class frmUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMember));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.grpEditProfileDetails = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstNAme = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBlueLine = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.grpEditProfileDetails.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlDetails.SuspendLayout();
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
            this.pnlHeader.TabIndex = 2;
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
            // grpEditProfileDetails
            // 
            this.grpEditProfileDetails.BackColor = System.Drawing.Color.White;
            this.grpEditProfileDetails.Controls.Add(this.btnDelete);
            this.grpEditProfileDetails.Controls.Add(this.pnlPassword);
            this.grpEditProfileDetails.Controls.Add(this.pnlDetails);
            this.grpEditProfileDetails.Controls.Add(this.btnCancel);
            this.grpEditProfileDetails.Controls.Add(this.btnSave);
            this.grpEditProfileDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditProfileDetails.Location = new System.Drawing.Point(185, 78);
            this.grpEditProfileDetails.Name = "grpEditProfileDetails";
            this.grpEditProfileDetails.Size = new System.Drawing.Size(609, 437);
            this.grpEditProfileDetails.TabIndex = 3;
            this.grpEditProfileDetails.TabStop = false;
            this.grpEditProfileDetails.Text = "Edit Profile Details";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.pnlPassword.Controls.Add(this.txtNewPassword);
            this.pnlPassword.Controls.Add(this.txtOldPassword);
            this.pnlPassword.Controls.Add(this.lblNewPassword);
            this.pnlPassword.Controls.Add(this.lblOldPassword);
            this.pnlPassword.Location = new System.Drawing.Point(316, 53);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(287, 269);
            this.pnlPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(37, 159);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(231, 29);
            this.txtNewPassword.TabIndex = 3;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(37, 90);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(231, 29);
            this.txtOldPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(94, 137);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(115, 19);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "New password: ";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(99, 68);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(105, 19);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old password:";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.pnlDetails.Controls.Add(this.dtpDOB);
            this.pnlDetails.Controls.Add(this.txtLastName);
            this.pnlDetails.Controls.Add(this.lblSecondName);
            this.pnlDetails.Controls.Add(this.radOther);
            this.pnlDetails.Controls.Add(this.radFemale);
            this.pnlDetails.Controls.Add(this.radMale);
            this.pnlDetails.Controls.Add(this.lblEmail);
            this.pnlDetails.Controls.Add(this.txtEmail);
            this.pnlDetails.Controls.Add(this.lblGender);
            this.pnlDetails.Controls.Add(this.txtPhone);
            this.pnlDetails.Controls.Add(this.txtFirstName);
            this.pnlDetails.Controls.Add(this.lblDOB);
            this.pnlDetails.Controls.Add(this.lblPhone);
            this.pnlDetails.Controls.Add(this.lblFirstNAme);
            this.pnlDetails.Location = new System.Drawing.Point(10, 53);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(287, 269);
            this.pnlDetails.TabIndex = 0;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(96, 148);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(182, 29);
            this.dtpDOB.TabIndex = 9;
            this.dtpDOB.Value = new System.DateTime(2024, 3, 4, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(107, 61);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 29);
            this.txtLastName.TabIndex = 3;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(12, 67);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(79, 19);
            this.lblSecondName.TabIndex = 2;
            this.lblSecondName.Text = "LastName:";
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(221, 109);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(55, 19);
            this.radOther.TabIndex = 7;
            this.radOther.Text = "Other";
            this.radOther.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(152, 107);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(63, 19);
            this.radFemale.TabIndex = 6;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(95, 109);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(51, 19);
            this.radMale.TabIndex = 5;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(96, 192);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 29);
            this.txtEmail.TabIndex = 11;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(11, 107);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(96, 229);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(182, 29);
            this.txtPhone.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(96, 18);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 29);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(11, 158);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(47, 19);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "DOB: ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(11, 232);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 19);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone:     +";
            // 
            // lblFirstNAme
            // 
            this.lblFirstNAme.AutoSize = true;
            this.lblFirstNAme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNAme.Location = new System.Drawing.Point(12, 24);
            this.lblFirstNAme.Name = "lblFirstNAme";
            this.lblFirstNAme.Size = new System.Drawing.Size(81, 19);
            this.lblFirstNAme.TabIndex = 0;
            this.lblFirstNAme.Text = "FirstName:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(338, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(476, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(38, 485);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(76, 28);
            this.btnLogOut.TabIndex = 4;
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
            this.mnuBook.Click += new System.EventHandler(this.mnuBook_Click);
            // 
            // pnlBlueLine
            // 
            this.pnlBlueLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlBlueLine.Location = new System.Drawing.Point(157, 0);
            this.pnlBlueLine.Name = "pnlBlueLine";
            this.pnlBlueLine.Size = new System.Drawing.Size(22, 523);
            this.pnlBlueLine.TabIndex = 1;
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.pnlBlueLine);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.grpEditProfileDetails);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Member Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditMemberProfile_FormClosed);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpEditProfileDetails.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.GroupBox grpEditProfileDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirstNAme;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.Panel pnlBlueLine;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}