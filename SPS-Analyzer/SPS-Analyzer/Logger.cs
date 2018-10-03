using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Analyzer
{
    public class Logger
    {
        /*
         * Logger Klasse, die als Instanz oder auch als Klasse verwendet werden kann
         */
        private String pfad;
        private static String pfadStatic;
        private System.Windows.Forms.IWin32Window frame;
        private static System.Windows.Forms.IWin32Window frameStatic;
        private StreamWriter writer;
        private static StreamWriter writerStatic;
        public Logger(String pfad, System.Windows.Forms.IWin32Window frame)
        {
            try
            {
                this.pfad = pfad;
                this.frame = frame;
                if (!File.Exists(pfad))
                {
                    File.Create(pfad);
                }
                writer = new StreamWriter(this.pfad);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(frame, ex.Message + "\n" + ex.StackTrace, "Logger-Fehler", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        public static void startLadder(String pfad, System.Windows.Forms.IWin32Window frame)
        {
            try
            {
                Logger.pfadStatic = pfad;
                Logger.frameStatic = frame;
                if (!File.Exists(pfadStatic))
                {
                    File.Create(pfadStatic);
                }
                writerStatic = new StreamWriter(Logger.pfadStatic);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(frameStatic, ex.Message + "\n" + ex.StackTrace, "Logger-Fehler", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        public void close()
        {
            writer.Close();
        }

        public static void closeStatic()
        {
            try
            {
                writerStatic.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(frameStatic, ex.Message + "\n" + ex.StackTrace, "Fehler Logger");
            }
            
        }

        public void write(String text)
        {
            writer = File.AppendText(text);
        }

        public static void writeStatic(String text)
        {
            try
            {
                writerStatic = File.AppendText(text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(frameStatic, ex.Message + "\n" + ex.StackTrace, "Fehler Logger");
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
