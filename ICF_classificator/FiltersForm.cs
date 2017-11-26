using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;
using ICF_classificator.Models.FiltersForm;
using ICF_classificator.Models.PatientDataModels;

namespace ICF_classificator
{
    public partial class FiltersForm : Form
    {
        private const string SelectAllCheckboxesText = "Отметить все галочки";
        private const string UnselectAllCheckboxesText = "Снять все галочки";
        private string _column;
        private readonly List<ConditionRow> conditionRows = new List<ConditionRow>();

        public FiltersForm()
        {
            InitializeComponent();
            var filterCondition = new ConditionRow(new Point(12, 14), this, false);
            conditionRows.Add(filterCondition);

            var columns = new[]
            {
                new DataGridViewTextBoxColumn {Name = "PatientName", HeaderText = @"ФИО Пациента"},
                new DataGridViewTextBoxColumn {Name = "Sex", HeaderText = @"Пол"},
                new DataGridViewTextBoxColumn {Name = "Address", HeaderText = @"Адрес"},
                new DataGridViewTextBoxColumn {Name = "ParentName", HeaderText = @"Имя родителя"},
                new DataGridViewTextBoxColumn {Name = "BirthDate", HeaderText = @"Дата рождения"},
                new DataGridViewTextBoxColumn {Name = "GestationAge", HeaderText = @"Гестационный возраст"},
                new DataGridViewTextBoxColumn {Name = "Weight", HeaderText = @"Масса"},
                new DataGridViewTextBoxColumn {Name = "Height", HeaderText = @"Длина"},
                new DataGridViewTextBoxColumn {Name = "HeadSize", HeaderText = @"Окружность головы"},
                new DataGridViewTextBoxColumn {Name = "ChestSize", HeaderText = @"Окружность груди"},
                new DataGridViewTextBoxColumn {Name = "ApgarScale", HeaderText = @"Оценка по Апгар"},
                new DataGridViewTextBoxColumn {Name = "Disability", HeaderText = @"Инвалидность"},
                new DataGridViewTextBoxColumn {Name = "IsNotFirstHospitalization", HeaderText = @"Госпитализация"},
                new DataGridViewTextBoxColumn {Name = "HospitalizationDate", HeaderText = @"Дата поступления"},
                new DataGridViewTextBoxColumn {Name = "ALVDuration", HeaderText = @"ИВЛ"},
                new DataGridViewTextBoxColumn {Name = "CPAPDuration", HeaderText = @"CPAP"},
                new DataGridViewTextBoxColumn {Name = "CerebralIschemia", HeaderText = @"Церебр. ишемия"},
                new DataGridViewTextBoxColumn {Name = "IVH", HeaderText = @"ВЖК"},
                new DataGridViewTextBoxColumn {Name = "Meningitis", HeaderText = @"Менингит"},
                new DataGridViewTextBoxColumn {Name = "Encephalitis", HeaderText = @"Энцефалит"},
                new DataGridViewTextBoxColumn {Name = "ConvulsiveSyndrome", HeaderText = @"Судорож. синдр."},
                new DataGridViewTextBoxColumn {Name = "Sepsis", HeaderText = @"Сепсис"},
                new DataGridViewTextBoxColumn {Name = "HDN", HeaderText = @"ГБН"},
                new DataGridViewTextBoxColumn {Name = "VKDB", HeaderText = @"Геморрагич. синдр."},
                new DataGridViewTextBoxColumn {Name = "Anemia", HeaderText = @"Анемия тяж.ст."},
                new DataGridViewTextBoxColumn {Name = "Hyperbilirubinemia", HeaderText = @"Гипербилирубинемия"},
                new DataGridViewTextBoxColumn {Name = "UNEC", HeaderText = @"ЯНЭК"},
                new DataGridViewTextBoxColumn {Name = "BirthDefect", HeaderText = @"ВПР"},
                new DataGridViewTextBoxColumn {Name = "Surgery", HeaderText = @"Оперативн. вмешательство"},
                new DataGridViewTextBoxColumn {Name = "PatientHistory", HeaderText = @"№ Истории болезни"}
            };
            ResultDataGridView.Columns.AddRange(columns);
            ResultDataGridView.ReadOnly = true;
            CheckAllCheckboxes();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            var requestCondition = conditionRows.Aggregate("", (current, conditionRow) => current + conditionRow.GetFilterCondition());
            ShowPatientsData(SqlHelper.Read<Patient>(requestCondition));
        }

        private void ShowPatientsData(IList patients)
        {
            ResultDataGridView.Rows.Clear();
            foreach (Patient patient in patients)
            {
                ResultDataGridView.Rows.Add(
                    patient.GetFullName(),
                    patient.Sex.GetDisplayedName(),
                    patient.Address,
                    patient.ParentName,
                    patient.BirthDate.GetReportString(),
                    patient.GestationAge,
                    patient.BirthWeight,
                    patient.BirthHeight,
                    patient.BirthHeadSize,
                    patient.BirthChestSize,
                    patient.ApgarScale.GetReportString(),
                    patient.HasDisability.GetReportString(),
                    patient.IsNotFirstHospitalization.GetReportResult(),
                    patient.HospitalizationDate.ToString("dd-MM-yyyy"),
                    patient.ALVDuration.GetReportString(),
                    patient.CPAPDuration.GetReportString(),
                    patient.CerebralIschemia.GetReportString(),
                    patient.IVH.GetReportString(),
                    patient.Meningitis.GetReportString(),
                    patient.Encephalitis.GetReportString(),
                    patient.ConvulsiveSyndromeDuration.GetReportString(),
                    patient.Sepsis.GetReportString(),
                    patient.HDN.GetReportString(),
                    patient.VKDB.GetReportString(),
                    patient.Anemia.GetReportString(),
                    patient.Hyperbilirubinemia.GetReportString(),
                    patient.UNEC.GetReportString(),
                    patient.BirthDefect,
                    patient.Surgery,
                    patient.PatientHistory
                );
            }
        }

        private void RefreshReportDataGridButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox control in CheckBoxesGroupBox.Controls)
            {
                ResultDataGridView.Columns[control.Name].Visible = control.Checked;
            }
        }

        private void FillCheckBoxesButton_Click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            foreach (CheckBox checkBox in CheckBoxesGroupBox.Controls)
            {
                checkBox.Checked = button.Text == SelectAllCheckboxesText;
            }
            button.Text = button.Text == UnselectAllCheckboxesText ? SelectAllCheckboxesText : UnselectAllCheckboxesText;
        }

        private void CheckAllCheckboxes()
        {
            foreach (CheckBox checkBox in CheckBoxesGroupBox.Controls)
            {
                checkBox.Checked = true;
            }
            FillCheckBoxesButton.Text = UnselectAllCheckboxesText;
        }

        private void addConditionButton_Click(object sender, EventArgs e)
        {
            var lastRow = conditionRows.Last();
            var conditionRow =
                new ConditionRow(
                    new Point(lastRow.filteredValuesComboBox.Left, lastRow.filteredValuesComboBox.Bottom + 10), this);
            conditionRows.Add(conditionRow);
            conditionRow.filteredValuesComboBox.SelectedIndex = 1;
            conditionRow.filteredValuesComboBox.SelectedIndex = 0;
            addConditionButton.Location = new Point(conditionRow.filteredValuesComboBox.Left,
                conditionRow.filteredValuesComboBox.Bottom + 10);
            deleteConditionButton.Location = new Point(addConditionButton.Right + 10, addConditionButton.Top);
        }

        private void deleteConditionButton_Click(object sender, EventArgs e)
        {
            if (conditionRows.Count > 1)
            {
                var lastRow = conditionRows.Last();
                var lastIndex = conditionRows.Count - 1;
                lastRow.RemoveAllControls();
                conditionRows.RemoveAt(lastIndex);

                lastRow = conditionRows.Last();
                addConditionButton.Location = new Point(lastRow.filteredValuesComboBox.Left,
                    lastRow.filteredValuesComboBox.Bottom + 10);
                deleteConditionButton.Location = new Point(addConditionButton.Right + 10, addConditionButton.Top);
            }
        }

        private void FiltersForm_Load(object sender, EventArgs e)
        {
            conditionRows.First().filteredValuesComboBox.SelectedIndex = 2;
            conditionRows.First().filteredValuesComboBox.SelectedIndex = 0;
        }

        private void addConditionButton_LocationChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            ResultDataGridView.Location = new Point(btn.Left, btn.Bottom + 20);
        }

        private void ResultDataGridView_LocationChanged(object sender, EventArgs e)
        {
            ResultDataGridView.Height = CheckBoxesGroupBox.Top - ResultDataGridView.Top - 5;
        }
    }
}