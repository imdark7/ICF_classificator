using System.Drawing;
using System.Windows.Forms;

namespace ICF_classificator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox2 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox3 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox4 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox5 = new ICF_classificator.Extensions.ListBoxExtension();
            this.listBox6 = new ICF_classificator.Extensions.ListBoxExtension();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.reportsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddCaseHistory = new System.Windows.Forms.Button();
            this.createNewReport = new System.Windows.Forms.Button();
            this.reportsListView = new System.Windows.Forms.ListView();
            this.ReportId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentReport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.commentReportTextBox = new System.Windows.Forms.TextBox();
            this.newReportGroupBox = new System.Windows.Forms.GroupBox();
            this.newReportDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.patientEditButton = new System.Windows.Forms.Button();
            this.reportItemGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.reportsGroupBox.SuspendLayout();
            this.newReportGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newReportDataGridView)).BeginInit();
            this.patientGroupBox.SuspendLayout();
            this.reportItemGroupBox.SuspendLayout();
            this.doctorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 200);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.Location = new System.Drawing.Point(158, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(271, 200);
            this.listBox2.TabIndex = 0;
            this.listBox2.Visible = false;
            this.listBox2.SelectedValueChanged += new System.EventHandler(this.listBox2_SelectedValueChanged);
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // listBox3
            // 
            this.listBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(435, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(241, 200);
            this.listBox3.TabIndex = 0;
            this.listBox3.Visible = false;
            this.listBox3.SelectedValueChanged += new System.EventHandler(this.listBox3_SelectedValueChanged);
            this.listBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // listBox4
            // 
            this.listBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(682, 19);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(234, 200);
            this.listBox4.TabIndex = 0;
            this.listBox4.Visible = false;
            this.listBox4.SelectedValueChanged += new System.EventHandler(this.listBox4_SelectedValueChanged);
            this.listBox4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // listBox5
            // 
            this.listBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(922, 19);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(229, 200);
            this.listBox5.TabIndex = 0;
            this.listBox5.Visible = false;
            this.listBox5.SelectedValueChanged += new System.EventHandler(this.listBox5_SelectedValueChanged);
            this.listBox5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // listBox6
            // 
            this.listBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(1157, 19);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(229, 200);
            this.listBox6.TabIndex = 3;
            this.listBox6.Visible = false;
            this.listBox6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.данныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентаToolStripMenuItem,
            this.врачаToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить...";
            // 
            // пациентаToolStripMenuItem
            // 
            this.пациентаToolStripMenuItem.Name = "пациентаToolStripMenuItem";
            this.пациентаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пациентаToolStripMenuItem.Text = "Пациента";
            this.пациентаToolStripMenuItem.Click += new System.EventHandler(this.пациентаToolStripMenuItem_Click);
            // 
            // врачаToolStripMenuItem
            // 
            this.врачаToolStripMenuItem.Name = "врачаToolStripMenuItem";
            this.врачаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.врачаToolStripMenuItem.Text = "Врача";
            this.врачаToolStripMenuItem.Click += new System.EventHandler(this.врачаToolStripMenuItem_Click);
            // 
            // patientComboBox
            // 
            this.patientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.patientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patientComboBox.Location = new System.Drawing.Point(10, 19);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(250, 21);
            this.patientComboBox.TabIndex = 5;
            this.patientComboBox.TabStop = false;
            this.patientComboBox.Text = "Выбрать..";
            this.patientComboBox.SelectedIndexChanged += new System.EventHandler(this.patientComboBox_SelectedIndexChanged);
            // 
            // reportsGroupBox
            // 
            this.reportsGroupBox.Controls.Add(this.AddCaseHistory);
            this.reportsGroupBox.Controls.Add(this.createNewReport);
            this.reportsGroupBox.Controls.Add(this.reportsListView);
            this.reportsGroupBox.Location = new System.Drawing.Point(12, 141);
            this.reportsGroupBox.Name = "reportsGroupBox";
            this.reportsGroupBox.Size = new System.Drawing.Size(359, 249);
            this.reportsGroupBox.TabIndex = 6;
            this.reportsGroupBox.TabStop = false;
            this.reportsGroupBox.Text = "Заведенные отчеты";
            this.reportsGroupBox.Visible = false;
            // 
            // AddCaseHistory
            // 
            this.AddCaseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddCaseHistory.Location = new System.Drawing.Point(7, 205);
            this.AddCaseHistory.Name = "AddCaseHistory";
            this.AddCaseHistory.Size = new System.Drawing.Size(145, 37);
            this.AddCaseHistory.TabIndex = 1;
            this.AddCaseHistory.Text = "Добавить историю болезни";
            this.AddCaseHistory.UseVisualStyleBackColor = true;
            this.AddCaseHistory.Click += new System.EventHandler(this.addCaseHistory_Click);
            // 
            // createNewReport
            // 
            this.createNewReport.Location = new System.Drawing.Point(180, 204);
            this.createNewReport.Name = "createNewReport";
            this.createNewReport.Size = new System.Drawing.Size(173, 38);
            this.createNewReport.TabIndex = 1;
            this.createNewReport.Text = "Добавить новый отчет";
            this.createNewReport.UseVisualStyleBackColor = true;
            this.createNewReport.Click += new System.EventHandler(this.createNewReport_Click);
            // 
            // reportsListView
            // 
            this.reportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReportId,
            this.DateReport,
            this.CommentReport,
            this.Doctor});
            this.reportsListView.FullRowSelect = true;
            this.reportsListView.Location = new System.Drawing.Point(7, 20);
            this.reportsListView.MultiSelect = false;
            this.reportsListView.Name = "reportsListView";
            this.reportsListView.Size = new System.Drawing.Size(346, 179);
            this.reportsListView.TabIndex = 0;
            this.reportsListView.UseCompatibleStateImageBehavior = false;
            this.reportsListView.View = System.Windows.Forms.View.Details;
            this.reportsListView.DoubleClick += new System.EventHandler(this.reportsListView_DoubleClick);
            this.reportsListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportsListView_MouseDown);
            // 
            // ReportId
            // 
            this.ReportId.Text = "ReportId";
            this.ReportId.Width = 0;
            // 
            // DateReport
            // 
            this.DateReport.Tag = "";
            this.DateReport.Text = "Дата";
            this.DateReport.Width = 70;
            // 
            // CommentReport
            // 
            this.CommentReport.Tag = "";
            this.CommentReport.Text = "Комментарий";
            this.CommentReport.Width = 196;
            // 
            // Doctor
            // 
            this.Doctor.Text = "Врач";
            this.Doctor.Width = 76;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // commentReportTextBox
            // 
            this.commentReportTextBox.Location = new System.Drawing.Point(6, 294);
            this.commentReportTextBox.Multiline = true;
            this.commentReportTextBox.Name = "commentReportTextBox";
            this.commentReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentReportTextBox.Size = new System.Drawing.Size(430, 52);
            this.commentReportTextBox.TabIndex = 0;
            // 
            // newReportGroupBox
            // 
            this.newReportGroupBox.Controls.Add(this.newReportDataGridView);
            this.newReportGroupBox.Controls.Add(this.saveReportButton);
            this.newReportGroupBox.Controls.Add(this.label1);
            this.newReportGroupBox.Controls.Add(this.dateLabel);
            this.newReportGroupBox.Controls.Add(this.commentReportTextBox);
            this.newReportGroupBox.Controls.Add(this.dateTimePicker1);
            this.newReportGroupBox.Location = new System.Drawing.Point(381, 37);
            this.newReportGroupBox.Name = "newReportGroupBox";
            this.newReportGroupBox.Size = new System.Drawing.Size(1024, 353);
            this.newReportGroupBox.TabIndex = 8;
            this.newReportGroupBox.TabStop = false;
            this.newReportGroupBox.Text = "Новый отчет";
            this.newReportGroupBox.Visible = false;
            // 
            // newReportDataGridView
            // 
            this.newReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.newReportDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.newReportDataGridView.Location = new System.Drawing.Point(9, 46);
            this.newReportDataGridView.Name = "newReportDataGridView";
            this.newReportDataGridView.Size = new System.Drawing.Size(1008, 229);
            this.newReportDataGridView.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DerangementState";
            this.Column3.HeaderText = "Состояние";
            this.Column3.Items.AddRange(new object[] {
            "Не задано",
            "Норма",
            "Нарушено"});
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Комментарий";
            this.Column4.Name = "Column4";
            this.Column4.Width = 590;
            // 
            // saveReportButton
            // 
            this.saveReportButton.Location = new System.Drawing.Point(494, 294);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(139, 52);
            this.saveReportButton.TabIndex = 11;
            this.saveReportButton.Text = "Сохранить отчет";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Комментарий к отчету:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(27, 23);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 13);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Дата: ";
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.patientEditButton);
            this.patientGroupBox.Controls.Add(this.patientComboBox);
            this.patientGroupBox.Location = new System.Drawing.Point(12, 89);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(359, 46);
            this.patientGroupBox.TabIndex = 9;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Пациент";
            // 
            // patientEditButton
            // 
            this.patientEditButton.Enabled = false;
            this.patientEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientEditButton.Location = new System.Drawing.Point(266, 19);
            this.patientEditButton.Name = "patientEditButton";
            this.patientEditButton.Size = new System.Drawing.Size(87, 21);
            this.patientEditButton.TabIndex = 6;
            this.patientEditButton.Text = "Редактировать";
            this.patientEditButton.UseVisualStyleBackColor = true;
            this.patientEditButton.Click += new System.EventHandler(this.patientEditButton_Click);
            // 
            // reportItemGroupBox
            // 
            this.reportItemGroupBox.Controls.Add(this.listBox1);
            this.reportItemGroupBox.Controls.Add(this.listBox2);
            this.reportItemGroupBox.Controls.Add(this.listBox6);
            this.reportItemGroupBox.Controls.Add(this.listBox3);
            this.reportItemGroupBox.Controls.Add(this.listBox4);
            this.reportItemGroupBox.Controls.Add(this.listBox5);
            this.reportItemGroupBox.Location = new System.Drawing.Point(12, 389);
            this.reportItemGroupBox.Name = "reportItemGroupBox";
            this.reportItemGroupBox.Size = new System.Drawing.Size(1393, 232);
            this.reportItemGroupBox.TabIndex = 10;
            this.reportItemGroupBox.TabStop = false;
            this.reportItemGroupBox.Visible = false;
            // 
            // doctorGroupBox
            // 
            this.doctorGroupBox.Controls.Add(this.doctorComboBox);
            this.doctorGroupBox.Location = new System.Drawing.Point(12, 37);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Size = new System.Drawing.Size(359, 46);
            this.doctorGroupBox.TabIndex = 10;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "Врач";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.doctorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doctorComboBox.Location = new System.Drawing.Point(10, 19);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(343, 21);
            this.doctorComboBox.TabIndex = 5;
            this.doctorComboBox.TabStop = false;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентовToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.данныеToolStripMenuItem.Text = "Данные...";
            // 
            // пациентовToolStripMenuItem
            // 
            this.пациентовToolStripMenuItem.Name = "пациентовToolStripMenuItem";
            this.пациентовToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пациентовToolStripMenuItem.Text = "Пациентов";
            this.пациентовToolStripMenuItem.Click += new System.EventHandler(this.пациентовToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 633);
            this.Controls.Add(this.doctorGroupBox);
            this.Controls.Add(this.newReportGroupBox);
            this.Controls.Add(this.reportsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.patientGroupBox);
            this.Controls.Add(this.reportItemGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ICF Classificator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.reportsGroupBox.ResumeLayout(false);
            this.newReportGroupBox.ResumeLayout(false);
            this.newReportGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newReportDataGridView)).EndInit();
            this.patientGroupBox.ResumeLayout(false);
            this.reportItemGroupBox.ResumeLayout(false);
            this.doctorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Extensions.ListBoxExtension listBox2;
        private Extensions.ListBoxExtension listBox3;
        private Extensions.ListBoxExtension listBox4;
        private Extensions.ListBoxExtension listBox5;
        private Extensions.ListBoxExtension listBox1;
        private Extensions.ListBoxExtension listBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem врачаToolStripMenuItem;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.GroupBox reportsGroupBox;
        private System.Windows.Forms.TextBox commentReportTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button createNewReport;
        private System.Windows.Forms.ListView reportsListView;
        private System.Windows.Forms.GroupBox newReportGroupBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.GroupBox reportItemGroupBox;
        private System.Windows.Forms.ColumnHeader DateReport;
        private System.Windows.Forms.ColumnHeader CommentReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.DataGridView newReportDataGridView;
        private GroupBox doctorGroupBox;
        private ComboBox doctorComboBox;
        private ColumnHeader ReportId;
        private ColumnHeader Doctor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button AddCaseHistory;
        private Button patientEditButton;
        private ToolStripMenuItem данныеToolStripMenuItem;
        private ToolStripMenuItem пациентовToolStripMenuItem;
    }
}

