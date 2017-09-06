namespace ICF_classificator
{
    partial class AddPatientForm
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
            this.PatientLastNameLabel = new System.Windows.Forms.Label();
            this.PatientFirstNameLabel = new System.Windows.Forms.Label();
            this.PatientSurNameLabel = new System.Windows.Forms.Label();
            this.PatientBirthDateLabel = new System.Windows.Forms.Label();
            this.PatientDoctorLabel = new System.Windows.Forms.Label();
            this.PatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientSurNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.CreatePatientButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatientLastNameLabel
            // 
            this.PatientLastNameLabel.AutoSize = true;
            this.PatientLastNameLabel.Location = new System.Drawing.Point(24, 29);
            this.PatientLastNameLabel.Name = "PatientLastNameLabel";
            this.PatientLastNameLabel.Size = new System.Drawing.Size(63, 13);
            this.PatientLastNameLabel.TabIndex = 0;
            this.PatientLastNameLabel.Text = "Фамилия *";
            // 
            // PatientFirstNameLabel
            // 
            this.PatientFirstNameLabel.AutoSize = true;
            this.PatientFirstNameLabel.Location = new System.Drawing.Point(24, 55);
            this.PatientFirstNameLabel.Name = "PatientFirstNameLabel";
            this.PatientFirstNameLabel.Size = new System.Drawing.Size(36, 13);
            this.PatientFirstNameLabel.TabIndex = 1;
            this.PatientFirstNameLabel.Text = "Имя *";
            // 
            // PatientSurNameLabel
            // 
            this.PatientSurNameLabel.AutoSize = true;
            this.PatientSurNameLabel.Location = new System.Drawing.Point(24, 81);
            this.PatientSurNameLabel.Name = "PatientSurNameLabel";
            this.PatientSurNameLabel.Size = new System.Drawing.Size(54, 13);
            this.PatientSurNameLabel.TabIndex = 2;
            this.PatientSurNameLabel.Text = "Отчество";
            // 
            // PatientBirthDateLabel
            // 
            this.PatientBirthDateLabel.AutoSize = true;
            this.PatientBirthDateLabel.Location = new System.Drawing.Point(24, 108);
            this.PatientBirthDateLabel.Name = "PatientBirthDateLabel";
            this.PatientBirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.PatientBirthDateLabel.TabIndex = 3;
            this.PatientBirthDateLabel.Text = "Дата рождения";
            // 
            // PatientDoctorLabel
            // 
            this.PatientDoctorLabel.AutoSize = true;
            this.PatientDoctorLabel.Location = new System.Drawing.Point(24, 133);
            this.PatientDoctorLabel.Name = "PatientDoctorLabel";
            this.PatientDoctorLabel.Size = new System.Drawing.Size(45, 13);
            this.PatientDoctorLabel.TabIndex = 4;
            this.PatientDoctorLabel.Text = "Доктор";
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(116, 26);
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.PatientLastNameTextBox.TabIndex = 5;
            // 
            // PatientFirstNameTextBox
            // 
            this.PatientFirstNameTextBox.Location = new System.Drawing.Point(116, 52);
            this.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox";
            this.PatientFirstNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.PatientFirstNameTextBox.TabIndex = 6;
            // 
            // PatientSurNameTextBox
            // 
            this.PatientSurNameTextBox.Location = new System.Drawing.Point(116, 78);
            this.PatientSurNameTextBox.Name = "PatientSurNameTextBox";
            this.PatientSurNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.PatientSurNameTextBox.TabIndex = 7;
            // 
            // PatientBirthDatePicker
            // 
            this.PatientBirthDatePicker.Location = new System.Drawing.Point(116, 104);
            this.PatientBirthDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.PatientBirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PatientBirthDatePicker.Name = "PatientBirthDatePicker";
            this.PatientBirthDatePicker.Size = new System.Drawing.Size(172, 20);
            this.PatientBirthDatePicker.TabIndex = 8;
            this.PatientBirthDatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(116, 130);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(172, 21);
            this.DoctorComboBox.TabIndex = 9;
            // 
            // CreatePatientButton
            // 
            this.CreatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePatientButton.Location = new System.Drawing.Point(131, 169);
            this.CreatePatientButton.Name = "CreatePatientButton";
            this.CreatePatientButton.Size = new System.Drawing.Size(144, 47);
            this.CreatePatientButton.TabIndex = 10;
            this.CreatePatientButton.Text = "Добавить";
            this.CreatePatientButton.UseVisualStyleBackColor = true;
            this.CreatePatientButton.Click += new System.EventHandler(this.CreatePatientButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(27, 169);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(100, 47);
            this.WarningLabel.TabIndex = 11;
            this.WarningLabel.Text = "Должны быть заполенны поля Фамилия и Имя";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WarningLabel.Visible = false;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 239);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CreatePatientButton);
            this.Controls.Add(this.DoctorComboBox);
            this.Controls.Add(this.PatientBirthDatePicker);
            this.Controls.Add(this.PatientSurNameTextBox);
            this.Controls.Add(this.PatientFirstNameTextBox);
            this.Controls.Add(this.PatientLastNameTextBox);
            this.Controls.Add(this.PatientDoctorLabel);
            this.Controls.Add(this.PatientBirthDateLabel);
            this.Controls.Add(this.PatientSurNameLabel);
            this.Controls.Add(this.PatientFirstNameLabel);
            this.Controls.Add(this.PatientLastNameLabel);
            this.Name = "AddPatientForm";
            this.Text = "Новый пациент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientLastNameLabel;
        private System.Windows.Forms.Label PatientFirstNameLabel;
        private System.Windows.Forms.Label PatientSurNameLabel;
        private System.Windows.Forms.Label PatientBirthDateLabel;
        private System.Windows.Forms.Label PatientDoctorLabel;
        private System.Windows.Forms.TextBox PatientLastNameTextBox;
        private System.Windows.Forms.TextBox PatientFirstNameTextBox;
        private System.Windows.Forms.TextBox PatientSurNameTextBox;
        private System.Windows.Forms.DateTimePicker PatientBirthDatePicker;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Button CreatePatientButton;
        private System.Windows.Forms.Label WarningLabel;
    }
}