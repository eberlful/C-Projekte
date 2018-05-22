using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceSOFT
{
    public partial class Status : MetroFramework.Forms.MetroForm
    {
        public Status()
        {
            InitializeComponent();
        }


        private void Status_Load(object sender, EventArgs e)
        {
            MetroTile tile = new MetroTile();
            tile.Text = "Ha";
            //tile.Location = new System.Drawing.Point(130, 95);
            tile.Size = new System.Drawing.Size(110, 30);
            //this.Controls.Add(tile);
            listView1.Controls.Add(tile);
            for(int i = 0; i < 5; i++)
            {
                MessageBox.Show("hf");
                MetroTile tile2 = new MetroTile();
                tile2.Text = "Ha";
                //tile.Location = new System.Drawing.Point(130, 95);
                tile2.Size = new System.Drawing.Size(110, 30);
                listView1.Controls.Add(tile2);
            }
        }
    }
}
