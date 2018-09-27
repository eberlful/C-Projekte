using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Steuerung(String ipAdresse, int rack, int slot, String name, Fertigung fertigung, int datenbaustein, int dbByte, int dbBit)
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
            client = new S7Client();
            this.verbindung = client.ConnectTo(this.ipAdresse, this.rack, this.slot);
        }

        public bool checkOnline()
        {
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
    }
}
