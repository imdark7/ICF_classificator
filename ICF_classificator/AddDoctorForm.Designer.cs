namespace ICF_classificator
{
    partial class AddDoctorForm
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
            this.WarningLabel = new System.Windows.Forms.Label();
            this.CreateDoctorButton = new System.Windows.Forms.Button();
            this.DoctorSurNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorSurNameLabel = new System.Windows.Forms.Label();
            this.DoctorFirstNameLabel = new System.Windows.Forms.Label();
            this.DoctorLastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WarningLabel
            // 
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(16, 139);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(100, 47);
            this.WarningLabel.TabIndex = 23;
            this.WarningLabel.Text = "Должны быть заполенны поля Фамилия и Имя";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WarningLabel.Visible = false;
            // 
            // CreateDoctorButton
            // 
            this.CreateDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDoctorButton.Location = new System.Drawing.Point(120, 139);
            this.CreateDoctorButton.Name = "CreateDoctorButton";
            this.CreateDoctorButton.Size = new System.Drawing.Size(144, 47);
            this.CreateDoctorButton.TabIndex = 22;
            this.CreateDoctorButton.Text = "Добавить";
            this.CreateDoctorButton.UseVisualStyleBackColor = true;
            this.CreateDoctorButton.Click += new System.EventHandler(this.CreateDoctorButton_Click);
            // 
            // DoctorSurNameTextBox
            // 
            this.DoctorSurNameTextBox.Location = new System.Drawing.Point(102, 87);
            this.DoctorSurNameTextBox.Name = "DoctorSurNameTextBox";
            this.DoctorSurNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.DoctorSurNameTextBox.TabIndex = 19;
            // 
            // DoctorFirstNameTextBox
            // 
            this.DoctorFirstNameTextBox.Location = new System.Drawing.Point(102, 61);
            this.DoctorFirstNameTextBox.Name = "DoctorFirstNameTextBox";
            this.DoctorFirstNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.DoctorFirstNameTextBox.TabIndex = 18;
            // 
            // DoctorLastNameTextBox
            // 
            this.DoctorLastNameTextBox.Location = new System.Drawing.Point(102, 35);
            this.DoctorLastNameTextBox.Name = "DoctorLastNameTextBox";
            this.DoctorLastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.DoctorLastNameTextBox.TabIndex = 17;
            // 
            // DoctorSurNameLabel
            // 
            this.DoctorSurNameLabel.AutoSize = true;
            this.DoctorSurNameLabel.Location = new System.Drawing.Point(10, 90);
            this.DoctorSurNameLabel.Name = "DoctorSurNameLabel";
            this.DoctorSurNameLabel.Size = new System.Drawing.Size(54, 13);
            this.DoctorSurNameLabel.TabIndex = 14;
            this.DoctorSurNameLabel.Text = "Отчество";
            // 
            // DoctorFirstNameLabel
            // 
            this.DoctorFirstNameLabel.AutoSize = true;
            this.DoctorFirstNameLabel.Location = new System.Drawing.Point(10, 64);
            this.DoctorFirstNameLabel.Name = "DoctorFirstNameLabel";
            this.DoctorFirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.DoctorFirstNameLabel.TabIndex = 13;
            this.DoctorFirstNameLabel.Text = "Имя";
            // 
            // DoctorLastNameLabel
            // 
            this.DoctorLastNameLabel.AutoSize = true;
            this.DoctorLastNameLabel.Location = new System.Drawing.Point(10, 38);
            this.DoctorLastNameLabel.Name = "DoctorLastNameLabel";
            this.DoctorLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.DoctorLastNameLabel.TabIndex = 12;
            this.DoctorLastNameLabel.Text = "Фамилия";
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 200);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CreateDoctorButton);
            this.Controls.Add(this.DoctorSurNameTextBox);
            this.Controls.Add(this.DoctorFirstNameTextBox);
            this.Controls.Add(this.DoctorLastNameTextBox);
            this.Controls.Add(this.DoctorSurNameLabel);
            this.Controls.Add(this.DoctorFirstNameLabel);
            this.Controls.Add(this.DoctorLastNameLabel);
            this.Name = "AddDoctorForm";
            this.Text = "Новый доктор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Button CreateDoctorButton;
        private System.Windows.Forms.TextBox DoctorSurNameTextBox;
        private System.Windows.Forms.TextBox DoctorFirstNameTextBox;
        private System.Windows.Forms.TextBox DoctorLastNameTextBox;
        private System.Windows.Forms.Label DoctorSurNameLabel;
        private System.Windows.Forms.Label DoctorFirstNameLabel;
        private System.Windows.Forms.Label DoctorLastNameLabel;
    }
}