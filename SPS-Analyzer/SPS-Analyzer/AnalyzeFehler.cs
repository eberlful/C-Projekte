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
    public partial class AnalyzeFehler : MetroFramework.Forms.MetroForm
    {
        private ListView.SelectedListViewItemCollection items;
        private List<Fehler> fehlerListe;
        private Thread myThread;
        private bool[,] array;
        public AnalyzeFehler(ListView.SelectedListViewItemCollection items, List<Fehler> fehler)
        {
            this.items = items;
            array = new bool[30,items.Count];
            fehlerListe = fehler;
            InitializeComponent();
        }

        private void AnalyzeFehler_Load(object sender, EventArgs e)
        {

        }

        private void threadInit()
        {
            myThread = new System.Threading.Thread(new System.Threading.ThreadStart(this.getFehler));
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void getFehler()
        {
            //var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            //var ramPerfCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            while (true)
            {
                //cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                //ramArray[ramArray.Length - 1] = Math.Round(ramPerfCounter.NextValue(), 0);
                foreach (ListViewItem item in items)
                {

                }
                //Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                //Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);
                if (analyseBit.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateAnalyse(); });
                }
                else
                {
                    //
                }

                Thread.Sleep(100);
            }
        }

        private void UpdateAnalyse()
        {

        }
    }
}
