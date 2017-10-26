namespace Kalavale
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddSurvey = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboItemTypeSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblResearchArea = new System.Windows.Forms.Label();
            this.cboResearchAreas = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datan analysointi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddSurvey);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lomakkeiden hallinta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddSurvey
            // 
            this.btnAddSurvey.Location = new System.Drawing.Point(35, 30);
            this.btnAddSurvey.Name = "btnAddSurvey";
            this.btnAddSurvey.Size = new System.Drawing.Size(92, 23);
            this.btnAddSurvey.TabIndex = 0;
            this.btnAddSurvey.Text = "Lisää lomake";
            this.btnAddSurvey.UseVisualStyleBackColor = true;
            this.btnAddSurvey.Click += new System.EventHandler(this.btnAddSurvey_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dgvItems);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(972, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tietokannan Hallinta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lisää";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Muokkaa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Poista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(340, 4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(629, 328);
            this.dgvItems.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboResearchAreas);
            this.panel1.Controls.Add(this.lblResearchArea);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblPostalCode);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.tbPostalCode);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.cboItemTypeSelector);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 328);
            this.panel1.TabIndex = 0;
            // 
            // cboItemTypeSelector
            // 
            this.cboItemTypeSelector.FormattingEnabled = true;
            this.cboItemTypeSelector.Location = new System.Drawing.Point(17, 32);
            this.cboItemTypeSelector.Name = "cboItemTypeSelector";
            this.cboItemTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.cboItemTypeSelector.TabIndex = 1;
            this.cboItemTypeSelector.SelectedIndexChanged += new System.EventHandler(this.cmbDBM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse muokattava";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(17, 129);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(191, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(17, 179);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(191, 20);
            this.tbPostalCode.TabIndex = 4;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(17, 231);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(191, 20);
            this.tbCity.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nimi:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 113);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Osoite:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(17, 163);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(68, 13);
            this.lblPostalCode.TabIndex = 9;
            this.lblPostalCode.Text = "Postinumero:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(17, 215);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "Toimipaikka";
            // 
            // lblResearchArea
            // 
            this.lblResearchArea.AutoSize = true;
            this.lblResearchArea.Location = new System.Drawing.Point(17, 265);
            this.lblResearchArea.Name = "lblResearchArea";
            this.lblResearchArea.Size = new System.Drawing.Size(67, 13);
            this.lblResearchArea.TabIndex = 11;
            this.lblResearchArea.Text = "Kalastusalue";
            // 
            // cboResearchAreas
            // 
            this.cboResearchAreas.FormattingEnabled = true;
            this.cboResearchAreas.Location = new System.Drawing.Point(17, 282);
            this.cboResearchAreas.Name = "cboResearchAreas";
            this.cboResearchAreas.Size = new System.Drawing.Size(191, 21);
            this.cboResearchAreas.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "KalaVale 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvItems;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cboItemTypeSelector;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAddSurvey;
        public System.Windows.Forms.ComboBox cboResearchAreas;
        public System.Windows.Forms.Label lblResearchArea;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblPostalCode;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbCity;
        public System.Windows.Forms.TextBox tbPostalCode;
        public System.Windows.Forms.TextBox tbAddress;
        public System.Windows.Forms.TextBox tbName;
    }
}

