namespace SPS_Analyzer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRack = new MetroFramework.Controls.MetroTextBox();
            this.txtSlot = new MetroFramework.Controls.MetroTextBox();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnVerbinden = new MetroFramework.Controls.MetroButton();
            this.btnCPUStop = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.btnCPURun = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtBit = new MetroFramework.Controls.MetroTextBox();
            this.btnEintrag = new MetroFramework.Controls.MetroButton();
            this.txtAdresse = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThreadStart = new MetroFramework.Controls.MetroButton();
            this.btnThreadingStop = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IP:";
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
            this.txtIP.Location = new System.Drawing.Point(67, 68);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.SelectionLength = 0;
            this.txtIP.SelectionStart = 0;
            this.txtIP.ShortcutsEnabled = true;
            this.txtIP.Size = new System.Drawing.Size(146, 23);
            this.txtIP.TabIndex = 1;
            this.txtIP.UseSelectable = true;
            this.txtIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Rack:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(117, 113);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Slot:";
            // 
            // txtRack
            // 
            // 
            // 
            // 
            this.txtRack.CustomButton.Image = null;
            this.txtRack.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.txtRack.CustomButton.Name = "";
            this.txtRack.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRack.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRack.CustomButton.TabIndex = 1;
            this.txtRack.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRack.CustomButton.UseSelectable = true;
            this.txtRack.CustomButton.Visible = false;
            this.txtRack.Lines = new string[0];
            this.txtRack.Location = new System.Drawing.Point(67, 109);
            this.txtRack.MaxLength = 2;
            this.txtRack.Name = "txtRack";
            this.txtRack.PasswordChar = '\0';
            this.txtRack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRack.SelectedText = "";
            this.txtRack.SelectionLength = 0;
            this.txtRack.SelectionStart = 0;
            this.txtRack.ShortcutsEnabled = true;
            this.txtRack.Size = new System.Drawing.Size(29, 23);
            this.txtRack.TabIndex = 6;
            this.txtRack.UseSelectable = true;
            this.txtRack.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRack.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRack.TextChanged += new System.EventHandler(this.txtRack_TextChanged);
            // 
            // txtSlot
            // 
            // 
            // 
            // 
            this.txtSlot.CustomButton.Image = null;
            this.txtSlot.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtSlot.CustomButton.Name = "";
            this.txtSlot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlot.CustomButton.TabIndex = 1;
            this.txtSlot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlot.CustomButton.UseSelectable = true;
            this.txtSlot.CustomButton.Visible = false;
            this.txtSlot.Lines = new string[0];
            this.txtSlot.Location = new System.Drawing.Point(169, 109);
            this.txtSlot.MaxLength = 2;
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.PasswordChar = '\0';
            this.txtSlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlot.SelectedText = "";
            this.txtSlot.SelectionLength = 0;
            this.txtSlot.SelectionStart = 0;
            this.txtSlot.ShortcutsEnabled = true;
            this.txtSlot.Size = new System.Drawing.Size(33, 23);
            this.txtSlot.TabIndex = 7;
            this.txtSlot.UseSelectable = true;
            this.txtSlot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSlot.TextChanged += new System.EventHandler(this.txtSlot_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(792, 588);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVerbinden
            // 
            this.btnVerbinden.Location = new System.Drawing.Point(229, 109);
            this.btnVerbinden.Name = "btnVerbinden";
            this.btnVerbinden.Size = new System.Drawing.Size(75, 23);
            this.btnVerbinden.TabIndex = 9;
            this.btnVerbinden.Text = "Verbinden";
            this.btnVerbinden.UseSelectable = true;
            this.btnVerbinden.Click += new System.EventHandler(this.btnVerbinden_Click);
            // 
            // btnCPUStop
            // 
            this.btnCPUStop.Location = new System.Drawing.Point(566, 100);
            this.btnCPUStop.Name = "btnCPUStop";
            this.btnCPUStop.Size = new System.Drawing.Size(75, 23);
            this.btnCPUStop.TabIndex = 11;
            this.btnCPUStop.Text = "Stop";
            this.btnCPUStop.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(563, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "CPU-Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(664, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 19);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "metroLabel6";
            // 
            // btnCPURun
            // 
            this.btnCPURun.Location = new System.Drawing.Point(664, 99);
            this.btnCPURun.Name = "btnCPURun";
            this.btnCPURun.Size = new System.Drawing.Size(75, 24);
            this.btnCPURun.TabIndex = 14;
            this.btnCPURun.Text = "Run";
            this.btnCPURun.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(229, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 23);
            this.panel1.TabIndex = 15;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 154);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(831, 415);
            this.metroTabControl1.TabIndex = 16;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtBit);
            this.metroTabPage1.Controls.Add(this.btnEintrag);
            this.metroTabPage1.Controls.Add(this.txtAdresse);
            this.metroTabPage1.Controls.Add(this.metroRadioButton3);
            this.metroTabPage1.Controls.Add(this.metroRadioButton2);
            this.metroTabPage1.Controls.Add(this.metroRadioButton1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(823, 373);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Verwaltung";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtBit
            // 
            // 
            // 
            // 
            this.txtBit.CustomButton.Image = null;
            this.txtBit.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.txtBit.CustomButton.Name = "";
            this.txtBit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBit.CustomButton.TabIndex = 1;
            this.txtBit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBit.CustomButton.UseSelectable = true;
            this.txtBit.CustomButton.Visible = false;
            this.txtBit.Lines = new string[0];
            this.txtBit.Location = new System.Drawing.Point(224, 23);
            this.txtBit.MaxLength = 1;
            this.txtBit.Name = "txtBit";
            this.txtBit.PasswordChar = '\0';
            this.txtBit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBit.SelectedText = "";
            this.txtBit.SelectionLength = 0;
            this.txtBit.SelectionStart = 0;
            this.txtBit.ShortcutsEnabled = true;
            this.txtBit.Size = new System.Drawing.Size(26, 23);
            this.txtBit.TabIndex = 7;
            this.txtBit.UseSelectable = true;
            this.txtBit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBit.TextChanged += new System.EventHandler(this.txtBit_TextChanged);
            // 
            // btnEintrag
            // 
            this.btnEintrag.Location = new System.Drawing.Point(158, 57);
            this.btnEintrag.Name = "btnEintrag";
            this.btnEintrag.Size = new System.Drawing.Size(92, 23);
            this.btnEintrag.TabIndex = 6;
            this.btnEintrag.Text = "Hinzufügen";
            this.btnEintrag.UseSelectable = true;
            this.btnEintrag.Click += new System.EventHandler(this.btnEintrag_Click);
            // 
            // txtAdresse
            // 
            // 
            // 
            // 
            this.txtAdresse.CustomButton.Image = null;
            this.txtAdresse.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtAdresse.CustomButton.Name = "";
            this.txtAdresse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdresse.CustomButton.TabIndex = 1;
            this.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdresse.CustomButton.UseSelectable = true;
            this.txtAdresse.CustomButton.Visible = false;
            this.txtAdresse.Lines = new string[0];
            this.txtAdresse.Location = new System.Drawing.Point(158, 23);
            this.txtAdresse.MaxLength = 32767;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.SelectionLength = 0;
            this.txtAdresse.SelectionStart = 0;
            this.txtAdresse.ShortcutsEnabled = true;
            this.txtAdresse.Size = new System.Drawing.Size(60, 23);
            this.txtAdresse.TabIndex = 5;
            this.txtAdresse.UseSelectable = true;
            this.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            this.txtAdresse.Click += new System.EventHandler(this.txtAdresse_Click);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(20, 65);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(70, 15);
            this.metroRadioButton3.TabIndex = 4;
            this.metroRadioButton3.Text = "Ausgang";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(20, 44);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(66, 15);
            this.metroRadioButton2.TabIndex = 3;
            this.metroRadioButton2.Text = "Eingang";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(20, 23);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(99, 15);
            this.metroRadioButton1.TabIndex = 2;
            this.metroRadioButton1.Text = "Datenbaustein";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroListView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(823, 373);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Liste";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.typ,
            this.adresse,
            this.bit,
            this.wert});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(15, 19);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(795, 351);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name:";
            this.name.Width = 156;
            // 
            // typ
            // 
            this.typ.Text = "Typ:";
            this.typ.Width = 49;
            // 
            // adresse
            // 
            this.adresse.Text = "Adresse:";
            this.adresse.Width = 94;
            // 
            // bit
            // 
            this.bit.Text = "Bit:";
            // 
            // wert
            // 
            this.wert.Text = "Wert: ";
            this.wert.Width = 103;
            // 
            // btnThreadStart
            // 
            this.btnThreadStart.Enabled = false;
            this.btnThreadStart.Location = new System.Drawing.Point(711, 588);
            this.btnThreadStart.Name = "btnThreadStart";
            this.btnThreadStart.Size = new System.Drawing.Size(75, 23);
            this.btnThreadStart.TabIndex = 17;
            this.btnThreadStart.Text = "Start";
            this.btnThreadStart.UseSelectable = true;
            this.btnThreadStart.Click += new System.EventHandler(this.btnThreadStart_Click);
            // 
            // btnThreadingStop
            // 
            this.btnThreadingStop.Enabled = false;
            this.btnThreadingStop.Location = new System.Drawing.Point(630, 588);
            this.btnThreadingStop.Name = "btnThreadingStop";
            this.btnThreadingStop.Size = new System.Drawing.Size(75, 23);
            this.btnThreadingStop.TabIndex = 18;
            this.btnThreadingStop.Text = "Stop";
            this.btnThreadingStop.UseSelectable = true;
            this.btnThreadingStop.Click += new System.EventHandler(this.btnThreadingStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 623);
            this.Controls.Add(this.btnThreadingStop);
            this.Controls.Add(this.btnThreadStart);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCPURun);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnCPUStop);
            this.Controls.Add(this.btnVerbinden);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.txtRack);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "SPS-Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtRack;
        private MetroFramework.Controls.MetroTextBox txtSlot;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnVerbinden;
        private MetroFramework.Controls.MetroButton btnCPUStop;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroButton btnCPURun;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtBit;
        private MetroFramework.Controls.MetroButton btnEintrag;
        private MetroFramework.Controls.MetroTextBox txtAdresse;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader wert;
        private MetroFramework.Controls.MetroButton btnThreadStart;
        private System.Windows.Forms.ColumnHeader typ;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader bit;
        private MetroFramework.Controls.MetroButton btnThreadingStop;
    }
}

