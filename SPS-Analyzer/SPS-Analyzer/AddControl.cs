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
    public partial class AddControl : MetroFramework.Forms.MetroForm
    {
        private string ipAdresse;
        private int rack;
        private int slot;
        private String fertigung;
        private String name;
        private bool ueberwachung;
        private int db;
        private int dbByte;
        private int dbBit;
        private List<Fertigung> fertigungList;

        public string IpAdresse
        {
            get { return ipAdresse; }
            set { ipAdresse = value; }
        }

        public int Rack
        {
            get { return rack; }
            set { rack = value; }
        }

        public int Slot
        {
            get { return slot; }
            set { slot = value; }
        }

        public String Fertigung
        {
            get { return fertigung; }
            set { fertigung = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Ueberwachung
        {
            get { return ueberwachung; }
            set { ueberwachung = value; }
        }

        public int Db
        {
            get { return db; }
            set { db = value; }
        }

        public int DbByte
        {
            get { return dbByte; }
            set { dbByte = value; }
        }

        public int DbBit
        {
            get { return dbBit; }
            set { dbBit = value; }
        }

        public AddControl()
        {
            InitializeComponent();
        }

        public AddControl(List<Fertigung> fertigungen)
        {
            this.fertigungList = fertigungen;
            InitializeComponent();
            loadFertigungen();
        }

        private void loadFertigungen()
        {
            foreach (Fertigung item in fertigungList)
            {
                fertigungMenu.Items.Add(item.Name);
            }
        }

        private void AddControl_Load(object sender, EventArgs e)
        {
            btnAdd.DialogResult = DialogResult.OK;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IpAdresse = txtIP.Text;
            Rack = Int32.Parse(txtRack.Text);
            Slot = Int32.Parse(txtSlot.Text);
            Fertigung = fertigungMenu.Text;
            Name = txtName.Text;
            Ueberwachung = checkBoxUeberwachung.Checked;
            Db = Int32.Parse(txtDB.Text);
            DbByte = Int32.Parse(txtByte.Text);
            DbBit = Int32.Parse(txtBit.Text);
        }

        private void btnAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtRack_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtRack.Text))
            {
                txtRack.Text = "";
            }
        }

        private void txtSlot_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtSlot.Text))
            {
                txtSlot.Text = "";
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

        private void txtByte_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtByte.Text))
            {
                txtByte.Text = "";
            }
        }

        private void txtBit_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtBit.Text))
            {
                txtBit.Text = "";
            }
        }
    }
}
