namespace Ferm
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1Load = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(638, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "Очистить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox4.Location = new System.Drawing.Point(515, 406);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 21);
            this.checkBox4.TabIndex = 41;
            this.checkBox4.Text = "Деньги";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox3.Location = new System.Drawing.Point(413, 405);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 21);
            this.checkBox3.TabIndex = 40;
            this.checkBox3.Text = "Старые";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox2.Location = new System.Drawing.Point(309, 405);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 21);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "Зрелые";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox1.Location = new System.Drawing.Point(200, 406);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 21);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Молодняк";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1Load
            // 
            this.button1Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1Load.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1Load.Location = new System.Drawing.Point(28, 388);
            this.button1Load.Name = "button1Load";
            this.button1Load.Size = new System.Drawing.Size(150, 50);
            this.button1Load.TabIndex = 37;
            this.button1Load.Text = "Загрузить данные";
            this.button1Load.UseVisualStyleBackColor = true;
            this.button1Load.Click += new System.EventHandler(this.button1Load_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.LegendText = "Молодняк";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.LabelForeColor = System.Drawing.Color.Gray;
            series2.Legend = "Legend1";
            series2.LegendText = "Зрелые";
            series2.MarkerBorderWidth = 2;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.LabelForeColor = System.Drawing.Color.Gray;
            series3.Legend = "Legend1";
            series3.LegendText = "Старые";
            series3.MarkerBorderWidth = 2;
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.LabelForeColor = System.Drawing.Color.Gray;
            series4.Legend = "Legend1";
            series4.LegendText = "Деньги";
            series4.MarkerBorderWidth = 2;
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(776, 370);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "файлы|*.csv";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Финансы и поголовье";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1Load;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}