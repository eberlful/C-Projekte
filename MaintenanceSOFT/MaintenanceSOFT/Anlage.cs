using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Sharp7.S7Client;

namespace MaintenanceSOFT
{
    class Anlage
    {
        private string fertigung;
        private string name;
        private IPAddress ipAdresse;
        private string betriebsMerker;
        private string baustein;
        private int bausteinNummer;
        private int datensatz;
        private byte bit;
        private bool status = false;
        private S7Client cpu;
        private bool verbindung = false;

        public Anlage(string fertigung, string name, IPAddress ipAdresse, string baustein, int bausteinNummer, int datensatz, byte bit)
        {
            this.fertigung = fertigung;
            this.name = name;
            this.ipAdresse = ipAdresse;
            this.baustein = baustein;
            this.bausteinNummer = bausteinNummer;
            this.datensatz = datensatz;
            this.bit = bit;
            if (baustein == "DB")
            {
                this.betriebsMerker = baustein + bausteinNummer + ".DBX" + datensatz + "." + bit;
                status = true;
            } else
            {
                status = false;
            }
            if (status == true)
            {
                try
                {
                    cpu.ConnectTo(ipAdresse.ToString(), 0, 2);
                    if (cpu.Connected)
                    {
                        verbindung = true;
                    } else
                    {
                        verbindung = false;
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public int statusCPU()
        {
            if (status == true && verbindung == true)
            {
                return 1;
            }
            return 1;
        }

        public bool aktBetriebMerker()
        {
            if (status == true)
            {
                if (cpu.Connected)
                {

                }
            }
            return false;
        }
    }
}
