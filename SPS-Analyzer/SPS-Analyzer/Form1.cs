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
using Tulpep.NotificationWindow;

namespace SPS_Analyzer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        /*
         * Listen:
         * - controlList   -> Liste aller Steuerungen
         * - fertigungList -> Liste aller Fertigungen
         * - threadList    -> Liste aller Threads
         */ 
        private List<Steuerung> controlList;
        private List<Fertigung> fertiungList;
        private Thread[] threadList;
        private DateTime[] dateList;

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
        private ContextMenuStrip menuStripControl;
        //public static Logger logger;
        //private ListViewItem listViewItem;

        /*
         * Einstellungen, die über den Button Einstellungen übergeben werden
         * 
         * 
         * 
         * 
         * 
         * 
         */
        private IPAddress dbIPAdresse;
        private bool dbAktiv;
        private bool dbLocalHost;
        private String dbName;
        private int akuRate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lade aus Einstellungen
            dbAktiv = Properties.Settings.Default.dbAktiv;
            dbLocalHost = Properties.Settings.Default.dbLocalHost;
            dbIPAdresse = IPAddress.Parse(Properties.Settings.Default.dbIPAdresse);
            dbName = Properties.Settings.Default.dbName;
            akuRate = Properties.Settings.Default.akuRate;
            //Sichtbarkeit
            lblStatus.Visible = false;
            btnPLCScan.Visible = false;
            btnPLCScan.Enabled = false;
            metroLabel3.Visible = false;
            btnThreadingStop.Enabled = false;
            btnThreadingStop.Visible = false;
            btnThreadStart.Enabled = false;
            btnThreadStart.Visible = false;
            btnCPURun.Enabled = false;
            btnCPURun.Visible = false;
            btnStopp.Enabled = false;
            //metroTabControl1.Enabled = false;
            //metroTabControl1.Visible = false;
            metroTabPage1.Enabled = false;
            metroTabControl1.HideTab(metroTabPage1);
            metroTabControl1.HideTab(metroTabPage2);
            fertiungList = new List<Fertigung>();
            //txtIP.Text = Properties.Settings.Default.ip;
            //txtRack.Text = Properties.Settings.Default.rack.ToString();
            //txtSlot.Text = Properties.Settings.Default.fg.ToString();
            //rack = Properties.Settings.Default.rack;
            //slot = Properties.Settings.Default.fg;
            //ip = Properties.Settings.Default.ip;
            lblStatus.Text = "";
            //GetIPv4();
            //Änderung 30.09.2018
            //IPAddress adr = GetIPv4();
            //ipShare(adr);
            controlList = new List<Steuerung>();
            menuStripControl = new ContextMenuStrip();
            //menuStripControl += menuStrip1_ItemClicked;
            menuStripControl.Items.Add("Löschen");
            menuStripControl.Items.Add("Anzeigen");
            //menuStripControl.Items.Add();
            metroListView2.ContextMenuStrip = menuStripControl;
            menuStripControl.Items[1].Click += anzeigen_Click;
            menuStripControl.Items[0].Click += loeschen_Click;
            Logger.startLadder("log.txt", Form1.ActiveForm);
        }

        private void loeschen_Click(object sender, EventArgs e)
        {
            ListViewItem item = metroListView2.SelectedItems[0];
            //Löschen der Steuerung
        }

        private void anzeigen_Click(object sender, EventArgs e)
        {
            ListViewItem item = metroListView2.SelectedItems[0];
            Console.WriteLine(item.SubItems[0].Text);
            foreach (Steuerung control in controlList)
            {
                Console.WriteLine("Vergleiche: " + control.getName() + " mit " + item.SubItems[0].Text);
                if (control.getName().Equals(item.SubItems[0].Text))
                {
                    Fehleruebersicht fehleruebersicht = new Fehleruebersicht(control);
                    fehleruebersicht.Show();
                }
            }
            //Fehleruebersicht fehleruebersicht = new Fehleruebersicht();
        }

        private void speichernEingaben()
        {
            //Properties.Settings.Default.ip = txtIP.Text;
            //Properties.Settings.Default.fg = Int32.Parse(txtSlot.Text);
            //Properties.Settings.Default.rack = Int32.Parse(txtRack.Text);
            //Properties.Settings.Default.Save();
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
                //MessageBox.Show(ipsdf[i]);
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
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Anwendung minimiert";
                notifyIcon1.BalloonTipTitle = "Windows-Event";
                notifyIcon1.ShowBalloonTip(10000);
                //this.Close();
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
                    item.SubItems.Add(chckUeberwachung.Checked.ToString());
                    item.SubItems.Add(txtBeschreibung.Text);
                    metroListView1.Items.Add(item);

                    //Ruecksetzung der Auswahl
                    //metroRadioButton2.Select();
                }
                else if (metroRadioButton3.Checked)
                {
                    anzahlEinträge++;
                    item = new ListViewItem("Ausgang " + txtAdresse.Text + "." + txtBit.Text);
                    item.SubItems.Add("A");
                    item.SubItems.Add(txtAdresse.Text);
                    item.SubItems.Add(txtBit.Text);
                    item.SubItems.Add("false");
                    item.SubItems.Add(chckUeberwachung.Checked.ToString());
                    item.SubItems.Add(txtBeschreibung.Text);
                    metroListView1.Items.Add(item);

                    //Ruecksetzung der Auswahl
                    //metroRadioButton3.Text = "false";
                }
                else if (metroRadioButton1.Checked)
                {
                    anzahlEinträge++;
                    item = new ListViewItem("Datenbaustein " + txtAdresse.Text + "." + txtBit.Text);
                    item.SubItems.Add("DB");
                    item.SubItems.Add(txtAdresse.Text);
                    item.SubItems.Add(txtBit.Text);
                    item.SubItems.Add("false");
                    item.SubItems.Add(chckUeberwachung.Checked.ToString());
                    item.SubItems.Add(txtBeschreibung.Text);
                    metroListView1.Items.Add(item);

                    //Ruecksetzung der Auswahl
                    //metroRadioButton1.Select();
                }
                if (chckUeberwachung.Checked)
                {
                    /*
                     * 13.08.2018 -> Einzelüberwachung erstellt
                     * 
                     */
                    //ueberwachung = true;
                }

                //Ruecksetzung der Auswahl
                txtBeschreibung.Text = "";
                txtAdresse.Text = "";
                txtBit.Text = "";
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

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPLCScan_Click(object sender, EventArgs e)
        {
            PLCScan plcScan = new PLCScan();
            plcScan.ShowDialog();
        }

        private void txtIP_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == "" || metroTextBox5.Text == "" || metroTextBox6.Text == "" || metroTextBox7.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Es fehlen Angaben!");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                //Name
                item.SubItems.Add(metroTextBox6.Text);
                //Fertigung
                item.SubItems.Add(metroTextBox7.Text);
                //IP-Adresse
                item.SubItems.Add(metroTextBox1.Text);
                //BDE-Status
                item.SubItems.Add("DB" + metroTextBox8.Text + ".DBX" + metroTextBox4.Text + "." + metroTextBox5.Text);
                //Rack
                item.SubItems.Add(metroTextBox2.Text);
                //Slot
                item.SubItems.Add(metroTextBox3.Text);
                metroListView2.Items.Add(item);
                akuMenu();
                MetroFramework.MetroMessageBox.Show(this, "IP-Adresse: " + metroTextBox1.Text + "\n" + "Rack: " + metroTextBox3.Text + "Slot: " + metroTextBox2.Text + "Name: " + metroTextBox6.Text + "Fertigung: " + metroTextBox7.Text + "DB" + metroTextBox8.Text + ".dbx" + metroTextBox4.Text + "." + metroTextBox5.Text);
                //Steuerung steuerung = new Steuerung(metroTextBox1.Text, Int32.Parse(metroTextBox3.Text), Int32.Parse(metroTextBox2.Text), metroTextBox6.Text, metroTextBox7.Text, Int32.Parse(metroTextBox8.Text), Int32.Parse(metroTextBox4.Text), Int32.Parse(metroTextBox5.Text));
                //comboBox1.Items.Add(steuerung.getName());
                deletePlaceholder();
            }
        }

        public void deletePlaceholder()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            metroTextBox7.Text = "";
            metroTextBox8.Text = "";
        }

        private void akuMenu()
        {
            foreach (ListViewItem item in metroListView2.Items)
            {
                comboBox1.Items.Add(item.Text);
                Console.Write("sdfkjklsdf");
            }
            //comboBox1.Items.Add("Halloe");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddControl_Click(object sender, EventArgs e)
        {
            AddControl addControl = new AddControl(fertiungList);
            if (addControl.ShowDialog() == DialogResult.OK)
            {
                Steuerung control = new Steuerung(addControl.IpAdresse, addControl.Rack, addControl.Slot, addControl.Name, addControl.Fertigung, addControl.Db, addControl.DbByte, addControl.DbBit, addControl.Linie);
                controlList.Add(control);
                addControl.Fertigung.addSteuerung(control);
                //Linienliste füllen
                addControl.Linie.addSteuerung(control);
                ListViewItem item = new ListViewItem(addControl.Name);
                item.SubItems.Add(addControl.Fertigung.Name);
                item.SubItems.Add(addControl.IpAdresse);
                item.SubItems.Add("DB" + addControl.Db + ".DBX" + addControl.DbByte + "." + addControl.DbBit);
                item.SubItems.Add(control.checkOnline().ToString());
                item.SubItems.Add(addControl.Linie.Name);
                control.ListViewItem = item;
                //listViewItem = item;
                //item.SubItems.Add();
                metroListView2.Items.Add(item);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Rechtsklick");
            //Rechtsklick-Menu Löschen Aktion
            ListView.SelectedListViewItemCollection selectItems = metroListView2.SelectedItems;
            if (e.ClickedItem.Text == "Löschen")
            {
                MessageBox.Show("Löschen ausgewählt");
                foreach (ListViewItem item in selectItems)
                {
                    metroListView2.Items.Remove(item);
                }
            }

            if (e.ClickedItem.Text == "")
            {

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //listViewItem.SubItems[0].Text = "lfa";
            AddFault addFault = new AddFault(controlList);
            if (addFault.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void metroListView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = metroListView2.SelectedItems[0];
            Console.WriteLine(item.SubItems[0].Text);
            foreach (Steuerung control in controlList)
            {
                Console.WriteLine("Vergleiche: " + control.getName() + " mit " + item.SubItems[0].Text);
                if (control.getName().Equals(item.SubItems[0].Text))
                {
                    Fehleruebersicht fehleruebersicht = new Fehleruebersicht(control);
                    fehleruebersicht.Show();
                }
            }
            //Fehleruebersicht fehleruebersicht = new Fehleruebersicht();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen(dbAktiv, dbLocalHost, dbName, dbIPAdresse, akuRate);
            if (einstellungen.ShowDialog() == DialogResult.OK)
            {
                dbAktiv = einstellungen.DbAktiv;
                dbLocalHost = einstellungen.DbLocalHost;
                dbIPAdresse = einstellungen.IpDB;
                dbName = einstellungen.DbNamen;
                akuRate = einstellungen.AkuRate;
                //Logger
                //logger.write("")
                //Lokal Speichern
                Properties.Settings.Default.dbAktiv = dbAktiv;
                Properties.Settings.Default.dbLocalHost = dbLocalHost;
                Properties.Settings.Default.dbName = dbName;
                Properties.Settings.Default.dbIPAdresse = dbIPAdresse.ToString();
                Properties.Settings.Default.akuRate = akuRate;
                Properties.Settings.Default.Save();
            }
            //einstellungen.Show();
        }

        private void btnNeueFertigung_Click(object sender, EventArgs e)
        {
            FertigungForm fertigungForm = new FertigungForm();
            
            if (fertigungForm.ShowDialog() == DialogResult.OK)
            {
                Fertigung fertigung = new Fertigung(fertigungForm.Name, fertigungForm.Number);
                fertiungList.Add(fertigung);
                ListViewItem item = new ListViewItem(fertigungForm.Name);
                item.SubItems.Add(fertigungForm.Number.ToString());
                item.SubItems.Add("0");
                fertigung.ListViewItem = item;
                metroListView4.Items.Add(item);
                Logger.writeStatic(DateTime.Now.ToString() + ": Neue Fertiung -> Name: " + fertigungForm.Name + " , Linie: " + fertigungForm.Number);
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info;
                popup.TitleText = "Neue Fertiung";
                popup.ContentText = fertigungForm.Name + " mit " + fertigungForm.Number.ToString() + " erstellt.";
                popup.Popup();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (fertiungList.Count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Es wurde keine Fertiung erzeugt", "Threaderzeugungs-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    threadList = new Thread[fertiungList.Count];
                    dateList = new DateTime[fertiungList.Count];
                    int i = 0;
                    foreach (Fertigung item in fertiungList)
                    {

                        //ParameterizedThreadStart pts = new ParameterizedThreadStart(this.threadFertigung);
                        //System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(threadFertigung));
                        //thread.Start(item);
                        if (item.getSteuerungen().Count > 0)
                        {
                            Thread thread = new Thread(delegate () { this.threadFertigung(item, i); });
                            thread.Start();
                            Console.WriteLine("Thread " + i + " gestartet");
                            threadList[i] = thread;
                            i++;
                            btnStart.Enabled = false;
                            btnStopp.Enabled = true;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Es wurde keine Steuerung in der Fertigung " + item.Name + " gefunden", "Threaderzeugungs-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Startfehler");
            }
        }

        public object objekt = new object();

        private void threadFertigung(Fertigung fertigung , int index)
        {
            while (true)
            {
                dateList[index] = DateTime.Now;
                foreach (Steuerung item in fertigung.getSteuerungen())
                {
                    item.loadFrame(this);
                    item.checkZustand();
                    //Änderung des Zustandes -> ListViewItem aktuallisieren
                    if (item.Run != item.RunLast)
                    {
                        item.ListViewItem.SubItems[3].Text = item.Run.ToString();
                    }
                    if (item.Run)
                    {
                        //Einstellung abfragen NZE
                    }
                    else
                    {
                        //Fehlertabelle listen
                    }
                    Console.WriteLine(item.getName());
                }
                Console.WriteLine("Thread " + fertigung.Name + " gestartet");
                lock(objekt){
                    if ((dateList[index].Millisecond + akuRate) < DateTime.Now.Millisecond)
                    {
                        Thread.Sleep(DateTime.Now.Millisecond - (dateList[index].Millisecond + akuRate));
                    }
                }
                
                //Thread.Sleep(1000);
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (dbAktiv)
            {
                Statistik statistik = new Statistik(dbIPAdresse, dbName);
                statistik.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Es ist keine Datenbank aktiv. \n Bitte registrieren Sie eine Datenbank", "Datenbank-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStopp_Click(object sender, EventArgs e)
        {
            if (threadList.Length > 0)
            {
                foreach (Thread item in threadList)
                {
                    //item.Suspend();
                    item.Abort();
                }
            }
        }

        private void anzeigenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem item = metroListView4.SelectedItems[0];
            foreach (Fertigung fertigung in fertiungList)
            {
                if (fertigung.ListViewItem == item)
                {

                }
            }
        }
    }
}
