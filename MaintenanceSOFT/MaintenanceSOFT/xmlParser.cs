using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MaintenanceSOFT
{
    class xmlParser
    {
        private string pfad;

        public xmlParser(string pfad){
            this.pfad = pfad;
        }

        public ListView getList()
        {
            ListView liste = new ListView();
            if(pfad != null)
            {
                try
                {
                    XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
                    XmlReader xmlReader = XmlReader.Create(pfad,xmlReaderSettings);

                    xmlReader.MoveToContent();

                    while (xmlReader.Read())
                    {
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                return null;
            }
            return liste;
        }

    }
}
