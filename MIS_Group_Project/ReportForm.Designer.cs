
namespace MIS_Group_Project
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelReportPage = new MaterialSkin.Controls.MaterialLabel();
            this.BoxSort = new MaterialSkin.Controls.MaterialComboBox();
            this.LabelSortBy = new MaterialSkin.Controls.MaterialLabel();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnGoBack = new MaterialSkin.Controls.MaterialButton();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabChart.SuspendLayout();
            this.tabTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelReportPage
            // 
            this.LabelReportPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelReportPage.AutoSize = true;
            this.LabelReportPage.Depth = 0;
            this.LabelReportPage.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelReportPage.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.LabelReportPage.Location = new System.Drawing.Point(389, 88);
            this.LabelReportPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelReportPage.Name = "LabelReportPage";
            this.LabelReportPage.Size = new System.Drawing.Size(277, 41);
            this.LabelReportPage.TabIndex = 0;
            this.LabelReportPage.Text = "Event Report Page";
            // 
            // BoxSort
            // 
            this.BoxSort.AllowDrop = true;
            this.BoxSort.AutoResize = false;
            this.BoxSort.BackColor = System.Drawing.Color.Gray;
            this.BoxSort.Depth = 0;
            this.BoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BoxSort.DropDownHeight = 131;
            this.BoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxSort.DropDownWidth = 208;
            this.BoxSort.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxSort.FormattingEnabled = true;
            this.BoxSort.IntegralHeight = false;
            this.BoxSort.ItemHeight = 43;
            this.BoxSort.Items.AddRange(new object[] {
            "Confirmed Applciations",
            "Pending Applications",
            "Registration Time"});
            this.BoxSort.Location = new System.Drawing.Point(753, 153);
            this.BoxSort.MaxDropDownItems = 3;
            this.BoxSort.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxSort.Name = "BoxSort";
            this.BoxSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxSort.Size = new System.Drawing.Size(208, 49);
            this.BoxSort.StartIndex = 0;
            this.BoxSort.TabIndex = 1;
            // 
            // LabelSortBy
            // 
            this.LabelSortBy.Depth = 0;
            this.LabelSortBy.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelSortBy.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelSortBy.HighEmphasis = true;
            this.LabelSortBy.Location = new System.Drawing.Point(749, 126);
            this.LabelSortBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelSortBy.Name = "LabelSortBy";
            this.LabelSortBy.Size = new System.Drawing.Size(71, 24);
            this.LabelSortBy.TabIndex = 2;
            this.LabelSortBy.Text = "Sort By:";
            this.LabelSortBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSortBy.Click += new System.EventHandler(this.LabelSortBy_Click);
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.tabTables);
            this.tabChart.Controls.Add(this.tabPage2);
            this.tabChart.Location = new System.Drawing.Point(165, 221);
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(792, 401);
            this.tabChart.TabIndex = 3;
            // 
            // tabTables
            // 
            this.tabTables.Controls.Add(this.dataGridView1);
            this.tabTables.Location = new System.Drawing.Point(4, 25);
            this.tabTables.Name = "tabTables";
            this.tabTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabTables.Size = new System.Drawing.Size(784, 372);
            this.tabTables.TabIndex = 0;
            this.tabTables.Text = "View Tables";
            this.tabTables.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.First_Name,
            this.Last_Name,
            this.Gender,
            this.company_email,
            this.phone_number,
            this.Department,
            this.Session,
            this.Confirmed,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpID.Width = 125;
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.MinimumWidth = 6;
            this.First_Name.Name = "First_Name";
            this.First_Name.Width = 125;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.MinimumWidth = 6;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // company_email
            // 
            this.company_email.HeaderText = "Company Email";
            this.company_email.MinimumWidth = 6;
            this.company_email.Name = "company_email";
            this.company_email.Width = 125;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Phone Number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 125;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 125;
            // 
            // Session
            // 
            this.Session.HeaderText = "Session";
            this.Session.MinimumWidth = 6;
            this.Session.Name = "Session";
            this.Session.Width = 125;
            // 
            // Confirmed
            // 
            this.Confirmed.HeaderText = "Confirmed";
            this.Confirmed.MinimumWidth = 6;
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart1.BackColor = System.Drawing.Color.DarkGray;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Trellis;
            chartArea1.BorderWidth = 25;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(241, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Confirmed";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Pending";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(364, 284);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Confirmed Application";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGoBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnGoBack.Depth = 0;
            this.BtnGoBack.HighEmphasis = true;
            this.BtnGoBack.Icon = null;
            this.BtnGoBack.Location = new System.Drawing.Point(874, 631);
            this.BtnGoBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnGoBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnGoBack.Size = new System.Drawing.Size(83, 36);
            this.BtnGoBack.TabIndex = 4;
            this.BtnGoBack.Text = "Go Back";
            this.BtnGoBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnGoBack.UseAccentColor = false;
            this.BtnGoBack.UseVisualStyleBackColor = true;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(MIS_Group_Project.Program);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 685);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.tabChart);
            this.Controls.Add(this.LabelSortBy);
            this.Controls.Add(this.BoxSort);
            this.Controls.Add(this.LabelReportPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tabChart.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelReportPage;
        private MaterialSkin.Controls.MaterialComboBox BoxSort;
        private MaterialSkin.Controls.MaterialLabel LabelSortBy;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage tabTables;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton BtnGoBack;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confirmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}