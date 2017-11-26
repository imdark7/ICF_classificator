namespace ICF_classificator
{
    partial class FiltersForm
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
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.CheckBoxesGroupBox = new System.Windows.Forms.GroupBox();
            this.BirthDefect = new System.Windows.Forms.CheckBox();
            this.ConvulsiveSyndrome = new System.Windows.Forms.CheckBox();
            this.HospitalizationDate = new System.Windows.Forms.CheckBox();
            this.Weight = new System.Windows.Forms.CheckBox();
            this.UNEC = new System.Windows.Forms.CheckBox();
            this.Encephalitis = new System.Windows.Forms.CheckBox();
            this.IsNotFirstHospitalization = new System.Windows.Forms.CheckBox();
            this.GestationAge = new System.Windows.Forms.CheckBox();
            this.Hyperbilirubinemia = new System.Windows.Forms.CheckBox();
            this.Meningitis = new System.Windows.Forms.CheckBox();
            this.Disability = new System.Windows.Forms.CheckBox();
            this.BirthDate = new System.Windows.Forms.CheckBox();
            this.Anemia = new System.Windows.Forms.CheckBox();
            this.IVH = new System.Windows.Forms.CheckBox();
            this.ApgarScale = new System.Windows.Forms.CheckBox();
            this.ParentName = new System.Windows.Forms.CheckBox();
            this.VKDB = new System.Windows.Forms.CheckBox();
            this.CerebralIschemia = new System.Windows.Forms.CheckBox();
            this.ChestSize = new System.Windows.Forms.CheckBox();
            this.Address = new System.Windows.Forms.CheckBox();
            this.PatientHistory = new System.Windows.Forms.CheckBox();
            this.HDN = new System.Windows.Forms.CheckBox();
            this.CPAPDuration = new System.Windows.Forms.CheckBox();
            this.HeadSize = new System.Windows.Forms.CheckBox();
            this.Sex = new System.Windows.Forms.CheckBox();
            this.Surgery = new System.Windows.Forms.CheckBox();
            this.Sepsis = new System.Windows.Forms.CheckBox();
            this.ALVDuration = new System.Windows.Forms.CheckBox();
            this.Height = new System.Windows.Forms.CheckBox();
            this.PatientName = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.RefreshReportDataGridButton = new System.Windows.Forms.Button();
            this.FillCheckBoxesButton = new System.Windows.Forms.Button();
            this.addConditionButton = new System.Windows.Forms.Button();
            this.deleteConditionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.CheckBoxesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Location = new System.Drawing.Point(12, 117);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.Size = new System.Drawing.Size(744, 326);
            this.ResultDataGridView.TabIndex = 0;
            this.ResultDataGridView.LocationChanged += new System.EventHandler(this.ResultDataGridView_LocationChanged);
            // 
            // CheckBoxesGroupBox
            // 
            this.CheckBoxesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckBoxesGroupBox.Controls.Add(this.BirthDefect);
            this.CheckBoxesGroupBox.Controls.Add(this.ConvulsiveSyndrome);
            this.CheckBoxesGroupBox.Controls.Add(this.HospitalizationDate);
            this.CheckBoxesGroupBox.Controls.Add(this.Weight);
            this.CheckBoxesGroupBox.Controls.Add(this.UNEC);
            this.CheckBoxesGroupBox.Controls.Add(this.Encephalitis);
            this.CheckBoxesGroupBox.Controls.Add(this.IsNotFirstHospitalization);
            this.CheckBoxesGroupBox.Controls.Add(this.GestationAge);
            this.CheckBoxesGroupBox.Controls.Add(this.Hyperbilirubinemia);
            this.CheckBoxesGroupBox.Controls.Add(this.Meningitis);
            this.CheckBoxesGroupBox.Controls.Add(this.Disability);
            this.CheckBoxesGroupBox.Controls.Add(this.BirthDate);
            this.CheckBoxesGroupBox.Controls.Add(this.Anemia);
            this.CheckBoxesGroupBox.Controls.Add(this.IVH);
            this.CheckBoxesGroupBox.Controls.Add(this.ApgarScale);
            this.CheckBoxesGroupBox.Controls.Add(this.ParentName);
            this.CheckBoxesGroupBox.Controls.Add(this.VKDB);
            this.CheckBoxesGroupBox.Controls.Add(this.CerebralIschemia);
            this.CheckBoxesGroupBox.Controls.Add(this.ChestSize);
            this.CheckBoxesGroupBox.Controls.Add(this.Address);
            this.CheckBoxesGroupBox.Controls.Add(this.PatientHistory);
            this.CheckBoxesGroupBox.Controls.Add(this.HDN);
            this.CheckBoxesGroupBox.Controls.Add(this.CPAPDuration);
            this.CheckBoxesGroupBox.Controls.Add(this.HeadSize);
            this.CheckBoxesGroupBox.Controls.Add(this.Sex);
            this.CheckBoxesGroupBox.Controls.Add(this.Surgery);
            this.CheckBoxesGroupBox.Controls.Add(this.Sepsis);
            this.CheckBoxesGroupBox.Controls.Add(this.ALVDuration);
            this.CheckBoxesGroupBox.Controls.Add(this.Height);
            this.CheckBoxesGroupBox.Controls.Add(this.PatientName);
            this.CheckBoxesGroupBox.Location = new System.Drawing.Point(12, 449);
            this.CheckBoxesGroupBox.Name = "CheckBoxesGroupBox";
            this.CheckBoxesGroupBox.Size = new System.Drawing.Size(610, 195);
            this.CheckBoxesGroupBox.TabIndex = 4;
            this.CheckBoxesGroupBox.TabStop = false;
            // 
            // BirthDefect
            // 
            this.BirthDefect.AutoSize = true;
            this.BirthDefect.Location = new System.Drawing.Point(441, 149);
            this.BirthDefect.Name = "BirthDefect";
            this.BirthDefect.Size = new System.Drawing.Size(48, 17);
            this.BirthDefect.TabIndex = 0;
            this.BirthDefect.Text = "ВПР";
            this.BirthDefect.UseVisualStyleBackColor = true;
            // 
            // ConvulsiveSyndrome
            // 
            this.ConvulsiveSyndrome.AutoSize = true;
            this.ConvulsiveSyndrome.Location = new System.Drawing.Point(292, 149);
            this.ConvulsiveSyndrome.Name = "ConvulsiveSyndrome";
            this.ConvulsiveSyndrome.Size = new System.Drawing.Size(137, 17);
            this.ConvulsiveSyndrome.TabIndex = 0;
            this.ConvulsiveSyndrome.Text = "Судорожный синдром";
            this.ConvulsiveSyndrome.UseVisualStyleBackColor = true;
            // 
            // HospitalizationDate
            // 
            this.HospitalizationDate.AutoSize = true;
            this.HospitalizationDate.Location = new System.Drawing.Point(153, 149);
            this.HospitalizationDate.Name = "HospitalizationDate";
            this.HospitalizationDate.Size = new System.Drawing.Size(119, 17);
            this.HospitalizationDate.TabIndex = 0;
            this.HospitalizationDate.Text = "Дата поступления";
            this.HospitalizationDate.UseVisualStyleBackColor = true;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(9, 150);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(133, 17);
            this.Weight.TabIndex = 0;
            this.Weight.Text = "Масса при рождении";
            this.Weight.UseVisualStyleBackColor = true;
            // 
            // UNEC
            // 
            this.UNEC.AutoSize = true;
            this.UNEC.Location = new System.Drawing.Point(441, 126);
            this.UNEC.Name = "UNEC";
            this.UNEC.Size = new System.Drawing.Size(56, 17);
            this.UNEC.TabIndex = 0;
            this.UNEC.Text = "ЯНЭК";
            this.UNEC.UseVisualStyleBackColor = true;
            // 
            // Encephalitis
            // 
            this.Encephalitis.AutoSize = true;
            this.Encephalitis.Location = new System.Drawing.Point(292, 126);
            this.Encephalitis.Name = "Encephalitis";
            this.Encephalitis.Size = new System.Drawing.Size(82, 17);
            this.Encephalitis.TabIndex = 0;
            this.Encephalitis.Text = "Энцефалит";
            this.Encephalitis.UseVisualStyleBackColor = true;
            // 
            // IsNotFirstHospitalization
            // 
            this.IsNotFirstHospitalization.AutoSize = true;
            this.IsNotFirstHospitalization.Location = new System.Drawing.Point(153, 126);
            this.IsNotFirstHospitalization.Name = "IsNotFirstHospitalization";
            this.IsNotFirstHospitalization.Size = new System.Drawing.Size(109, 17);
            this.IsNotFirstHospitalization.TabIndex = 0;
            this.IsNotFirstHospitalization.Text = "Госпитализация";
            this.IsNotFirstHospitalization.UseVisualStyleBackColor = true;
            // 
            // GestationAge
            // 
            this.GestationAge.AutoSize = true;
            this.GestationAge.Location = new System.Drawing.Point(9, 127);
            this.GestationAge.Name = "GestationAge";
            this.GestationAge.Size = new System.Drawing.Size(143, 17);
            this.GestationAge.TabIndex = 0;
            this.GestationAge.Text = "Гестационный возраст";
            this.GestationAge.UseVisualStyleBackColor = true;
            // 
            // Hyperbilirubinemia
            // 
            this.Hyperbilirubinemia.AutoSize = true;
            this.Hyperbilirubinemia.Location = new System.Drawing.Point(441, 103);
            this.Hyperbilirubinemia.Name = "Hyperbilirubinemia";
            this.Hyperbilirubinemia.Size = new System.Drawing.Size(135, 17);
            this.Hyperbilirubinemia.TabIndex = 0;
            this.Hyperbilirubinemia.Text = "Гипербилирубинемия";
            this.Hyperbilirubinemia.UseVisualStyleBackColor = true;
            // 
            // Meningitis
            // 
            this.Meningitis.AutoSize = true;
            this.Meningitis.Location = new System.Drawing.Point(292, 103);
            this.Meningitis.Name = "Meningitis";
            this.Meningitis.Size = new System.Drawing.Size(75, 17);
            this.Meningitis.TabIndex = 0;
            this.Meningitis.Text = "Менингит";
            this.Meningitis.UseVisualStyleBackColor = true;
            // 
            // Disability
            // 
            this.Disability.AutoSize = true;
            this.Disability.Location = new System.Drawing.Point(153, 103);
            this.Disability.Name = "Disability";
            this.Disability.Size = new System.Drawing.Size(99, 17);
            this.Disability.TabIndex = 0;
            this.Disability.Text = "Инвалидность";
            this.Disability.UseVisualStyleBackColor = true;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(9, 104);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(105, 17);
            this.BirthDate.TabIndex = 0;
            this.BirthDate.Text = "Дата рождения";
            this.BirthDate.UseVisualStyleBackColor = true;
            // 
            // Anemia
            // 
            this.Anemia.AutoSize = true;
            this.Anemia.Location = new System.Drawing.Point(441, 80);
            this.Anemia.Name = "Anemia";
            this.Anemia.Size = new System.Drawing.Size(155, 17);
            this.Anemia.TabIndex = 0;
            this.Anemia.Text = "Анемия тяжелой степени";
            this.Anemia.UseVisualStyleBackColor = true;
            // 
            // IVH
            // 
            this.IVH.AutoSize = true;
            this.IVH.Location = new System.Drawing.Point(292, 80);
            this.IVH.Name = "IVH";
            this.IVH.Size = new System.Drawing.Size(51, 17);
            this.IVH.TabIndex = 0;
            this.IVH.Text = "ВЖК";
            this.IVH.UseVisualStyleBackColor = true;
            // 
            // ApgarScale
            // 
            this.ApgarScale.AutoSize = true;
            this.ApgarScale.Location = new System.Drawing.Point(153, 80);
            this.ApgarScale.Name = "ApgarScale";
            this.ApgarScale.Size = new System.Drawing.Size(112, 17);
            this.ApgarScale.TabIndex = 0;
            this.ApgarScale.Text = "Оценка по Апгар";
            this.ApgarScale.UseVisualStyleBackColor = true;
            // 
            // ParentName
            // 
            this.ParentName.AutoSize = true;
            this.ParentName.Location = new System.Drawing.Point(9, 81);
            this.ParentName.Name = "ParentName";
            this.ParentName.Size = new System.Drawing.Size(98, 17);
            this.ParentName.TabIndex = 0;
            this.ParentName.Text = "Имя родителя";
            this.ParentName.UseVisualStyleBackColor = true;
            // 
            // VKDB
            // 
            this.VKDB.AutoSize = true;
            this.VKDB.Location = new System.Drawing.Point(441, 57);
            this.VKDB.Name = "VKDB";
            this.VKDB.Size = new System.Drawing.Size(163, 17);
            this.VKDB.TabIndex = 0;
            this.VKDB.Text = "Геморрагический синдром";
            this.VKDB.UseVisualStyleBackColor = true;
            // 
            // CerebralIschemia
            // 
            this.CerebralIschemia.AutoSize = true;
            this.CerebralIschemia.Location = new System.Drawing.Point(292, 57);
            this.CerebralIschemia.Name = "CerebralIschemia";
            this.CerebralIschemia.Size = new System.Drawing.Size(143, 17);
            this.CerebralIschemia.TabIndex = 0;
            this.CerebralIschemia.Text = "Церебральная ишемия";
            this.CerebralIschemia.UseVisualStyleBackColor = true;
            // 
            // ChestSize
            // 
            this.ChestSize.AutoSize = true;
            this.ChestSize.Location = new System.Drawing.Point(153, 57);
            this.ChestSize.Name = "ChestSize";
            this.ChestSize.Size = new System.Drawing.Size(119, 17);
            this.ChestSize.TabIndex = 0;
            this.ChestSize.Text = "Окружность груди";
            this.ChestSize.UseVisualStyleBackColor = true;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(9, 58);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(57, 17);
            this.Address.TabIndex = 0;
            this.Address.Text = "Адрес";
            this.Address.UseVisualStyleBackColor = true;
            // 
            // PatientHistory
            // 
            this.PatientHistory.AutoSize = true;
            this.PatientHistory.Location = new System.Drawing.Point(9, 173);
            this.PatientHistory.Name = "PatientHistory";
            this.PatientHistory.Size = new System.Drawing.Size(128, 17);
            this.PatientHistory.TabIndex = 0;
            this.PatientHistory.Text = "№ Истории болезни";
            this.PatientHistory.UseVisualStyleBackColor = true;
            // 
            // HDN
            // 
            this.HDN.AutoSize = true;
            this.HDN.Location = new System.Drawing.Point(441, 34);
            this.HDN.Name = "HDN";
            this.HDN.Size = new System.Drawing.Size(47, 17);
            this.HDN.TabIndex = 0;
            this.HDN.Text = "ГБН";
            this.HDN.UseVisualStyleBackColor = true;
            // 
            // CPAPDuration
            // 
            this.CPAPDuration.AutoSize = true;
            this.CPAPDuration.Location = new System.Drawing.Point(292, 34);
            this.CPAPDuration.Name = "CPAPDuration";
            this.CPAPDuration.Size = new System.Drawing.Size(54, 17);
            this.CPAPDuration.TabIndex = 0;
            this.CPAPDuration.Text = "CPAP";
            this.CPAPDuration.UseVisualStyleBackColor = true;
            // 
            // HeadSize
            // 
            this.HeadSize.AutoSize = true;
            this.HeadSize.Location = new System.Drawing.Point(153, 34);
            this.HeadSize.Name = "HeadSize";
            this.HeadSize.Size = new System.Drawing.Size(128, 17);
            this.HeadSize.TabIndex = 0;
            this.HeadSize.Text = "Окружность головы";
            this.HeadSize.UseVisualStyleBackColor = true;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(9, 35);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(46, 17);
            this.Sex.TabIndex = 0;
            this.Sex.Text = "Пол";
            this.Sex.UseVisualStyleBackColor = true;
            // 
            // Surgery
            // 
            this.Surgery.AutoSize = true;
            this.Surgery.Location = new System.Drawing.Point(153, 172);
            this.Surgery.Name = "Surgery";
            this.Surgery.Size = new System.Drawing.Size(176, 17);
            this.Surgery.TabIndex = 0;
            this.Surgery.Text = "Оперативное вмешательство";
            this.Surgery.UseVisualStyleBackColor = true;
            // 
            // Sepsis
            // 
            this.Sepsis.AutoSize = true;
            this.Sepsis.Location = new System.Drawing.Point(441, 11);
            this.Sepsis.Name = "Sepsis";
            this.Sepsis.Size = new System.Drawing.Size(63, 17);
            this.Sepsis.TabIndex = 0;
            this.Sepsis.Text = "Сепсис";
            this.Sepsis.UseVisualStyleBackColor = true;
            // 
            // ALVDuration
            // 
            this.ALVDuration.AutoSize = true;
            this.ALVDuration.Location = new System.Drawing.Point(292, 11);
            this.ALVDuration.Name = "ALVDuration";
            this.ALVDuration.Size = new System.Drawing.Size(49, 17);
            this.ALVDuration.TabIndex = 0;
            this.ALVDuration.Text = "ИВЛ";
            this.ALVDuration.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(153, 11);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(133, 17);
            this.Height.TabIndex = 0;
            this.Height.Text = "Длина при рождении";
            this.Height.UseVisualStyleBackColor = true;
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Location = new System.Drawing.Point(9, 12);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(105, 17);
            this.PatientName.TabIndex = 0;
            this.PatientName.Text = "ФИО Пациента";
            this.PatientName.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(533, 14);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 37);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // RefreshReportDataGridButton
            // 
            this.RefreshReportDataGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshReportDataGridButton.Location = new System.Drawing.Point(642, 518);
            this.RefreshReportDataGridButton.Name = "RefreshReportDataGridButton";
            this.RefreshReportDataGridButton.Size = new System.Drawing.Size(105, 64);
            this.RefreshReportDataGridButton.TabIndex = 6;
            this.RefreshReportDataGridButton.Text = "Отобразить выбранные стоблцы";
            this.RefreshReportDataGridButton.UseVisualStyleBackColor = true;
            this.RefreshReportDataGridButton.Click += new System.EventHandler(this.RefreshReportDataGridButton_Click);
            // 
            // FillCheckBoxesButton
            // 
            this.FillCheckBoxesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillCheckBoxesButton.Location = new System.Drawing.Point(642, 461);
            this.FillCheckBoxesButton.Name = "FillCheckBoxesButton";
            this.FillCheckBoxesButton.Size = new System.Drawing.Size(105, 40);
            this.FillCheckBoxesButton.TabIndex = 5;
            this.FillCheckBoxesButton.Text = "button1";
            this.FillCheckBoxesButton.UseVisualStyleBackColor = true;
            this.FillCheckBoxesButton.Click += new System.EventHandler(this.FillCheckBoxesButton_Click);
            // 
            // addConditionButton
            // 
            this.addConditionButton.Location = new System.Drawing.Point(12, 42);
            this.addConditionButton.Name = "addConditionButton";
            this.addConditionButton.Size = new System.Drawing.Size(124, 23);
            this.addConditionButton.TabIndex = 10;
            this.addConditionButton.Text = "+ Добавить";
            this.addConditionButton.UseVisualStyleBackColor = true;
            this.addConditionButton.LocationChanged += new System.EventHandler(this.addConditionButton_LocationChanged);
            this.addConditionButton.Click += new System.EventHandler(this.addConditionButton_Click);
            // 
            // deleteConditionButton
            // 
            this.deleteConditionButton.Location = new System.Drawing.Point(142, 42);
            this.deleteConditionButton.Name = "deleteConditionButton";
            this.deleteConditionButton.Size = new System.Drawing.Size(124, 23);
            this.deleteConditionButton.TabIndex = 10;
            this.deleteConditionButton.Text = "Удалить строку";
            this.deleteConditionButton.UseVisualStyleBackColor = true;
            this.deleteConditionButton.Click += new System.EventHandler(this.deleteConditionButton_Click);
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 667);
            this.Controls.Add(this.deleteConditionButton);
            this.Controls.Add(this.addConditionButton);
            this.Controls.Add(this.RefreshReportDataGridButton);
            this.Controls.Add(this.FillCheckBoxesButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.CheckBoxesGroupBox);
            this.Controls.Add(this.ResultDataGridView);
            this.MinimumSize = new System.Drawing.Size(780, 480);
            this.Name = "FiltersForm";
            this.Text = "FiltersForm";
            this.Load += new System.EventHandler(this.FiltersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.CheckBoxesGroupBox.ResumeLayout(false);
            this.CheckBoxesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.GroupBox CheckBoxesGroupBox;
        private System.Windows.Forms.CheckBox BirthDefect;
        private System.Windows.Forms.CheckBox ConvulsiveSyndrome;
        private System.Windows.Forms.CheckBox HospitalizationDate;
        private System.Windows.Forms.CheckBox Weight;
        private System.Windows.Forms.CheckBox UNEC;
        private System.Windows.Forms.CheckBox Encephalitis;
        private System.Windows.Forms.CheckBox IsNotFirstHospitalization;
        private System.Windows.Forms.CheckBox GestationAge;
        private System.Windows.Forms.CheckBox Hyperbilirubinemia;
        private System.Windows.Forms.CheckBox Meningitis;
        private System.Windows.Forms.CheckBox Disability;
        private System.Windows.Forms.CheckBox BirthDate;
        private System.Windows.Forms.CheckBox Anemia;
        private System.Windows.Forms.CheckBox IVH;
        private System.Windows.Forms.CheckBox ApgarScale;
        private System.Windows.Forms.CheckBox ParentName;
        private System.Windows.Forms.CheckBox VKDB;
        private System.Windows.Forms.CheckBox CerebralIschemia;
        private System.Windows.Forms.CheckBox ChestSize;
        private System.Windows.Forms.CheckBox Address;
        private System.Windows.Forms.CheckBox HDN;
        private System.Windows.Forms.CheckBox CPAPDuration;
        private System.Windows.Forms.CheckBox HeadSize;
        private System.Windows.Forms.CheckBox Sex;
        private System.Windows.Forms.CheckBox Sepsis;
        private System.Windows.Forms.CheckBox ALVDuration;
        private System.Windows.Forms.CheckBox Height;
        private System.Windows.Forms.CheckBox PatientName;
        private System.Windows.Forms.CheckBox PatientHistory;
        private System.Windows.Forms.CheckBox Surgery;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button RefreshReportDataGridButton;
        private System.Windows.Forms.Button FillCheckBoxesButton;
        private System.Windows.Forms.Button addConditionButton;
        private System.Windows.Forms.Button deleteConditionButton;
    }
}