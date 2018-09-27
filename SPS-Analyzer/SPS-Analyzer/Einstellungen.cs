using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class Einstellungen : MetroFramework.Forms.MetroForm
    {
        private IPAddress ipDB;
        private String dbNamen;
        private bool dbAktiv;
        private bool dbLocalhost;
        System.Threading.Thread myThread;
        private ThreadExceptionDialog cpuThread;
        private double[] cpuArray = new double[30];
        private double[] ramArray = new double[30];
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {
            threadInit();

        }

        private void threadInit()
        {
            myThread = new System.Threading.Thread(new System.Threading.ThreadStart(this.getCPU));
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void getCPU()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            var ramPerfCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                ramArray[ramArray.Length - 1] = Math.Round(ramPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);
                if (cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //
                }

                Thread.Sleep(1000);
            }
        }

        public void UpdateCpuChart()
        {
            cpuChart.Series["CPU"].Points.Clear();
            cpuChart.Series["RAM"].Points.Clear();

            for (int i = 0; i < cpuArray.Length-1; i++)
            {
                //Console.WriteLine(cpuArray[i]);
                cpuChart.Series["CPU"].Points.AddY(cpuArray[i]);
                cpuChart.Series["RAM"].Points.AddY(ramArray[i]);
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                dbLocalhost = checkBoxLocalHost.Checked;
                if (!checkBoxLocalHost.Checked)
                {
                    ipDB = IPAddress.Parse(txtIP.Text);
                } 
                dbNamen = txtDBName.Text;
                dbAktiv = checkBoxAktivieren.Checked;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Fehler: IP-Konvertierung");
            }
        }

        public bool DbLocalHost
        {
            get { return dbLocalhost; }
            set { dbLocalhost = value; }
        }


        public bool DbAktiv
        {
            get { return dbAktiv; }
            set { dbAktiv = value; }
        }

        public IPAddress IpDB
        {
            get { return ipDB; }
            set { ipDB = value; }
        }

        public String DbNamen
        {
            get { return dbNamen; }
            set { dbNamen = value; }
        }
    }
}
