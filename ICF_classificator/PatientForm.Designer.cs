using System;
using System.Windows.Forms;

namespace ICF_classificator
{
    partial class PatientForm
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
            this.CreatePatientButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.PatientAddressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ParentFIOTextBox = new System.Windows.Forms.TextBox();
            this.FIOParentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ALVLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sexPatientLabel = new System.Windows.Forms.Label();
            this.MaleSexRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleSexRadioButton = new System.Windows.Forms.RadioButton();
            this.SexRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.GestationAgeLabel = new System.Windows.Forms.Label();
            this.GestationAgeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WeightNewbornLabel = new System.Windows.Forms.Label();
            this.BirthWeightTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ApgarTextBox3 = new System.Windows.Forms.TextBox();
            this.ApgarTextBox2 = new System.Windows.Forms.TextBox();
            this.ApgarTextBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.disabilityRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.DisabilityNoRadioButton = new System.Windows.Forms.RadioButton();
            this.DisabilityYesRadioButton = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.BirthChestSizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChestSizeLabel = new System.Windows.Forms.Label();
            this.BirthHeadSizeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HeadSizeNewbornLabel = new System.Windows.Forms.Label();
            this.BirthHeightTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.HeightNewbornLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.HospitalizationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.CPAPDurationTextBox = new System.Windows.Forms.TextBox();
            this.ALVDutarionTextBox = new System.Windows.Forms.TextBox();
            this.ALVDurationLabel = new System.Windows.Forms.Label();
            this.CPAPDurationLabel = new System.Windows.Forms.Label();
            this.CerebralIschemiaComboBox = new System.Windows.Forms.ComboBox();
            this.IVHDegreeComboBox = new System.Windows.Forms.ComboBox();
            this.IVHLocalizationComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.BirthDefectTextBox = new System.Windows.Forms.TextBox();
            this.SurgeryTextBox = new System.Windows.Forms.TextBox();
            this.ALVRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.ALVNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ALVYesRadioButton = new System.Windows.Forms.RadioButton();
            this.CPAPRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.CPAPNoRadioButton = new System.Windows.Forms.RadioButton();
            this.CPAPYesRadioButton = new System.Windows.Forms.RadioButton();
            this.EncephalitisRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.EncephalitisNoRadioButton = new System.Windows.Forms.RadioButton();
            this.EncephalitisYesRadioButton = new System.Windows.Forms.RadioButton();
            this.MeningitisRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.MeningitisNoRadioButton = new System.Windows.Forms.RadioButton();
            this.MeningitisYesRadioButton = new System.Windows.Forms.RadioButton();
            this.ConclusiveSyndromeRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.ConclusiveSyndromeNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ConvulsiveSyndromeYesRadioButton = new System.Windows.Forms.RadioButton();
            this.ConclusiveSyndromeDurationLabel = new System.Windows.Forms.Label();
            this.ConvulsiveSyndromeDurationTextBox = new System.Windows.Forms.TextBox();
            this.SepsisRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.SepsisNoRadioButton = new System.Windows.Forms.RadioButton();
            this.SepsisYesRadioButton = new System.Windows.Forms.RadioButton();
            this.HDNRadioButtosPanel = new System.Windows.Forms.Panel();
            this.HDNNoRadioButton = new System.Windows.Forms.RadioButton();
            this.HDNYesRadioButton = new System.Windows.Forms.RadioButton();
            this.VKDBRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.VKDBNoRadioButton = new System.Windows.Forms.RadioButton();
            this.VKDBYesRadioButton = new System.Windows.Forms.RadioButton();
            this.AnemiaRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.AnemiaNoRadioButton = new System.Windows.Forms.RadioButton();
            this.AnemiaYesRadioButton = new System.Windows.Forms.RadioButton();
            this.HyperbilirubinemiaRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.HyperbilirubinemiaNoRadioButton = new System.Windows.Forms.RadioButton();
            this.HyperbilirubinemiaYesRadioButton = new System.Windows.Forms.RadioButton();
            this.UNECRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.UNECNoRadioButton = new System.Windows.Forms.RadioButton();
            this.UNECYesRadioButton = new System.Windows.Forms.RadioButton();
            this.BirthDefectRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.BirthDefectNoRadioButton = new System.Windows.Forms.RadioButton();
            this.BirthDefectYesRadioButton = new System.Windows.Forms.RadioButton();
            this.SurgeryRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.SurgeryNoRadioButton = new System.Windows.Forms.RadioButton();
            this.SurgeryYesRadioButton = new System.Windows.Forms.RadioButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.HospitalizationFirstTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.HospitalizationNotFirstTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.CaseHistoryLabel = new System.Windows.Forms.Label();
            this.PatientHistoryTextBox = new System.Windows.Forms.TextBox();
            this.SexRadioButtonsPanel.SuspendLayout();
            this.disabilityRadioButtonsPanel.SuspendLayout();
            this.ALVRadioButtonsPanel.SuspendLayout();
            this.CPAPRadioButtonsPanel.SuspendLayout();
            this.EncephalitisRadioButtonsPanel.SuspendLayout();
            this.MeningitisRadioButtonsPanel.SuspendLayout();
            this.ConclusiveSyndromeRadioButtonsPanel.SuspendLayout();
            this.SepsisRadioButtonsPanel.SuspendLayout();
            this.HDNRadioButtosPanel.SuspendLayout();
            this.VKDBRadioButtonsPanel.SuspendLayout();
            this.AnemiaRadioButtonsPanel.SuspendLayout();
            this.HyperbilirubinemiaRadioButtonsPanel.SuspendLayout();
            this.UNECRadioButtonsPanel.SuspendLayout();
            this.BirthDefectRadioButtonsPanel.SuspendLayout();
            this.SurgeryRadioButtonsPanel.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientLastNameLabel
            // 
            this.PatientLastNameLabel.AutoSize = true;
            this.PatientLastNameLabel.Location = new System.Drawing.Point(15, 30);
            this.PatientLastNameLabel.Name = "PatientLastNameLabel";
            this.PatientLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.PatientLastNameLabel.TabIndex = 0;
            this.PatientLastNameLabel.Text = "Фамилия";
            // 
            // PatientFirstNameLabel
            // 
            this.PatientFirstNameLabel.AutoSize = true;
            this.PatientFirstNameLabel.Location = new System.Drawing.Point(15, 56);
            this.PatientFirstNameLabel.Name = "PatientFirstNameLabel";
            this.PatientFirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.PatientFirstNameLabel.TabIndex = 1;
            this.PatientFirstNameLabel.Text = "Имя";
            // 
            // PatientSurNameLabel
            // 
            this.PatientSurNameLabel.AutoSize = true;
            this.PatientSurNameLabel.Location = new System.Drawing.Point(15, 82);
            this.PatientSurNameLabel.Name = "PatientSurNameLabel";
            this.PatientSurNameLabel.Size = new System.Drawing.Size(54, 13);
            this.PatientSurNameLabel.TabIndex = 2;
            this.PatientSurNameLabel.Text = "Отчество";
            // 
            // PatientBirthDateLabel
            // 
            this.PatientBirthDateLabel.AutoSize = true;
            this.PatientBirthDateLabel.Location = new System.Drawing.Point(15, 186);
            this.PatientBirthDateLabel.Name = "PatientBirthDateLabel";
            this.PatientBirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.PatientBirthDateLabel.TabIndex = 3;
            this.PatientBirthDateLabel.Text = "Дата рождения";
            // 
            // PatientDoctorLabel
            // 
            this.PatientDoctorLabel.AutoSize = true;
            this.PatientDoctorLabel.Location = new System.Drawing.Point(326, 285);
            this.PatientDoctorLabel.Name = "PatientDoctorLabel";
            this.PatientDoctorLabel.Size = new System.Drawing.Size(97, 26);
            this.PatientDoctorLabel.TabIndex = 4;
            this.PatientDoctorLabel.Text = "Геморрагический\r\nсиндром";
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(136, 26);
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.PatientLastNameTextBox.TabIndex = 5;
            // 
            // PatientFirstNameTextBox
            // 
            this.PatientFirstNameTextBox.Location = new System.Drawing.Point(136, 52);
            this.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox";
            this.PatientFirstNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.PatientFirstNameTextBox.TabIndex = 6;
            // 
            // PatientSurNameTextBox
            // 
            this.PatientSurNameTextBox.Location = new System.Drawing.Point(136, 78);
            this.PatientSurNameTextBox.Name = "PatientSurNameTextBox";
            this.PatientSurNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.PatientSurNameTextBox.TabIndex = 7;
            // 
            // PatientBirthDatePicker
            // 
            this.PatientBirthDatePicker.Location = new System.Drawing.Point(136, 183);
            this.PatientBirthDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.PatientBirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PatientBirthDatePicker.Name = "PatientBirthDatePicker";
            this.PatientBirthDatePicker.Size = new System.Drawing.Size(161, 20);
            this.PatientBirthDatePicker.TabIndex = 8;
            this.PatientBirthDatePicker.Value = new System.DateTime(2017, 10, 19, 0, 0, 0, 0);
            // 
            // CreatePatientButton
            // 
            this.CreatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePatientButton.Location = new System.Drawing.Point(136, 472);
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
            this.WarningLabel.Location = new System.Drawing.Point(12, 443);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(120, 98);
            this.WarningLabel.TabIndex = 11;
            this.WarningLabel.Text = "Должны быть заполенны поля Фамилия и Имя";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WarningLabel.Visible = false;
            // 
            // PatientAddressTextBox
            // 
            this.PatientAddressTextBox.Location = new System.Drawing.Point(136, 157);
            this.PatientAddressTextBox.Name = "PatientAddressTextBox";
            this.PatientAddressTextBox.Size = new System.Drawing.Size(161, 20);
            this.PatientAddressTextBox.TabIndex = 13;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(15, 161);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(86, 13);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "Адрес (фактич.)";
            // 
            // ParentFIOTextBox
            // 
            this.ParentFIOTextBox.Location = new System.Drawing.Point(136, 131);
            this.ParentFIOTextBox.Name = "ParentFIOTextBox";
            this.ParentFIOTextBox.Size = new System.Drawing.Size(161, 20);
            this.ParentFIOTextBox.TabIndex = 15;
            // 
            // FIOParentLabel
            // 
            this.FIOParentLabel.AutoSize = true;
            this.FIOParentLabel.Location = new System.Drawing.Point(15, 127);
            this.FIOParentLabel.Name = "FIOParentLabel";
            this.FIOParentLabel.Size = new System.Drawing.Size(109, 26);
            this.FIOParentLabel.TabIndex = 14;
            this.FIOParentLabel.Text = "ФИО родителя \r\n(сопровождающего)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Церебральная ишемия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPAP";
            // 
            // ALVLabel
            // 
            this.ALVLabel.AutoSize = true;
            this.ALVLabel.Location = new System.Drawing.Point(326, 30);
            this.ALVLabel.Name = "ALVLabel";
            this.ALVLabel.Size = new System.Drawing.Size(30, 13);
            this.ALVLabel.TabIndex = 16;
            this.ALVLabel.Text = "ИВЛ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Энцефалит";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Менингит";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ВЖК";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ГБН";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Сепсис";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Судорожный синдром";
            // 
            // sexPatientLabel
            // 
            this.sexPatientLabel.AutoSize = true;
            this.sexPatientLabel.Location = new System.Drawing.Point(15, 108);
            this.sexPatientLabel.Name = "sexPatientLabel";
            this.sexPatientLabel.Size = new System.Drawing.Size(27, 13);
            this.sexPatientLabel.TabIndex = 35;
            this.sexPatientLabel.Text = "Пол";
            // 
            // MaleSexRadioButton
            // 
            this.MaleSexRadioButton.AutoSize = true;
            this.MaleSexRadioButton.Location = new System.Drawing.Point(39, 2);
            this.MaleSexRadioButton.Name = "MaleSexRadioButton";
            this.MaleSexRadioButton.Size = new System.Drawing.Size(34, 17);
            this.MaleSexRadioButton.TabIndex = 36;
            this.MaleSexRadioButton.TabStop = true;
            this.MaleSexRadioButton.Text = "M";
            this.MaleSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleSexRadioButton
            // 
            this.FemaleSexRadioButton.AutoSize = true;
            this.FemaleSexRadioButton.Location = new System.Drawing.Point(79, 2);
            this.FemaleSexRadioButton.Name = "FemaleSexRadioButton";
            this.FemaleSexRadioButton.Size = new System.Drawing.Size(36, 17);
            this.FemaleSexRadioButton.TabIndex = 36;
            this.FemaleSexRadioButton.TabStop = true;
            this.FemaleSexRadioButton.Text = "Ж";
            this.FemaleSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexRadioButtonsPanel
            // 
            this.SexRadioButtonsPanel.Controls.Add(this.MaleSexRadioButton);
            this.SexRadioButtonsPanel.Controls.Add(this.FemaleSexRadioButton);
            this.SexRadioButtonsPanel.Location = new System.Drawing.Point(136, 104);
            this.SexRadioButtonsPanel.Name = "SexRadioButtonsPanel";
            this.SexRadioButtonsPanel.Size = new System.Drawing.Size(161, 20);
            this.SexRadioButtonsPanel.TabIndex = 38;
            // 
            // GestationAgeLabel
            // 
            this.GestationAgeLabel.AutoSize = true;
            this.GestationAgeLabel.Location = new System.Drawing.Point(15, 206);
            this.GestationAgeLabel.Name = "GestationAgeLabel";
            this.GestationAgeLabel.Size = new System.Drawing.Size(80, 26);
            this.GestationAgeLabel.TabIndex = 39;
            this.GestationAgeLabel.Text = "Гестационный\r\nвозраст";
            // 
            // GestationAgeTextBox
            // 
            this.GestationAgeTextBox.Location = new System.Drawing.Point(136, 209);
            this.GestationAgeTextBox.Name = "GestationAgeTextBox";
            this.GestationAgeTextBox.Size = new System.Drawing.Size(103, 20);
            this.GestationAgeTextBox.TabIndex = 40;
            this.GestationAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "недель";
            // 
            // WeightNewbornLabel
            // 
            this.WeightNewbornLabel.AutoSize = true;
            this.WeightNewbornLabel.Location = new System.Drawing.Point(15, 234);
            this.WeightNewbornLabel.Name = "WeightNewbornLabel";
            this.WeightNewbornLabel.Size = new System.Drawing.Size(78, 26);
            this.WeightNewbornLabel.TabIndex = 39;
            this.WeightNewbornLabel.Text = "Масса тела \r\nпри рождении";
            // 
            // BirthWeightTextBox
            // 
            this.BirthWeightTextBox.Location = new System.Drawing.Point(136, 237);
            this.BirthWeightTextBox.Name = "BirthWeightTextBox";
            this.BirthWeightTextBox.Size = new System.Drawing.Size(103, 20);
            this.BirthWeightTextBox.TabIndex = 40;
            this.BirthWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "грамм";
            // 
            // ApgarTextBox3
            // 
            this.ApgarTextBox3.Location = new System.Drawing.Point(226, 341);
            this.ApgarTextBox3.MaxLength = 2;
            this.ApgarTextBox3.Name = "ApgarTextBox3";
            this.ApgarTextBox3.Size = new System.Drawing.Size(39, 20);
            this.ApgarTextBox3.TabIndex = 52;
            this.ApgarTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // ApgarTextBox2
            // 
            this.ApgarTextBox2.Location = new System.Drawing.Point(181, 341);
            this.ApgarTextBox2.MaxLength = 2;
            this.ApgarTextBox2.Name = "ApgarTextBox2";
            this.ApgarTextBox2.Size = new System.Drawing.Size(39, 20);
            this.ApgarTextBox2.TabIndex = 51;
            this.ApgarTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // ApgarTextBox1
            // 
            this.ApgarTextBox1.Location = new System.Drawing.Point(136, 341);
            this.ApgarTextBox1.MaxLength = 2;
            this.ApgarTextBox1.Name = "ApgarTextBox1";
            this.ApgarTextBox1.Size = new System.Drawing.Size(39, 20);
            this.ApgarTextBox1.TabIndex = 44;
            this.ApgarTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Оценка по Апгар";
            // 
            // disabilityRadioButtonsPanel
            // 
            this.disabilityRadioButtonsPanel.Controls.Add(this.DisabilityNoRadioButton);
            this.disabilityRadioButtonsPanel.Controls.Add(this.DisabilityYesRadioButton);
            this.disabilityRadioButtonsPanel.Location = new System.Drawing.Point(136, 367);
            this.disabilityRadioButtonsPanel.Name = "disabilityRadioButtonsPanel";
            this.disabilityRadioButtonsPanel.Size = new System.Drawing.Size(161, 20);
            this.disabilityRadioButtonsPanel.TabIndex = 38;
            // 
            // DisabilityNoRadioButton
            // 
            this.DisabilityNoRadioButton.AutoSize = true;
            this.DisabilityNoRadioButton.Checked = true;
            this.DisabilityNoRadioButton.Location = new System.Drawing.Point(16, 2);
            this.DisabilityNoRadioButton.Name = "DisabilityNoRadioButton";
            this.DisabilityNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.DisabilityNoRadioButton.TabIndex = 36;
            this.DisabilityNoRadioButton.TabStop = true;
            this.DisabilityNoRadioButton.Text = "Нет";
            this.DisabilityNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // DisabilityYesRadioButton
            // 
            this.DisabilityYesRadioButton.AutoSize = true;
            this.DisabilityYesRadioButton.Location = new System.Drawing.Point(63, 2);
            this.DisabilityYesRadioButton.Name = "DisabilityYesRadioButton";
            this.DisabilityYesRadioButton.Size = new System.Drawing.Size(85, 17);
            this.DisabilityYesRadioButton.TabIndex = 36;
            this.DisabilityYesRadioButton.Text = "Оформлена";
            this.DisabilityYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Инвалидность";
            // 
            // BirthChestSizeTextBox
            // 
            this.BirthChestSizeTextBox.Location = new System.Drawing.Point(136, 315);
            this.BirthChestSizeTextBox.Name = "BirthChestSizeTextBox";
            this.BirthChestSizeTextBox.Size = new System.Drawing.Size(103, 20);
            this.BirthChestSizeTextBox.TabIndex = 49;
            this.BirthChestSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "см";
            // 
            // ChestSizeLabel
            // 
            this.ChestSizeLabel.AutoSize = true;
            this.ChestSizeLabel.Location = new System.Drawing.Point(15, 312);
            this.ChestSizeLabel.Name = "ChestSizeLabel";
            this.ChestSizeLabel.Size = new System.Drawing.Size(116, 26);
            this.ChestSizeLabel.TabIndex = 48;
            this.ChestSizeLabel.Text = "Окружность грудной\r\nклетки при рождении";
            // 
            // BirthHeadSizeTextBox
            // 
            this.BirthHeadSizeTextBox.Location = new System.Drawing.Point(136, 289);
            this.BirthHeadSizeTextBox.Name = "BirthHeadSizeTextBox";
            this.BirthHeadSizeTextBox.Size = new System.Drawing.Size(103, 20);
            this.BirthHeadSizeTextBox.TabIndex = 46;
            this.BirthHeadSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "см";
            // 
            // HeadSizeNewbornLabel
            // 
            this.HeadSizeNewbornLabel.AutoSize = true;
            this.HeadSizeNewbornLabel.Location = new System.Drawing.Point(15, 284);
            this.HeadSizeNewbornLabel.Name = "HeadSizeNewbornLabel";
            this.HeadSizeNewbornLabel.Size = new System.Drawing.Size(109, 26);
            this.HeadSizeNewbornLabel.TabIndex = 45;
            this.HeadSizeNewbornLabel.Text = "Окружность головы\r\nпри рождении";
            // 
            // BirthHeightTextBox
            // 
            this.BirthHeightTextBox.Location = new System.Drawing.Point(136, 263);
            this.BirthHeightTextBox.Name = "BirthHeightTextBox";
            this.BirthHeightTextBox.Size = new System.Drawing.Size(103, 20);
            this.BirthHeightTextBox.TabIndex = 43;
            this.BirthHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "см";
            // 
            // HeightNewbornLabel
            // 
            this.HeightNewbornLabel.AutoSize = true;
            this.HeightNewbornLabel.Location = new System.Drawing.Point(15, 265);
            this.HeightNewbornLabel.Name = "HeightNewbornLabel";
            this.HeightNewbornLabel.Size = new System.Drawing.Size(114, 13);
            this.HeightNewbornLabel.TabIndex = 42;
            this.HeightNewbornLabel.Text = "Длина при рождении";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 395);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Госпитализация";
            // 
            // HospitalizationDatePicker
            // 
            this.HospitalizationDatePicker.Location = new System.Drawing.Point(136, 419);
            this.HospitalizationDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.HospitalizationDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.HospitalizationDatePicker.Name = "HospitalizationDatePicker";
            this.HospitalizationDatePicker.Size = new System.Drawing.Size(161, 20);
            this.HospitalizationDatePicker.TabIndex = 56;
            this.HospitalizationDatePicker.Value = new System.DateTime(2017, 10, 19, 0, 0, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 422);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Дата поступления";
            // 
            // CPAPDurationTextBox
            // 
            this.CPAPDurationTextBox.Enabled = false;
            this.CPAPDurationTextBox.Location = new System.Drawing.Point(546, 53);
            this.CPAPDurationTextBox.Name = "CPAPDurationTextBox";
            this.CPAPDurationTextBox.Size = new System.Drawing.Size(32, 20);
            this.CPAPDurationTextBox.TabIndex = 59;
            this.CPAPDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // ALVDutarionTextBox
            // 
            this.ALVDutarionTextBox.Enabled = false;
            this.ALVDutarionTextBox.Location = new System.Drawing.Point(546, 26);
            this.ALVDutarionTextBox.Name = "ALVDutarionTextBox";
            this.ALVDutarionTextBox.Size = new System.Drawing.Size(32, 20);
            this.ALVDutarionTextBox.TabIndex = 58;
            this.ALVDutarionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // ALVDurationLabel
            // 
            this.ALVDurationLabel.AutoSize = true;
            this.ALVDurationLabel.Enabled = false;
            this.ALVDurationLabel.Location = new System.Drawing.Point(581, 30);
            this.ALVDurationLabel.Name = "ALVDurationLabel";
            this.ALVDurationLabel.Size = new System.Drawing.Size(35, 13);
            this.ALVDurationLabel.TabIndex = 60;
            this.ALVDurationLabel.Text = "суток";
            // 
            // CPAPDurationLabel
            // 
            this.CPAPDurationLabel.AutoSize = true;
            this.CPAPDurationLabel.Enabled = false;
            this.CPAPDurationLabel.Location = new System.Drawing.Point(581, 57);
            this.CPAPDurationLabel.Name = "CPAPDurationLabel";
            this.CPAPDurationLabel.Size = new System.Drawing.Size(35, 13);
            this.CPAPDurationLabel.TabIndex = 61;
            this.CPAPDurationLabel.Text = "суток";
            // 
            // CerebralIschemiaComboBox
            // 
            this.CerebralIschemiaComboBox.FormattingEnabled = true;
            this.CerebralIschemiaComboBox.Items.AddRange(new object[] {
            "Нет",
            "Легкая",
            "Средняя",
            "Тяжелая"});
            this.CerebralIschemiaComboBox.Location = new System.Drawing.Point(452, 79);
            this.CerebralIschemiaComboBox.Name = "CerebralIschemiaComboBox";
            this.CerebralIschemiaComboBox.Size = new System.Drawing.Size(161, 21);
            this.CerebralIschemiaComboBox.TabIndex = 62;
            // 
            // IVHDegreeComboBox
            // 
            this.IVHDegreeComboBox.FormattingEnabled = true;
            this.IVHDegreeComboBox.Items.AddRange(new object[] {
            "Нет",
            "I степень",
            "II степень",
            "III степень",
            "IV степень"});
            this.IVHDegreeComboBox.Location = new System.Drawing.Point(452, 105);
            this.IVHDegreeComboBox.Name = "IVHDegreeComboBox";
            this.IVHDegreeComboBox.Size = new System.Drawing.Size(161, 21);
            this.IVHDegreeComboBox.TabIndex = 62;
            this.IVHDegreeComboBox.SelectedIndexChanged += new System.EventHandler(this.IVHDegreeComboBox_SelectedIndexChanged);
            // 
            // IVHLocalizationComboBox
            // 
            this.IVHLocalizationComboBox.Enabled = false;
            this.IVHLocalizationComboBox.FormattingEnabled = true;
            this.IVHLocalizationComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IVHLocalizationComboBox.Items.AddRange(new object[] {
            "Не определено",
            "Справа",
            "Слева",
            "С обеих сторон"});
            this.IVHLocalizationComboBox.Location = new System.Drawing.Point(452, 131);
            this.IVHLocalizationComboBox.Name = "IVHLocalizationComboBox";
            this.IVHLocalizationComboBox.Size = new System.Drawing.Size(161, 21);
            this.IVHLocalizationComboBox.TabIndex = 62;
            this.IVHLocalizationComboBox.Text = "справа";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(326, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 26);
            this.label20.TabIndex = 65;
            this.label20.Text = "Анемия тяжелой \r\nстепени";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(326, 343);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 13);
            this.label21.TabIndex = 67;
            this.label21.Text = "Гипербилирубинемия";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(326, 369);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 69;
            this.label22.Text = "ЯНЭК";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(326, 396);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 71;
            this.label23.Text = "ВПР";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(326, 438);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 26);
            this.label24.TabIndex = 73;
            this.label24.Text = "Оперативное \r\nвмешательство";
            // 
            // BirthDefectTextBox
            // 
            this.BirthDefectTextBox.Enabled = false;
            this.BirthDefectTextBox.Location = new System.Drawing.Point(452, 415);
            this.BirthDefectTextBox.Name = "BirthDefectTextBox";
            this.BirthDefectTextBox.Size = new System.Drawing.Size(161, 20);
            this.BirthDefectTextBox.TabIndex = 75;
            // 
            // SurgeryTextBox
            // 
            this.SurgeryTextBox.Enabled = false;
            this.SurgeryTextBox.Location = new System.Drawing.Point(452, 466);
            this.SurgeryTextBox.Name = "SurgeryTextBox";
            this.SurgeryTextBox.Size = new System.Drawing.Size(161, 20);
            this.SurgeryTextBox.TabIndex = 75;
            // 
            // ALVRadioButtonsPanel
            // 
            this.ALVRadioButtonsPanel.Controls.Add(this.ALVNoRadioButton);
            this.ALVRadioButtonsPanel.Controls.Add(this.ALVYesRadioButton);
            this.ALVRadioButtonsPanel.Location = new System.Drawing.Point(452, 26);
            this.ALVRadioButtonsPanel.Name = "ALVRadioButtonsPanel";
            this.ALVRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.ALVRadioButtonsPanel.TabIndex = 39;
            // 
            // ALVNoRadioButton
            // 
            this.ALVNoRadioButton.AutoSize = true;
            this.ALVNoRadioButton.Checked = true;
            this.ALVNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.ALVNoRadioButton.Name = "ALVNoRadioButton";
            this.ALVNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.ALVNoRadioButton.TabIndex = 36;
            this.ALVNoRadioButton.TabStop = true;
            this.ALVNoRadioButton.Text = "Нет";
            this.ALVNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ALVYesRadioButton
            // 
            this.ALVYesRadioButton.AutoSize = true;
            this.ALVYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.ALVYesRadioButton.Name = "ALVYesRadioButton";
            this.ALVYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.ALVYesRadioButton.TabIndex = 36;
            this.ALVYesRadioButton.Text = "Да";
            this.ALVYesRadioButton.UseVisualStyleBackColor = true;
            this.ALVYesRadioButton.CheckedChanged += new System.EventHandler(this.ALVYesRadioButton_CheckedChanged);
            // 
            // CPAPRadioButtonsPanel
            // 
            this.CPAPRadioButtonsPanel.Controls.Add(this.CPAPNoRadioButton);
            this.CPAPRadioButtonsPanel.Controls.Add(this.CPAPYesRadioButton);
            this.CPAPRadioButtonsPanel.Location = new System.Drawing.Point(452, 53);
            this.CPAPRadioButtonsPanel.Name = "CPAPRadioButtonsPanel";
            this.CPAPRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.CPAPRadioButtonsPanel.TabIndex = 40;
            // 
            // CPAPNoRadioButton
            // 
            this.CPAPNoRadioButton.AutoSize = true;
            this.CPAPNoRadioButton.Checked = true;
            this.CPAPNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.CPAPNoRadioButton.Name = "CPAPNoRadioButton";
            this.CPAPNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.CPAPNoRadioButton.TabIndex = 36;
            this.CPAPNoRadioButton.TabStop = true;
            this.CPAPNoRadioButton.Text = "Нет";
            this.CPAPNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CPAPYesRadioButton
            // 
            this.CPAPYesRadioButton.AutoSize = true;
            this.CPAPYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.CPAPYesRadioButton.Name = "CPAPYesRadioButton";
            this.CPAPYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.CPAPYesRadioButton.TabIndex = 36;
            this.CPAPYesRadioButton.Text = "Да";
            this.CPAPYesRadioButton.UseVisualStyleBackColor = true;
            this.CPAPYesRadioButton.CheckedChanged += new System.EventHandler(this.CPAPYesRadioButton_CheckedChanged);
            // 
            // EncephalitisRadioButtonsPanel
            // 
            this.EncephalitisRadioButtonsPanel.Controls.Add(this.EncephalitisNoRadioButton);
            this.EncephalitisRadioButtonsPanel.Controls.Add(this.EncephalitisYesRadioButton);
            this.EncephalitisRadioButtonsPanel.Location = new System.Drawing.Point(452, 183);
            this.EncephalitisRadioButtonsPanel.Name = "EncephalitisRadioButtonsPanel";
            this.EncephalitisRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.EncephalitisRadioButtonsPanel.TabIndex = 40;
            // 
            // EncephalitisNoRadioButton
            // 
            this.EncephalitisNoRadioButton.AutoSize = true;
            this.EncephalitisNoRadioButton.Checked = true;
            this.EncephalitisNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.EncephalitisNoRadioButton.Name = "EncephalitisNoRadioButton";
            this.EncephalitisNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.EncephalitisNoRadioButton.TabIndex = 36;
            this.EncephalitisNoRadioButton.TabStop = true;
            this.EncephalitisNoRadioButton.Text = "Нет";
            this.EncephalitisNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // EncephalitisYesRadioButton
            // 
            this.EncephalitisYesRadioButton.AutoSize = true;
            this.EncephalitisYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.EncephalitisYesRadioButton.Name = "EncephalitisYesRadioButton";
            this.EncephalitisYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.EncephalitisYesRadioButton.TabIndex = 36;
            this.EncephalitisYesRadioButton.Text = "Да";
            this.EncephalitisYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // MeningitisRadioButtonsPanel
            // 
            this.MeningitisRadioButtonsPanel.Controls.Add(this.MeningitisNoRadioButton);
            this.MeningitisRadioButtonsPanel.Controls.Add(this.MeningitisYesRadioButton);
            this.MeningitisRadioButtonsPanel.Location = new System.Drawing.Point(452, 157);
            this.MeningitisRadioButtonsPanel.Name = "MeningitisRadioButtonsPanel";
            this.MeningitisRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.MeningitisRadioButtonsPanel.TabIndex = 41;
            // 
            // MeningitisNoRadioButton
            // 
            this.MeningitisNoRadioButton.AutoSize = true;
            this.MeningitisNoRadioButton.Checked = true;
            this.MeningitisNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.MeningitisNoRadioButton.Name = "MeningitisNoRadioButton";
            this.MeningitisNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.MeningitisNoRadioButton.TabIndex = 36;
            this.MeningitisNoRadioButton.TabStop = true;
            this.MeningitisNoRadioButton.Text = "Нет";
            this.MeningitisNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // MeningitisYesRadioButton
            // 
            this.MeningitisYesRadioButton.AutoSize = true;
            this.MeningitisYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.MeningitisYesRadioButton.Name = "MeningitisYesRadioButton";
            this.MeningitisYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.MeningitisYesRadioButton.TabIndex = 36;
            this.MeningitisYesRadioButton.Text = "Да";
            this.MeningitisYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConclusiveSyndromeRadioButtonsPanel
            // 
            this.ConclusiveSyndromeRadioButtonsPanel.Controls.Add(this.ConclusiveSyndromeNoRadioButton);
            this.ConclusiveSyndromeRadioButtonsPanel.Controls.Add(this.ConvulsiveSyndromeYesRadioButton);
            this.ConclusiveSyndromeRadioButtonsPanel.Location = new System.Drawing.Point(452, 209);
            this.ConclusiveSyndromeRadioButtonsPanel.Name = "ConclusiveSyndromeRadioButtonsPanel";
            this.ConclusiveSyndromeRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.ConclusiveSyndromeRadioButtonsPanel.TabIndex = 76;
            // 
            // ConclusiveSyndromeNoRadioButton
            // 
            this.ConclusiveSyndromeNoRadioButton.AutoSize = true;
            this.ConclusiveSyndromeNoRadioButton.Checked = true;
            this.ConclusiveSyndromeNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.ConclusiveSyndromeNoRadioButton.Name = "ConclusiveSyndromeNoRadioButton";
            this.ConclusiveSyndromeNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.ConclusiveSyndromeNoRadioButton.TabIndex = 36;
            this.ConclusiveSyndromeNoRadioButton.TabStop = true;
            this.ConclusiveSyndromeNoRadioButton.Text = "Нет";
            this.ConclusiveSyndromeNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConvulsiveSyndromeYesRadioButton
            // 
            this.ConvulsiveSyndromeYesRadioButton.AutoSize = true;
            this.ConvulsiveSyndromeYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.ConvulsiveSyndromeYesRadioButton.Name = "ConvulsiveSyndromeYesRadioButton";
            this.ConvulsiveSyndromeYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.ConvulsiveSyndromeYesRadioButton.TabIndex = 36;
            this.ConvulsiveSyndromeYesRadioButton.Text = "Да";
            this.ConvulsiveSyndromeYesRadioButton.UseVisualStyleBackColor = true;
            this.ConvulsiveSyndromeYesRadioButton.CheckedChanged += new System.EventHandler(this.ConclusiveSyndromeYesRadioButton_CheckedChanged);
            // 
            // ConclusiveSyndromeDurationLabel
            // 
            this.ConclusiveSyndromeDurationLabel.AutoSize = true;
            this.ConclusiveSyndromeDurationLabel.Enabled = false;
            this.ConclusiveSyndromeDurationLabel.Location = new System.Drawing.Point(581, 213);
            this.ConclusiveSyndromeDurationLabel.Name = "ConclusiveSyndromeDurationLabel";
            this.ConclusiveSyndromeDurationLabel.Size = new System.Drawing.Size(35, 13);
            this.ConclusiveSyndromeDurationLabel.TabIndex = 78;
            this.ConclusiveSyndromeDurationLabel.Text = "суток";
            // 
            // ConvulsiveSyndromeDurationTextBox
            // 
            this.ConvulsiveSyndromeDurationTextBox.Enabled = false;
            this.ConvulsiveSyndromeDurationTextBox.Location = new System.Drawing.Point(546, 209);
            this.ConvulsiveSyndromeDurationTextBox.Name = "ConvulsiveSyndromeDurationTextBox";
            this.ConvulsiveSyndromeDurationTextBox.Size = new System.Drawing.Size(32, 20);
            this.ConvulsiveSyndromeDurationTextBox.TabIndex = 77;
            this.ConvulsiveSyndromeDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientFormOnlyIntegerTextBox_KeyPress);
            // 
            // SepsisRadioButtonsPanel
            // 
            this.SepsisRadioButtonsPanel.Controls.Add(this.SepsisNoRadioButton);
            this.SepsisRadioButtonsPanel.Controls.Add(this.SepsisYesRadioButton);
            this.SepsisRadioButtonsPanel.Location = new System.Drawing.Point(452, 235);
            this.SepsisRadioButtonsPanel.Name = "SepsisRadioButtonsPanel";
            this.SepsisRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.SepsisRadioButtonsPanel.TabIndex = 79;
            // 
            // SepsisNoRadioButton
            // 
            this.SepsisNoRadioButton.AutoSize = true;
            this.SepsisNoRadioButton.Checked = true;
            this.SepsisNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.SepsisNoRadioButton.Name = "SepsisNoRadioButton";
            this.SepsisNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.SepsisNoRadioButton.TabIndex = 36;
            this.SepsisNoRadioButton.TabStop = true;
            this.SepsisNoRadioButton.Text = "Нет";
            this.SepsisNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // SepsisYesRadioButton
            // 
            this.SepsisYesRadioButton.AutoSize = true;
            this.SepsisYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.SepsisYesRadioButton.Name = "SepsisYesRadioButton";
            this.SepsisYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.SepsisYesRadioButton.TabIndex = 36;
            this.SepsisYesRadioButton.Text = "Да";
            this.SepsisYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // HDNRadioButtosPanel
            // 
            this.HDNRadioButtosPanel.Controls.Add(this.HDNNoRadioButton);
            this.HDNRadioButtosPanel.Controls.Add(this.HDNYesRadioButton);
            this.HDNRadioButtosPanel.Location = new System.Drawing.Point(452, 263);
            this.HDNRadioButtosPanel.Name = "HDNRadioButtosPanel";
            this.HDNRadioButtosPanel.Size = new System.Drawing.Size(91, 20);
            this.HDNRadioButtosPanel.TabIndex = 80;
            // 
            // HDNNoRadioButton
            // 
            this.HDNNoRadioButton.AutoSize = true;
            this.HDNNoRadioButton.Checked = true;
            this.HDNNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.HDNNoRadioButton.Name = "HDNNoRadioButton";
            this.HDNNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.HDNNoRadioButton.TabIndex = 36;
            this.HDNNoRadioButton.TabStop = true;
            this.HDNNoRadioButton.Text = "Нет";
            this.HDNNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // HDNYesRadioButton
            // 
            this.HDNYesRadioButton.AutoSize = true;
            this.HDNYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.HDNYesRadioButton.Name = "HDNYesRadioButton";
            this.HDNYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.HDNYesRadioButton.TabIndex = 36;
            this.HDNYesRadioButton.Text = "Да";
            this.HDNYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // VKDBRadioButtonsPanel
            // 
            this.VKDBRadioButtonsPanel.Controls.Add(this.VKDBNoRadioButton);
            this.VKDBRadioButtonsPanel.Controls.Add(this.VKDBYesRadioButton);
            this.VKDBRadioButtonsPanel.Location = new System.Drawing.Point(452, 288);
            this.VKDBRadioButtonsPanel.Name = "VKDBRadioButtonsPanel";
            this.VKDBRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.VKDBRadioButtonsPanel.TabIndex = 81;
            // 
            // VKDBNoRadioButton
            // 
            this.VKDBNoRadioButton.AutoSize = true;
            this.VKDBNoRadioButton.Checked = true;
            this.VKDBNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.VKDBNoRadioButton.Name = "VKDBNoRadioButton";
            this.VKDBNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.VKDBNoRadioButton.TabIndex = 36;
            this.VKDBNoRadioButton.TabStop = true;
            this.VKDBNoRadioButton.Text = "Нет";
            this.VKDBNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // VKDBYesRadioButton
            // 
            this.VKDBYesRadioButton.AutoSize = true;
            this.VKDBYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.VKDBYesRadioButton.Name = "VKDBYesRadioButton";
            this.VKDBYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.VKDBYesRadioButton.TabIndex = 36;
            this.VKDBYesRadioButton.Text = "Да";
            this.VKDBYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnemiaRadioButtonsPanel
            // 
            this.AnemiaRadioButtonsPanel.Controls.Add(this.AnemiaNoRadioButton);
            this.AnemiaRadioButtonsPanel.Controls.Add(this.AnemiaYesRadioButton);
            this.AnemiaRadioButtonsPanel.Location = new System.Drawing.Point(452, 314);
            this.AnemiaRadioButtonsPanel.Name = "AnemiaRadioButtonsPanel";
            this.AnemiaRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.AnemiaRadioButtonsPanel.TabIndex = 42;
            // 
            // AnemiaNoRadioButton
            // 
            this.AnemiaNoRadioButton.AutoSize = true;
            this.AnemiaNoRadioButton.Checked = true;
            this.AnemiaNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.AnemiaNoRadioButton.Name = "AnemiaNoRadioButton";
            this.AnemiaNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.AnemiaNoRadioButton.TabIndex = 36;
            this.AnemiaNoRadioButton.TabStop = true;
            this.AnemiaNoRadioButton.Text = "Нет";
            this.AnemiaNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnemiaYesRadioButton
            // 
            this.AnemiaYesRadioButton.AutoSize = true;
            this.AnemiaYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.AnemiaYesRadioButton.Name = "AnemiaYesRadioButton";
            this.AnemiaYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.AnemiaYesRadioButton.TabIndex = 36;
            this.AnemiaYesRadioButton.Text = "Да";
            this.AnemiaYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // HyperbilirubinemiaRadioButtonsPanel
            // 
            this.HyperbilirubinemiaRadioButtonsPanel.Controls.Add(this.HyperbilirubinemiaNoRadioButton);
            this.HyperbilirubinemiaRadioButtonsPanel.Controls.Add(this.HyperbilirubinemiaYesRadioButton);
            this.HyperbilirubinemiaRadioButtonsPanel.Location = new System.Drawing.Point(452, 339);
            this.HyperbilirubinemiaRadioButtonsPanel.Name = "HyperbilirubinemiaRadioButtonsPanel";
            this.HyperbilirubinemiaRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.HyperbilirubinemiaRadioButtonsPanel.TabIndex = 82;
            // 
            // HyperbilirubinemiaNoRadioButton
            // 
            this.HyperbilirubinemiaNoRadioButton.AutoSize = true;
            this.HyperbilirubinemiaNoRadioButton.Checked = true;
            this.HyperbilirubinemiaNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.HyperbilirubinemiaNoRadioButton.Name = "HyperbilirubinemiaNoRadioButton";
            this.HyperbilirubinemiaNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.HyperbilirubinemiaNoRadioButton.TabIndex = 36;
            this.HyperbilirubinemiaNoRadioButton.TabStop = true;
            this.HyperbilirubinemiaNoRadioButton.Text = "Нет";
            this.HyperbilirubinemiaNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // HyperbilirubinemiaYesRadioButton
            // 
            this.HyperbilirubinemiaYesRadioButton.AutoSize = true;
            this.HyperbilirubinemiaYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.HyperbilirubinemiaYesRadioButton.Name = "HyperbilirubinemiaYesRadioButton";
            this.HyperbilirubinemiaYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.HyperbilirubinemiaYesRadioButton.TabIndex = 36;
            this.HyperbilirubinemiaYesRadioButton.Text = "Да";
            this.HyperbilirubinemiaYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // UNECRadioButtonsPanel
            // 
            this.UNECRadioButtonsPanel.Controls.Add(this.UNECNoRadioButton);
            this.UNECRadioButtonsPanel.Controls.Add(this.UNECYesRadioButton);
            this.UNECRadioButtonsPanel.Location = new System.Drawing.Point(452, 364);
            this.UNECRadioButtonsPanel.Name = "UNECRadioButtonsPanel";
            this.UNECRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.UNECRadioButtonsPanel.TabIndex = 83;
            // 
            // UNECNoRadioButton
            // 
            this.UNECNoRadioButton.AutoSize = true;
            this.UNECNoRadioButton.Checked = true;
            this.UNECNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.UNECNoRadioButton.Name = "UNECNoRadioButton";
            this.UNECNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.UNECNoRadioButton.TabIndex = 36;
            this.UNECNoRadioButton.TabStop = true;
            this.UNECNoRadioButton.Text = "Нет";
            this.UNECNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // UNECYesRadioButton
            // 
            this.UNECYesRadioButton.AutoSize = true;
            this.UNECYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.UNECYesRadioButton.Name = "UNECYesRadioButton";
            this.UNECYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.UNECYesRadioButton.TabIndex = 36;
            this.UNECYesRadioButton.Text = "Да";
            this.UNECYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // BirthDefectRadioButtonsPanel
            // 
            this.BirthDefectRadioButtonsPanel.Controls.Add(this.BirthDefectNoRadioButton);
            this.BirthDefectRadioButtonsPanel.Controls.Add(this.BirthDefectYesRadioButton);
            this.BirthDefectRadioButtonsPanel.Location = new System.Drawing.Point(452, 390);
            this.BirthDefectRadioButtonsPanel.Name = "BirthDefectRadioButtonsPanel";
            this.BirthDefectRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.BirthDefectRadioButtonsPanel.TabIndex = 42;
            // 
            // BirthDefectNoRadioButton
            // 
            this.BirthDefectNoRadioButton.AutoSize = true;
            this.BirthDefectNoRadioButton.Checked = true;
            this.BirthDefectNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.BirthDefectNoRadioButton.Name = "BirthDefectNoRadioButton";
            this.BirthDefectNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.BirthDefectNoRadioButton.TabIndex = 36;
            this.BirthDefectNoRadioButton.TabStop = true;
            this.BirthDefectNoRadioButton.Text = "Нет";
            this.BirthDefectNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // BirthDefectYesRadioButton
            // 
            this.BirthDefectYesRadioButton.AutoSize = true;
            this.BirthDefectYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.BirthDefectYesRadioButton.Name = "BirthDefectYesRadioButton";
            this.BirthDefectYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.BirthDefectYesRadioButton.TabIndex = 36;
            this.BirthDefectYesRadioButton.Text = "Да";
            this.BirthDefectYesRadioButton.UseVisualStyleBackColor = true;
            this.BirthDefectYesRadioButton.CheckedChanged += new System.EventHandler(this.BirthDefectYesRadioButton_CheckedChanged);
            // 
            // SurgeryRadioButtonsPanel
            // 
            this.SurgeryRadioButtonsPanel.Controls.Add(this.SurgeryNoRadioButton);
            this.SurgeryRadioButtonsPanel.Controls.Add(this.SurgeryYesRadioButton);
            this.SurgeryRadioButtonsPanel.Location = new System.Drawing.Point(452, 441);
            this.SurgeryRadioButtonsPanel.Name = "SurgeryRadioButtonsPanel";
            this.SurgeryRadioButtonsPanel.Size = new System.Drawing.Size(91, 20);
            this.SurgeryRadioButtonsPanel.TabIndex = 84;
            // 
            // SurgeryNoRadioButton
            // 
            this.SurgeryNoRadioButton.AutoSize = true;
            this.SurgeryNoRadioButton.Checked = true;
            this.SurgeryNoRadioButton.Location = new System.Drawing.Point(3, 2);
            this.SurgeryNoRadioButton.Name = "SurgeryNoRadioButton";
            this.SurgeryNoRadioButton.Size = new System.Drawing.Size(44, 17);
            this.SurgeryNoRadioButton.TabIndex = 36;
            this.SurgeryNoRadioButton.TabStop = true;
            this.SurgeryNoRadioButton.Text = "Нет";
            this.SurgeryNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // SurgeryYesRadioButton
            // 
            this.SurgeryYesRadioButton.AutoSize = true;
            this.SurgeryYesRadioButton.Location = new System.Drawing.Point(48, 2);
            this.SurgeryYesRadioButton.Name = "SurgeryYesRadioButton";
            this.SurgeryYesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.SurgeryYesRadioButton.TabIndex = 36;
            this.SurgeryYesRadioButton.Text = "Да";
            this.SurgeryYesRadioButton.UseVisualStyleBackColor = true;
            this.SurgeryYesRadioButton.CheckedChanged += new System.EventHandler(this.SurgeryYesRadioButton_CheckedChanged);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.HospitalizationFirstTimeRadioButton);
            this.panel15.Controls.Add(this.HospitalizationNotFirstTimeRadioButton);
            this.panel15.Location = new System.Drawing.Point(136, 393);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(161, 20);
            this.panel15.TabIndex = 43;
            // 
            // HospitalizationFirstTimeRadioButton
            // 
            this.HospitalizationFirstTimeRadioButton.AutoSize = true;
            this.HospitalizationFirstTimeRadioButton.Checked = true;
            this.HospitalizationFirstTimeRadioButton.Location = new System.Drawing.Point(3, 2);
            this.HospitalizationFirstTimeRadioButton.Name = "HospitalizationFirstTimeRadioButton";
            this.HospitalizationFirstTimeRadioButton.Size = new System.Drawing.Size(80, 17);
            this.HospitalizationFirstTimeRadioButton.TabIndex = 36;
            this.HospitalizationFirstTimeRadioButton.TabStop = true;
            this.HospitalizationFirstTimeRadioButton.Text = "Первичная";
            this.HospitalizationFirstTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // HospitalizationNotFirstTimeRadioButton
            // 
            this.HospitalizationNotFirstTimeRadioButton.AutoSize = true;
            this.HospitalizationNotFirstTimeRadioButton.Location = new System.Drawing.Point(83, 2);
            this.HospitalizationNotFirstTimeRadioButton.Name = "HospitalizationNotFirstTimeRadioButton";
            this.HospitalizationNotFirstTimeRadioButton.Size = new System.Drawing.Size(80, 17);
            this.HospitalizationNotFirstTimeRadioButton.TabIndex = 36;
            this.HospitalizationNotFirstTimeRadioButton.Text = "Повторная";
            this.HospitalizationNotFirstTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // CaseHistoryLabel
            // 
            this.CaseHistoryLabel.AutoSize = true;
            this.CaseHistoryLabel.Location = new System.Drawing.Point(326, 496);
            this.CaseHistoryLabel.Name = "CaseHistoryLabel";
            this.CaseHistoryLabel.Size = new System.Drawing.Size(109, 13);
            this.CaseHistoryLabel.TabIndex = 85;
            this.CaseHistoryLabel.Text = "№ Истории болезни";
            // 
            // PatientHistoryTextBox
            // 
            this.PatientHistoryTextBox.Location = new System.Drawing.Point(452, 493);
            this.PatientHistoryTextBox.Name = "PatientHistoryTextBox";
            this.PatientHistoryTextBox.Size = new System.Drawing.Size(161, 20);
            this.PatientHistoryTextBox.TabIndex = 86;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 550);
            this.Controls.Add(this.PatientHistoryTextBox);
            this.Controls.Add(this.CaseHistoryLabel);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.SurgeryRadioButtonsPanel);
            this.Controls.Add(this.BirthDefectRadioButtonsPanel);
            this.Controls.Add(this.UNECRadioButtonsPanel);
            this.Controls.Add(this.HyperbilirubinemiaRadioButtonsPanel);
            this.Controls.Add(this.AnemiaRadioButtonsPanel);
            this.Controls.Add(this.VKDBRadioButtonsPanel);
            this.Controls.Add(this.HDNRadioButtosPanel);
            this.Controls.Add(this.SepsisRadioButtonsPanel);
            this.Controls.Add(this.ConclusiveSyndromeRadioButtonsPanel);
            this.Controls.Add(this.ConclusiveSyndromeDurationLabel);
            this.Controls.Add(this.ConvulsiveSyndromeDurationTextBox);
            this.Controls.Add(this.MeningitisRadioButtonsPanel);
            this.Controls.Add(this.EncephalitisRadioButtonsPanel);
            this.Controls.Add(this.CPAPRadioButtonsPanel);
            this.Controls.Add(this.ALVRadioButtonsPanel);
            this.Controls.Add(this.SurgeryTextBox);
            this.Controls.Add(this.BirthDefectTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.IVHLocalizationComboBox);
            this.Controls.Add(this.IVHDegreeComboBox);
            this.Controls.Add(this.CerebralIschemiaComboBox);
            this.Controls.Add(this.CPAPDurationLabel);
            this.Controls.Add(this.ALVDurationLabel);
            this.Controls.Add(this.CPAPDurationTextBox);
            this.Controls.Add(this.ALVDutarionTextBox);
            this.Controls.Add(this.HospitalizationDatePicker);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ApgarTextBox3);
            this.Controls.Add(this.ApgarTextBox2);
            this.Controls.Add(this.ApgarTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GestationAgeTextBox);
            this.Controls.Add(this.disabilityRadioButtonsPanel);
            this.Controls.Add(this.GestationAgeLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SexRadioButtonsPanel);
            this.Controls.Add(this.BirthChestSizeTextBox);
            this.Controls.Add(this.sexPatientLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChestSizeLabel);
            this.Controls.Add(this.BirthHeadSizeTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HeadSizeNewbornLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BirthHeightTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HeightNewbornLabel);
            this.Controls.Add(this.BirthWeightTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeightNewbornLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ALVLabel);
            this.Controls.Add(this.ParentFIOTextBox);
            this.Controls.Add(this.FIOParentLabel);
            this.Controls.Add(this.PatientAddressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CreatePatientButton);
            this.Controls.Add(this.PatientBirthDatePicker);
            this.Controls.Add(this.PatientSurNameTextBox);
            this.Controls.Add(this.PatientFirstNameTextBox);
            this.Controls.Add(this.PatientLastNameTextBox);
            this.Controls.Add(this.PatientDoctorLabel);
            this.Controls.Add(this.PatientBirthDateLabel);
            this.Controls.Add(this.PatientSurNameLabel);
            this.Controls.Add(this.PatientFirstNameLabel);
            this.Controls.Add(this.PatientLastNameLabel);
            this.Name = "PatientForm";
            this.Text = "Новый пациент";
            this.SexRadioButtonsPanel.ResumeLayout(false);
            this.SexRadioButtonsPanel.PerformLayout();
            this.disabilityRadioButtonsPanel.ResumeLayout(false);
            this.disabilityRadioButtonsPanel.PerformLayout();
            this.ALVRadioButtonsPanel.ResumeLayout(false);
            this.ALVRadioButtonsPanel.PerformLayout();
            this.CPAPRadioButtonsPanel.ResumeLayout(false);
            this.CPAPRadioButtonsPanel.PerformLayout();
            this.EncephalitisRadioButtonsPanel.ResumeLayout(false);
            this.EncephalitisRadioButtonsPanel.PerformLayout();
            this.MeningitisRadioButtonsPanel.ResumeLayout(false);
            this.MeningitisRadioButtonsPanel.PerformLayout();
            this.ConclusiveSyndromeRadioButtonsPanel.ResumeLayout(false);
            this.ConclusiveSyndromeRadioButtonsPanel.PerformLayout();
            this.SepsisRadioButtonsPanel.ResumeLayout(false);
            this.SepsisRadioButtonsPanel.PerformLayout();
            this.HDNRadioButtosPanel.ResumeLayout(false);
            this.HDNRadioButtosPanel.PerformLayout();
            this.VKDBRadioButtonsPanel.ResumeLayout(false);
            this.VKDBRadioButtonsPanel.PerformLayout();
            this.AnemiaRadioButtonsPanel.ResumeLayout(false);
            this.AnemiaRadioButtonsPanel.PerformLayout();
            this.HyperbilirubinemiaRadioButtonsPanel.ResumeLayout(false);
            this.HyperbilirubinemiaRadioButtonsPanel.PerformLayout();
            this.UNECRadioButtonsPanel.ResumeLayout(false);
            this.UNECRadioButtonsPanel.PerformLayout();
            this.BirthDefectRadioButtonsPanel.ResumeLayout(false);
            this.BirthDefectRadioButtonsPanel.PerformLayout();
            this.SurgeryRadioButtonsPanel.ResumeLayout(false);
            this.SurgeryRadioButtonsPanel.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
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
        private System.Windows.Forms.Button CreatePatientButton;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.TextBox PatientAddressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox ParentFIOTextBox;
        private System.Windows.Forms.Label FIOParentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ALVLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sexPatientLabel;
        private System.Windows.Forms.RadioButton MaleSexRadioButton;
        private System.Windows.Forms.RadioButton FemaleSexRadioButton;
        private System.Windows.Forms.Panel SexRadioButtonsPanel;
        private System.Windows.Forms.Label GestationAgeLabel;
        private System.Windows.Forms.TextBox GestationAgeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label WeightNewbornLabel;
        private System.Windows.Forms.TextBox BirthWeightTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BirthHeadSizeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label HeadSizeNewbornLabel;
        private System.Windows.Forms.TextBox BirthHeightTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label HeightNewbornLabel;
        private System.Windows.Forms.TextBox ApgarTextBox3;
        private System.Windows.Forms.TextBox ApgarTextBox2;
        private System.Windows.Forms.TextBox ApgarTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel disabilityRadioButtonsPanel;
        private System.Windows.Forms.RadioButton DisabilityNoRadioButton;
        private System.Windows.Forms.RadioButton DisabilityYesRadioButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BirthChestSizeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ChestSizeLabel;
        private Label label16;
        private DateTimePicker HospitalizationDatePicker;
        private Label label17;
        private TextBox CPAPDurationTextBox;
        private TextBox ALVDutarionTextBox;
        private Label ALVDurationLabel;
        private Label CPAPDurationLabel;
        private ComboBox CerebralIschemiaComboBox;
        private ComboBox IVHDegreeComboBox;
        private ComboBox IVHLocalizationComboBox;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox BirthDefectTextBox;
        private TextBox SurgeryTextBox;
        private Panel ALVRadioButtonsPanel;
        private RadioButton ALVNoRadioButton;
        private RadioButton ALVYesRadioButton;
        private Panel CPAPRadioButtonsPanel;
        private RadioButton CPAPNoRadioButton;
        private RadioButton CPAPYesRadioButton;
        private Panel EncephalitisRadioButtonsPanel;
        private RadioButton EncephalitisNoRadioButton;
        private RadioButton EncephalitisYesRadioButton;
        private Panel MeningitisRadioButtonsPanel;
        private RadioButton MeningitisNoRadioButton;
        private RadioButton MeningitisYesRadioButton;
        private Panel ConclusiveSyndromeRadioButtonsPanel;
        private RadioButton ConclusiveSyndromeNoRadioButton;
        private RadioButton ConvulsiveSyndromeYesRadioButton;
        private Label ConclusiveSyndromeDurationLabel;
        private TextBox ConvulsiveSyndromeDurationTextBox;
        private Panel SepsisRadioButtonsPanel;
        private RadioButton SepsisNoRadioButton;
        private RadioButton SepsisYesRadioButton;
        private Panel HDNRadioButtosPanel;
        private RadioButton HDNNoRadioButton;
        private RadioButton HDNYesRadioButton;
        private Panel VKDBRadioButtonsPanel;
        private RadioButton VKDBNoRadioButton;
        private RadioButton VKDBYesRadioButton;
        private Panel AnemiaRadioButtonsPanel;
        private RadioButton AnemiaNoRadioButton;
        private RadioButton AnemiaYesRadioButton;
        private Panel HyperbilirubinemiaRadioButtonsPanel;
        private RadioButton HyperbilirubinemiaNoRadioButton;
        private RadioButton HyperbilirubinemiaYesRadioButton;
        private Panel UNECRadioButtonsPanel;
        private RadioButton UNECNoRadioButton;
        private RadioButton UNECYesRadioButton;
        private Panel BirthDefectRadioButtonsPanel;
        private RadioButton BirthDefectNoRadioButton;
        private RadioButton BirthDefectYesRadioButton;
        private Panel SurgeryRadioButtonsPanel;
        private RadioButton SurgeryNoRadioButton;
        private RadioButton SurgeryYesRadioButton;
        private Panel panel15;
        private RadioButton HospitalizationFirstTimeRadioButton;
        private RadioButton HospitalizationNotFirstTimeRadioButton;
        private Label CaseHistoryLabel;
        private TextBox PatientHistoryTextBox;
    }
}