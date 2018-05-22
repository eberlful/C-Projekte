using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceSOFT
{
    public partial class Benutzeranmeldung : MetroFramework.Forms.MetroForm
    {
        public Benutzeranmeldung()
        {
            InitializeComponent();
        }

        private void Benutzeranmeldung_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            if (metroTextBoxBenutzer.Text != "" && metroTextBoxPasswort.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Geben Sie etwas ein");
            }
        }
    }
}
