using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class AddFault : MetroFramework.Forms.MetroForm
    {
        private List<Steuerung> clients;
        private Steuerung client;
        private Fehler fault;
        public AddFault()
        {
            InitializeComponent();
        }

        public AddFault(List<Steuerung> liste)
        {
            this.clients = liste;
            InitializeComponent();
            foreach (Steuerung client in clients)
            {
                comboBoxControlls.Items.Add(client.getName());
            }
        }

        private void AddFault_Load(object sender, EventArgs e)
        {
            btnAdd.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Steuerung client in clients)
            {
                Console.WriteLine(client.getName() + " | " + comboBoxControlls.Text);
                if (client.getName().Equals(comboBoxControlls.Text))
                {
                    Console.WriteLine(client.getName());
                    this.client = client;
                }
            }
            if (checkBoxDB.Checked && checkBoxM.Checked)
            {
                MetroFramework.MetroMessageBox.Show(this, "Es können nicht beide Arten aktiv sein");
            }
            else if (checkBoxDB.Checked && client != null)
            {
                Console.WriteLine("Client: " + client.ToString());
                Fehler fehler = new Fehler(client, checkBoxUeberwachung.Checked, Int32.Parse(txtDB.Text), Int32.Parse(txtDBByte.Text), Int32.Parse(txtDBBit.Text), 0, Int32.Parse(txtMerkerByte.Text), Int32.Parse(txtMerkerBit.Text), txtText.Text, txtName.Text, Int32.Parse(txtNummer.Text));
                client.addFehler(fehler);
            }
            else if (checkBoxM.Checked && client != null)
            {
                Fehler fehler = new Fehler(client, checkBoxUeberwachung.Checked, Int32.Parse(txtDB.Text), Int32.Parse(txtDBByte.Text), Int32.Parse(txtDBBit.Text), 1, Int32.Parse(txtMerkerByte.Text), Int32.Parse(txtMerkerBit.Text), txtText.Text, txtName.Text, Int32.Parse(txtNummer.Text));
                client.addFehler(fehler);
            }
            
        }

        public List<Steuerung> Clients
        {
            get { return clients; }
            set { clients = value; }
        }

        public Fehler Fault
        {
            get { return fault; }
            set { fault = value; }
        }

        private void txtMerkerByte_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtMerkerByte.Text))
            {
                txtMerkerByte.Text = "";
            }
        }

        private void txtMerkerBit_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtMerkerBit.Text))
            {
                txtMerkerBit.Text = "";
            }
        }

        private void txtDB_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtDB.Text))
            {
                txtDB.Text = "";
            }
        }

        private void txtDBByte_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtDBByte.Text))
            {
                txtDBByte.Text = "";
            }
        }

        private void txtDBBit_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtDBBit.Text))
            {
                txtDBBit.Text = "";
            }
        }

        private void txtNummer_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtNummer.Text))
            {
                txtNummer.Text = "";
            }
        }
    }
}
