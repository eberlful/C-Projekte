using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netzwerkteilnehmer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string file = @"file.txt";
        public string arg = "arp -a";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Netzwerktool";
            try
            {
                metroLabel5.Text = ARPtheNet();
            } catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }           
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
           
        }

        public static StreamReader ExecuteCommandLine(String file, String arguments = "")
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = file;
            startInfo.Arguments = arguments;

            Process process = Process.Start(startInfo);

            return process.StandardOutput;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string ip = metroTextBox1.Text + "." + metroTextBox2.Text + "." + metroTextBox3.Text + "." + metroTextBox4.Text;
            try
            {
                Ping Sender = new Ping();
                PingReply Result = Sender.Send(ip);
                if (Result.Status == IPStatus.Success)
                {
                    metroLabel4.Text = "Erreichbar";
                }
                else
                {
                    metroLabel4.Text = "Nicht Erreichbar";
                }
            } catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            
        }

        private static string ARPtheNet()
        {
            //this is the process that will run the arp
            Process p = null;

            //this string will capture the output
            string output = string.Empty;

            try
            {
                //to the Process we will give the name of the file (wich is the command we use on the cmd and a string with the particular parameters
                p = Process.Start(new ProcessStartInfo("arp", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                });

                //we store the output into the string
                output = p.StandardOutput.ReadToEnd();

                //then we close te process
                p.Close();
            }
            catch (Exception ex)
            {
                //If something goes wrong we throw a message with the name of the failing component, and the exception itself
                throw new Exception("NetInfo: Error al realizar un ARP a la red", ex);
            }
            finally
            {
                //whether everithing goes right or wrong, we nedd to close the process..
                if (p != null)
                {
                    p.Close();
                }
            }
            return output;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(metroTextBox1.Text))
            {
                metroTextBox1.Text = "";
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(metroTextBox2.Text))
            {
                metroTextBox2.Text = "";
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(metroTextBox3.Text))
            {
                metroTextBox3.Text = "";
            }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(metroTextBox4.Text))
            {
                metroTextBox4.Text = "";
            }
        }
    }
}
