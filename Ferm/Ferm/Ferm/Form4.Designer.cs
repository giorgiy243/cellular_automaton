namespace Ferm
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(666, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "графиков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(666, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(666, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Загружено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(666, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Время расчета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(654, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Количество графиков";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericUpDown2.Location = new System.Drawing.Point(652, 138);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 37;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericUpDown1.Location = new System.Drawing.Point(652, 87);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(651, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 35;
            this.button1.Text = "Загрузить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Эталон";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(742, 285);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(782, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Эталонная функция";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}