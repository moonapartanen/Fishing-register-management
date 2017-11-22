namespace Kalavale.Forms {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSurveyForm));
            this.grpBasicSettings = new System.Windows.Forms.GroupBox();
            this.txtSurveyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAddQuestion = new System.Windows.Forms.GroupBox();
            this.btnAbortQuestion = new System.Windows.Forms.Button();
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
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnAbortSurvey = new System.Windows.Forms.Button();
            this.errColOptions = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSurveyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBasicSettings.SuspendLayout();
            this.grpAddQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionOrderNumber)).BeginInit();
            this.grpQuestionSettings.SuspendLayout();
            this.grpQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errColOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSurveyName)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBasicSettings
            // 
            this.grpBasicSettings.Controls.Add(this.txtSurveyName);
            this.grpBasicSettings.Controls.Add(this.label1);
            this.grpBasicSettings.Location = new System.Drawing.Point(12, 12);
            this.grpBasicSettings.Name = "grpBasicSettings";
            this.grpBasicSettings.Size = new System.Drawing.Size(338, 61);
            this.grpBasicSettings.TabIndex = 1;
            this.grpBasicSettings.TabStop = false;
            this.grpBasicSettings.Text = "Perusasetukset";
            // 
            // txtSurveyName
            // 
            this.txtSurveyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurveyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errSurveyName.SetIconPadding(this.txtSurveyName, 5);
            this.txtSurveyName.Location = new System.Drawing.Point(103, 26);
            this.txtSurveyName.Name = "txtSurveyName";
            this.txtSurveyName.Size = new System.Drawing.Size(163, 20);
            this.txtSurveyName.TabIndex = 1;
            this.txtSurveyName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurveyName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kyselyn nimi:";
            // 
            // grpAddQuestion
            // 
            this.grpAddQuestion.Controls.Add(this.btnAbortQuestion);
            this.grpAddQuestion.Controls.Add(this.numQuestionOrderNumber);
            this.grpAddQuestion.Controls.Add(this.btnSaveQuestion);
            this.grpAddQuestion.Controls.Add(this.grpQuestionSettings);
            this.grpAddQuestion.Controls.Add(this.cboQuestionTypeSelector);
            this.grpAddQuestion.Controls.Add(this.label7);
            this.grpAddQuestion.Controls.Add(this.label6);
            this.grpAddQuestion.Controls.Add(this.label5);
            this.grpAddQuestion.Controls.Add(this.txtQuestionTitle);
            this.grpAddQuestion.Location = new System.Drawing.Point(356, 12);
            this.grpAddQuestion.Name = "grpAddQuestion";
            this.grpAddQuestion.Size = new System.Drawing.Size(365, 319);
            this.grpAddQuestion.TabIndex = 2;
            this.grpAddQuestion.TabStop = false;
            this.grpAddQuestion.Text = "Kysymyksen lisäys";
            // 
            // btnAbortQuestion
            // 
            this.btnAbortQuestion.Location = new System.Drawing.Point(188, 291);
            this.btnAbortQuestion.Name = "btnAbortQuestion";
            this.btnAbortQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnAbortQuestion.TabIndex = 10;
            this.btnAbortQuestion.Text = "Peruuta";
            this.btnAbortQuestion.UseVisualStyleBackColor = true;
            this.btnAbortQuestion.Click += new System.EventHandler(this.btnAbortQuestion_Click);
            // 
            // numQuestionOrderNumber
            // 
            this.numQuestionOrderNumber.Location = new System.Drawing.Point(140, 19);
            this.numQuestionOrderNumber.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numQuestionOrderNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuestionOrderNumber.Name = "numQuestionOrderNumber";
            this.numQuestionOrderNumber.Size = new System.Drawing.Size(41, 20);
            this.numQuestionOrderNumber.TabIndex = 9;
            this.numQuestionOrderNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(115, 291);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnSaveQuestion.TabIndex = 8;
            this.btnSaveQuestion.Text = "Tallenna";
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
            this.grpQuestionSettings.Size = new System.Drawing.Size(347, 152);
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
            this.lbvRowOptions.Size = new System.Drawing.Size(167, 108);
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
            this.lbvColumnOptions.Location = new System.Drawing.Point(179, 38);
            this.lbvColumnOptions.Name = "lbvColumnOptions";
            this.lbvColumnOptions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbvColumnOptions.Size = new System.Drawing.Size(162, 108);
            this.lbvColumnOptions.TabIndex = 1;
            this.lbvColumnOptions.ValueMember = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sarakkeet:";
            // 
            // cboQuestionTypeSelector
            // 
            this.cboQuestionTypeSelector.DisplayMember = "nimi";
            this.cboQuestionTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionTypeSelector.FormattingEnabled = true;
            this.cboQuestionTypeSelector.Location = new System.Drawing.Point(140, 45);
            this.cboQuestionTypeSelector.Name = "cboQuestionTypeSelector";
            this.cboQuestionTypeSelector.Size = new System.Drawing.Size(192, 21);
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
            this.txtQuestionTitle.Location = new System.Drawing.Point(140, 72);
            this.txtQuestionTitle.Multiline = true;
            this.txtQuestionTitle.Name = "txtQuestionTitle";
            this.txtQuestionTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionTitle.Size = new System.Drawing.Size(192, 57);
            this.txtQuestionTitle.TabIndex = 0;
            this.txtQuestionTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuestionTitle_Validating);
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
            this.lbvAddedQuestions.Location = new System.Drawing.Point(6, 20);
            this.lbvAddedQuestions.Name = "lbvAddedQuestions";
            this.lbvAddedQuestions.Size = new System.Drawing.Size(322, 199);
            this.lbvAddedQuestions.TabIndex = 11;
            // 
            // btnSaveSurvey
            // 
            this.btnSaveSurvey.Location = new System.Drawing.Point(12, 356);
            this.btnSaveSurvey.Name = "btnSaveSurvey";
            this.btnSaveSurvey.Size = new System.Drawing.Size(97, 24);
            this.btnSaveSurvey.TabIndex = 3;
            this.btnSaveSurvey.Text = "Tallenna kysely";
            this.btnSaveSurvey.UseVisualStyleBackColor = true;
            this.btnSaveSurvey.Click += new System.EventHandler(this.btnSaveSurvey_Click);
            // 
            // grpQuestions
            // 
            this.grpQuestions.Controls.Add(this.btnEditQuestion);
            this.grpQuestions.Controls.Add(this.btnDeleteQuestion);
            this.grpQuestions.Controls.Add(this.button4);
            this.grpQuestions.Controls.Add(this.lbvAddedQuestions);
            this.grpQuestions.Location = new System.Drawing.Point(12, 79);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Size = new System.Drawing.Size(338, 252);
            this.grpQuestions.TabIndex = 4;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "Kysymykset";
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(6, 224);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnEditQuestion.TabIndex = 11;
            this.btnEditQuestion.Text = "Muokkaa";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(79, 224);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnDeleteQuestion.TabIndex = 11;
            this.btnDeleteQuestion.Text = "Poista";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnAbortSurvey
            // 
            this.btnAbortSurvey.Location = new System.Drawing.Point(115, 356);
            this.btnAbortSurvey.Name = "btnAbortSurvey";
            this.btnAbortSurvey.Size = new System.Drawing.Size(97, 24);
            this.btnAbortSurvey.TabIndex = 5;
            this.btnAbortSurvey.Text = "Peruuta";
            this.btnAbortSurvey.UseVisualStyleBackColor = true;
            this.btnAbortSurvey.Click += new System.EventHandler(this.btnAbortSurvey_Click);
            // 
            // errColOptions
            // 
            this.errColOptions.ContainerControl = this;
            // 
            // errSurveyName
            // 
            this.errSurveyName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSurveyName.ContainerControl = this;
            this.errSurveyName.Icon = ((System.Drawing.Icon)(resources.GetObject("errSurveyName.Icon")));
            // 
            // AddSurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 392);
            this.Controls.Add(this.btnAbortSurvey);
            this.Controls.Add(this.grpQuestions);
            this.Controls.Add(this.btnSaveSurvey);
            this.Controls.Add(this.grpAddQuestion);
            this.Controls.Add(this.grpBasicSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSurveyForm";
            this.Text = "Kysely";
            this.Load += new System.EventHandler(this.AddSurveyForm_Load);
            this.grpBasicSettings.ResumeLayout(false);
            this.grpBasicSettings.PerformLayout();
            this.grpAddQuestion.ResumeLayout(false);
            this.grpAddQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionOrderNumber)).EndInit();
            this.grpQuestionSettings.ResumeLayout(false);
            this.grpQuestionSettings.PerformLayout();
            this.grpQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errColOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSurveyName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBasicSettings;
        private System.Windows.Forms.TextBox txtSurveyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAddQuestion;
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
        private System.Windows.Forms.Button btnAbortQuestion;
        private System.Windows.Forms.Button btnAbortSurvey;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.NumericUpDown numQuestionOrderNumber;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.ErrorProvider errColOptions;
        private System.Windows.Forms.ErrorProvider errSurveyName;
    }
}

