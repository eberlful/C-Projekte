using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MaintenanceSOFT
{
    public partial class Verwaltung : MetroFramework.Forms.MetroForm
    {
        private string pfad;

        public Verwaltung(string pfadXML)
        {
            pfad = pfadXML;
            InitializeComponent();
        }

        private void Verwaltung_Load(object sender, EventArgs e)
        {
            if (File.Exists(pfad))
            {
                //XML Auslesen
                XmlDocument doc = new XmlDocument();
                doc.Load(pfad);
                string[] info = new string[4];

                foreach (XmlNode node in doc.DocumentElement)
                {
                    info[0] = node.Attributes[0].InnerText;
                    info[2] = node.Attributes[1].InnerText;
                    info[1] = node.Attributes[2].InnerText;
                    info[3] = node.Attributes[3].InnerText;
                    ListViewItem item = new ListViewItem(info);
                    listView1.Items.Add(item);
                }
            } else
            {
                MetroFramework.MetroMessageBox.Show(this, "Es wurde keine Config-Datei gefunden", "Config-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            treeView1.ContextMenuStrip = contextMenuStrip1;
            string[] werte = new string[4];
            werte[0] = "Hallo";
            werte[1] = "Hallo";
            werte[2] = "Hallo";
            werte[3] = "Hallo";
            //ListViewItem item = new ListViewItem(werte);

            //listView1.Items.Add(item);
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("Hallo");
            if (treeView1.SelectedNode == null)
            {
                treeView1.Nodes.Add(newNode);
            } else
            {
                treeView1.SelectedNode.Nodes.Add(newNode);
            }
            
        }

        private void storeXML(string[] values)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pfad);
            XmlElement xmlElement = doc.CreateElement("anlage");
            xmlElement.SetAttribute("name", values[0]);
            xmlElement.SetAttribute("ip", values[2]);
            xmlElement.SetAttribute("fertigung", values[1]);
            xmlElement.SetAttribute("fehlerbit", values[3]);
            doc.DocumentElement.AppendChild(xmlElement);
            doc.PreserveWhitespace = false;
            doc.Save(pfad);
        }

        private void metroButtonSpeichern_Click(object sender, EventArgs e)
        {
            if (metroTextBoxAnlage.Text != "" && metroTextBoxBetriebsmerker.Text != "" && metroTextBoxFertigung.Text != "" && metroTextBoxIP.Text != "")
            {
                string[] werte = new string[4];
                werte[0] = metroTextBoxAnlage.Text;
                werte[2] = metroTextBoxIP.Text;
                werte[1] = metroTextBoxFertigung.Text;
                werte[3] = metroTextBoxBetriebsmerker.Text;
                ListViewItem item = new ListViewItem(werte);

                listView1.Items.Add(item);
                storeXML(werte);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Bitte füllen Sie das Formular korrekt aus!", "Formfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
