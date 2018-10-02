using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public class Steuerung
    {
        private List<Fehler> fehlerListe;
        private String ipAdresse;
        private int rack;
        private int slot;
        private String name;
        //private String fertigung;
        private Fertigung fertigung;
        private int datenbaustein;
        private int dbByte;
        private int dbBit;
        private int verbindung;
        private S7Client client;
        private Linie linie;
        private bool run;
        private bool verbindungsStatus;
        private System.Windows.Forms.IWin32Window frame;
        private ListViewItem listViewItem;
        private bool runLast;

        public Steuerung(String ipAdresse, int rack, int slot, String name, Fertigung fertigung, int datenbaustein, int dbByte, int dbBit, Linie linie)
        {
            this.fehlerListe = new List<Fehler>();
            this.ipAdresse = ipAdresse;
            this.rack = rack;
            this.slot = slot;
            this.name = name;
            this.fertigung = fertigung;
            this.datenbaustein = datenbaustein;
            this.dbByte = dbByte;
            this.dbBit = dbBit;
            this.linie = linie;
            client = new S7Client();
            this.verbindung = client.ConnectTo(this.ipAdresse, this.rack, this.slot);
            verbindungsStatus = client.Connected;
        }

        public bool checkOnline()
        {
            verbindungsStatus = client.Connected;
            return client.Connected;
        }

        public List<Fehler> getFehlerListe()
        {
            return this.fehlerListe;
        }

        public String getName()
        {
            return this.name;
        }

        public S7Client getS7Client()
        {
            return client;
        }

        public void addFehler(bool ueberwachung, int db, int dbByte, int dbBit)
        {
            //Fehler fehler = new Fehler(client, ueberwachung, datenbaustein, dbByte, dbBit);
        }

        public void addFehler(Fehler fehler)
        {
            if(fehler != null)
            {
                fehlerListe.Add(fehler);
                Console.WriteLine(fehler.Fehlername + " hinzugefügt");
                //Console.WriteLine("Es wurde eine NULL übergeben" + "Steuerung, addFehler");
            }
            else
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Übergebener Fehler hat keine gültige Referenz");
                Console.WriteLine(this.getName());
                Console.WriteLine("-----------------------------------------");
            }
        }

        public void loadFrame(System.Windows.Forms.IWin32Window window)
        {
            frame = window;
        }

        public void checkZustand()
        {
            try
            {
                if (verbindungsStatus)
                {
                    Byte[] buffer = new Byte[1];
                    client.DBRead(datenbaustein, dbByte, 8, buffer);
                    runLast = run;
                    run = S7.GetBitAt(buffer, 0, dbBit);
                }
                else
                {
                    verbindung = client.ConnectTo(ipAdresse, rack, slot);
                    if (client.Connected)
                    {
                        Byte[] buffer = new Byte[1];
                        client.DBRead(datenbaustein, dbByte, 8, buffer);
                        run = S7.GetBitAt(buffer, 0, dbBit);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(frame, ex.Message + "\n" + ex.StackTrace, "Fehler bei Aktualliserung", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public bool Run
        {
            get { return run; }
            //set { run = value; }
        }

        public ListViewItem ListViewItem
        {
            get { return listViewItem; }
            set { listViewItem = value; }
        }

        public bool RunLast
        {
            get { return runLast; }
        }
    }
}
