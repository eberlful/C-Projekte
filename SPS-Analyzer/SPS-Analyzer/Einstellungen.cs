using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class Einstellungen : MetroFramework.Forms.MetroForm
    {
        System.Threading.Thread myThread;
        private ThreadExceptionDialog cpuThread;
        private double[] cpuArray = new double[30];
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
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
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

            for (int i = 0; i < cpuArray.Length-1; i++)
            {
                Console.WriteLine(cpuArray[i]);
                cpuChart.Series["CPU"].Points.AddY(cpuArray[i]);
            }
        }
    }
}
