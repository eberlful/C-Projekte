namespace MaintenanceSOFT
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
            this.metroTileUebersicht = new MetroFramework.Controls.MetroTile();
            this.metroTileEinstellungen = new MetroFramework.Controls.MetroTile();
            this.metroTileStatus = new MetroFramework.Controls.MetroTile();
            this.metroTileBenutzer = new MetroFramework.Controls.MetroTile();
            this.metroTileVerwaltung = new MetroFramework.Controls.MetroTile();
            this.metroTileClient = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileUebersicht
            // 
            this.metroTileUebersicht.ActiveControl = null;
            this.metroTileUebersicht.Location = new System.Drawing.Point(23, 63);
            this.metroTileUebersicht.Name = "metroTileUebersicht";
            this.metroTileUebersicht.Size = new System.Drawing.Size(330, 230);
            this.metroTileUebersicht.TabIndex = 1;
            this.metroTileUebersicht.Text = "Übersicht";
            this.metroTileUebersicht.UseSelectable = true;
            this.metroTileUebersicht.Click += new System.EventHandler(this.metroTileUebersicht_Click);
            // 
            // metroTileEinstellungen
            // 
            this.metroTileEinstellungen.ActiveControl = null;
            this.metroTileEinstellungen.Location = new System.Drawing.Point(379, 63);
            this.metroTileEinstellungen.Name = "metroTileEinstellungen";
            this.metroTileEinstellungen.Size = new System.Drawing.Size(330, 230);
            this.metroTileEinstellungen.TabIndex = 2;
            this.metroTileEinstellungen.Text = "Einstellungen";
            this.metroTileEinstellungen.UseSelectable = true;
            this.metroTileEinstellungen.Click += new System.EventHandler(this.metroTileEinstellungen_Click);
            // 
            // metroTileStatus
            // 
            this.metroTileStatus.ActiveControl = null;
            this.metroTileStatus.Location = new System.Drawing.Point(739, 63);
            this.metroTileStatus.Name = "metroTileStatus";
            this.metroTileStatus.Size = new System.Drawing.Size(330, 230);
            this.metroTileStatus.TabIndex = 3;
            this.metroTileStatus.Text = "Status";
            this.metroTileStatus.UseSelectable = true;
            this.metroTileStatus.Click += new System.EventHandler(this.metroTileStatus_Click);
            // 
            // metroTileBenutzer
            // 
            this.metroTileBenutzer.ActiveControl = null;
            this.metroTileBenutzer.Location = new System.Drawing.Point(23, 308);
            this.metroTileBenutzer.Name = "metroTileBenutzer";
            this.metroTileBenutzer.Size = new System.Drawing.Size(330, 230);
            this.metroTileBenutzer.TabIndex = 4;
            this.metroTileBenutzer.Text = "Benutzer";
            this.metroTileBenutzer.UseSelectable = true;
            this.metroTileBenutzer.Click += new System.EventHandler(this.metroTileBenutzer_Click);
            // 
            // metroTileVerwaltung
            // 
            this.metroTileVerwaltung.ActiveControl = null;
            this.metroTileVerwaltung.Location = new System.Drawing.Point(379, 308);
            this.metroTileVerwaltung.Name = "metroTileVerwaltung";
            this.metroTileVerwaltung.Size = new System.Drawing.Size(330, 230);
            this.metroTileVerwaltung.TabIndex = 5;
            this.metroTileVerwaltung.Text = "Verwaltung";
            this.metroTileVerwaltung.UseSelectable = true;
            this.metroTileVerwaltung.Click += new System.EventHandler(this.metroTileVerwaltung_Click);
            // 
            // metroTileClient
            // 
            this.metroTileClient.ActiveControl = null;
            this.metroTileClient.Location = new System.Drawing.Point(739, 308);
            this.metroTileClient.Name = "metroTileClient";
            this.metroTileClient.Size = new System.Drawing.Size(330, 230);
            this.metroTileClient.TabIndex = 6;
            this.metroTileClient.Text = "Clients";
            this.metroTileClient.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 565);
            this.Controls.Add(this.metroTileClient);
            this.Controls.Add(this.metroTileVerwaltung);
            this.Controls.Add(this.metroTileBenutzer);
            this.Controls.Add(this.metroTileStatus);
            this.Controls.Add(this.metroTileEinstellungen);
            this.Controls.Add(this.metroTileUebersicht);
            this.Name = "Form1";
            this.Text = "MaintenanceSOFT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileUebersicht;
        private MetroFramework.Controls.MetroTile metroTileEinstellungen;
        private MetroFramework.Controls.MetroTile metroTileStatus;
        private MetroFramework.Controls.MetroTile metroTileBenutzer;
        private MetroFramework.Controls.MetroTile metroTileVerwaltung;
        private MetroFramework.Controls.MetroTile metroTileClient;
    }
}

