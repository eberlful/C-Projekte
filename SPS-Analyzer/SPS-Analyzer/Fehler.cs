﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Analyzer
{
    public class Fehler
    {
        private bool ueberwachung;
        private int art;    // 0 = DB, 1 = Eingang, 2 = Ausgang
        private bool zustand; // true = Fehler vorhanden
        private Steuerung clientST;
        private Sharp7.S7Client client;
        private int db;
        private int dbByte;
        private int dbBit;
        private int merkerByte;
        private int merkerBit;
        private String fehlerText;
        private String fehlername;
        private int fehlernummer;
        private static int fehlerCounter = 0;
        private String pfadFehlerBehebung;
        // Muss noch implementiert werden
        private DateTime last;

        public Fehler(Steuerung clientST, bool ueberwachung, int db, int dbByte, int dbBit, int art, int merkerByte, int merkerBit, String fehlertext, String fehlername, int fehlernummer)
        {
            this.clientST = clientST;
            this.client = clientST.getS7Client();
            this.ueberwachung = ueberwachung;
            this.db = db;
            this.dbByte = dbByte;
            this.dbBit = dbBit;
            this.art = art;
            this.merkerByte = merkerByte;
            this.merkerBit = merkerBit;
            this.fehlerText = fehlertext;
            this.fehlername = fehlername;
            this.fehlernummer = fehlernummer;
        }

        public bool checkZustand()
        {
            if (client.Connected)
            {
                byte[] buffer = new byte[1];
                int result = client.DBRead(db, dbByte, 1, buffer);
                zustand = Sharp7.S7.GetBitAt(buffer, 0, dbBit);
                checkUueberwachung();
                return zustand;
            } else
            {
                zustand = false;
                return false;
            }
        }

        public void checkUueberwachung()
        {
            if(ueberwachung == true && zustand == true)
            {
                //Ueberwachung werfen
            }
        }

        public Sharp7.S7Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public String FehlerText
        {
            get { return fehlerText; }
            set { fehlerText = value; }
        }

        public bool Zustand
        {
            get { return zustand; }
        }

        public bool Ueberwachung
        {
            get { return ueberwachung; }
        }

        public DateTime Last
        {
            get { return last; }
        }

        public int Fehlernummer
        {
            get { return fehlernummer; }
        }

        public String Fehlername
        {
            get { return fehlername; }
            set { fehlername = value; }
        }

        public int Art
        {
            get { return art; }
            set { art = value; }
        }

        public int Db
        {
            get { return db; }
            set { db = value; }
        }

        public int DbByte
        {
            get { return dbByte; }
            set { dbByte = value; }
        }

        public int DbBit
        {
            get { return dbBit; }
            set { dbBit = value; }
        }

        public int MerkerByte
        {
            get { return merkerByte; }
            set { merkerByte = value; }
        }

        public int MerkerBit
        {
            get { return merkerBit; }
            set { merkerBit = value; }
        }
    }
}
