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
            // Fehleruebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 684);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.listViewFehler);
            this.Name = "Fehleruebersicht";
            this.Text = "Fehlerübersicht";
            this.Load += new System.EventHandler(this.Fehleruebersicht_Load);
            this.ResumeLayout(false);

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
    }
}