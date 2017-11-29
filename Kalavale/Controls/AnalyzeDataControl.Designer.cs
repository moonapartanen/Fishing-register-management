namespace Kalavale.Controls
{
    partial class AnalyzeDataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.cboResearchArea = new System.Windows.Forms.ComboBox();
            this.txtGroupSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSurvey = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(21, 389);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analysoi";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // cboResearchArea
            // 
            this.cboResearchArea.DisplayMember = "Name";
            this.cboResearchArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResearchArea.FormattingEnabled = true;
            this.cboResearchArea.Location = new System.Drawing.Point(21, 55);
            this.cboResearchArea.Name = "cboResearchArea";
            this.cboResearchArea.Size = new System.Drawing.Size(170, 21);
            this.cboResearchArea.TabIndex = 1;
            this.cboResearchArea.ValueMember = "Id";
            this.cboResearchArea.SelectedIndexChanged += new System.EventHandler(this.cboResearchArea_SelectedIndexChanged);
            // 
            // txtGroupSize
            // 
            this.txtGroupSize.Location = new System.Drawing.Point(21, 168);
            this.txtGroupSize.Name = "txtGroupSize";
            this.txtGroupSize.Size = new System.Drawing.Size(170, 20);
            this.txtGroupSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valitse tutkimusalue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anna perusjoukon koko:";
            // 
            // cboSurvey
            // 
            this.cboSurvey.DisplayMember = "Name";
            this.cboSurvey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurvey.FormattingEnabled = true;
            this.cboSurvey.Location = new System.Drawing.Point(20, 111);
            this.cboSurvey.Name = "cboSurvey";
            this.cboSurvey.Size = new System.Drawing.Size(171, 21);
            this.cboSurvey.TabIndex = 5;
            this.cboSurvey.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valitse kysely:";
            // 
            // AnalyzeDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSurvey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroupSize);
            this.Controls.Add(this.cboResearchArea);
            this.Controls.Add(this.btnAnalyze);
            this.Name = "AnalyzeDataControl";
            this.Size = new System.Drawing.Size(683, 440);
            this.Load += new System.EventHandler(this.AnalyzeDataControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ComboBox cboResearchArea;
        private System.Windows.Forms.TextBox txtGroupSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSurvey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
