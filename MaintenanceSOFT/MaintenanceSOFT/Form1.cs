using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        private int aktuallisierungRate = 1000;
        public static ListView listeAnlagen;
        public static bool status;
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

        public ListView loadListe(String pfad)
        {
            ListView speicher = new ListView();
            if (File.Exists(pfad))
            {
                //XML Auslesen
                XmlDocument doc = new XmlDocument();
                doc.Load(pfad);
                string[] info = new string[4];

                foreach (XmlNode node in doc.DocumentElement)
                {
                    info[0] = node.Attributes[0].InnerText;
                    info[2] = node.Attributes[1].InnerText;
                    info[1] = node.Attributes[2].InnerText;
                    info[3] = node.Attributes[3].InnerText;
                    ListViewItem item = new ListViewItem(info);
                    speicher.Items.Add(item);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Es wurde keine Config-Datei gefunden", "Config-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return speicher;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verwaltungPfad = Properties.Settings.Default.pfadVerwaltung;
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
                    else
                    {
                        OpenFileDialog dialog = new OpenFileDialog();
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            verwaltungPfad = dialog.FileName;
                            Properties.Settings.Default.pfadVerwaltung = verwaltungPfad;
                            Properties.Settings.Default.Save();
                            listeAnlagen = loadListe(verwaltungPfad);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace, "Stacktrackerückgabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
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
            metroTileEinstellungen.BackColor = Color.Green;
            Thread thread = new Thread(new ThreadStart(startThread()));
            thread.Start();
        }

        public static void speichereFehler(Exception ex)
        {
            try
            {
                if (File.Exists("fehler.txt"))
                {
                    File.AppendText("\n" + "Fehler: " + ex.StackTrace);
                }
                else
                {
                    File.Create("fehler.txt");
                    File.AppendText("\n" + "Fehler: " + ex.StackTrace);
                }
            }
            catch (Exception exx)
            {
                speichereFehler(exx);
            }
        }

        private ThreadStart startThread()
        {
            try
            {
                status = true;
                threadAktuall zyklus = new threadAktuall();
                zyklus.start();
                while (status)
                {

                }
            } catch(Exception ex)
            {
                speichereFehler(ex);
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Fehler");
            }
            return null;
        }

        public void startThrvbad()
        {

        }

        private void metroTileUebersicht_Click(object sender, EventArgs e)
        {
            statusUebersicht uebersicht = new statusUebersicht();
            uebersicht.Show();
        }
    }
}
