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

namespace Backup
{
    public partial class Ladeform : MetroFramework.Forms.MetroForm
    {
        public Ladeform()
        {
            InitializeComponent();
        }

        private void Ladeform_Load(object sender, EventArgs e)
        {
            this.Name = "Lade...";
            Thread a = new Thread(new ThreadStart(aku));
            a.Start();
        }

        private void aku()
        {
            int wert = 0;
            while (true)
            {
                SetProgressBar(wert);
                wert++;
                if (wert > 100)
                {
                    wert = 0;
                }
                Thread.Sleep(200);
            }
        }



        delegate void Text(int value);

        private void SetProgressBar(int value)
        {
            if (metroProgressBar1.InvokeRequired)
            {
                metroProgressBar1.Invoke(new Text(SetProgressBar), value);
            } else
            {
                metroProgressBar1.Value = value;
            }
        }
    }
}
