using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class Statistik : MetroFramework.Forms.MetroForm
    {
        private IPAddress ipDB;
        private String dbName;
        public Statistik()
        {
            InitializeComponent();
        }

        public Statistik(IPAddress ipDB, String dbName)
        {
            this.ipDB = ipDB;
            this.dbName = dbName;
        }

        private void Statistik_Load(object sender, EventArgs e)
        {

        }
    }
}
