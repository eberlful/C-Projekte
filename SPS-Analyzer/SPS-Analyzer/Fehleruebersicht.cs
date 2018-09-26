using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class Fehleruebersicht : MetroFramework.Forms.MetroForm
    {
        private Steuerung control;

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
            AnalyzeFehler analyze = new AnalyzeFehler(selectItems);
            analyze.Show();
        }
    }
}
