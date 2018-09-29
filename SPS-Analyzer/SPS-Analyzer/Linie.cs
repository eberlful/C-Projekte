using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Analyzer
{
    public class Linie
    {
        private List<Steuerung> steuerungen = new List<Steuerung>();
        private Fertigung fertigung;
        private String name;

        public Linie(Fertigung fertigung, int count)
        {
            this.fertigung = fertigung;
            this.name = "Linie " + count;
            Console.WriteLine(this.name + " " + fertigung.Name + " erzeugt");
        }

        /*
         * Fügt eine Steuerung der Linie als Objekt hinzu
         */
        public void addSteuerung(Steuerung steuerung)
        {
            Console.WriteLine(steuerung.getName() + " in " + this.name + " eingefügt");
            steuerungen.Add(steuerung);
        }

        public void deleteSteuerung(Steuerung steuerung)
        {
            if (steuerungen.Count > 0)
            {
                int index = -1;
                foreach (Steuerung item in steuerungen)
                {
                    if (item.Equals(steuerung))
                    {
                        steuerungen.Remove(item);
                    }
                }
            }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
