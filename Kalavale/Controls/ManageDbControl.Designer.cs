namespace Kalavale.Controls {
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
            this.cbEditItem = new System.Windows.Forms.CheckBox();
            this.pnResearchAreaLayout = new System.Windows.Forms.Panel();
            this.cboResearchAreaWaterSystem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnUserLayout = new System.Windows.Forms.Panel();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.tbUserKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboUserResearchArea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUserCity = new System.Windows.Forms.TextBox();
            this.tbUserAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUserZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnFishingAreaLayout = new System.Windows.Forms.Panel();
            this.cboFishingAreaResearchArea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.cboItemTypeSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSurvey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnResearchAreaLayout.SuspendLayout();
            this.pnUserLayout.SuspendLayout();
            this.pnFishingAreaLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(268, 16);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(507, 287);
            this.dgvItems.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnUserLayout);
            this.panel1.Controls.Add(this.cbEditItem);
            this.panel1.Controls.Add(this.pnResearchAreaLayout);
            this.panel1.Controls.Add(this.pnFishingAreaLayout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbItemName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAbort);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Controls.Add(this.cboItemTypeSelector);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 415);
            this.panel1.TabIndex = 0;
            // 
            // cbEditItem
            // 
            this.cbEditItem.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEditItem.AutoSize = true;
            this.cbEditItem.Location = new System.Drawing.Point(268, 309);
            this.cbEditItem.Name = "cbEditItem";
            this.cbEditItem.Size = new System.Drawing.Size(62, 23);
            this.cbEditItem.TabIndex = 17;
            this.cbEditItem.Text = "Muokkaa";
            this.cbEditItem.UseVisualStyleBackColor = true;
            this.cbEditItem.Click += new System.EventHandler(this.cbEditItem_Click);
            // 
            // pnResearchAreaLayout
            // 
            this.pnResearchAreaLayout.Controls.Add(this.cboResearchAreaWaterSystem);
            this.pnResearchAreaLayout.Controls.Add(this.label3);
            this.pnResearchAreaLayout.Location = new System.Drawing.Point(15, 89);
            this.pnResearchAreaLayout.Name = "pnResearchAreaLayout";
            this.pnResearchAreaLayout.Size = new System.Drawing.Size(192, 192);
            this.pnResearchAreaLayout.TabIndex = 4;
            this.pnResearchAreaLayout.Visible = false;
            // 
            // cboResearchAreaWaterSystem
            // 
            this.cboResearchAreaWaterSystem.DisplayMember = "Name";
            this.cboResearchAreaWaterSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResearchAreaWaterSystem.FormattingEnabled = true;
            this.cboResearchAreaWaterSystem.Location = new System.Drawing.Point(0, 16);
            this.cboResearchAreaWaterSystem.Name = "cboResearchAreaWaterSystem";
            this.cboResearchAreaWaterSystem.Size = new System.Drawing.Size(171, 21);
            this.cboResearchAreaWaterSystem.TabIndex = 3;
            this.cboResearchAreaWaterSystem.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vesistö:";
            // 
            // pnUserLayout
            // 
            this.pnUserLayout.Controls.Add(this.btnGenerateKey);
            this.pnUserLayout.Controls.Add(this.tbUserKey);
            this.pnUserLayout.Controls.Add(this.label9);
            this.pnUserLayout.Controls.Add(this.cboUserResearchArea);
            this.pnUserLayout.Controls.Add(this.label8);
            this.pnUserLayout.Controls.Add(this.tbUserCity);
            this.pnUserLayout.Controls.Add(this.tbUserAddress);
            this.pnUserLayout.Controls.Add(this.label7);
            this.pnUserLayout.Controls.Add(this.tbUserZip);
            this.pnUserLayout.Controls.Add(this.label6);
            this.pnUserLayout.Controls.Add(this.label5);
            this.pnUserLayout.Location = new System.Drawing.Point(15, 89);
            this.pnUserLayout.Name = "pnUserLayout";
            this.pnUserLayout.Size = new System.Drawing.Size(192, 214);
            this.pnUserLayout.TabIndex = 5;
            this.pnUserLayout.Visible = false;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(131, 182);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(40, 23);
            this.btnGenerateKey.TabIndex = 13;
            this.btnGenerateKey.Text = "Luo";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // tbUserKey
            // 
            this.tbUserKey.Enabled = false;
            this.tbUserKey.Location = new System.Drawing.Point(0, 184);
            this.tbUserKey.Name = "tbUserKey";
            this.tbUserKey.Size = new System.Drawing.Size(125, 20);
            this.tbUserKey.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Avain:";
            // 
            // cboUserResearchArea
            // 
            this.cboUserResearchArea.DisplayMember = "Name";
            this.cboUserResearchArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserResearchArea.FormattingEnabled = true;
            this.cboUserResearchArea.Location = new System.Drawing.Point(0, 139);
            this.cboUserResearchArea.Name = "cboUserResearchArea";
            this.cboUserResearchArea.Size = new System.Drawing.Size(171, 21);
            this.cboUserResearchArea.TabIndex = 10;
            this.cboUserResearchArea.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tutkimusalue:";
            // 
            // tbUserCity
            // 
            this.tbUserCity.Location = new System.Drawing.Point(0, 95);
            this.tbUserCity.Name = "tbUserCity";
            this.tbUserCity.Size = new System.Drawing.Size(171, 20);
            this.tbUserCity.TabIndex = 8;
            // 
            // tbUserAddress
            // 
            this.tbUserAddress.Location = new System.Drawing.Point(0, 16);
            this.tbUserAddress.Name = "tbUserAddress";
            this.tbUserAddress.Size = new System.Drawing.Size(171, 20);
            this.tbUserAddress.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toimipaikka:";
            // 
            // tbUserZip
            // 
            this.tbUserZip.Location = new System.Drawing.Point(0, 55);
            this.tbUserZip.Name = "tbUserZip";
            this.tbUserZip.Size = new System.Drawing.Size(171, 20);
            this.tbUserZip.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Postinumero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Osoite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nimi:";
            // 
            // pnFishingAreaLayout
            // 
            this.pnFishingAreaLayout.Controls.Add(this.cboFishingAreaResearchArea);
            this.pnFishingAreaLayout.Controls.Add(this.label4);
            this.pnFishingAreaLayout.Location = new System.Drawing.Point(15, 89);
            this.pnFishingAreaLayout.Name = "pnFishingAreaLayout";
            this.pnFishingAreaLayout.Size = new System.Drawing.Size(192, 192);
            this.pnFishingAreaLayout.TabIndex = 1;
            this.pnFishingAreaLayout.Visible = false;
            // 
            // cboFishingAreaResearchArea
            // 
            this.cboFishingAreaResearchArea.DisplayMember = "Name";
            this.cboFishingAreaResearchArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFishingAreaResearchArea.FormattingEnabled = true;
            this.cboFishingAreaResearchArea.Location = new System.Drawing.Point(0, 16);
            this.cboFishingAreaResearchArea.Name = "cboFishingAreaResearchArea";
            this.cboFishingAreaResearchArea.Size = new System.Drawing.Size(171, 21);
            this.cboFishingAreaResearchArea.TabIndex = 3;
            this.cboFishingAreaResearchArea.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tutkimusalue:";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(15, 63);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(171, 20);
            this.tbItemName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(700, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Massalisäys";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Poista";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(111, 309);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 13;
            this.btnAbort.Text = "Keskeytä";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // cboItemTypeSelector
            // 
            this.cboItemTypeSelector.FormattingEnabled = true;
            this.cboItemTypeSelector.Location = new System.Drawing.Point(106, 16);
            this.cboItemTypeSelector.Name = "cboItemTypeSelector";
            this.cboItemTypeSelector.Size = new System.Drawing.Size(156, 21);
            this.cboItemTypeSelector.TabIndex = 1;
            this.cboItemTypeSelector.SelectedIndexChanged += new System.EventHandler(this.cboItemTypeSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse muokattava:";
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
            this.Size = new System.Drawing.Size(829, 494);
            this.Load += new System.EventHandler(this.ManageDbControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnResearchAreaLayout.ResumeLayout(false);
            this.pnResearchAreaLayout.PerformLayout();
            this.pnUserLayout.ResumeLayout(false);
            this.pnUserLayout.PerformLayout();
            this.pnFishingAreaLayout.ResumeLayout(false);
            this.pnFishingAreaLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboItemTypeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSurvey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnFishingAreaLayout;
        private System.Windows.Forms.ComboBox cboFishingAreaResearchArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Panel pnResearchAreaLayout;
        private System.Windows.Forms.ComboBox cboResearchAreaWaterSystem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnUserLayout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUserCity;
        private System.Windows.Forms.TextBox tbUserAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUserZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboUserResearchArea;
        private System.Windows.Forms.CheckBox cbEditItem;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox tbUserKey;
        private System.Windows.Forms.Label label9;
    }
}
