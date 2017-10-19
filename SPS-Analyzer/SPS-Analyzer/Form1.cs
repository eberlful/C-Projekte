using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Sharp7;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;

namespace SPS_Analyzer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int anzahlEinträge = 0;
        public string cpuFile = @"cpu.xml";
        //CPU-Variablen
        public string ip;
        public int rack;
        public int slot;
        public S7Client CPU;
        public bool conTrue = false;
        public bool verbindung = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnVerbinden_Click(object sender, EventArgs e)
        {
            if (txtSlot.Text =="" || txtRack.Text == "" || txtIP.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Es fehlen noch Angaben!");
            } else
            {
                ip = txtIP.Text;
                rack = Int32.Parse(txtRack.Text);
                slot = Int32.Parse(txtSlot.Text);

                CPU = new S7Client();
                int result = CPU.ConnectTo(ip, rack, slot);
                if (result == 0)
                {
                    verbindung = true;
                    conTrue = true;
                    panel1.BackColor = Color.Green;
                    btnCPUStop.Enabled = true;
                    btnCPURun.Enabled = true;
                    btnThreadStart.Enabled = true;
                     
                }
                else
                {
                    conTrue = false;
                    panel1.BackColor = Color.Red;
                    MetroFramework.MetroMessageBox.Show(this, "Es konnte keine Verbindung hergestellt werden!");
                    btnCPURun.Enabled = false;
                    btnCPUStop.Enabled = false;
                }
            }           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (verbindung == true)
            {
                CPU.Disconnect();
                this.Close();
            } else
            {
                this.Close();
            }        
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]");

            if (regex.IsMatch(txtIP.Text))
            {
                txtIP.Text = "";
            }
        }

        private void txtRack_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtRack.Text))
            {
                txtRack.Text = "";
            }
        }

        private void txtSlot_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtSlot.Text))
            {
                txtSlot.Text = "";
            }
        }

        
        private void btnEintrag_Click(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtBit.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Es fehlen Angaben!");
            } else
            {
                ListViewItem item = new ListViewItem();
                if (metroRadioButton2.Checked)
                {
                    anzahlEinträge++;
                    item = new ListViewItem("Eingang " + txtAdresse.Text + "." + txtBit.Text);
                    item.SubItems.Add("E");
                    item.SubItems.Add(txtAdresse.Text);
                    item.SubItems.Add(txtBit.Text);
                    item.SubItems.Add("false");
                    metroListView1.Items.Add(item);
                }
                else if (metroRadioButton3.Checked)
                {
                    anzahlEinträge++;
                    item = new ListViewItem("Ausgang " + txtAdresse.Text + "." + txtBit.Text);
                    item.SubItems.Add("A");
                    item.SubItems.Add(txtAdresse.Text);
                    item.SubItems.Add(txtBit.Text);
                    item.SubItems.Add("false");
                    metroListView1.Items.Add(item);
                }
            }
            
        }
        public Thread thread;
        public bool stop = false;
        private void btnThreadStart_Click(object sender, EventArgs e)
        {
            if (anzahlEinträge > 0)
            {
                btnThreadStart.Enabled = false;
                thread = new Thread(new ThreadStart(aku));
                btnThreadingStop.Enabled = true;
                thread.Start();

                Control.CheckForIllegalCrossThreadCalls = false;
            } else
            {
                MetroFramework.MetroMessageBox.Show(this, "Es sind keine Einträge in der Liste!");
            }
        }

        private void aku()
        {
            while (stop == false)
            {
                for (int i = 0; i < anzahlEinträge; i++)
                {
                    string  typ = metroListView1.Items[i].SubItems[1].Text;
                    int adr = Int32.Parse(metroListView1.Items[i].SubItems[2].Text);
                    int bt = Int32.Parse(metroListView1.Items[i].SubItems[3].Text);
                    bool k = StatusM(typ, adr, bt);
                    metroListView1.Items[i].SubItems[4].Text = k.ToString();
                }
                Thread.Sleep(200);
            }           
        }

        private bool StatusM(string a, int b ,int c)
        {
            bool w;
            byte[] Buffer = new byte[18];
            if (a == "A")
            {
                int result2 = CPU.ABRead(b, 4, Buffer);
                
                if (result2 != 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, CPU.ErrorText(result2));                    
                } else
                {
                    w = S7.GetBitAt(Buffer, b, c);
                    return w;
                }              
            } else
            {
                int result2 = CPU.EBRead(b, 4, Buffer);
                if (result2 != 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, CPU.ErrorText(result2));
                } else
                {
                    w = S7.GetBitAt(Buffer, b, c);
                    return w;
                }                
            }
            
            return false;
        }

        private void btnThreadingStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void txtAdresse_Click(object sender, EventArgs e)
        {

        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtAdresse.Text))
            {
                txtAdresse.Text = "";
            }
        }

        private void txtBit_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtBit.Text))
            {
                txtBit.Text = "";
            }
        }
    }
}
