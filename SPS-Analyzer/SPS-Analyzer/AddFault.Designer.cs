namespace SPS_Analyzer
{
    partial class AddFault
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtText = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxDB = new System.Windows.Forms.CheckBox();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.txtDB = new MetroFramework.Controls.MetroTextBox();
            this.txtNummer = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxControlls = new System.Windows.Forms.ComboBox();
            this.txtDBByte = new MetroFramework.Controls.MetroTextBox();
            this.txtDBBit = new MetroFramework.Controls.MetroTextBox();
            this.txtMerkerByte = new MetroFramework.Controls.MetroTextBox();
            this.txtMerkerBit = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxUeberwachung = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(289, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Fehlername:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Fehlertext:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "Fehlerart:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(26, 19);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "DB";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(190, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = ".DBX";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 184);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Steuerung:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(5, 213);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(99, 19);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Fehlernummer:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(262, 123);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(21, 19);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "M";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(110, 60);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(271, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtText
            // 
            // 
            // 
            // 
            this.txtText.CustomButton.Image = null;
            this.txtText.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txtText.CustomButton.Name = "";
            this.txtText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtText.CustomButton.TabIndex = 1;
            this.txtText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtText.CustomButton.UseSelectable = true;
            this.txtText.CustomButton.Visible = false;
            this.txtText.Lines = new string[0];
            this.txtText.Location = new System.Drawing.Point(110, 89);
            this.txtText.MaxLength = 32767;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.ShortcutsEnabled = true;
            this.txtText.Size = new System.Drawing.Size(271, 23);
            this.txtText.TabIndex = 1;
            this.txtText.UseSelectable = true;
            this.txtText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBoxDB
            // 
            this.checkBoxDB.AutoSize = true;
            this.checkBoxDB.Location = new System.Drawing.Point(121, 123);
            this.checkBoxDB.Name = "checkBoxDB";
            this.checkBoxDB.Size = new System.Drawing.Size(66, 17);
            this.checkBoxDB.TabIndex = 50;
            this.checkBoxDB.Text = "Datenbit";
            this.checkBoxDB.UseVisualStyleBackColor = true;
            this.checkBoxDB.CheckedChanged += new System.EventHandler(this.checkBoxDB_CheckedChanged);
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(193, 123);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(59, 17);
            this.checkBoxM.TabIndex = 51;
            this.checkBoxM.Text = "Merker";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // txtDB
            // 
            // 
            // 
            // 
            this.txtDB.CustomButton.Image = null;
            this.txtDB.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.txtDB.CustomButton.Name = "";
            this.txtDB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDB.CustomButton.TabIndex = 1;
            this.txtDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDB.CustomButton.UseSelectable = true;
            this.txtDB.CustomButton.Visible = false;
            this.txtDB.Lines = new string[0];
            this.txtDB.Location = new System.Drawing.Point(110, 151);
            this.txtDB.MaxLength = 32767;
            this.txtDB.Name = "txtDB";
            this.txtDB.PasswordChar = '\0';
            this.txtDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDB.SelectedText = "";
            this.txtDB.SelectionLength = 0;
            this.txtDB.SelectionStart = 0;
            this.txtDB.ShortcutsEnabled = true;
            this.txtDB.Size = new System.Drawing.Size(77, 23);
            this.txtDB.TabIndex = 4;
            this.txtDB.UseSelectable = true;
            this.txtDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDB.TextChanged += new System.EventHandler(this.txtDB_TextChanged);
            // 
            // txtNummer
            // 
            // 
            // 
            // 
            this.txtNummer.CustomButton.Image = null;
            this.txtNummer.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txtNummer.CustomButton.Name = "";
            this.txtNummer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNummer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNummer.CustomButton.TabIndex = 1;
            this.txtNummer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNummer.CustomButton.UseSelectable = true;
            this.txtNummer.CustomButton.Visible = false;
            this.txtNummer.Lines = new string[0];
            this.txtNummer.Location = new System.Drawing.Point(110, 209);
            this.txtNummer.MaxLength = 32767;
            this.txtNummer.Name = "txtNummer";
            this.txtNummer.PasswordChar = '\0';
            this.txtNummer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNummer.SelectedText = "";
            this.txtNummer.SelectionLength = 0;
            this.txtNummer.SelectionStart = 0;
            this.txtNummer.ShortcutsEnabled = true;
            this.txtNummer.Size = new System.Drawing.Size(271, 23);
            this.txtNummer.TabIndex = 8;
            this.txtNummer.UseSelectable = true;
            this.txtNummer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNummer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNummer.TextChanged += new System.EventHandler(this.txtNummer_TextChanged);
            // 
            // comboBoxControlls
            // 
            this.comboBoxControlls.FormattingEnabled = true;
            this.comboBoxControlls.Location = new System.Drawing.Point(110, 182);
            this.comboBoxControlls.Name = "comboBoxControlls";
            this.comboBoxControlls.Size = new System.Drawing.Size(271, 21);
            this.comboBoxControlls.TabIndex = 7;
            // 
            // txtDBByte
            // 
            // 
            // 
            // 
            this.txtDBByte.CustomButton.Image = null;
            this.txtDBByte.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.txtDBByte.CustomButton.Name = "";
            this.txtDBByte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBByte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBByte.CustomButton.TabIndex = 1;
            this.txtDBByte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBByte.CustomButton.UseSelectable = true;
            this.txtDBByte.CustomButton.Visible = false;
            this.txtDBByte.Lines = new string[0];
            this.txtDBByte.Location = new System.Drawing.Point(229, 151);
            this.txtDBByte.MaxLength = 32767;
            this.txtDBByte.Name = "txtDBByte";
            this.txtDBByte.PasswordChar = '\0';
            this.txtDBByte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBByte.SelectedText = "";
            this.txtDBByte.SelectionLength = 0;
            this.txtDBByte.SelectionStart = 0;
            this.txtDBByte.ShortcutsEnabled = true;
            this.txtDBByte.Size = new System.Drawing.Size(54, 23);
            this.txtDBByte.TabIndex = 5;
            this.txtDBByte.UseSelectable = true;
            this.txtDBByte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBByte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDBByte.TextChanged += new System.EventHandler(this.txtDBByte_TextChanged);
            // 
            // txtDBBit
            // 
            // 
            // 
            // 
            this.txtDBBit.CustomButton.Image = null;
            this.txtDBBit.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.txtDBBit.CustomButton.Name = "";
            this.txtDBBit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBBit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBBit.CustomButton.TabIndex = 1;
            this.txtDBBit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBBit.CustomButton.UseSelectable = true;
            this.txtDBBit.CustomButton.Visible = false;
            this.txtDBBit.Lines = new string[0];
            this.txtDBBit.Location = new System.Drawing.Point(289, 151);
            this.txtDBBit.MaxLength = 32767;
            this.txtDBBit.Name = "txtDBBit";
            this.txtDBBit.PasswordChar = '\0';
            this.txtDBBit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBBit.SelectedText = "";
            this.txtDBBit.SelectionLength = 0;
            this.txtDBBit.SelectionStart = 0;
            this.txtDBBit.ShortcutsEnabled = true;
            this.txtDBBit.Size = new System.Drawing.Size(35, 23);
            this.txtDBBit.TabIndex = 6;
            this.txtDBBit.UseSelectable = true;
            this.txtDBBit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBBit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDBBit.TextChanged += new System.EventHandler(this.txtDBBit_TextChanged);
            // 
            // txtMerkerByte
            // 
            // 
            // 
            // 
            this.txtMerkerByte.CustomButton.Image = null;
            this.txtMerkerByte.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.txtMerkerByte.CustomButton.Name = "";
            this.txtMerkerByte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMerkerByte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMerkerByte.CustomButton.TabIndex = 1;
            this.txtMerkerByte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMerkerByte.CustomButton.UseSelectable = true;
            this.txtMerkerByte.CustomButton.Visible = false;
            this.txtMerkerByte.Lines = new string[0];
            this.txtMerkerByte.Location = new System.Drawing.Point(289, 119);
            this.txtMerkerByte.MaxLength = 32767;
            this.txtMerkerByte.Name = "txtMerkerByte";
            this.txtMerkerByte.PasswordChar = '\0';
            this.txtMerkerByte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMerkerByte.SelectedText = "";
            this.txtMerkerByte.SelectionLength = 0;
            this.txtMerkerByte.SelectionStart = 0;
            this.txtMerkerByte.ShortcutsEnabled = true;
            this.txtMerkerByte.Size = new System.Drawing.Size(54, 23);
            this.txtMerkerByte.TabIndex = 2;
            this.txtMerkerByte.UseSelectable = true;
            this.txtMerkerByte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMerkerByte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMerkerByte.TextChanged += new System.EventHandler(this.txtMerkerByte_TextChanged);
            // 
            // txtMerkerBit
            // 
            // 
            // 
            // 
            this.txtMerkerBit.CustomButton.Image = null;
            this.txtMerkerBit.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.txtMerkerBit.CustomButton.Name = "";
            this.txtMerkerBit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMerkerBit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMerkerBit.CustomButton.TabIndex = 1;
            this.txtMerkerBit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMerkerBit.CustomButton.UseSelectable = true;
            this.txtMerkerBit.CustomButton.Visible = false;
            this.txtMerkerBit.Lines = new string[0];
            this.txtMerkerBit.Location = new System.Drawing.Point(346, 119);
            this.txtMerkerBit.MaxLength = 32767;
            this.txtMerkerBit.Name = "txtMerkerBit";
            this.txtMerkerBit.PasswordChar = '\0';
            this.txtMerkerBit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMerkerBit.SelectedText = "";
            this.txtMerkerBit.SelectionLength = 0;
            this.txtMerkerBit.SelectionStart = 0;
            this.txtMerkerBit.ShortcutsEnabled = true;
            this.txtMerkerBit.Size = new System.Drawing.Size(35, 23);
            this.txtMerkerBit.TabIndex = 3;
            this.txtMerkerBit.UseSelectable = true;
            this.txtMerkerBit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMerkerBit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMerkerBit.TextChanged += new System.EventHandler(this.txtMerkerBit_TextChanged);
            // 
            // checkBoxUeberwachung
            // 
            this.checkBoxUeberwachung.AutoSize = true;
            this.checkBoxUeberwachung.Location = new System.Drawing.Point(121, 238);
            this.checkBoxUeberwachung.Name = "checkBoxUeberwachung";
            this.checkBoxUeberwachung.Size = new System.Drawing.Size(93, 17);
            this.checkBoxUeberwachung.TabIndex = 59;
            this.checkBoxUeberwachung.Text = "Überwachung";
            this.checkBoxUeberwachung.UseVisualStyleBackColor = true;
            // 
            // AddFault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 292);
            this.Controls.Add(this.checkBoxUeberwachung);
            this.Controls.Add(this.txtMerkerBit);
            this.Controls.Add(this.txtMerkerByte);
            this.Controls.Add(this.txtDBBit);
            this.Controls.Add(this.txtDBByte);
            this.Controls.Add(this.comboBoxControlls);
            this.Controls.Add(this.txtNummer);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.checkBoxDB);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddFault";
            this.Text = "Neuer Fehler";
            this.Load += new System.EventHandler(this.AddFault_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtText;
        private System.Windows.Forms.CheckBox checkBoxDB;
        private System.Windows.Forms.CheckBox checkBoxM;
        private MetroFramework.Controls.MetroTextBox txtDB;
        private MetroFramework.Controls.MetroTextBox txtNummer;
        private System.Windows.Forms.ComboBox comboBoxControlls;
        private MetroFramework.Controls.MetroTextBox txtDBByte;
        private MetroFramework.Controls.MetroTextBox txtDBBit;
        private MetroFramework.Controls.MetroTextBox txtMerkerByte;
        private MetroFramework.Controls.MetroTextBox txtMerkerBit;
        private System.Windows.Forms.CheckBox checkBoxUeberwachung;
    }
}