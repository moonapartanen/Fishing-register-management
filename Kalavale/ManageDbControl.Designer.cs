namespace Kalavale {
    partial class ManageDbControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboResearchAreas = new System.Windows.Forms.ComboBox();
            this.lblResearchArea = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cboItemTypeSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSurvey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(227, 16);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(338, 428);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cboResearchAreas);
            this.panel1.Controls.Add(this.dgvItems);
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
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 466);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Massalisäys";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Poista";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Tyhjennä  kentät";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboResearchAreas
            // 
            this.cboResearchAreas.FormattingEnabled = true;
            this.cboResearchAreas.Location = new System.Drawing.Point(17, 282);
            this.cboResearchAreas.Name = "cboResearchAreas";
            this.cboResearchAreas.Size = new System.Drawing.Size(191, 21);
            this.cboResearchAreas.TabIndex = 12;
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
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(17, 215);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "Toimipaikka";
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
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 113);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Osoite:";
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
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(17, 231);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(191, 20);
            this.tbCity.TabIndex = 5;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(17, 179);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(191, 20);
            this.tbPostalCode.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(17, 129);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(191, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 20);
            this.tbName.TabIndex = 2;
            // 
            // cboItemTypeSelector
            // 
            this.cboItemTypeSelector.FormattingEnabled = true;
            this.cboItemTypeSelector.Location = new System.Drawing.Point(17, 32);
            this.cboItemTypeSelector.Name = "cboItemTypeSelector";
            this.cboItemTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.cboItemTypeSelector.TabIndex = 1;
            this.cboItemTypeSelector.SelectedIndexChanged += new System.EventHandler(this.cboItemTypeSelector_SelectedIndexChanged);
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
            // btnAddSurvey
            // 
            this.btnAddSurvey.Location = new System.Drawing.Point(0, 0);
            this.btnAddSurvey.Name = "btnAddSurvey";
            this.btnAddSurvey.Size = new System.Drawing.Size(75, 23);
            this.btnAddSurvey.TabIndex = 0;
            // 
            // ManageDbControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageDbControl";
            this.Size = new System.Drawing.Size(594, 473);
            this.Load += new System.EventHandler(this.ManageDbControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboItemTypeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSurvey;
        private System.Windows.Forms.ComboBox cboResearchAreas;
        private System.Windows.Forms.Label lblResearchArea;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}
