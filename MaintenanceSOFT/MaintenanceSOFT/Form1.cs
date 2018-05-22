using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MaintenanceSOFT
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string verwaltungPfad = @"C:\Users\marku\OneDrive\Desktop\C-Projekte\MaintenanceSOFT\MaintenanceSOFT\bin\Debug\anlagen.xml";
        private bool anlagenFile = false;
        private ListView liste = new ListView();
        private int currentUser = 0;
        private string currentUsername = "";
        /*
         * 0 = Undefiniert
         * 1 = root
         * 3 = Instandhalter
         * 6 = Benutzer
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Beim laden wird Config-File geladen und in Liste gespeichert
            try
            {
                if (File.Exists(verwaltungPfad))
                {
                    anlagenFile = true;
                }
                else
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Es wurde kein File gefunden. Soll ein neues erzeugt werden?", "Config-File Fehler", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if(result == DialogResult.Yes)
                    {
                        File.Create(verwaltungPfad);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Stacktrackerückgabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private ListView loadListe(string pfad)
        {
            ListView localList = new ListView();
            return localList;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkUser(string benutzer, string passwort)
        {
            if (benutzer == "root" && passwort == "root")
            {
                currentUser = 1;
                currentUsername = "root".ToUpper();
            } else
            {
                MetroFramework.MetroMessageBox.Show(this, "Falsches Kennwort oder unbekannter Benutzer. Bitte ändern Sie ihre Eingabe!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroTileBenutzer_Click(object sender, EventArgs e)
        {
            if (currentUser > 0)
            {
                DialogResult result = MessageBox.Show("Benutzer ist schon angemeldet, wollen Sie den aktuellen Benutzer abmelden und ihren Benutzer anmelden ?", "Benutzeranmeldung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    currentUser = 0;
                    Benutzeranmeldung anmeldung = new Benutzeranmeldung();
                    if (anmeldung.ShowDialog(this) == DialogResult.OK)
                    {
                        string benutzer = anmeldung.metroTextBoxBenutzer.Text;
                        string passwort = anmeldung.metroTextBoxPasswort.Text;
                        checkUser(benutzer, passwort);
                        metroTileBenutzer.Text = "Benutzer \n " + currentUsername;
                    }
                } else
                {

                }
            } else
            {
                Benutzeranmeldung anmeldung = new Benutzeranmeldung();
                if (anmeldung.ShowDialog(this) == DialogResult.OK)
                {
                    string benutzer = anmeldung.metroTextBoxBenutzer.Text;
                    string passwort = anmeldung.metroTextBoxPasswort.Text;
                    checkUser(benutzer, passwort);
                    metroTileBenutzer.Text = "Benutzer \n " + currentUsername;
                }
            }
        }

        private void metroTileVerwaltung_Click(object sender, EventArgs e)
        {
            if(currentUser == 1)
            {
                Verwaltung verwaltung = new Verwaltung(verwaltungPfad);
                verwaltung.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Sie haben nicht die ausreichende Berechtigung", "Authorisierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTileStatus_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
        }

        private void metroTileEinstellungen_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen();
            einstellungen.Show();
        }

        private void metroTileUebersicht_Click(object sender, EventArgs e)
        {
            statusUebersicht uebersicht = new statusUebersicht();
            uebersicht.Show();
        }
    }
}
