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
using System.Collections;

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
        public bool ueberwachung = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = Properties.Settings.Default.ip;
            txtRack.Text = Properties.Settings.Default.rack.ToString();
            txtSlot.Text = Properties.Settings.Default.slot.ToString();
            rack = Properties.Settings.Default.rack;
            slot = Properties.Settings.Default.slot;
            ip = Properties.Settings.Default.ip;
            lblStatus.Text = "";
            //GetIPv4();
            IPAddress adr = GetIPv4();
            ipShare(adr);
        }

        private void speichernEingaben()
        {
            Properties.Settings.Default.ip = txtIP.Text;
            Properties.Settings.Default.slot = Int32.Parse(txtSlot.Text);
            Properties.Settings.Default.rack = Int32.Parse(txtRack.Text);
            Properties.Settings.Default.Save();
        }

        private void btnVerbinden_Click(object sender, EventArgs e)
        {
            if (txtSlot.Text =="" || txtRack.Text == "" || txtIP.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Es fehlen noch Angaben!");
            } else
            {
                //Speichern der Eingaben
                speichernEingaben();

                //Variablen initiallisieren
                ip = txtIP.Text;
                rack = Int32.Parse(txtRack.Text);
                slot = Int32.Parse(txtSlot.Text);

                //Objekt initialisieren und auf Verbindung prüfen
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
                    //Statusabfrage
                    status();
                    //int abc = CPU.PlcGetStatus();
                    //int def = CPU.GetCpuInfo();
                    //MetroFramework.MetroMessageBox.Show(this,); 
                }
                else
                {
                    lblStatus.Text = "Keine Verbindung";
                    conTrue = false;
                    panel1.BackColor = Color.Red;
                    MetroFramework.MetroMessageBox.Show(this, "Es konnte keine Verbindung hergestellt werden!");
                    btnCPURun.Enabled = false;
                    btnCPUStop.Enabled = false;
                }
            }           
        }

        private IPAddress GetIPv4()
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                if (addr[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    MessageBox.Show(addr[i].ToString());
                    return addr[i];
                }
            }
            string ipA = "0.0.0.0";
            IPAddress a;

            a = IPAddress.Parse(ipA);
            return a;
        }

        private string[] ipShare(IPAddress ipAdresse)
        {
            string[] ipZerlegt = new string[4];
            string ipSpeicher = ipAdresse.ToString();
            //ipZerlegt[] = ipSpeicher.Split('.');
            string[] ipsdf = ipSpeicher.Split('.');
            for (int i = 0; i < ipsdf.Length; i++)
            {
                MessageBox.Show(ipsdf[i]);
            }
            return ipsdf;
        }

        private IPAddress[] availableClient(IPAddress a)
        {
            IPAddress[] ab;
            string[] oktetten = new string[4];
            oktetten = ipShare(a);

            for (int i = 1; i < 254; i++)
            {
                IPAddress con = IPAddress.Parse(oktetten[0] + "." + oktetten[1] + "." + oktetten[2]);
            }

            return ab;
        }

        private string status()
        {
            int statuss = 0;
            int b = CPU.PlcGetStatus(ref statuss);
            //int a = CPU.GetCpuInfo();
            //MessageBox.Show("b: " + b.ToString() + "statuss: " + statuss.ToString());
            if (statuss == 4)
            {
                lblStatus.Text = "Stop";
            }
            else if (statuss == 8)
            {
                lblStatus.Text = "Run";
            }
            return b.ToString();
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
                if (chckUeberwachung.Checked)
                {
                    ueberwachung = true;
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
                    bool k;
                    if (ueberwachung == true)
                    {
                        bool speicher = bool.Parse(metroListView1.Items[i].SubItems[4].Text);
                        k = StatusM(typ, adr, bt);
                        if (speicher != k)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Eine Eingabe hat sich verändert", "Überwachung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        k = StatusM(typ, adr, bt);
                    }
                    
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
                    //Fehler weil Zahl nicht höher als Buffer sein darf!!!
                    //Faktorrechnung einfügen!!!
                    w = S7.GetBitAt(Buffer, 0, c);
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
                    //Fehler weil Zahl nicht höher als Buffer sein darf!!!
                    //Faktorrechnung einfügen!!!
                    w = S7.GetBitAt(Buffer, 0, c);
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

        private void lblStatus_Click(object sender, EventArgs e)
        {
            CPU.PlcColdStart();
        }

        private void btnCPUStop_Click(object sender, EventArgs e)
        {
            CPU.PlcStop();
            lblStatus.Text = "Run";
        }

        private void btnCPURun_Click(object sender, EventArgs e)
        {          
            CPU.PlcHotStart();
            lblStatus.Text = "Stop";
        }
    }
}
