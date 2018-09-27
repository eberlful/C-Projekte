﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Analyzer
{
    public partial class FertigungForm : MetroFramework.Forms.MetroForm
    {
        private String name;

        public FertigungForm()
        {
            InitializeComponent();
        }

        private void FertigungForm_Load(object sender, EventArgs e)
        {
            btnAdd.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.name = txtName.Text;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
