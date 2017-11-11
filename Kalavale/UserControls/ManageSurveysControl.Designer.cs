namespace Kalavale {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbvSurveys = new System.Windows.Forms.ListBox();
            this.btnDeleteSurvey = new System.Windows.Forms.Button();
            this.btnEditSurvey = new System.Windows.Forms.Button();
            this.btnAddSurvey = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboResearchAreaSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddSurveyToRA = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.cboSurveySelector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbvRASurveys = new System.Windows.Forms.ListBox();
            this.btnDeleteSurveyFromRA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(611, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luodut kyselyt";
            // 
            // lbvSurveys
            // 
            this.lbvSurveys.FormattingEnabled = true;
            this.lbvSurveys.Location = new System.Drawing.Point(157, 19);
            this.lbvSurveys.Name = "lbvSurveys";
            this.lbvSurveys.Size = new System.Drawing.Size(448, 186);
            this.lbvSurveys.TabIndex = 3;
            this.lbvSurveys.DisplayMember = "Name";
            this.lbvSurveys.ValueMember = "Id";
            // 
            // btnDeleteSurvey
            // 
            this.btnDeleteSurvey.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSurvey.Location = new System.Drawing.Point(6, 178);
            this.btnDeleteSurvey.Name = "btnDeleteSurvey";
            this.btnDeleteSurvey.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteSurvey.TabIndex = 1;
            this.btnDeleteSurvey.Text = "Poista valittu kysely";
            this.btnDeleteSurvey.UseVisualStyleBackColor = true;
            this.btnDeleteSurvey.Click += new System.EventHandler(this.btnDeleteSurvey_Click);
            // 
            // btnEditSurvey
            // 
            this.btnEditSurvey.Location = new System.Drawing.Point(6, 149);
            this.btnEditSurvey.Name = "btnEditSurvey";
            this.btnEditSurvey.Size = new System.Drawing.Size(144, 23);
            this.btnEditSurvey.TabIndex = 2;
            this.btnEditSurvey.Text = "Muokkaa valittua kyselyä";
            this.btnEditSurvey.UseVisualStyleBackColor = true;
            this.btnEditSurvey.Click += new System.EventHandler(this.btnEditSurvey_Click);
            // 
            // btnAddSurvey
            // 
            this.btnAddSurvey.Location = new System.Drawing.Point(6, 19);
            this.btnAddSurvey.Name = "btnAddSurvey";
            this.btnAddSurvey.Size = new System.Drawing.Size(144, 23);
            this.btnAddSurvey.TabIndex = 1;
            this.btnAddSurvey.Text = "Lisää kysely";
            this.btnAddSurvey.UseVisualStyleBackColor = true;
            this.btnAddSurvey.Click += new System.EventHandler(this.btnAddSurvey_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboResearchAreaSelector);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbvRASurveys);
            this.groupBox2.Controls.Add(this.btnDeleteSurveyFromRA);
            this.groupBox2.Location = new System.Drawing.Point(80, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 255);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tutkimusalueiden kyselyt";
            // 
            // cboResearchAreaSelector
            // 
            this.cboResearchAreaSelector.DisplayMember = "Name";
            this.cboResearchAreaSelector.FormattingEnabled = true;
            this.cboResearchAreaSelector.Location = new System.Drawing.Point(87, 32);
            this.cboResearchAreaSelector.Name = "cboResearchAreaSelector";
            this.cboResearchAreaSelector.Size = new System.Drawing.Size(184, 21);
            this.cboResearchAreaSelector.TabIndex = 6;
            this.cboResearchAreaSelector.ValueMember = "Id";
            this.cboResearchAreaSelector.SelectedIndexChanged += new System.EventHandler(this.cboResearchAreaSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tutkimusalue:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddSurveyToRA);
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.dtpBeginDate);
            this.groupBox3.Controls.Add(this.cboSurveySelector);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 173);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yhdistä kysely valittuun tutkimusalueeseen";
            // 
            // btnAddSurveyToRA
            // 
            this.btnAddSurveyToRA.Location = new System.Drawing.Point(94, 130);
            this.btnAddSurveyToRA.Name = "btnAddSurveyToRA";
            this.btnAddSurveyToRA.Size = new System.Drawing.Size(75, 23);
            this.btnAddSurveyToRA.TabIndex = 13;
            this.btnAddSurveyToRA.Text = "Lisää";
            this.btnAddSurveyToRA.UseVisualStyleBackColor = true;
            this.btnAddSurveyToRA.Click += new System.EventHandler(this.btnAddSurveyToRA_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(81, 79);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(178, 20);
            this.dtpEndDate.TabIndex = 12;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(81, 53);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(178, 20);
            this.dtpBeginDate.TabIndex = 11;
            // 
            // cboSurveySelector
            // 
            this.cboSurveySelector.DisplayMember = "Name";
            this.cboSurveySelector.FormattingEnabled = true;
            this.cboSurveySelector.Location = new System.Drawing.Point(81, 25);
            this.cboSurveySelector.Name = "cboSurveySelector";
            this.cboSurveySelector.Size = new System.Drawing.Size(178, 21);
            this.cboSurveySelector.TabIndex = 10;
            this.cboSurveySelector.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kysely:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loppupvm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alkupvm:";
            // 
            // lbvRASurveys
            // 
            this.lbvRASurveys.DisplayMember = "Name";
            this.lbvRASurveys.FormattingEnabled = true;
            this.lbvRASurveys.Location = new System.Drawing.Point(277, 19);
            this.lbvRASurveys.Name = "lbvRASurveys";
            this.lbvRASurveys.Size = new System.Drawing.Size(184, 199);
            this.lbvRASurveys.TabIndex = 3;
            this.lbvRASurveys.ValueMember = "Id";
            // 
            // btnDeleteSurveyFromRA
            // 
            this.btnDeleteSurveyFromRA.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSurveyFromRA.Location = new System.Drawing.Point(277, 224);
            this.btnDeleteSurveyFromRA.Name = "btnDeleteSurveyFromRA";
            this.btnDeleteSurveyFromRA.Size = new System.Drawing.Size(184, 23);
            this.btnDeleteSurveyFromRA.TabIndex = 1;
            this.btnDeleteSurveyFromRA.Text = "Poista valittu kysely";
            this.btnDeleteSurveyFromRA.UseVisualStyleBackColor = true;
            this.btnDeleteSurveyFromRA.Click += new System.EventHandler(this.btnDeleteSurveyFromRA_Click);
            // 
            // ManageSurveysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSurveysControl";
            this.Size = new System.Drawing.Size(631, 560);
            this.Load += new System.EventHandler(this.ManageSurveysControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteSurvey;
        private System.Windows.Forms.Button btnEditSurvey;
        private System.Windows.Forms.Button btnAddSurvey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboResearchAreaSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddSurveyToRA;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.ComboBox cboSurveySelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbvRASurveys;
        private System.Windows.Forms.Button btnDeleteSurveyFromRA;
        private System.Windows.Forms.ListBox lbvSurveys;
    }
}
