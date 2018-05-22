namespace MaintenanceSOFT
{
    partial class Verwaltung
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.anlagenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fertigung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFertigung = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAnlage = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxIP = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxBetriebsmerker = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonSpeichern = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.anlagenName,
            this.fertigung,
            this.bit,
            this.ip});
            this.listView1.Location = new System.Drawing.Point(296, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(895, 487);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // anlagenName
            // 
            this.anlagenName.Text = "Anlagennamen";
            this.anlagenName.Width = 175;
            // 
            // fertigung
            // 
            this.fertigung.Text = "Fertigung";
            this.fertigung.Width = 225;
            // 
            // bit
            // 
            this.bit.Text = "Überwachungsbit";
            this.bit.Width = 266;
            // 
            // ip
            // 
            this.ip.Text = "IP-Adresse";
            this.ip.Width = 225;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(30, 319);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(168, 239);
            this.treeView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einfügenToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.infosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 70);
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.einfügenToolStripMenuItem.Text = "Einfügen";
            this.einfügenToolStripMenuItem.Click += new System.EventHandler(this.einfügenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // infosToolStripMenuItem
            // 
            this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            this.infosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.infosToolStripMenuItem.Text = "Infos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Fertigung:";
            // 
            // metroTextBoxFertigung
            // 
            // 
            // 
            // 
            this.metroTextBoxFertigung.CustomButton.Image = null;
            this.metroTextBoxFertigung.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.metroTextBoxFertigung.CustomButton.Name = "";
            this.metroTextBoxFertigung.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFertigung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFertigung.CustomButton.TabIndex = 1;
            this.metroTextBoxFertigung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFertigung.CustomButton.UseSelectable = true;
            this.metroTextBoxFertigung.CustomButton.Visible = false;
            this.metroTextBoxFertigung.Lines = new string[0];
            this.metroTextBoxFertigung.Location = new System.Drawing.Point(33, 93);
            this.metroTextBoxFertigung.MaxLength = 32767;
            this.metroTextBoxFertigung.Name = "metroTextBoxFertigung";
            this.metroTextBoxFertigung.PasswordChar = '\0';
            this.metroTextBoxFertigung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFertigung.SelectedText = "";
            this.metroTextBoxFertigung.SelectionLength = 0;
            this.metroTextBoxFertigung.SelectionStart = 0;
            this.metroTextBoxFertigung.ShortcutsEnabled = true;
            this.metroTextBoxFertigung.Size = new System.Drawing.Size(246, 23);
            this.metroTextBoxFertigung.TabIndex = 8;
            this.metroTextBoxFertigung.UseSelectable = true;
            this.metroTextBoxFertigung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFertigung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Anlage:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "IP-Adresse:";
            // 
            // metroTextBoxAnlage
            // 
            // 
            // 
            // 
            this.metroTextBoxAnlage.CustomButton.Image = null;
            this.metroTextBoxAnlage.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.metroTextBoxAnlage.CustomButton.Name = "";
            this.metroTextBoxAnlage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAnlage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAnlage.CustomButton.TabIndex = 1;
            this.metroTextBoxAnlage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAnlage.CustomButton.UseSelectable = true;
            this.metroTextBoxAnlage.CustomButton.Visible = false;
            this.metroTextBoxAnlage.Lines = new string[0];
            this.metroTextBoxAnlage.Location = new System.Drawing.Point(33, 151);
            this.metroTextBoxAnlage.MaxLength = 32767;
            this.metroTextBoxAnlage.Name = "metroTextBoxAnlage";
            this.metroTextBoxAnlage.PasswordChar = '\0';
            this.metroTextBoxAnlage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAnlage.SelectedText = "";
            this.metroTextBoxAnlage.SelectionLength = 0;
            this.metroTextBoxAnlage.SelectionStart = 0;
            this.metroTextBoxAnlage.ShortcutsEnabled = true;
            this.metroTextBoxAnlage.Size = new System.Drawing.Size(246, 23);
            this.metroTextBoxAnlage.TabIndex = 11;
            this.metroTextBoxAnlage.UseSelectable = true;
            this.metroTextBoxAnlage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAnlage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxIP
            // 
            // 
            // 
            // 
            this.metroTextBoxIP.CustomButton.Image = null;
            this.metroTextBoxIP.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.metroTextBoxIP.CustomButton.Name = "";
            this.metroTextBoxIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIP.CustomButton.TabIndex = 1;
            this.metroTextBoxIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIP.CustomButton.UseSelectable = true;
            this.metroTextBoxIP.CustomButton.Visible = false;
            this.metroTextBoxIP.Lines = new string[0];
            this.metroTextBoxIP.Location = new System.Drawing.Point(33, 214);
            this.metroTextBoxIP.MaxLength = 32767;
            this.metroTextBoxIP.Name = "metroTextBoxIP";
            this.metroTextBoxIP.PasswordChar = '\0';
            this.metroTextBoxIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIP.SelectedText = "";
            this.metroTextBoxIP.SelectionLength = 0;
            this.metroTextBoxIP.SelectionStart = 0;
            this.metroTextBoxIP.ShortcutsEnabled = true;
            this.metroTextBoxIP.Size = new System.Drawing.Size(246, 23);
            this.metroTextBoxIP.TabIndex = 12;
            this.metroTextBoxIP.UseSelectable = true;
            this.metroTextBoxIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxBetriebsmerker
            // 
            // 
            // 
            // 
            this.metroTextBoxBetriebsmerker.CustomButton.Image = null;
            this.metroTextBoxBetriebsmerker.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.metroTextBoxBetriebsmerker.CustomButton.Name = "";
            this.metroTextBoxBetriebsmerker.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxBetriebsmerker.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBetriebsmerker.CustomButton.TabIndex = 1;
            this.metroTextBoxBetriebsmerker.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBetriebsmerker.CustomButton.UseSelectable = true;
            this.metroTextBoxBetriebsmerker.CustomButton.Visible = false;
            this.metroTextBoxBetriebsmerker.Lines = new string[0];
            this.metroTextBoxBetriebsmerker.Location = new System.Drawing.Point(33, 280);
            this.metroTextBoxBetriebsmerker.MaxLength = 32767;
            this.metroTextBoxBetriebsmerker.Name = "metroTextBoxBetriebsmerker";
            this.metroTextBoxBetriebsmerker.PasswordChar = '\0';
            this.metroTextBoxBetriebsmerker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBetriebsmerker.SelectedText = "";
            this.metroTextBoxBetriebsmerker.SelectionLength = 0;
            this.metroTextBoxBetriebsmerker.SelectionStart = 0;
            this.metroTextBoxBetriebsmerker.ShortcutsEnabled = true;
            this.metroTextBoxBetriebsmerker.Size = new System.Drawing.Size(246, 23);
            this.metroTextBoxBetriebsmerker.TabIndex = 13;
            this.metroTextBoxBetriebsmerker.UseSelectable = true;
            this.metroTextBoxBetriebsmerker.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBetriebsmerker.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 258);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Betriebsmerker:";
            // 
            // metroButtonSpeichern
            // 
            this.metroButtonSpeichern.Location = new System.Drawing.Point(204, 319);
            this.metroButtonSpeichern.Name = "metroButtonSpeichern";
            this.metroButtonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSpeichern.TabIndex = 15;
            this.metroButtonSpeichern.Text = "Speichern";
            this.metroButtonSpeichern.UseSelectable = true;
            this.metroButtonSpeichern.Click += new System.EventHandler(this.metroButtonSpeichern_Click);
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 591);
            this.Controls.Add(this.metroButtonSpeichern);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxBetriebsmerker);
            this.Controls.Add(this.metroTextBoxIP);
            this.Controls.Add(this.metroTextBoxAnlage);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxFertigung);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Name = "Verwaltung";
            this.Text = "Verwaltung";
            this.Load += new System.EventHandler(this.Verwaltung_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader anlagenName;
        private System.Windows.Forms.ColumnHeader fertigung;
        private System.Windows.Forms.ColumnHeader bit;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox metroTextBoxFertigung;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox metroTextBoxAnlage;
        public MetroFramework.Controls.MetroTextBox metroTextBoxIP;
        public MetroFramework.Controls.MetroTextBox metroTextBoxBetriebsmerker;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonSpeichern;
    }
}