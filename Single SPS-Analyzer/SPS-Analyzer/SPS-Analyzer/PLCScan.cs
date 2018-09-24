using Sharp7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class PLCScan : MetroFramework.Forms.MetroForm
    {
        public PLCScan()
        {
            InitializeComponent();
        }

        private void PLCScan_Load(object sender, EventArgs e)
        {
            btnThreadStart.Enabled = true;
        }

        private void txtIP_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            //Regex regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");

            //if (!regex.IsMatch(txtIP.Text))
            //{
            //    txtIP.Text = "";
            //}
        }

        private void btnThreadStart_Click(object sender, EventArgs e)
        {
            IPAddress ipSource = GetIPv4();
            ipShare(ipSource);

            IPAddress[] plcOnline = availableClient(ipSource);
            erstelleListViewItems(plcOnline);
        }

        private void erstelleListViewItems(IPAddress[] addressList)
        {
            int i = 0;
            int a = 0;
            ArrayList listeRun = new ArrayList();
            ArrayList listeStop = new ArrayList();
            for(int j = 0; j < addressList.Length; j++)
            {
                int wert = isClientPLC(addressList[j]);
                if (wert == 1)
                {
                    listeRun.Add(addressList[j]);
                    i++;
                }
                else if (wert == 2)
                {
                    listeStop.Add(addressList[j]);
                    a++;
                }
                else
                {

                }
            }
            
            for (int k = 0; k < a; k++)
            {
                ListViewItem item = new ListViewItem((k+1).ToString());
                item.SubItems.Add(listeStop[k].ToString());
                item.SubItems.Add("Stop");
            }

            for (int h = 0; h < i; h++)
            {
                ListViewItem item = new ListViewItem((h + 1 + a).ToString());
                item.SubItems.Add(listeStop[h].ToString());
                item.SubItems.Add("Run");
            }
        }

        /*
         * 1 = run
         * 2 = stop
         * 3 = unkown client
         */

        private int isClientPLC(IPAddress client)
        {
            S7Client cpu = new S7Client();
            cpu.ConnectTo(client.ToString(), 0, 2);
            if (DialogResult == 0)
            {
                int statuss = 0;
                int status = cpu.PlcGetStatus(ref statuss);
                if (status == 4)
                {
                    return 2;
                }
                else if (status == 8)
                {
                    return 1;
                }
                else
                {
                    textBox1.AppendText("Unknown Device connected: " + client.ToString() + " Com: " + status);
                    return 3;
                }
            }
            else
            {
                textBox1.AppendText("Fehler bei der Verbindung: " + client.ToString() + "\n");
                return 3;
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
            IPAddress[] ab = new IPAddress[254];
            string[] oktetten = new string[4];
            oktetten = ipShare(a);

            for (int i = 1; i < 254; i++)
            {
                IPAddress con = IPAddress.Parse(oktetten[0] + "." + oktetten[1] + "." + oktetten[2] + "." + i);
                ab[i] = con;
            }

            return ab;
        }
    }
}
