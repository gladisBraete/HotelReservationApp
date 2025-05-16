namespace Gladis_Holtelz
{
    partial class GraphicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TotalReceiptsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TotalReceiptsChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalReceiptsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.TotalReceiptsChart.ChartAreas.Add(chartArea2);
            this.TotalReceiptsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.TotalReceiptsChart.Legends.Add(legend2);
            this.TotalReceiptsChart.Location = new System.Drawing.Point(0, 0);
            this.TotalReceiptsChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalReceiptsChart.Name = "TotalReceiptsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Receipts";
            this.TotalReceiptsChart.Series.Add(series2);
            this.TotalReceiptsChart.Size = new System.Drawing.Size(1067, 554);
            this.TotalReceiptsChart.TabIndex = 0;
            this.TotalReceiptsChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalReceiptsChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 1;
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "GraphicForm";
            this.Text = "GraphicForm";
            this.Load += new System.EventHandler(this.GraphicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalReceiptsChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TotalReceiptsChart;
        private System.Windows.Forms.Panel panel1;
    }
}