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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSurveys = new System.Windows.Forms.DataGridView();
            this.btnDeleteSurvey = new System.Windows.Forms.Button();
            this.btnEditSurvey = new System.Windows.Forms.Button();
            this.btnAddSurvey = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).BeginInit();
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
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lomakkeiden hallinta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboResearchAreaSelector);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbvRASurveys);
            this.groupBox2.Controls.Add(this.btnDeleteSurveyFromRA);
            this.groupBox2.Location = new System.Drawing.Point(85, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tutkimusalueiden kyselyt";
            // 
            // cboResearchAreaSelector
            // 
            this.cboResearchAreaSelector.DisplayMember = "nimi";
            this.cboResearchAreaSelector.FormattingEnabled = true;
            this.cboResearchAreaSelector.Location = new System.Drawing.Point(87, 32);
            this.cboResearchAreaSelector.Name = "cboResearchAreaSelector";
            this.cboResearchAreaSelector.Size = new System.Drawing.Size(184, 21);
            this.cboResearchAreaSelector.TabIndex = 6;
            this.cboResearchAreaSelector.ValueMember = "id";
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
            this.cboSurveySelector.DisplayMember = "nimi";
            this.cboSurveySelector.FormattingEnabled = true;
            this.cboSurveySelector.Location = new System.Drawing.Point(81, 25);
            this.cboSurveySelector.Name = "cboSurveySelector";
            this.cboSurveySelector.Size = new System.Drawing.Size(178, 21);
            this.cboSurveySelector.TabIndex = 10;
            this.cboSurveySelector.ValueMember = "id";
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
            this.lbvRASurveys.DisplayMember = "nimi";
            this.lbvRASurveys.FormattingEnabled = true;
            this.lbvRASurveys.Location = new System.Drawing.Point(277, 19);
            this.lbvRASurveys.Name = "lbvRASurveys";
            this.lbvRASurveys.Size = new System.Drawing.Size(184, 199);
            this.lbvRASurveys.TabIndex = 3;
            this.lbvRASurveys.ValueMember = "id";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSurveys);
            this.groupBox1.Controls.Add(this.btnDeleteSurvey);
            this.groupBox1.Controls.Add(this.btnEditSurvey);
            this.groupBox1.Controls.Add(this.btnAddSurvey);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luodut kyselyt";
            // 
            // dgvSurveys
            // 
            this.dgvSurveys.AllowUserToAddRows = false;
            this.dgvSurveys.AllowUserToDeleteRows = false;
            this.dgvSurveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurveys.Location = new System.Drawing.Point(156, 16);
            this.dgvSurveys.Name = "dgvSurveys";
            this.dgvSurveys.ReadOnly = true;
            this.dgvSurveys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSurveys.Size = new System.Drawing.Size(446, 185);
            this.dgvSurveys.TabIndex = 3;
            this.dgvSurveys.SelectionChanged += new System.EventHandler(this.dgvSurveys_SelectionChanged);
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
            // 
            // btnEditSurvey
            // 
            this.btnEditSurvey.Location = new System.Drawing.Point(6, 149);
            this.btnEditSurvey.Name = "btnEditSurvey";
            this.btnEditSurvey.Size = new System.Drawing.Size(144, 23);
            this.btnEditSurvey.TabIndex = 2;
            this.btnEditSurvey.Text = "Muokkaa valittua kyselyä";
            this.btnEditSurvey.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(972, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tietokannan Hallinta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "KalaVale 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.DataGridView dgvSurveys;
    }
}

