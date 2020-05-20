namespace FitnessTracker2._0
{
    partial class dietCum
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.yrboxdiet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Gobut = new System.Windows.Forms.Button();
            this.comboBoxdiet = new System.Windows.Forms.ComboBox();
            this.dietchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dietchart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yrboxdiet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Gobut);
            this.panel1.Controls.Add(this.comboBoxdiet);
            this.panel1.Controls.Add(this.dietchart);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(31, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 448);
            this.panel1.TabIndex = 0;
            // 
            // yrboxdiet
            // 
            this.yrboxdiet.Location = new System.Drawing.Point(105, 86);
            this.yrboxdiet.Name = "yrboxdiet";
            this.yrboxdiet.Size = new System.Drawing.Size(73, 29);
            this.yrboxdiet.TabIndex = 9;
            this.yrboxdiet.Text = "2020";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(3, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter Year";
            // 
            // Gobut
            // 
            this.Gobut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gobut.FlatAppearance.BorderSize = 0;
            this.Gobut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.Gobut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.Gobut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gobut.Location = new System.Drawing.Point(326, 82);
            this.Gobut.Name = "Gobut";
            this.Gobut.Size = new System.Drawing.Size(52, 35);
            this.Gobut.TabIndex = 7;
            this.Gobut.Text = "Go";
            this.Gobut.UseVisualStyleBackColor = false;
            // 
            // comboBoxdiet
            // 
            this.comboBoxdiet.FormattingEnabled = true;
            this.comboBoxdiet.Items.AddRange(new object[] {
            "--Select--",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxdiet.Location = new System.Drawing.Point(193, 86);
            this.comboBoxdiet.Name = "comboBoxdiet";
            this.comboBoxdiet.Size = new System.Drawing.Size(127, 31);
            this.comboBoxdiet.TabIndex = 6;
            // 
            // dietchart
            // 
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 200;
            chartArea1.Area3DStyle.PointGapDepth = 200;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.dietchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dietchart.Legends.Add(legend1);
            this.dietchart.Location = new System.Drawing.Point(3, 133);
            this.dietchart.Name = "dietchart";
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.AxisLabel = "Days of Month";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.dietchart.Series.Add(series1);
            this.dietchart.Size = new System.Drawing.Size(393, 242);
            this.dietchart.TabIndex = 5;
            this.dietchart.Text = "dietchart";
            title1.Name = "Avg. Duration of Workout";
            this.dietchart.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(437, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 448);
            this.panel2.TabIndex = 1;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 128);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "CollectedSliceExploded=True, PieDrawingStyle=SoftEdge, PieLabelStyle=Outside";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(414, 254);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chartJunk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Choose Time Period";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "--select--",
            "Today",
            "Last 7 days",
            "Last 30 days",
            "All Time"});
            this.comboBox2.Location = new System.Drawing.Point(179, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 31);
            this.comboBox2.TabIndex = 4;
            // 
            // dietCum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(885, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "dietCum";
            this.Text = "dietCum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dietchart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox yrboxdiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Gobut;
        private System.Windows.Forms.ComboBox comboBoxdiet;
        private System.Windows.Forms.DataVisualization.Charting.Chart dietchart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}