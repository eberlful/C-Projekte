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
    public partial class AnalyzeFehler : MetroFramework.Forms.MetroForm
    {
        private ListView.SelectedListViewItemCollection items;
        public AnalyzeFehler(ListView.SelectedListViewItemCollection items)
        {
            this.items = items;
            InitializeComponent();
        }

        private void AnalyzeFehler_Load(object sender, EventArgs e)
        {

        }
    }
}
