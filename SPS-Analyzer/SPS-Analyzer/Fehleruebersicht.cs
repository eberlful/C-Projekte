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

namespace SPS_Analyzer
{
    public partial class Fehleruebersicht : MetroFramework.Forms.MetroForm
    {
        private Steuerung control;
        private Thread myThread;
        public Fehleruebersicht(Steuerung control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void Fehleruebersicht_Load(object sender, EventArgs e)
        {
            foreach (Fehler fault in control.getFehlerListe())
            {
                ListViewItem item = new ListViewItem(fault.Fehlername);
                // Fehlende Einbindung beachten
                item.SubItems.Add(fault.Zustand.ToString());
                item.SubItems.Add(fault.Ueberwachung.ToString());
                item.SubItems.Add(fault.FehlerText);
                item.SubItems.Add(fault.Last.ToString());
                item.SubItems.Add(fault.Fehlernummer.ToString());
                listViewFehler.Items.Add(item);
                fault.ListViewItem = item;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectItems = listViewFehler.SelectedItems;
            List<Fehler> fehler = new List<Fehler>();
            foreach (ListViewItem item in selectItems)
            {
                foreach (Fehler fehl in control.getFehlerListe())
                {
                    if (fehl.ListViewItem == item)
                    {
                        fehler.Add(fehl);
                    }
                }
            }
            AnalyzeFehler analyze = new AnalyzeFehler(selectItems, fehler);
            analyze.Show();
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectItems = listViewFehler.SelectedItems;
            if (selectItems.Count > 0 && selectItems != null)
            {
                txtConsole.AppendText(Environment.NewLine + "Die Übergabe der ausgewählten Elemente erfolgte richtig");
                try
                {
                    foreach (Fehler fehler in control.getFehlerListe())
                    {
                        fehler.ListViewItem.SubItems[1].Text = fehler.checkZustand(txtConsole).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Fehler Online");
                    //throw;
                }
                //myThread = new Thread(delegate () { this.threadStart(selectItems); });
                //txtConsole.AppendText("\n Thread gestartet");
                //myThread.Start();
            }
            else
            {
                txtConsole.AppendText(Environment.NewLine + "Falsche Übergabe " + selectItems.Count + " Items, Objekt: " + selectItems);
            }
        }

        private void threadStart(ListView.SelectedListViewItemCollection collection)
        {
            try
            {
                while (true)
                {
                    foreach (Fehler fehler in control.getFehlerListe())
                    {
                        //txtConsole.AppendText("\n" + DateTime.Now.ToString() + " Check: " + fehler.Fehlername);
                        fehler.ListViewItem.SubItems[1].Text = fehler.checkZustand(txtConsole).ToString();
                        //foreach (ListViewItem item in collection)
                        //{
                        //    if (item == fehler.ListViewItem)
                        //    {
                        //        item.SubItems[1].Text = fehler.checkZustand().ToString();
                        //    }
                        //}
                    }
                    Thread.Sleep(500);
                } 
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Fehler-Onlinethread", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            String pfad;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "csv Dateien (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pfad = openFileDialog1.FileName;
                readCSV(pfad);
            }  
        }

        private void readCSV(String pfad)
        {
            if (pfad != null)
            {
                try
                {
                    if (File.Exists(pfad))
                    {
                        string[] lines = File.ReadAllLines(pfad);

                        string[][] parts = new string[lines.Length][];

                        for (int i = 0; i < lines.Length; i++)
                        {
                            parts[i] = lines[i].Split(';');
                            foreach (String item in parts[i])
                            {
                                txtConsole.AppendText(item + " ");
                            }
                            txtConsole.AppendText("\n");
                        }
                    }

                    else
                        throw new FileNotFoundException();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
    }
}
