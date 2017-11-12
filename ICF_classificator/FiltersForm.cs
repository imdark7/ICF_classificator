using System;
using System.Collections;
using System.Collections.Generic;
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

        public FiltersForm()
        {
            InitializeComponent();
            RequestTextBox.Location = RequestComboBox.Location;
            RequestTextBox.Size = RequestComboBox.Size;
            RequestDateTimePicker.Location = RequestComboBox.Location;
            RequestDateTimePicker.Size = RequestComboBox.Size;
            RequestDigitTextBox.Location = RequestComboBox.Location;
            RequestDigitTextBox.Size = RequestComboBox.Size;
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
            CheckAllCheckboxes();


            SqlHelper.Read<Patient>();
            FilteredValuesComboBox.DataSource = EnumHelper<FilteredValues>.GetDisplayedValues();

        }

        private void Show(Control control)
        {
            if (control.Equals(RequestComboBox))
            {
                RequestComboBox.ResetText();
                RequestComboBox.Show();
                RequestDateTimePicker.Hide();
                RequestDigitTextBox.Hide();
                RequestTextBox.Hide();
            }
            else if (control.Equals(RequestDateTimePicker))
            {
                RequestDateTimePicker.ResetText();
                RequestDateTimePicker.Show();
                RequestComboBox.Hide();
                RequestDigitTextBox.Hide();
                RequestTextBox.Hide();
            }
            else if (control.Equals(RequestTextBox))
            {
                RequestTextBox.ResetText();
                RequestTextBox.Show();
                RequestDateTimePicker.Hide();
                RequestDigitTextBox.Hide();
                RequestComboBox.Hide();
            }
            else if (control.Equals(RequestDigitTextBox))
            {
                RequestDigitTextBox.ResetText();
                RequestDigitTextBox.Show();
                RequestTextBox.Hide();
                RequestComboBox.Hide();
                RequestDateTimePicker.Hide();
            }
        }

        private void FilteredValuesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = (FilteredValues)FilteredValuesComboBox.SelectedIndex;
            _column = Enum.GetName(typeof(FilteredValues), selectedValue);
            if
            (
                selectedValue == FilteredValues.LastName ||
                selectedValue == FilteredValues.FirstName ||
                selectedValue == FilteredValues.SurName ||
                selectedValue == FilteredValues.Address ||
                selectedValue == FilteredValues.ParentName ||
                selectedValue == FilteredValues.BirthDefect ||
                selectedValue == FilteredValues.Surgery ||
                selectedValue == FilteredValues.PatientHistory
            )
            {
                ConditionComboBox.DataSource = EnumHelper<ContainsConditionOperators>.GetDisplayedValues();
                Show(RequestTextBox);
            }
            else if
            (
                selectedValue == FilteredValues.Sex ||
                selectedValue == FilteredValues.HasDisability ||
                selectedValue == FilteredValues.IsNotFirstHospitalization ||
                selectedValue == FilteredValues.CerebralIschemia ||
                selectedValue == FilteredValues.IVH ||
                selectedValue == FilteredValues.Meningitis ||
                selectedValue == FilteredValues.Encephalitis ||
                selectedValue == FilteredValues.Sepsis ||
                selectedValue == FilteredValues.HDN ||
                selectedValue == FilteredValues.VKDB ||
                selectedValue == FilteredValues.Anemia ||
                selectedValue == FilteredValues.Hyperbilirubinemia ||
                selectedValue == FilteredValues.UNEC
            )
            {
                ConditionComboBox.DataSource = EnumHelper<EqualsConditionOperators>.GetDisplayedValues();
                Show(RequestComboBox);
                switch (selectedValue)
                {
                    case FilteredValues.Sex:
                        RequestComboBox.DataSource = EnumHelper<PatientSex>.GetDisplayedValues();
                        break;
                    case FilteredValues.IsNotFirstHospitalization:
                        RequestComboBox.DataSource = EnumHelper<HospitalizationCount>.GetDisplayedValues();
                        break;
                    case FilteredValues.CerebralIschemia:
                        RequestComboBox.DataSource = EnumHelper<CerebralIschemiaDegree>.GetDisplayedValues();
                        break;
                    case FilteredValues.IVH:
                        RequestComboBox.DataSource = IVHModel.GetDisplayedValues();
                        break;
                    default:
                        RequestComboBox.DataSource = EnumHelper<NoYesRadioButtonResult>.GetDisplayedValues();
                        break;
                }
            }
            else if
            (
                selectedValue == FilteredValues.BirthDate ||
                selectedValue == FilteredValues.HospitalizationDate
            )
            {
                ConditionComboBox.DataSource = EnumHelper<CompareConditionOperators>.GetDisplayedValues();
                Show(RequestDateTimePicker);
            }
            else if
            (
                selectedValue == FilteredValues.ALVDuration ||
                selectedValue == FilteredValues.CPAPDuration ||
                selectedValue == FilteredValues.ConvulsiveSyndromeDuration ||
                selectedValue == FilteredValues.GestationAge ||
                selectedValue == FilteredValues.BirthWeight ||
                selectedValue == FilteredValues.BirthHeight ||
                selectedValue == FilteredValues.BirthHeadSize ||
                selectedValue == FilteredValues.BirthChestSize ||
                selectedValue == FilteredValues.ApgarFirst ||
                selectedValue == FilteredValues.ApgarSecond ||
                selectedValue == FilteredValues.ApgarThird ||
                selectedValue == FilteredValues.BirthWeight
            )
            {
                ConditionComboBox.DataSource = EnumHelper<CompareConditionOperators>.GetDisplayedValues();
                Show(RequestDigitTextBox);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {

            string requestCondition = null;
            if ((string)ConditionComboBox.SelectedValue == ContainsConditionOperators.Contain.GetDisplayedName())
            {
                requestCondition = $"{_column} LIKE '%{RequestTextBox.Text}%'";
            }
            else if ((string)ConditionComboBox.SelectedValue == ContainsConditionOperators.NotContain.GetDisplayedName())
            {
                requestCondition = $"{_column} NOT LIKE '%{RequestTextBox.Text}%'";
            }
            else if ((string)ConditionComboBox.SelectedValue == CompareConditionOperators.Equal.GetDisplayedName())
            {
                if (_column == "IVH")
                {
                    requestCondition =
                        $"IVHDegree LIKE '{GetRequestConditionFor("IVHDegree")}' AND IVHLocalization LIKE '{GetRequestConditionFor("IVHLocalization")}'";
                }
                else if (_column == "BirthDate" || _column == "HospitalizationDate")
                {
                    requestCondition =
                        $"{_column} > '{GetRequestConditionFor(_column)}' AND {_column} < '{GetRequestConditionFor(_column, true)}'";
                }
                else
                {
                    requestCondition =
                        $"{_column} LIKE '{GetRequestConditionFor(_column)}'";
                }
            }
            else if ((string)ConditionComboBox.SelectedValue == CompareConditionOperators.NotEqual.GetDisplayedName())
            {
                if (_column == "IVH")
                {
                    requestCondition =
                        $"IVHDegree NOT LIKE '{GetRequestConditionFor("IVHDegree")}' AND IVHLocalization NOT LIKE '{GetRequestConditionFor("IVHLocalization")}'";
                }
                else if (_column == "BirthDate" || _column == "HospitalizationDate")
                {
                    requestCondition =
                        $"{_column} < '{GetRequestConditionFor(_column)}' OR {_column} > '{GetRequestConditionFor(_column, true)}'";
                }
                else
                {
                    requestCondition =
                        $"{_column} NOT LIKE '{GetRequestConditionFor(_column)}'";
                }
            }
            else if ((string)ConditionComboBox.SelectedValue == CompareConditionOperators.Less.GetDisplayedName())
            {
                requestCondition = $"{_column} < '{GetRequestConditionFor(_column)}'";
            }
            else if ((string)ConditionComboBox.SelectedValue == CompareConditionOperators.More.GetDisplayedName())
            {
                requestCondition = $"{_column} > '{GetRequestConditionFor(_column)}'";
            }
            else
            {
                throw new NotImplementedException();
            }

            ShowPatientsData(SqlHelper.Read<Patient>(requestCondition));
        }

        private string GetRequestConditionFor(string columnName, bool needDayPlus = false)
        {
            if (_textBoxFieldNames.Contains(columnName))
            {
                return RequestTextBox.Text;
            }
            if (_digitFieldNames.Contains(columnName))
            {
                return RequestDigitTextBox.Text;
            }
            if (_dateTimeFieldNames.Contains(columnName))
            {
                return needDayPlus ? RequestDateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd") : RequestDateTimePicker.Value.ToString("yyyy-MM-dd");
            }
            if (_noYesFieldNames.Contains(columnName))
            {
                return
                ((int)
                    EnumHelper<NoYesRadioButtonResult>.ParseByDisplayedNameAttributeValue(
                        (string)RequestComboBox.SelectedValue)).ToString();
            }
            if (columnName == "Sex")
            {
                return
                    ((int)
                        EnumHelper<PatientSex>.ParseByDisplayedNameAttributeValue((string)RequestComboBox.SelectedValue))
                    .ToString();
            }
            if (columnName == "IsNotFirstHospitalization")
            {
                return
                ((int)
                    EnumHelper<HospitalizationCount>.ParseByDisplayedNameAttributeValue(
                        (string)RequestComboBox.SelectedValue)).ToString();
            }
            if (columnName == "CerebralIschemia")
            {
                return
                ((int)
                    EnumHelper<CerebralIschemiaDegree>.ParseByDisplayedNameAttributeValue(
                        (string)RequestComboBox.SelectedValue)).ToString();
            }
            if (columnName == "IVHDegree")
            {
                var model = IVHModel.GetModelByReportString((string)RequestComboBox.SelectedValue);
                return ((int)model.Degree).ToString();
            }
            if (columnName == "IVHLocalization")
            {
                var model = IVHModel.GetModelByReportString((string)RequestComboBox.SelectedValue);
                return ((int)model.Localization).ToString();
            }
            throw new NotImplementedException($"Не найден столбец {columnName}");
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
            var button = (Button)sender;
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

        private readonly List<string> _textBoxFieldNames = new List<string>
        {
            "LastName",
            "FirstName",
            "SurName",
            "Address",
            "ParentName",
            "BirthDefect",
            "Surgery",
            "PatientHistory"
        };

        private readonly List<string> _dateTimeFieldNames = new List<string>
        {
            "HospitalizationDate",
            "BirthDate"
        };

        private readonly List<string> _digitFieldNames = new List<string>
        {
            "ALVDuration",
            "CPAPDuration",
            "ConvulsiveSyndromeDuration",
            "GestationAge",
            "BirthWeight",
            "BirthHeight",
            "BirthHeadSize",
            "BirthChestSize",
            "ApgarFirst",
            "ApgarSecond",
            "ApgarThird",
            "BirthWeight"
        };

        private readonly List<string> _noYesFieldNames = new List<string>
        {
            "HasDisability",
            "Meningitis",
            "Encephalitis",
            "Sepsis",
            "HDN",
            "VKDB",
            "Anemia",
            "Hyperbilirubinemia",
            "UNEC"
        };

        private void RequestDigitTextBox_KeyPress(object obj, KeyPressEventArgs args)
        {
            if (!char.IsDigit(args.KeyChar) && args.KeyChar != Convert.ToChar(8))
            {
                args.Handled = true;
            }
        }
    }
}


