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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.CreatePatientButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(24, 29);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 13);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Фамилия *";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(24, 55);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(36, 13);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Имя *";
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(24, 81);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurNameLabel.TabIndex = 2;
            this.SurNameLabel.Text = "Отчество";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(24, 108);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthDateLabel.TabIndex = 3;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.AutoSize = true;
            this.DoctorLabel.Location = new System.Drawing.Point(24, 133);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(45, 13);
            this.DoctorLabel.TabIndex = 4;
            this.DoctorLabel.Text = "Доктор";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(116, 26);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(116, 52);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.Location = new System.Drawing.Point(116, 78);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.SurNameTextBox.TabIndex = 7;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(116, 104);
            this.BirthDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(172, 20);
            this.BirthDatePicker.TabIndex = 8;
            this.BirthDatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.SurNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.DoctorLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "AddPatientForm";
            this.Text = "Новый пациент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label DoctorLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SurNameTextBox;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Button CreatePatientButton;
        private System.Windows.Forms.Label WarningLabel;
    }
}