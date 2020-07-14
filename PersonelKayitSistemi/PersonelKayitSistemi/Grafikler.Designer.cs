namespace PersonelKayitSistemi
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SehirlerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MeslekMaasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SehirlerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeslekMaasChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SehirlerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SehirlerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SehirlerChart.Legends.Add(legend1);
            this.SehirlerChart.Location = new System.Drawing.Point(12, 12);
            this.SehirlerChart.Name = "SehirlerChart";
            this.SehirlerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sehirler";
            this.SehirlerChart.Series.Add(series1);
            this.SehirlerChart.Size = new System.Drawing.Size(408, 269);
            this.SehirlerChart.TabIndex = 0;
            this.SehirlerChart.Text = "chart1";
            // 
            // MeslekMaasChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MeslekMaasChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MeslekMaasChart.Legends.Add(legend2);
            this.MeslekMaasChart.Location = new System.Drawing.Point(12, 287);
            this.MeslekMaasChart.Name = "MeslekMaasChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Meslek-Ort Maas";
            this.MeslekMaasChart.Series.Add(series2);
            this.MeslekMaasChart.Size = new System.Drawing.Size(408, 443);
            this.MeslekMaasChart.TabIndex = 1;
            this.MeslekMaasChart.Text = "chart2";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 746);
            this.Controls.Add(this.MeslekMaasChart);
            this.Controls.Add(this.SehirlerChart);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grafikler";
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SehirlerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeslekMaasChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SehirlerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MeslekMaasChart;
    }
}