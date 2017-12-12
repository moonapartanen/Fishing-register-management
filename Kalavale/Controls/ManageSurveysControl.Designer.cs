namespace Kalavale.Controls {
    partial class ManageSurveysControl {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSurveysControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbvSurveys = new System.Windows.Forms.ListBox();
            this.btnDeleteSurvey = new System.Windows.Forms.Button();
            this.btnEditSurvey = new System.Windows.Forms.Button();
            this.btnAddSurvey = new System.Windows.Forms.Button();
            this.grpConnectSurvey = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboWaterSystem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboResearchArea = new System.Windows.Forms.ComboBox();
            this.btnAddSurveyToResearchArea = new System.Windows.Forms.Button();
            this.lbvResearchAreaSurveys = new System.Windows.Forms.ListBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSurveySelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteSurveyFromRA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grpConnectSurvey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbvSurveys);
            this.groupBox1.Controls.Add(this.btnDeleteSurvey);
            this.groupBox1.Controls.Add(this.btnEditSurvey);
            this.groupBox1.Controls.Add(this.btnAddSurvey);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luodut kyselyt";
            // 
            // lbvSurveys
            // 
            this.lbvSurveys.DisplayMember = "Name";
            this.lbvSurveys.FormattingEnabled = true;
            this.lbvSurveys.Location = new System.Drawing.Point(7, 13);
            this.lbvSurveys.Name = "lbvSurveys";
            this.lbvSurveys.Size = new System.Drawing.Size(360, 303);
            this.lbvSurveys.TabIndex = 3;
            this.lbvSurveys.ValueMember = "Id";
            // 
            // btnDeleteSurvey
            // 
            this.btnDeleteSurvey.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSurvey.Location = new System.Drawing.Point(250, 322);
            this.btnDeleteSurvey.Name = "btnDeleteSurvey";
            this.btnDeleteSurvey.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteSurvey.TabIndex = 1;
            this.btnDeleteSurvey.Text = "Poista valittu";
            this.btnDeleteSurvey.UseVisualStyleBackColor = true;
            this.btnDeleteSurvey.Click += new System.EventHandler(this.btnDeleteSurvey_Click);
            // 
            // btnEditSurvey
            // 
            this.btnEditSurvey.Location = new System.Drawing.Point(128, 322);
            this.btnEditSurvey.Name = "btnEditSurvey";
            this.btnEditSurvey.Size = new System.Drawing.Size(116, 23);
            this.btnEditSurvey.TabIndex = 2;
            this.btnEditSurvey.Text = "Muokkaa valittua";
            this.btnEditSurvey.UseVisualStyleBackColor = true;
            this.btnEditSurvey.Click += new System.EventHandler(this.btnEditSurvey_Click);
            // 
            // btnAddSurvey
            // 
            this.btnAddSurvey.Location = new System.Drawing.Point(6, 322);
            this.btnAddSurvey.Name = "btnAddSurvey";
            this.btnAddSurvey.Size = new System.Drawing.Size(116, 23);
            this.btnAddSurvey.TabIndex = 1;
            this.btnAddSurvey.Text = "Lisää kysely";
            this.btnAddSurvey.UseVisualStyleBackColor = true;
            this.btnAddSurvey.Click += new System.EventHandler(this.btnAddSurvey_Click);
            // 
            // grpConnectSurvey
            // 
            this.grpConnectSurvey.Controls.Add(this.label5);
            this.grpConnectSurvey.Controls.Add(this.cboWaterSystem);
            this.grpConnectSurvey.Controls.Add(this.label1);
            this.grpConnectSurvey.Controls.Add(this.cboResearchArea);
            this.grpConnectSurvey.Controls.Add(this.btnAddSurveyToResearchArea);
            this.grpConnectSurvey.Controls.Add(this.lbvResearchAreaSurveys);
            this.grpConnectSurvey.Controls.Add(this.dtpEndDate);
            this.grpConnectSurvey.Controls.Add(this.label4);
            this.grpConnectSurvey.Controls.Add(this.cboSurveySelector);
            this.grpConnectSurvey.Controls.Add(this.label2);
            this.grpConnectSurvey.Controls.Add(this.dtpStartDate);
            this.grpConnectSurvey.Controls.Add(this.btnDeleteSurveyFromRA);
            this.grpConnectSurvey.Controls.Add(this.label3);
            this.grpConnectSurvey.Location = new System.Drawing.Point(379, 3);
            this.grpConnectSurvey.Name = "grpConnectSurvey";
            this.grpConnectSurvey.Size = new System.Drawing.Size(423, 351);
            this.grpConnectSurvey.TabIndex = 5;
            this.grpConnectSurvey.TabStop = false;
            this.grpConnectSurvey.Text = "Kyselyiden yhdistäminen ja poisto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vesistö:";
            // 
            // cboWaterSystem
            // 
            this.cboWaterSystem.DisplayMember = "Name";
            this.cboWaterSystem.FormattingEnabled = true;
            this.cboWaterSystem.Location = new System.Drawing.Point(95, 22);
            this.cboWaterSystem.Name = "cboWaterSystem";
            this.cboWaterSystem.Size = new System.Drawing.Size(193, 21);
            this.cboWaterSystem.TabIndex = 7;
            this.cboWaterSystem.ValueMember = "Id";
            this.cboWaterSystem.SelectedIndexChanged += new System.EventHandler(this.cboWaterSystem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tutkimusalue:";
            // 
            // cboResearchArea
            // 
            this.cboResearchArea.DisplayMember = "Name";
            this.cboResearchArea.FormattingEnabled = true;
            this.cboResearchArea.Location = new System.Drawing.Point(95, 49);
            this.cboResearchArea.Name = "cboResearchArea";
            this.cboResearchArea.Size = new System.Drawing.Size(193, 21);
            this.cboResearchArea.TabIndex = 6;
            this.cboResearchArea.ValueMember = "Id";
            this.cboResearchArea.SelectedIndexChanged += new System.EventHandler(this.cboResearchArea_SelectedIndexChanged);
            // 
            // btnAddSurveyToResearchArea
            // 
            this.btnAddSurveyToResearchArea.Location = new System.Drawing.Point(6, 322);
            this.btnAddSurveyToResearchArea.Name = "btnAddSurveyToResearchArea";
            this.btnAddSurveyToResearchArea.Size = new System.Drawing.Size(75, 23);
            this.btnAddSurveyToResearchArea.TabIndex = 13;
            this.btnAddSurveyToResearchArea.Text = "Lisää";
            this.btnAddSurveyToResearchArea.UseVisualStyleBackColor = true;
            this.btnAddSurveyToResearchArea.Click += new System.EventHandler(this.btnAddSurveyToResearchArea_Click);
            // 
            // lbvResearchAreaSurveys
            // 
            this.lbvResearchAreaSurveys.DisplayMember = "Name";
            this.lbvResearchAreaSurveys.FormattingEnabled = true;
            this.lbvResearchAreaSurveys.Location = new System.Drawing.Point(6, 156);
            this.lbvResearchAreaSurveys.Name = "lbvResearchAreaSurveys";
            this.lbvResearchAreaSurveys.Size = new System.Drawing.Size(411, 160);
            this.lbvResearchAreaSurveys.TabIndex = 3;
            this.lbvResearchAreaSurveys.ValueMember = "KyselyId";
            // 
            // dtpEndDate
            // 
            this.errorProvider.SetIconPadding(this.dtpEndDate, 5);
            this.dtpEndDate.Location = new System.Drawing.Point(95, 129);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(193, 20);
            this.dtpEndDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kysely:";
            // 
            // cboSurveySelector
            // 
            this.cboSurveySelector.DisplayMember = "Name";
            this.cboSurveySelector.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cboSurveySelector, 5);
            this.cboSurveySelector.Location = new System.Drawing.Point(95, 76);
            this.cboSurveySelector.Name = "cboSurveySelector";
            this.cboSurveySelector.Size = new System.Drawing.Size(193, 21);
            this.cboSurveySelector.TabIndex = 10;
            this.cboSurveySelector.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alkupvm:";
            // 
            // dtpStartDate
            // 
            this.errorProvider.SetIconPadding(this.dtpStartDate, 5);
            this.dtpStartDate.Location = new System.Drawing.Point(95, 103);
            this.dtpStartDate.MinDate = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(193, 20);
            this.dtpStartDate.TabIndex = 11;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // btnDeleteSurveyFromRA
            // 
            this.btnDeleteSurveyFromRA.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSurveyFromRA.Location = new System.Drawing.Point(87, 322);
            this.btnDeleteSurveyFromRA.Name = "btnDeleteSurveyFromRA";
            this.btnDeleteSurveyFromRA.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSurveyFromRA.TabIndex = 1;
            this.btnDeleteSurveyFromRA.Text = "Poista";
            this.btnDeleteSurveyFromRA.UseVisualStyleBackColor = true;
            this.btnDeleteSurveyFromRA.Click += new System.EventHandler(this.btnDeleteSurveyFromResearchArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loppupvm:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // ManageSurveysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpConnectSurvey);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSurveysControl";
            this.Size = new System.Drawing.Size(805, 357);
            this.Load += new System.EventHandler(this.ManageSurveysControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpConnectSurvey.ResumeLayout(false);
            this.grpConnectSurvey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteSurvey;
        private System.Windows.Forms.Button btnEditSurvey;
        private System.Windows.Forms.Button btnAddSurvey;
        private System.Windows.Forms.GroupBox grpConnectSurvey;
        private System.Windows.Forms.ComboBox cboResearchArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSurveyToResearchArea;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboSurveySelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbvResearchAreaSurveys;
        private System.Windows.Forms.Button btnDeleteSurveyFromRA;
        private System.Windows.Forms.ListBox lbvSurveys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboWaterSystem;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
