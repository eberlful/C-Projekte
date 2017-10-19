using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prüfungsdownlaoder
{
    public partial class Form1 : Form
    {
        public string text;
        public string grundLink = "http://www.fernuni-hagen.de/FACHSCHINF/";
        WebClient client;
        ArrayList a = new ArrayList();
        ArrayList links = new ArrayList();
        ArrayList ordner = new ArrayList();
        int had = 0;
        int had2 = 0;
        public string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = client.DownloadString("http://www.fernuni-hagen.de/FACHSCHINF/Klausuren.htm");
                //textBox1.Text = text;
                string link = "http://www.fernuni-hagen.de/FACHSCHINF/1135/1135HK2008.pdf";
                //href="
                //
                MatchCollection m = Regex.Matches(text, "<a href=\"[^\"]*.pdf\" target=\"_new\">");
                int trefferHref = m.Count;
                double trefferHrefd = trefferHref;
                double faktor = 100.0 / trefferHrefd;
                //MessageBox.Show(faktor.ToString());
                string x = "Hallo";
                for (int i = 0; i < m.Count; i++)
                {
                    double ca = faktor * i;
                    progressBar1.Value = (int)ca;
                    x = m[i].Groups[0].Value;
                    a.Add(x);
                    textBox1.AppendText("\n");
                    textBox1.AppendText(x);
                }
                //progressBar1.Value = 100;
                //MessageBox.Show(x);

                button1.Text = trefferHref.ToString();
                ordnerErstellen();
                visuLinks();
                ordnerErstell();
                string pfad1 = pfad() + "Prüfungen FernUni";
                path = pfad1 + "\\";
                if (System.IO.Directory.Exists(pfad1) == false)
                {
                    System.IO.Directory.CreateDirectory(pfad1);
                }
                for (int c = 0; c < ordner.Count; c++)
                {
                    textBox1.AppendText("\n");
                    textBox1.AppendText(ordner[c].ToString());
                    if (System.IO.Directory.Exists(pfad1 + "\\" + ordner[c]) == false)
                    {
                        //MessageBox.Show("ordner wird erzeugt");
                        System.IO.Directory.CreateDirectory(pfad1 + "\\" + ordner[c]);
                    }
                }
                ladePdf();
                progressBar1.Value = 100;
                StreamWriter sw = new StreamWriter("log.txt");
                sw.Write(textBox1.Text);
                sw.Close();
                textBox1.AppendText("\n");
                textBox1.AppendText("_________________________________________________________________\n");
                textBox1.AppendText("fertig");
                MessageBox.Show("Fertig");
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        public void ladePdf()
        {
            if (path != "")
            {
                double fak = 0.14285;
                progressBar1.Value = 0;
                for (int t = 0; t < links.Count; t++)
                {
                    string quelle = "http://www.fernuni-hagen.de/FACHSCHINF/" + links[t];
                    string ziel = path + links[t];
                    string hafs = "/";
                    string fsf = @"\";
                    ziel = ziel.Replace(hafs, fsf);
                    downloadPDF(quelle, ziel);
                    textBox1.AppendText("\n");
                    textBox1.AppendText(quelle);
                    textBox1.AppendText("\n");
                    textBox1.AppendText(ziel);
                    double fak2 = t * fak;
                    int fak3 = (int)fak2;
                    if (fak3 >=100)
                    {
                        progressBar1.Value = 100;
                    }
                    else
                    {
                        progressBar1.Value = fak3;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Es wurde kein Pfad angegeben!");
            }
        }

        public void ordnerErstellen()
        {
            for (int i = 0; i < a.Count; i++)
            {
                string b = a[i].ToString();
                string trimStartat = "<a href=\"";
                string trimEndat = "\" target=\"_new\">";
                string a1 = "FACHSCHINF/";
                string a2 = "../../M&I/";
                string zw = b.TrimStart(trimStartat.ToCharArray());
                string zw2 = zw.TrimEnd(trimEndat.ToCharArray());
                string zw3 = zw2.TrimStart('/');
                string zw4 = zw3.TrimStart(a1.ToCharArray());
                string zw5 = zw4.TrimStart(a2.ToCharArray());
                links.Add(zw5);
            }
        }

        public void downloadPDF(string quellPfad, string zielPfad)
        {
            string remoteFilename = quellPfad;
            string localFilename = zielPfad;
            if (System.IO.File.Exists(zielPfad) == false)
            {
                WebClient c = new WebClient();
                c.Encoding = Encoding.UTF8;
                c.DownloadFileAsync(new Uri(remoteFilename, UriKind.Absolute), localFilename);
            }
            else
            {
                textBox1.AppendText("File schon vorhanden!");
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
        }

        public void visuLinks()
        {
            textBox1.AppendText("\n");
            textBox1.AppendText("____________________________________________________________________");

            for (int i = 0; i < links.Count; i++)
            {
                textBox1.AppendText("\n");
                textBox1.AppendText(links[i].ToString());
            }
        }

        public string pfad()
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(folderBrowserDialog1.SelectedPath);
                path = folderBrowserDialog1.SelectedPath;
                return folderBrowserDialog1.SelectedPath;
            } else
            {
                return "";
            }
            return "";
        }

        public void ordnerErstell()
        {
            string ordnerTemp;
            for (int i = 0; i < links.Count; i++)
            {
                ordnerTemp = links[i].ToString();
                //MessageBox.Show(ordnerTemp);
                if (ordnerTemp[0] == '1')
                {
                    char[] ordchar = new char[4];
                    for (int a = 0; a < 4; a++)
                    {
                        ordchar[a] = ordnerTemp[a];
                        //MessageBox.Show(ordnerTemp[a].ToString());
                    }
                    string ordstring = ordchar[0].ToString() + ordchar[1].ToString() + ordchar[2].ToString() + ordchar[3].ToString();
                    //MessageBox.Show(ordstring);
                    
                    if (had == 0)
                    {
                        had++;
                        ordner.Add(ordstring);
                    }
                    else
                    {
                        if (ordner[ordner.Count-1].ToString() != ordstring)
                        {
                            ordner.Add(ordstring);
                        }
                    }       
                } else
                {
                    //char[] ordchar = new char["Wirtschaftsinformatik".Count()];
                    //for (int a = 0; a < "Wirtschaftsinformatik".Count(); a++)
                    //{
                    //    ordchar[a] = ordnerTemp[a];
                    //}
                    //string ordstring = ordchar[].ToString() + ordchar[].ToString() + ordchar[].ToString() + ordchar[].ToString();
                    //ordner.Add(ordstring);
                    if (had2 == 0)
                    {
                        ordner.Add("Wirtschaftsinformatik");
                        had2++;
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
