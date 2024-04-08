namespace DanceStudioBookingSystem
{
    partial class frmStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            this.grpAnalyzeYearlyRevenue = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuScheduleClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuCancelClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAnalyzePopularDanceStyle = new System.Windows.Forms.GroupBox();
            this.lblPopularDanseStype = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblFindPopularDanceStyle = new System.Windows.Forms.Label();
            this.grpChartYearlyRevenue = new System.Windows.Forms.GroupBox();
            this.chtRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpChartPopularDanceStyle = new System.Windows.Forms.GroupBox();
            this.chtPopularDanceStyles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpAnalyzeYearlyRevenue.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.grpAnalyzePopularDanceStyle.SuspendLayout();
            this.grpChartYearlyRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).BeginInit();
            this.grpChartPopularDanceStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPopularDanceStyles)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAnalyzeYearlyRevenue
            // 
            this.grpAnalyzeYearlyRevenue.BackColor = System.Drawing.Color.White;
            this.grpAnalyzeYearlyRevenue.Controls.Add(this.btnCalculate);
            this.grpAnalyzeYearlyRevenue.Controls.Add(this.cboYear);
            this.grpAnalyzeYearlyRevenue.Controls.Add(this.lblYear);
            this.grpAnalyzeYearlyRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalyzeYearlyRevenue.Location = new System.Drawing.Point(12, 46);
            this.grpAnalyzeYearlyRevenue.Name = "grpAnalyzeYearlyRevenue";
            this.grpAnalyzeYearlyRevenue.Size = new System.Drawing.Size(414, 187);
            this.grpAnalyzeYearlyRevenue.TabIndex = 1;
            this.grpAnalyzeYearlyRevenue.TabStop = false;
            this.grpAnalyzeYearlyRevenue.Text = "Analyze Yearly Revenue";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(154, 103);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 31);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.cboYear.DropDownHeight = 80;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.IntegralHeight = false;
            this.cboYear.ItemHeight = 17;
            this.cboYear.Location = new System.Drawing.Point(182, 54);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(100, 25);
            this.cboYear.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(124, 58);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 21);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year: ";
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
            // mnuStatistics
            // 
            this.mnuStatistics.Checked = true;
            this.mnuStatistics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStatistics.Name = "mnuStatistics";
            this.mnuStatistics.Size = new System.Drawing.Size(96, 29);
            this.mnuStatistics.Text = "Statistics";
            this.mnuStatistics.Click += new System.EventHandler(this.mnuStatistics_Click);
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
            this.mnuMainMenu.Size = new System.Drawing.Size(882, 31);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "Menu";
            // 
            // mnuBack
            // 
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(63, 29);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpAnalyzePopularDanceStyle
            // 
            this.grpAnalyzePopularDanceStyle.BackColor = System.Drawing.Color.White;
            this.grpAnalyzePopularDanceStyle.Controls.Add(this.lblPopularDanseStype);
            this.grpAnalyzePopularDanceStyle.Controls.Add(this.btnFind);
            this.grpAnalyzePopularDanceStyle.Controls.Add(this.lblFindPopularDanceStyle);
            this.grpAnalyzePopularDanceStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalyzePopularDanceStyle.Location = new System.Drawing.Point(459, 46);
            this.grpAnalyzePopularDanceStyle.Name = "grpAnalyzePopularDanceStyle";
            this.grpAnalyzePopularDanceStyle.Size = new System.Drawing.Size(414, 187);
            this.grpAnalyzePopularDanceStyle.TabIndex = 2;
            this.grpAnalyzePopularDanceStyle.TabStop = false;
            this.grpAnalyzePopularDanceStyle.Text = "Analyze Popular Dance Styles";
            // 
            // lblPopularDanseStype
            // 
            this.lblPopularDanseStype.AutoSize = true;
            this.lblPopularDanseStype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularDanseStype.Location = new System.Drawing.Point(133, 66);
            this.lblPopularDanseStype.Name = "lblPopularDanseStype";
            this.lblPopularDanseStype.Size = new System.Drawing.Size(155, 17);
            this.lblPopularDanseStype.TabIndex = 2;
            this.lblPopularDanseStype.Text = "for all times and all years";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(154, 125);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 31);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblFindPopularDanceStyle
            // 
            this.lblFindPopularDanceStyle.AutoSize = true;
            this.lblFindPopularDanceStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindPopularDanceStyle.Location = new System.Drawing.Point(112, 45);
            this.lblFindPopularDanceStyle.Name = "lblFindPopularDanceStyle";
            this.lblFindPopularDanceStyle.Size = new System.Drawing.Size(208, 21);
            this.lblFindPopularDanceStyle.TabIndex = 0;
            this.lblFindPopularDanceStyle.Text = "Find Popular Dance Styles";
            // 
            // grpChartYearlyRevenue
            // 
            this.grpChartYearlyRevenue.BackColor = System.Drawing.Color.White;
            this.grpChartYearlyRevenue.Controls.Add(this.chtRevenue);
            this.grpChartYearlyRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChartYearlyRevenue.Location = new System.Drawing.Point(11, 249);
            this.grpChartYearlyRevenue.Name = "grpChartYearlyRevenue";
            this.grpChartYearlyRevenue.Size = new System.Drawing.Size(414, 272);
            this.grpChartYearlyRevenue.TabIndex = 3;
            this.grpChartYearlyRevenue.TabStop = false;
            this.grpChartYearlyRevenue.Text = "Result";
            // 
            // chtRevenue
            // 
            chartArea1.AxisX.Title = "Month";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Style";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "Yearly Revenue";
            this.chtRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRevenue.Legends.Add(legend1);
            this.chtRevenue.Location = new System.Drawing.Point(6, 28);
            this.chtRevenue.Name = "chtRevenue";
            series1.ChartArea = "Yearly Revenue";
            series1.Legend = "Legend1";
            series1.Name = "Income in €";
            series1.XValueMember = "uyghy";
            this.chtRevenue.Series.Add(series1);
            this.chtRevenue.Size = new System.Drawing.Size(390, 232);
            this.chtRevenue.TabIndex = 0;
            this.chtRevenue.Text = "Yearly Revenue";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Name = "Yearly Revenue";
            this.chtRevenue.Titles.Add(title1);
            // 
            // grpChartPopularDanceStyle
            // 
            this.grpChartPopularDanceStyle.BackColor = System.Drawing.Color.White;
            this.grpChartPopularDanceStyle.Controls.Add(this.chtPopularDanceStyles);
            this.grpChartPopularDanceStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChartPopularDanceStyle.Location = new System.Drawing.Point(459, 249);
            this.grpChartPopularDanceStyle.Name = "grpChartPopularDanceStyle";
            this.grpChartPopularDanceStyle.Size = new System.Drawing.Size(414, 272);
            this.grpChartPopularDanceStyle.TabIndex = 4;
            this.grpChartPopularDanceStyle.TabStop = false;
            this.grpChartPopularDanceStyle.Text = "Result";
            // 
            // chtPopularDanceStyles
            // 
            chartArea2.Name = "ChartArea1";
            this.chtPopularDanceStyles.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtPopularDanceStyles.Legends.Add(legend2);
            this.chtPopularDanceStyles.Location = new System.Drawing.Point(9, 25);
            this.chtPopularDanceStyles.Name = "chtPopularDanceStyles";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtPopularDanceStyles.Series.Add(series2);
            this.chtPopularDanceStyles.Size = new System.Drawing.Size(395, 234);
            this.chtPopularDanceStyles.TabIndex = 0;
            this.chtPopularDanceStyles.Text = "POpular Dance Styles";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(882, 530);
            this.Controls.Add(this.grpChartPopularDanceStyle);
            this.Controls.Add(this.grpChartYearlyRevenue);
            this.Controls.Add(this.grpAnalyzePopularDanceStyle);
            this.Controls.Add(this.grpAnalyzeYearlyRevenue);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStatistics_FormClosed);
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.grpAnalyzeYearlyRevenue.ResumeLayout(false);
            this.grpAnalyzeYearlyRevenue.PerformLayout();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpAnalyzePopularDanceStyle.ResumeLayout(false);
            this.grpAnalyzePopularDanceStyle.PerformLayout();
            this.grpChartYearlyRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).EndInit();
            this.grpChartPopularDanceStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtPopularDanceStyles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAnalyzeYearlyRevenue;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem tmnuScheduleClass;
        private System.Windows.Forms.ToolStripMenuItem tmnuModifyClass;
        private System.Windows.Forms.ToolStripMenuItem tmnuCancelClass;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpAnalyzePopularDanceStyle;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblFindPopularDanceStyle;
        private System.Windows.Forms.Label lblPopularDanseStype;
        private System.Windows.Forms.GroupBox grpChartYearlyRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenue;
        private System.Windows.Forms.GroupBox grpChartPopularDanceStyle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPopularDanceStyles;
    }
}