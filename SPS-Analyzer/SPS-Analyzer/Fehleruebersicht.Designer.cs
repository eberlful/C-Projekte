namespace SPS_Analyzer
{
    partial class Fehleruebersicht
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
            this.listViewFehler = new MetroFramework.Controls.MetroListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ueb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beschr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnalyze = new MetroFramework.Controls.MetroButton();
            this.btnOnline = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtSuche = new MetroFramework.Controls.MetroTextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnImport = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listViewFehler
            // 
            this.listViewFehler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.wert,
            this.ueb,
            this.beschr,
            this.last,
            this.nummer});
            this.listViewFehler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewFehler.FullRowSelect = true;
            this.listViewFehler.Location = new System.Drawing.Point(23, 63);
            this.listViewFehler.Name = "listViewFehler";
            this.listViewFehler.OwnerDraw = true;
            this.listViewFehler.Size = new System.Drawing.Size(1016, 562);
            this.listViewFehler.TabIndex = 3;
            this.listViewFehler.UseCompatibleStateImageBehavior = false;
            this.listViewFehler.UseSelectable = true;
            this.listViewFehler.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name:";
            this.name.Width = 186;
            // 
            // wert
            // 
            this.wert.Text = "Wert: ";
            this.wert.Width = 90;
            // 
            // ueb
            // 
            this.ueb.Text = "Überwachung:";
            this.ueb.Width = 115;
            // 
            // beschr
            // 
            this.beschr.Text = "Beschreibung:";
            this.beschr.Width = 356;
            // 
            // last
            // 
            this.last.Text = "Zuletzt";
            this.last.Width = 175;
            // 
            // nummer
            // 
            this.nummer.Text = "Nummer";
            this.nummer.Width = 74;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(947, 638);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(92, 23);
            this.btnAnalyze.TabIndex = 9;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseSelectable = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.Location = new System.Drawing.Point(849, 638);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(92, 23);
            this.btnOnline.TabIndex = 10;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseSelectable = true;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 642);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 19);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Suche:";
            // 
            // txtSuche
            // 
            // 
            // 
            // 
            this.txtSuche.CustomButton.Image = null;
            this.txtSuche.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.txtSuche.CustomButton.Name = "";
            this.txtSuche.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSuche.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuche.CustomButton.TabIndex = 1;
            this.txtSuche.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuche.CustomButton.UseSelectable = true;
            this.txtSuche.CustomButton.Visible = false;
            this.txtSuche.Lines = new string[0];
            this.txtSuche.Location = new System.Drawing.Point(75, 642);
            this.txtSuche.MaxLength = 32767;
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.PasswordChar = '\0';
            this.txtSuche.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuche.SelectedText = "";
            this.txtSuche.SelectionLength = 0;
            this.txtSuche.SelectionStart = 0;
            this.txtSuche.ShortcutsEnabled = true;
            this.txtSuche.Size = new System.Drawing.Size(320, 23);
            this.txtSuche.TabIndex = 44;
            this.txtSuche.UseSelectable = true;
            this.txtSuche.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuche.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(23, 682);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(1014, 147);
            this.txtConsole.TabIndex = 46;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(549, 642);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 23);
            this.btnImport.TabIndex = 47;
            this.btnImport.Text = "Katalog importieren";
            this.btnImport.UseSelectable = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Fehleruebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 841);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.listViewFehler);
            this.Name = "Fehleruebersicht";
            this.Text = "Fehlerübersicht";
            this.Load += new System.EventHandler(this.Fehleruebersicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewFehler;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader wert;
        private System.Windows.Forms.ColumnHeader ueb;
        private System.Windows.Forms.ColumnHeader beschr;
        private System.Windows.Forms.ColumnHeader last;
        private System.Windows.Forms.ColumnHeader nummer;
        private MetroFramework.Controls.MetroButton btnAnalyze;
        private MetroFramework.Controls.MetroButton btnOnline;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtSuche;
        private System.Windows.Forms.TextBox txtConsole;
        private MetroFramework.Controls.MetroButton btnImport;
    }
}