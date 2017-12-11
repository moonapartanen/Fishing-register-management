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
            this.grpSurveySettings = new System.Windows.Forms.GroupBox();
            this.txtSurveyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAddQuestion = new System.Windows.Forms.GroupBox();
            this.btnAbortQuestion = new System.Windows.Forms.Button();
            this.numQuestionNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.grpQuestionSettings = new System.Windows.Forms.GroupBox();
            this.lbvRowOptions = new System.Windows.Forms.ListBox();
            this.lblRowOptions = new System.Windows.Forms.Label();
            this.lbvColumnOptions = new System.Windows.Forms.ListBox();
            this.lblColOptions = new System.Windows.Forms.Label();
            this.cboQuestionTypeSelector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestionTitle = new System.Windows.Forms.TextBox();
            this.lbvAddedQuestions = new System.Windows.Forms.ListBox();
            this.btnSaveSurvey = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnAbortSurvey = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddedQuestions = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.grpSurveySettings.SuspendLayout();
            this.grpAddQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionNumber)).BeginInit();
            this.grpQuestionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSurveySettings
            // 
            this.grpSurveySettings.Controls.Add(this.btnAddQuestion);
            this.grpSurveySettings.Controls.Add(this.lblAddedQuestions);
            this.grpSurveySettings.Controls.Add(this.btnEditQuestion);
            this.grpSurveySettings.Controls.Add(this.btnDeleteQuestion);
            this.grpSurveySettings.Controls.Add(this.txtSurveyName);
            this.grpSurveySettings.Controls.Add(this.label1);
            this.grpSurveySettings.Controls.Add(this.lbvAddedQuestions);
            this.grpSurveySettings.Location = new System.Drawing.Point(12, 12);
            this.grpSurveySettings.Name = "grpSurveySettings";
            this.grpSurveySettings.Size = new System.Drawing.Size(365, 319);
            this.grpSurveySettings.TabIndex = 1;
            this.grpSurveySettings.TabStop = false;
            this.grpSurveySettings.Text = "Kyselyn asetukset";
            // 
            // txtSurveyName
            // 
            this.txtSurveyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurveyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider.SetIconPadding(this.txtSurveyName, 5);
            this.txtSurveyName.Location = new System.Drawing.Point(79, 19);
            this.txtSurveyName.Name = "txtSurveyName";
            this.txtSurveyName.Size = new System.Drawing.Size(171, 20);
            this.txtSurveyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kyselyn nimi:";
            // 
            // grpAddQuestion
            // 
            this.grpAddQuestion.Controls.Add(this.btnAbortQuestion);
            this.grpAddQuestion.Controls.Add(this.numQuestionNumber);
            this.grpAddQuestion.Controls.Add(this.btnSaveQuestion);
            this.grpAddQuestion.Controls.Add(this.grpQuestionSettings);
            this.grpAddQuestion.Controls.Add(this.cboQuestionTypeSelector);
            this.grpAddQuestion.Controls.Add(this.label7);
            this.grpAddQuestion.Controls.Add(this.label6);
            this.grpAddQuestion.Controls.Add(this.label5);
            this.grpAddQuestion.Controls.Add(this.txtQuestionTitle);
            this.grpAddQuestion.Location = new System.Drawing.Point(383, 12);
            this.grpAddQuestion.Name = "grpAddQuestion";
            this.grpAddQuestion.Size = new System.Drawing.Size(365, 319);
            this.grpAddQuestion.TabIndex = 2;
            this.grpAddQuestion.TabStop = false;
            this.grpAddQuestion.Text = "Kysymyksen asetukset";
            // 
            // btnAbortQuestion
            // 
            this.btnAbortQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAbortQuestion.Location = new System.Drawing.Point(188, 291);
            this.btnAbortQuestion.Name = "btnAbortQuestion";
            this.btnAbortQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnAbortQuestion.TabIndex = 10;
            this.btnAbortQuestion.Text = "Peruuta";
            this.btnAbortQuestion.UseVisualStyleBackColor = true;
            this.btnAbortQuestion.Click += new System.EventHandler(this.btnAbortQuestion_Click);
            // 
            // numQuestionNumber
            // 
            this.errorProvider.SetIconPadding(this.numQuestionNumber, 5);
            this.numQuestionNumber.Location = new System.Drawing.Point(140, 19);
            this.numQuestionNumber.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numQuestionNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuestionNumber.Name = "numQuestionNumber";
            this.numQuestionNumber.Size = new System.Drawing.Size(41, 20);
            this.numQuestionNumber.TabIndex = 9;
            this.numQuestionNumber.Value = new decimal(new int[] {
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
            this.grpQuestionSettings.Controls.Add(this.lblRowOptions);
            this.grpQuestionSettings.Controls.Add(this.lbvColumnOptions);
            this.grpQuestionSettings.Controls.Add(this.lblColOptions);
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
            // lblRowOptions
            // 
            this.lblRowOptions.AutoSize = true;
            this.errorProvider.SetIconPadding(this.lblRowOptions, 5);
            this.lblRowOptions.Location = new System.Drawing.Point(3, 22);
            this.lblRowOptions.Name = "lblRowOptions";
            this.lblRowOptions.Size = new System.Drawing.Size(31, 13);
            this.lblRowOptions.TabIndex = 2;
            this.lblRowOptions.Text = "Rivit:";
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
            // lblColOptions
            // 
            this.lblColOptions.AutoSize = true;
            this.errorProvider.SetIconPadding(this.lblColOptions, 5);
            this.lblColOptions.Location = new System.Drawing.Point(176, 22);
            this.lblColOptions.Name = "lblColOptions";
            this.lblColOptions.Size = new System.Drawing.Size(59, 13);
            this.lblColOptions.TabIndex = 0;
            this.lblColOptions.Text = "Sarakkeet:";
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
            this.errorProvider.SetIconAlignment(this.txtQuestionTitle, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.errorProvider.SetIconPadding(this.txtQuestionTitle, 5);
            this.txtQuestionTitle.Location = new System.Drawing.Point(140, 72);
            this.txtQuestionTitle.Multiline = true;
            this.txtQuestionTitle.Name = "txtQuestionTitle";
            this.txtQuestionTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionTitle.Size = new System.Drawing.Size(192, 57);
            this.txtQuestionTitle.TabIndex = 0;
            // 
            // lbvAddedQuestions
            // 
            this.lbvAddedQuestions.FormattingEnabled = true;
            this.lbvAddedQuestions.Location = new System.Drawing.Point(6, 69);
            this.lbvAddedQuestions.Name = "lbvAddedQuestions";
            this.lbvAddedQuestions.Size = new System.Drawing.Size(353, 212);
            this.lbvAddedQuestions.TabIndex = 11;
            // 
            // btnSaveSurvey
            // 
            this.btnSaveSurvey.Location = new System.Drawing.Point(280, 337);
            this.btnSaveSurvey.Name = "btnSaveSurvey";
            this.btnSaveSurvey.Size = new System.Drawing.Size(97, 32);
            this.btnSaveSurvey.TabIndex = 3;
            this.btnSaveSurvey.Text = "Tallenna kysely";
            this.btnSaveSurvey.UseVisualStyleBackColor = true;
            this.btnSaveSurvey.Click += new System.EventHandler(this.btnSaveSurvey_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(79, 291);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnEditQuestion.TabIndex = 11;
            this.btnEditQuestion.Text = "Muokkaa";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.errorProvider.SetIconPadding(this.btnDeleteQuestion, 5);
            this.btnDeleteQuestion.Location = new System.Drawing.Point(152, 291);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnDeleteQuestion.TabIndex = 11;
            this.btnDeleteQuestion.Text = "Poista";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnAbortSurvey
            // 
            this.btnAbortSurvey.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAbortSurvey.Location = new System.Drawing.Point(383, 337);
            this.btnAbortSurvey.Name = "btnAbortSurvey";
            this.btnAbortSurvey.Size = new System.Drawing.Size(97, 32);
            this.btnAbortSurvey.TabIndex = 5;
            this.btnAbortSurvey.Text = "Peruuta";
            this.btnAbortSurvey.UseVisualStyleBackColor = true;
            this.btnAbortSurvey.Click += new System.EventHandler(this.btnAbortSurvey_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // lblAddedQuestions
            // 
            this.lblAddedQuestions.AutoSize = true;
            this.lblAddedQuestions.Location = new System.Drawing.Point(3, 53);
            this.lblAddedQuestions.Name = "lblAddedQuestions";
            this.lblAddedQuestions.Size = new System.Drawing.Size(97, 13);
            this.lblAddedQuestions.TabIndex = 12;
            this.lblAddedQuestions.Text = "Lisätyt kysymykset:";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(6, 291);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(67, 22);
            this.btnAddQuestion.TabIndex = 13;
            this.btnAddQuestion.Text = "Lisää";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // AddSurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 375);
            this.Controls.Add(this.btnAbortSurvey);
            this.Controls.Add(this.btnSaveSurvey);
            this.Controls.Add(this.grpAddQuestion);
            this.Controls.Add(this.grpSurveySettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSurveyForm";
            this.Text = "Kysely";
            this.Load += new System.EventHandler(this.AddSurveyForm_Load);
            this.grpSurveySettings.ResumeLayout(false);
            this.grpSurveySettings.PerformLayout();
            this.grpAddQuestion.ResumeLayout(false);
            this.grpAddQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionNumber)).EndInit();
            this.grpQuestionSettings.ResumeLayout(false);
            this.grpQuestionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpSurveySettings;
        private System.Windows.Forms.TextBox txtSurveyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAddQuestion;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.GroupBox grpQuestionSettings;
        private System.Windows.Forms.ListBox lbvRowOptions;
        private System.Windows.Forms.Label lblRowOptions;
        private System.Windows.Forms.ListBox lbvColumnOptions;
        private System.Windows.Forms.Label lblColOptions;
        private System.Windows.Forms.ComboBox cboQuestionTypeSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestionTitle;
        private System.Windows.Forms.Button btnSaveSurvey;
        private System.Windows.Forms.ListBox lbvAddedQuestions;
        private System.Windows.Forms.Button btnAbortQuestion;
        private System.Windows.Forms.Button btnAbortSurvey;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown numQuestionNumber;
        private System.Windows.Forms.Label lblAddedQuestions;
        private System.Windows.Forms.Button btnAddQuestion;
    }
}

