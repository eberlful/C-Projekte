using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Analyzer
{
    public class Fertigung
    {
        private List<Steuerung> listeSteuerungen = new List<Steuerung>();
        private String name;

        public Fertigung(String name)
        {
            this.name = name;
        }

        public void addSteuerung(Steuerung steuerung)
        {
            if (steuerung != null)
            {
                listeSteuerungen.Add(steuerung);
            }
            else
            {
                //
            }
        }

        public String Name
        {
            get { return name; }
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
