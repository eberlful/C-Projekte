using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public class Fertigung
    {
        private List<Steuerung> listeSteuerungen = new List<Steuerung>();
        private List<Linie> linien = new List<Linie>();
        private String name;
        private ListViewItem listViewItem;
        public Fertigung(String name, int anzahlLinien)
        {
            this.name = name;
            for (int i = 1; i <= anzahlLinien; i++)
            {
                Linie linie = new Linie(this, i);
                linien.Add(linie);
            }
        }

        public void addSteuerung(Steuerung steuerung)
        {
            if (steuerung != null)
            {
                Console.WriteLine(steuerung.getName() + " in " + this.name + " eingefügt");
                listeSteuerungen.Add(steuerung);
            }
            else
            {
                //
            }
        }

        //public void AaddLinie(Linie linie)
        //{

        //}

        public String Name
        {
            get { return name; }
        }

        public List<Linie> getLinien()
        {
            return this.linien;
        }

        public List<Steuerung> getSteuerungen()
        {
            return this.listeSteuerungen;
        }

        public void delete(Steuerung steuerung)
        {
            listeSteuerungen.Remove(steuerung);
        }

        public void deleteAll()
        {
            this.listeSteuerungen.Clear();
        }
    }
}
