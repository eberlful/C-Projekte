using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.IO;
using System.Threading;
using System.IO.Compression;

namespace Backup
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Dateien, in denen die komplette Verzeichnisstruktur gelistet ist
        //public static string logDateiQuelle = @"log1.txt";
        public static ArrayList quelle;
        public static ArrayList quelleOrdner;
        //public static string logDateiZiel = @"log2.txt";
        public static ArrayList ziel;
        public static ArrayList zielOrdner;
        //public static string logDateiEqual = @"log3.txt";
        public static ArrayList equal = new ArrayList();
        public static ArrayList equalOrdner = new ArrayList();
        //public static string logDateiKopieren = @"log4.txt";
        public static ArrayList kopieren = new ArrayList();
        public static ArrayList kopierenOrdner = new ArrayList();
        //Pfad der Quelle
        public static string quellePfad;
        //Pfad des Ziel´s
        public static string zielPfad;

        //Falls Ordner erstellt wird für Backup -> Ordnername
        public static string fullBackupOrdner;

        //Aktivebit für Thread
        //public static bool thread3Aktiv = false;
        public Thread a;

        //
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {             
                metroProgressBar1.Visible = false;
                metroTextBox1.Text = Properties.Settings.Default.quellVerzeichnis;
                metroTextBox2.Text = Properties.Settings.Default.zielVerzeichnis;
                quellePfad = Properties.Settings.Default.quellVerzeichnis;
                zielPfad = Properties.Settings.Default.zielVerzeichnis;
                if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
                {
                    metroButton3.Enabled = true;
                    Thread thread2 = new Thread(new ThreadStart(Thread2));
                    thread2.Start();
                    Thread thread1 = new Thread(new ThreadStart(Thread1));
                    thread1.Start();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }



        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
                       
        }

        private void metroTextBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Quelle auswählen";
            //objDialog.SelectedPath = @"C:\";       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                quellePfad = objDialog.SelectedPath;
                Properties.Settings.Default.quellVerzeichnis = objDialog.SelectedPath;
                metroTextBox1.Text = objDialog.SelectedPath;
                try
                {
                    //Thread zum füllen der Listen
                    Thread thread1 = new Thread(new ThreadStart(Thread1));
                    thread1.Start();                  
                } catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
                if (metroTextBox2.Text != "")
                {
                    metroButton3.Enabled = true;
                }
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Abbruch gewählt!");
            }
        }

        private void Thread1()
        {
            if (quellePfad != "")
            {
                quelle = listeFile(quellePfad);
                quelleOrdner = OrdnerListe(quellePfad);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                StreamWriter sw6 = new StreamWriter(@"quelleFile.txt");
                for (int i = 0; i < quelle.Count; i++)
                {
                    sw6.WriteLine(quelle[i]);
                }
                sw6.Close();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else
            {
                MessageBox.Show("Abfrage des Pfad für den Quellpfad war Fehlerhaft!");
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Ziel auswählen";
            //objDialog.SelectedPath = @"C:\";       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                zielPfad = objDialog.SelectedPath;
                Properties.Settings.Default.zielVerzeichnis = objDialog.SelectedPath;
                metroTextBox2.Text = objDialog.SelectedPath;
                try
                {
                    //Erzeugen eines Thread´s um Listen zu generieren
                    Thread thread2 = new Thread(new ThreadStart(Thread2));
                    thread2.Start();                   
                } catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
                if (metroTextBox1.Text != "")
                {
                    metroButton3.Enabled = true;
                }
               
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Abbruch gewählt!");
            }
        }

        private void Thread2()
        {
            if (zielPfad != "")
            {
                ziel = listeFile(zielPfad);
                zielOrdner = OrdnerListe(zielPfad);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                StreamWriter sw5 = new StreamWriter(@"zielFile.txt");
                for (int i = 0; i < ziel.Count; i++)
                {
                    sw5.WriteLine(ziel[i]);
                }
                sw5.Close();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else
            {
                MessageBox.Show("Abfrage des Pfad für den Quellpfad war Fehlerhaft!");
            }
        }

        //Füllt die Listen durch Vergleichen
        private void DateienVerzeichnisErzeugen()
        {
            try
            {
                StreamWriter sw2 = new StreamWriter(@"equalFile.txt");
                for (int i = 0; i < quelle.Count; i++)
                {
                    for (int k = 0; k < ziel.Count; k++)
                    {
                        
                        if (quelle[i].ToString().Trim() == ziel[k].ToString().Trim())
                        {
                            //MessageBox.Show("quelle" + i + " = " + quelle[i] + " \n ziel" + k + " = " + ziel[k]);
                            equal.Add(quelle[i]);
                            sw2.WriteLine(quelle[i]);
                            break;
                        }
                    }
                }
                sw2.Close();
                StreamWriter sw = new StreamWriter(@"kopiernFile.txt");
                for (int l = 0; l < quelle.Count; l++)
                {
                    for (int m = 0; m < ziel.Count; m++)
                    {
                        if (quelle[l].ToString().Trim() != ziel[m].ToString().Trim())
                        {
                            kopieren.Add(quelle[l]);
                            sw.WriteLine(quelle[l]);
                            break;
                        }
                    }
                }
                sw.Close();
                StreamWriter sw3 = new StreamWriter(@"equalOrdner.txt");
                for (int n = 0; n < quelleOrdner.Count; n++)
                {
                    for (int o = 0; o < zielOrdner.Count; o++)
                    {
                        if (quelleOrdner[n].ToString().Trim() == ziel[o].ToString().Trim())
                        {
                            equalOrdner.Add(quelleOrdner[n]);
                            sw3.WriteLine(quelleOrdner[n]);
                            break;
                        }
                    }
                }
                sw3.Close();
                StreamWriter sw4 = new StreamWriter(@"kopierenOrdner.txt");
                for (int p = 0; p < quelleOrdner.Count; p++)
                {
                    for (int q = 0; q < zielOrdner.Count; q++)
                    {
                        if (quelleOrdner[p].ToString().Trim() != zielOrdner[q].ToString().Trim())
                        {
                            kopierenOrdner.Add(quelleOrdner[p]);
                            sw4.WriteLine(quelleOrdner[p]);
                            break;
                        }                       
                    }
                }
                sw4.Close();
            } catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Systemfehler");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //Sichert Properties
                Properties.Settings.Default.Save();
                //Thread für das Erzeugen des Backup´s nebenbei
                a = new Thread(new ThreadStart(DateienVerzeichnisErzeugen));
                a.Start();

                //Progressbar sichtbar machen
                metroProgressBar1.Visible = true;

                //Toggleabfrage
                if (metroToggle1.Checked == true && metroToggle2.Checked == true)
                {
                    //Beide Togglebuttons true -> Fehlermeldung
                    MetroFramework.MetroMessageBox.Show(this, "Ihre Auswahl ist nicht Korrekt!", "Eingabefehler");
                } else if (metroToggle1.Checked == true && metroToggle2.Checked == false)
                {
                    //Backup in Ordner mit Datum
                    DateTime thisDay = DateTime.Today;
                    string textbox2 = metroTextBox2.Text.Trim('\\');
                    //MessageBox.Show(textbox2);                
                    if (textbox2[textbox2.Length-1] == '\\')
                    {

                    }
                    fullBackupOrdner = textbox2 + @"\Backup_" + thisDay.ToString("d");
                    if (metroToggle3.Checked == true)
                    {
                        //Gezipte Sicherung
                        metroProgressBar1.Visible = true;
                        Thread thread3 = new Thread(new ThreadStart(Thread3));
                        thread3.Start();             
                        //ZipFile.CreateFromDirectory(metroTextBox1.Text, fullBackupOrdner + ".zip");
                        metroProgressBar1.Visible = false;
                        MetroFramework.MetroMessageBox.Show(this, "Das Erstellen der Sicherung war Erfolgreich", "Erfolg");
                    } else
                    {
                        //Normale Sicherung in neuem Ordner
                        Thread thread4 = new Thread(new ThreadStart(Thread4));
                        thread4.Start();
                        //if (!Directory.Exists(fullBackupOrdner))
                        //{
                        //    Directory.CreateDirectory(fullBackupOrdner);
                        //}

                        //for (int r = 0; r < quelleOrdner.Count; r++)
                        //{
                        //    Directory.CreateDirectory(fullBackupOrdner + @"\" + quelleOrdner);
                        //}

                        ////Progress einschalten
                        //metroProgressBar1.Visible = true;
                        //double faktor = 100 / quelle.Count;                        
                        //string sourceFile;
                        //string targetFile;
                        //for (int y = 0; y < quelle.Count; y++)
                        //{
                        //    int value = (int)(y * faktor);
                        //    metroProgressBar1.Value = value;
                        //    sourceFile = quellePfad + @"\" + quelle[y];
                        //    targetFile = zielPfad + @"\" + quelle[y];
                        //    File.Copy(sourceFile, targetFile);
                        //}
                        //metroProgressBar1.Value = 100;
                        //MetroFramework.MetroMessageBox.Show(this, "Es wurden Erfolgreich "  + quelle.Count + " Dateien gesichert", "Sicherung Erfolgreich");
                        
                    }

                } else if (metroToggle1.Checked == false && metroToggle2.Checked == true)
                {
                    //Altes Backup wird miteinbezogen
                    Thread thread5 = new Thread(new ThreadStart(Thread5));
                    thread5.Start();
                    MessageBox.Show("Thread gestartet");

                } else if (metroToggle1.Checked == false && metroToggle2.Checked == false)
                {
                    //Kein Togglebutton true -> Fehlermeldung
                    MetroFramework.MetroMessageBox.Show(this, "Ihre Auswahl ist nicht Korrekt! \n Bitte Entscheiden Sie sich für ein Backup", "Eingabefehler");
                }

                //MetroFramework.MetroMessageBox.Show(this, "Anahl der Quelledateien: " + quelle.Count + "/n" + "Anzahl der Zieldateien: " + ziel.Count + "/n" + "Anzahl der gleichen Dateien: " + equal.Count + "/n" + "Anzahl der kopierten Dateien: " + kopieren.Count);
            } catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            
        }

        //Listet alle Ordner
        private ArrayList OrdnerListe(string pfad)
        {
            ArrayList b = new ArrayList();
            var allOrdner = Directory.GetDirectories(pfad, "**", System.IO.SearchOption.AllDirectories);

            string neu;
            char[] trim = new char[pfad.Length];
            for (int x = 0; x < pfad.Length; x++)
            {
                trim[x] = pfad[x];
            }

            foreach (string ordner in allOrdner)
            {
                neu = ordner.TrimStart(trim);
                b.Add(neu);
            }

            return b;
        }

        //Listet alle Dateien
        private ArrayList listeFile(string pfad)
        {
            ArrayList a = new ArrayList();
            var allfiles = System.IO.Directory.GetFiles(pfad, "*.*", System.IO.SearchOption.AllDirectories);

            string neu;
            char[] trim = new char[pfad.Length];
            for (int z = 0; z < pfad.Length; z++)
            {
                trim[z] = pfad[z];
            }

            foreach (string files in allfiles)
            {
                neu = files.TrimStart(trim);
                a.Add(neu);               
            }

            return a;
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Es wird bei Erstellen des Backup´s ein altes mit einbezogen, sodass manche Dateien nicht Doppelt kopiert werden müssen.");
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Für das Backup wird ein neuer Ordner erstellt.");
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == false)
            {
                metroToggle3.Enabled = false;
                metroToggle2.Checked = true;
            }
            else
            {
                metroToggle3.Enabled = true;
                metroToggle2.Checked = false;
            }
        }

        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle2.Checked == true)
            {
                metroToggle1.Checked = false;
                metroToggle3.Checked = false;
            } else
            {
                metroToggle1.Checked = true;
            }
        }

        //Zip Thread
        private void Thread3()
        {
            SetProgressBarVisible(true);        
            ZipFile.CreateFromDirectory(metroTextBox1.Text, fullBackupOrdner + ".zip");
            SetProgressBarVisible(false);         
        }
        delegate void progressBarVisibleDelegate(bool value);
        private void SetProgressBarVisible(bool value)
        {
            if (metroProgressBar1.InvokeRequired)
            {
                metroProgressBar1.Invoke(new progressBarVisibleDelegate(SetProgressBarVisible), value);
            }
            else
            {
                metroProgressBar1.Visible = value;
            }
        }

        //Backup in neuem Ordner Thread
        private void Thread4()
        {
            try
            {
                if (!Directory.Exists(fullBackupOrdner))
                {
                    Directory.CreateDirectory(fullBackupOrdner);
                }

                for (int r = 0; r < quelleOrdner.Count; r++)
                {
                    //MessageBox.Show(fullBackupOrdner + @"\" + quelleOrdner[r]);
                    Directory.CreateDirectory(fullBackupOrdner + @"\" + quelleOrdner[r]);
                }

                //Progress einschalten
                SetProgressBarVisible(true);
                SetProgressBarValue(0);
                double faktor = 100 / quelle.Count;
                string sourceFile;
                string targetFile;
                for (int y = 0; y < quelle.Count; y++)
                {
                    int value = (int)(y * faktor);
                    SetProgressBarValue(value);
                    sourceFile = quellePfad + @"\" + quelle[y];
                    targetFile = fullBackupOrdner + @"\" + quelle[y];
                    //MessageBox.Show("SourceFile = " + sourceFile + " | TargetFile = " + targetFile);
                    File.Copy(sourceFile, targetFile);
                }
                SetProgressBarValue(100);
                SetProgressBarVisible(false);
                MetroFramework.MetroMessageBox.Show(this, "Es wurden Erfolgreich " + quelle.Count + " Dateien gesichert", "Sicherung Erfolgreich");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        delegate void progressBarValueDelegate(int value);
        private void SetProgressBarValue(int value)
        {
            if (metroProgressBar1.InvokeRequired)
            {
                metroProgressBar1.Invoke(new progressBarValueDelegate(SetProgressBarValue), value);
            }
            else
            {
                metroProgressBar1.Value = value;
            }
        }

        //Thread zur Abfrage ob Listenerzeugung fertig ist
        private void Thread5()
        {
            try
            {
                while (a.ThreadState == ThreadState.Running)
                {

                }
                SetProgressBarVisible(true);
                for (int ia = 0; ia < kopierenOrdner.Count; ia++)
                {
                    Directory.CreateDirectory(zielPfad + @"\" + kopierenOrdner[ia]);
                }
                SetProgressBarValue(0);
                double faktor = 100 / kopieren.Count;
                for (int ib = 0; ib < kopieren.Count; ib++)
                {
                    SetProgressBarValue((int)(faktor * kopieren.Count));
                    File.Copy(quellePfad + @"\" + kopieren[ib], zielPfad + @"\" + kopieren[ib]);
                }

                var result = MetroFramework.MetroMessageBox.Show(this, "Wollen sie die schon vorhanden Dateien aktualliesieren ?", "Übereinstimmung gefunden", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    //Aktualliseren
                    FileAttributes atr;
                    FileAttributes atr2;
                    string fileAtr;
                    string fileAtr2;

                    SetProgressBarValue(0);
                    faktor = 100 / equal.Count;
                    for (int ic = 0; ic < equal.Count; ic++)
                    {
                        SetProgressBarValue((int)(faktor * equal.Count));
                        fileAtr = quellePfad + @"\" + equal[ic];
                        fileAtr2 = zielPfad + @"\" + equal[ic];
                        atr = File.GetAttributes(fileAtr);
                        atr2 = File.GetAttributes(fileAtr2);
                        if (File.GetCreationTime(fileAtr) == File.GetCreationTime(fileAtr2))
                        {
                            if (File.GetLastWriteTime(fileAtr) >= File.GetLastWriteTime(fileAtr2))
                            {
                                //Datei Ersetzen
                                if (Directory.Exists(zielPfad + @"\" + DateTime.Today + "-Löschen"))
                                {
                                    Directory.Delete(zielPfad + @"\" + DateTime.Today + "-Löschen");
                                }
                                else
                                {
                                    Directory.CreateDirectory(zielPfad + @"\" + DateTime.Today + "-Löschen");
                                }
                                File.Copy(fileAtr2, zielPfad + @"\" + DateTime.Today + "-Löschen");
                                File.Delete(fileAtr2);
                                File.Copy(fileAtr, fileAtr2);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            fileAtr2 = fileAtr2 + "(2)";
                            File.Copy(fileAtr, fileAtr2);
                        }
                    }
                    SetProgressBarValue(100);
                    MetroFramework.MetroMessageBox.Show(this, "Es wurden " + (kopieren.Count + equal.Count) + " Dateien gesichert", "Sicherung Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    SetProgressBarVisible(false);
                }
                else
                {
                    //Nicht Aktuallisieren
                    SetProgressBarVisible(false);
                    MetroFramework.MetroMessageBox.Show(this, "Es wurden " + kopieren.Count + " Dateien gesichert", "Sicherung Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            DateienVerzeichnisErzeugen();
        }
    }
}
