namespace ICF_classificator
{
    partial class AddPatientHistoryToPatient
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
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientHistory = new System.Windows.Forms.Label();
            this.AddPatientHistoryButton = new System.Windows.Forms.Button();
            this.PatientHistoryTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.Location = new System.Drawing.Point(12, 9);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(189, 60);
            this.PatientNameLabel.TabIndex = 0;
            this.PatientNameLabel.Text = "№ Истории болезнии по пациенту Иванченко Самуил Георгиевич 24.12.2017";
            this.PatientNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PatientHistory
            // 
            this.PatientHistory.Location = new System.Drawing.Point(12, 84);
            this.PatientHistory.Name = "PatientHistory";
            this.PatientHistory.Size = new System.Drawing.Size(189, 29);
            this.PatientHistory.TabIndex = 0;
            this.PatientHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddPatientHistoryButton
            // 
            this.AddPatientHistoryButton.Enabled = false;
            this.AddPatientHistoryButton.Location = new System.Drawing.Point(72, 142);
            this.AddPatientHistoryButton.Name = "AddPatientHistoryButton";
            this.AddPatientHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.AddPatientHistoryButton.TabIndex = 1;
            this.AddPatientHistoryButton.Text = "Добавить";
            this.AddPatientHistoryButton.UseVisualStyleBackColor = true;
            this.AddPatientHistoryButton.Click += new System.EventHandler(this.AddPatientHistoryButton_Click);
            // 
            // PatientHistoryTextBox
            // 
            this.PatientHistoryTextBox.Location = new System.Drawing.Point(72, 116);
            this.PatientHistoryTextBox.Name = "PatientHistoryTextBox";
            this.PatientHistoryTextBox.Size = new System.Drawing.Size(75, 20);
            this.PatientHistoryTextBox.TabIndex = 2;
            this.PatientHistoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientHistoryTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 174);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(89, 44);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(111, 174);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 44);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPatientHistoryToPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 230);
            this.Controls.Add(this.PatientHistory);
            this.Controls.Add(this.PatientHistoryTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddPatientHistoryButton);
            this.Controls.Add(this.PatientNameLabel);
            this.Name = "AddPatientHistoryToPatient";
            this.Text = "AddPatientHistoryToPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label PatientHistory;
        private System.Windows.Forms.Button AddPatientHistoryButton;
        private System.Windows.Forms.TextBox PatientHistoryTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}