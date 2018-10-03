using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                myThread = new Thread(delegate () { this.threadStart(selectItems); });
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
                        foreach (ListViewItem item in collection)
                        {
                            if (item == fehler.ListViewItem)
                            {
                                item.SubItems[1].Text = fehler.checkZustand().ToString();
                            }
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Fehler-Onlinethread", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
