namespace Kalavale {
    partial class AddSurveyForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.txtSurveyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numQuestionOrderNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.grpQuestionSettings = new System.Windows.Forms.GroupBox();
            this.lbvRowOptions = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbvColumnOptions = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboQuestionTypeSelector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestionTitle = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lbvAddedQuestions = new System.Windows.Forms.ListBox();
            this.btnSaveSurvey = new System.Windows.Forms.Button();
            this.grpQuestions = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionOrderNumber)).BeginInit();
            this.grpQuestionSettings.SuspendLayout();
            this.grpQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpCreationDate);
            this.groupBox1.Controls.Add(this.txtSurveyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perusasetukset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Päivämäärä:";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Location = new System.Drawing.Point(327, 28);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreationDate.TabIndex = 2;
            // 
            // txtSurveyName
            // 
            this.txtSurveyName.Location = new System.Drawing.Point(79, 28);
            this.txtSurveyName.Name = "txtSurveyName";
            this.txtSurveyName.Size = new System.Drawing.Size(154, 20);
            this.txtSurveyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kyselyn nimi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numQuestionOrderNumber);
            this.groupBox2.Controls.Add(this.btnSaveQuestion);
            this.groupBox2.Controls.Add(this.grpQuestionSettings);
            this.groupBox2.Controls.Add(this.cboQuestionTypeSelector);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtQuestionTitle);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 364);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kysymyksen lisäys";
            // 
            // numQuestionOrderNumber
            // 
            this.numQuestionOrderNumber.Location = new System.Drawing.Point(119, 20);
            this.numQuestionOrderNumber.Name = "numQuestionOrderNumber";
            this.numQuestionOrderNumber.Size = new System.Drawing.Size(41, 20);
            this.numQuestionOrderNumber.TabIndex = 9;
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(118, 332);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(101, 22);
            this.btnSaveQuestion.TabIndex = 8;
            this.btnSaveQuestion.Text = "Tallenna kysymys";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // grpQuestionSettings
            // 
            this.grpQuestionSettings.Controls.Add(this.lbvRowOptions);
            this.grpQuestionSettings.Controls.Add(this.label9);
            this.grpQuestionSettings.Controls.Add(this.lbvColumnOptions);
            this.grpQuestionSettings.Controls.Add(this.label8);
            this.grpQuestionSettings.Location = new System.Drawing.Point(9, 135);
            this.grpQuestionSettings.Name = "grpQuestionSettings";
            this.grpQuestionSettings.Size = new System.Drawing.Size(319, 191);
            this.grpQuestionSettings.TabIndex = 7;
            this.grpQuestionSettings.TabStop = false;
            this.grpQuestionSettings.Text = "Monivalinta- ja matriisivaihtoehdot";
            // 
            // lbvRowOptions
            // 
            this.lbvRowOptions.DisplayMember = "nimi";
            this.lbvRowOptions.FormattingEnabled = true;
            this.lbvRowOptions.Location = new System.Drawing.Point(6, 38);
            this.lbvRowOptions.Name = "lbvRowOptions";
            this.lbvRowOptions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbvRowOptions.Size = new System.Drawing.Size(145, 147);
            this.lbvRowOptions.TabIndex = 3;
            this.lbvRowOptions.ValueMember = "id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rivit:";
            // 
            // lbvColumnOptions
            // 
            this.lbvColumnOptions.DisplayMember = "nimi";
            this.lbvColumnOptions.FormattingEnabled = true;
            this.lbvColumnOptions.Location = new System.Drawing.Point(168, 38);
            this.lbvColumnOptions.Name = "lbvColumnOptions";
            this.lbvColumnOptions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbvColumnOptions.Size = new System.Drawing.Size(145, 147);
            this.lbvColumnOptions.TabIndex = 1;
            this.lbvColumnOptions.ValueMember = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sarakkeet:";
            // 
            // cboQuestionTypeSelector
            // 
            this.cboQuestionTypeSelector.DisplayMember = "nimi";
            this.cboQuestionTypeSelector.FormattingEnabled = true;
            this.cboQuestionTypeSelector.Location = new System.Drawing.Point(118, 45);
            this.cboQuestionTypeSelector.Name = "cboQuestionTypeSelector";
            this.cboQuestionTypeSelector.Size = new System.Drawing.Size(210, 21);
            this.cboQuestionTypeSelector.TabIndex = 5;
            this.cboQuestionTypeSelector.ValueMember = "id";
            this.cboQuestionTypeSelector.SelectedIndexChanged += new System.EventHandler(this.cboQuestionTypeSelector_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kysymyksen tyyppi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kysymyksen otsikko:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kysymyksen numero:";
            // 
            // txtQuestionTitle
            // 
            this.txtQuestionTitle.Location = new System.Drawing.Point(118, 72);
            this.txtQuestionTitle.Multiline = true;
            this.txtQuestionTitle.Name = "txtQuestionTitle";
            this.txtQuestionTitle.Size = new System.Drawing.Size(210, 57);
            this.txtQuestionTitle.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Poista valittu kysymys";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbvAddedQuestions
            // 
            this.lbvAddedQuestions.FormattingEnabled = true;
            this.lbvAddedQuestions.Location = new System.Drawing.Point(6, 18);
            this.lbvAddedQuestions.Name = "lbvAddedQuestions";
            this.lbvAddedQuestions.Size = new System.Drawing.Size(188, 303);
            this.lbvAddedQuestions.TabIndex = 11;
            // 
            // btnSaveSurvey
            // 
            this.btnSaveSurvey.Location = new System.Drawing.Point(225, 461);
            this.btnSaveSurvey.Name = "btnSaveSurvey";
            this.btnSaveSurvey.Size = new System.Drawing.Size(125, 37);
            this.btnSaveSurvey.TabIndex = 3;
            this.btnSaveSurvey.Text = "Tallenna kysely";
            this.btnSaveSurvey.UseVisualStyleBackColor = true;
            this.btnSaveSurvey.Click += new System.EventHandler(this.btnSaveSurvey_Click);
            // 
            // grpQuestions
            // 
            this.grpQuestions.Controls.Add(this.button4);
            this.grpQuestions.Controls.Add(this.lbvAddedQuestions);
            this.grpQuestions.Location = new System.Drawing.Point(357, 84);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Size = new System.Drawing.Size(200, 363);
            this.grpQuestions.TabIndex = 4;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "Lisätyt kysymykset";
            // 
            // AddSurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 510);
            this.Controls.Add(this.grpQuestions);
            this.Controls.Add(this.btnSaveSurvey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSurveyForm";
            this.Text = "Kysely";
            this.Load += new System.EventHandler(this.AddSurveyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionOrderNumber)).EndInit();
            this.grpQuestionSettings.ResumeLayout(false);
            this.grpQuestionSettings.PerformLayout();
            this.grpQuestions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSurveyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.GroupBox grpQuestionSettings;
        private System.Windows.Forms.ListBox lbvRowOptions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbvColumnOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboQuestionTypeSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestionTitle;
        private System.Windows.Forms.Button btnSaveSurvey;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbvAddedQuestions;
        private System.Windows.Forms.GroupBox grpQuestions;
        private System.Windows.Forms.NumericUpDown numQuestionOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
    }
}

