namespace SPS_Analyzer
{
    partial class Einstellungen
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
            this.btnSpeichern = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLocalHost = new System.Windows.Forms.CheckBox();
            this.txtDBName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checkBoxAktivieren = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAKU = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(910, 590);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(92, 23);
            this.btnSpeichern.TabIndex = 10;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseSelectable = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpuChart);
            this.groupBox1.Location = new System.Drawing.Point(538, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 315);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware-Informationen";
            // 
            // cpuChart
            // 
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart.Legends.Add(legend1);
            this.cpuChart.Location = new System.Drawing.Point(6, 19);
            this.cpuChart.Name = "cpuChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Series.Add(series2);
            this.cpuChart.Size = new System.Drawing.Size(452, 282);
            this.cpuChart.TabIndex = 0;
            this.cpuChart.Text = "chart1";
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.CustomButton.Image = null;
            this.txtIP.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtIP.CustomButton.Name = "";
            this.txtIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIP.CustomButton.TabIndex = 1;
            this.txtIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIP.CustomButton.UseSelectable = true;
            this.txtIP.CustomButton.Visible = false;
            this.txtIP.Lines = new string[0];
            this.txtIP.Location = new System.Drawing.Point(119, 31);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.SelectionLength = 0;
            this.txtIP.SelectionStart = 0;
            this.txtIP.ShortcutsEnabled = true;
            this.txtIP.Size = new System.Drawing.Size(265, 23);
            this.txtIP.TabIndex = 12;
            this.txtIP.UseSelectable = true;
            this.txtIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 29);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 41;
            this.metroLabel8.Text = "IP-Adresse:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxLocalHost);
            this.groupBox2.Controls.Add(this.txtDBName);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.checkBoxAktivieren);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 123);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datenbank";
            // 
            // checkBoxLocalHost
            // 
            this.checkBoxLocalHost.AutoSize = true;
            this.checkBoxLocalHost.Location = new System.Drawing.Point(404, 31);
            this.checkBoxLocalHost.Name = "checkBoxLocalHost";
            this.checkBoxLocalHost.Size = new System.Drawing.Size(72, 17);
            this.checkBoxLocalHost.TabIndex = 45;
            this.checkBoxLocalHost.Text = "Localhost";
            this.checkBoxLocalHost.UseVisualStyleBackColor = true;
            // 
            // txtDBName
            // 
            // 
            // 
            // 
            this.txtDBName.CustomButton.Image = null;
            this.txtDBName.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtDBName.CustomButton.Name = "";
            this.txtDBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBName.CustomButton.TabIndex = 1;
            this.txtDBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBName.CustomButton.UseSelectable = true;
            this.txtDBName.CustomButton.Visible = false;
            this.txtDBName.Lines = new string[0];
            this.txtDBName.Location = new System.Drawing.Point(119, 69);
            this.txtDBName.MaxLength = 32767;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.PasswordChar = '\0';
            this.txtDBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBName.SelectedText = "";
            this.txtDBName.SelectionLength = 0;
            this.txtDBName.SelectionStart = 0;
            this.txtDBName.ShortcutsEnabled = true;
            this.txtDBName.Size = new System.Drawing.Size(265, 23);
            this.txtDBName.TabIndex = 44;
            this.txtDBName.UseSelectable = true;
            this.txtDBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Datenbankname:";
            // 
            // checkBoxAktivieren
            // 
            this.checkBoxAktivieren.AutoSize = true;
            this.checkBoxAktivieren.Location = new System.Drawing.Point(404, 75);
            this.checkBoxAktivieren.Name = "checkBoxAktivieren";
            this.checkBoxAktivieren.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAktivieren.TabIndex = 42;
            this.checkBoxAktivieren.Text = "Aktivieren";
            this.checkBoxAktivieren.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.txtAKU);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Location = new System.Drawing.Point(23, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 157);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servereinstellungen";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Aktuallisierungszeit:";
            // 
            // txtAKU
            // 
            // 
            // 
            // 
            this.txtAKU.CustomButton.Image = null;
            this.txtAKU.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtAKU.CustomButton.Name = "";
            this.txtAKU.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAKU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAKU.CustomButton.TabIndex = 1;
            this.txtAKU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAKU.CustomButton.UseSelectable = true;
            this.txtAKU.CustomButton.Visible = false;
            this.txtAKU.Lines = new string[0];
            this.txtAKU.Location = new System.Drawing.Point(133, 30);
            this.txtAKU.MaxLength = 32767;
            this.txtAKU.Name = "txtAKU";
            this.txtAKU.PasswordChar = '\0';
            this.txtAKU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAKU.SelectedText = "";
            this.txtAKU.SelectionLength = 0;
            this.txtAKU.SelectionStart = 0;
            this.txtAKU.ShortcutsEnabled = true;
            this.txtAKU.Size = new System.Drawing.Size(88, 23);
            this.txtAKU.TabIndex = 46;
            this.txtAKU.UseSelectable = true;
            this.txtAKU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAKU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAKU.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(227, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(26, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "ms";
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSpeichern);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSpeichern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtDBName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckBox checkBoxAktivieren;
        private System.Windows.Forms.CheckBox checkBoxLocalHost;
        private MetroFramework.Controls.MetroTextBox txtAKU;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}