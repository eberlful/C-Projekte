namespace SPS_Analyzer
{
    partial class PLCScan
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
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnThreadStart = new MetroFramework.Controls.MetroButton();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.CustomButton.Image = null;
            this.txtIP.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtIP.CustomButton.Name = "";
            this.txtIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIP.CustomButton.TabIndex = 1;
            this.txtIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIP.CustomButton.UseSelectable = true;
            this.txtIP.CustomButton.Visible = false;
            this.txtIP.Lines = new string[0];
            this.txtIP.Location = new System.Drawing.Point(37, 94);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.SelectionLength = 0;
            this.txtIP.SelectionStart = 0;
            this.txtIP.ShortcutsEnabled = true;
            this.txtIP.Size = new System.Drawing.Size(146, 23);
            this.txtIP.TabIndex = 2;
            this.txtIP.UseSelectable = true;
            this.txtIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            this.txtIP.Click += new System.EventHandler(this.txtIP_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Netzadresse:";
            // 
            // btnThreadStart
            // 
            this.btnThreadStart.Enabled = false;
            this.btnThreadStart.Location = new System.Drawing.Point(204, 94);
            this.btnThreadStart.Name = "btnThreadStart";
            this.btnThreadStart.Size = new System.Drawing.Size(75, 23);
            this.btnThreadStart.TabIndex = 18;
            this.btnThreadStart.Text = "Start";
            this.btnThreadStart.UseSelectable = true;
            this.btnThreadStart.Click += new System.EventHandler(this.btnThreadStart_Click);
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.ipAdresse,
            this.status});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(37, 139);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(327, 227);
            this.metroListView1.TabIndex = 19;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "Index";
            // 
            // ipAdresse
            // 
            this.ipAdresse.Text = "IP-Adresse";
            this.ipAdresse.Width = 148;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 114;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 386);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 145);
            this.textBox1.TabIndex = 20;
            // 
            // PLCScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 574);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.btnThreadStart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIP);
            this.Name = "PLCScan";
            this.Text = "PLC-Scan";
            this.Load += new System.EventHandler(this.PLCScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnThreadStart;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader ipAdresse;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.TextBox textBox1;
    }
}