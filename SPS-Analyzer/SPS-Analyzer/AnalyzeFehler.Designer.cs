namespace SPS_Analyzer
{
    partial class AnalyzeFehler
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
            this.analyseBit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.analyseBit)).BeginInit();
            this.SuspendLayout();
            // 
            // analyseBit
            // 
            chartArea1.Name = "ChartArea1";
            this.analyseBit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.analyseBit.Legends.Add(legend1);
            this.analyseBit.Location = new System.Drawing.Point(23, 63);
            this.analyseBit.Name = "analyseBit";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.analyseBit.Series.Add(series1);
            this.analyseBit.Size = new System.Drawing.Size(902, 480);
            this.analyseBit.TabIndex = 0;
            this.analyseBit.Text = "chart1";
            // 
            // AnalyzeFehler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 566);
            this.Controls.Add(this.analyseBit);
            this.Name = "AnalyzeFehler";
            this.Text = "AnalyzeFehler";
            this.Load += new System.EventHandler(this.AnalyzeFehler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analyseBit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart analyseBit;
    }
}