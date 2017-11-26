using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models.PatientDataModels;

namespace ICF_classificator.Models.FiltersForm
{
    public class ConditionRow : Control
    {
        public readonly ComboBox filteredValuesComboBox;
        private readonly ComboBox conditionComboBox;
        private readonly ComboBox requestComboBox;
        private readonly TextBox requestTextBox;
        private readonly TextBox requestDigitTextBox;
        private readonly DateTimePicker requestDateTimePicker;

        public readonly ComboBox andOrComboBox;

        private string _column;

        public ConditionRow(Point drawPoint, Form paretntForm, bool needAndOrComboBox = true)
        {
            if (needAndOrComboBox)
            {
                andOrComboBox = new ComboBox
                {
                    DataSource = EnumHelper<AndOr>.GetDisplayedValues(),
                    Location = drawPoint,
                    Size = new Size(50, 21),
                    Parent = paretntForm
                };
            }
            filteredValuesComboBox = new ComboBox
            {
                DataSource = EnumHelper<FilteredValues>.GetDisplayedValues(),
                FormattingEnabled = true,
                Location = needAndOrComboBox ? new Point(andOrComboBox.Location.X, andOrComboBox.Location.Y + andOrComboBox.Size.Height + 10) : drawPoint,
                Name = "FilteredValuesComboBox",
                Size = new Size(195, 21),
                Parent = paretntForm
            };
            filteredValuesComboBox.SelectedIndexChanged += FilteredValuesComboBox_SelectedIndexChanged;

            conditionComboBox = new ComboBox
            {
                FormattingEnabled = true,
                Location =
                    new Point(filteredValuesComboBox.Location.X + filteredValuesComboBox.Size.Width + 10,
                        filteredValuesComboBox.Location.Y),
                Name = "ConditionComboBox",
                Size = new Size(121, 21),
                Parent = paretntForm
            };
            requestComboBox = new ComboBox
            {
                FormattingEnabled = true,
                Location =
                    new Point(conditionComboBox.Location.X + conditionComboBox.Size.Width + 10,
                        conditionComboBox.Location.Y),
                Name = "RequestComboBox",
                Size = new Size(145, 21),
                Parent = paretntForm
            };
            requestTextBox = new TextBox
            {
                Location = requestComboBox.Location,
                Name = "RequestTextBox",
                Size = requestComboBox.Size,
                Parent = paretntForm
            };
            requestDigitTextBox = new TextBox
            {
                Location = requestComboBox.Location,
                Name = "RequestDigitTextBox",
                Size = requestComboBox.Size,
                Parent = paretntForm
            };
            KeyPress += RequestDigitTextBox_KeyPress;
            requestDateTimePicker = new DateTimePicker
            {
                Location = requestComboBox.Location,
                Name = "RequestDateTimePicker",
                Size = requestComboBox.Size,
                Parent = paretntForm
            };
        }

        private void FilteredValuesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = (FilteredValues)filteredValuesComboBox.SelectedIndex;
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
                conditionComboBox.DataSource = EnumHelper<ContainsConditionOperators>.GetDisplayedValues();
                Show(requestTextBox);
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
                conditionComboBox.DataSource = EnumHelper<EqualsConditionOperators>.GetDisplayedValues();
                Show(requestComboBox);
                switch (selectedValue)
                {
                    case FilteredValues.Sex:
                        requestComboBox.DataSource = EnumHelper<PatientSex>.GetDisplayedValues();
                        break;
                    case FilteredValues.IsNotFirstHospitalization:
                        requestComboBox.DataSource = EnumHelper<HospitalizationCount>.GetDisplayedValues();
                        break;
                    case FilteredValues.CerebralIschemia:
                        requestComboBox.DataSource = EnumHelper<CerebralIschemiaDegree>.GetDisplayedValues();
                        break;
                    case FilteredValues.IVH:
                        requestComboBox.DataSource = IVHModel.GetDisplayedValues();
                        break;
                    default:
                        requestComboBox.DataSource = EnumHelper<NoYesRadioButtonResult>.GetDisplayedValues();
                        break;
                }
            }
            else if
            (
                selectedValue == FilteredValues.BirthDate ||
                selectedValue == FilteredValues.HospitalizationDate
            )
            {
                conditionComboBox.DataSource = EnumHelper<CompareConditionOperators>.GetDisplayedValues();
                Show(requestDateTimePicker);
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
                conditionComboBox.DataSource = EnumHelper<CompareConditionOperators>.GetDisplayedValues();
                Show(requestDigitTextBox);
            }
        }

        private void Show(Control control)
        {
            if (control.Equals(requestComboBox))
            {
                requestComboBox.ResetText();
                requestComboBox.Show();
                requestDateTimePicker.Hide();
                requestDigitTextBox.Hide();
                requestTextBox.Hide();
            }
            else if (control.Equals(requestDateTimePicker))
            {
                requestDateTimePicker.ResetText();
                requestDateTimePicker.Show();
                requestComboBox.Hide();
                requestDigitTextBox.Hide();
                requestTextBox.Hide();
            }
            else if (control.Equals(requestTextBox))
            {
                requestTextBox.ResetText();
                requestTextBox.Show();
                requestDateTimePicker.Hide();
                requestDigitTextBox.Hide();
                requestComboBox.Hide();
            }
            else if (control.Equals(requestDigitTextBox))
            {
                requestDigitTextBox.ResetText();
                requestDigitTextBox.Show();
                requestTextBox.Hide();
                requestComboBox.Hide();
                requestDateTimePicker.Hide();
            }
        }

        public string GetFilterCondition()
        {
            string requestCondition;
            if ((string)conditionComboBox.SelectedValue == ContainsConditionOperators.Contain.GetDisplayedName())
            {
                requestCondition = $"{_column} LIKE '%{requestTextBox.Text}%'";
            }
            else if ((string)conditionComboBox.SelectedValue == ContainsConditionOperators.NotContain.GetDisplayedName())
            {
                requestCondition = $"{_column} NOT LIKE '%{requestTextBox.Text}%'";
            }
            else if ((string)conditionComboBox.SelectedValue == CompareConditionOperators.Equal.GetDisplayedName())
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
            else if ((string)conditionComboBox.SelectedValue == CompareConditionOperators.NotEqual.GetDisplayedName())
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
            else if ((string)conditionComboBox.SelectedValue == CompareConditionOperators.Less.GetDisplayedName())
            {
                requestCondition = $"{_column} < '{GetRequestConditionFor(_column)}'";
            }
            else if ((string)conditionComboBox.SelectedValue == CompareConditionOperators.More.GetDisplayedName())
            {
                requestCondition = $"{_column} > '{GetRequestConditionFor(_column)}'";
            }
            else
            {
                throw new NotImplementedException();
            }
            return andOrComboBox == null ? requestCondition : (AndOr)andOrComboBox.SelectedIndex == AndOr.And ? $" AND {requestCondition}" : $" OR {requestCondition}";
        }

        private string GetRequestConditionFor(string columnName, bool needDayPlus = false)
        {
            if (_textBoxFieldNames.Contains(columnName))
            {
                return requestTextBox.Text;
            }
            if (_digitFieldNames.Contains(columnName))
            {
                return requestDigitTextBox.Text;
            }
            if (_dateTimeFieldNames.Contains(columnName))
            {
                return needDayPlus
                    ? requestDateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")
                    : requestDateTimePicker.Value.ToString("yyyy-MM-dd");
            }
            if (_noYesFieldNames.Contains(columnName))
            {
                return
                ((int)
                    EnumHelper<NoYesRadioButtonResult>.ParseByDisplayedNameAttributeValue(
                        (string)requestComboBox.SelectedValue)).ToString();
            }
            if (columnName == "Sex")
            {
                return
                    ((int)
                        EnumHelper<PatientSex>.ParseByDisplayedNameAttributeValue((string)requestComboBox.SelectedValue))
                    .ToString();
            }
            if (columnName == "IsNotFirstHospitalization")
            {
                return
                ((int)
                    EnumHelper<HospitalizationCount>.ParseByDisplayedNameAttributeValue(
                        (string)requestComboBox.SelectedValue)).ToString();
            }
            if (columnName == "CerebralIschemia")
            {
                return
                ((int)
                    EnumHelper<CerebralIschemiaDegree>.ParseByDisplayedNameAttributeValue(
                        (string)requestComboBox.SelectedValue)).ToString();
            }
            if (columnName == "IVHDegree")
            {
                var model = IVHModel.GetModelByReportString((string)requestComboBox.SelectedValue);
                return ((int)model.Degree).ToString();
            }
            if (columnName == "IVHLocalization")
            {
                var model = IVHModel.GetModelByReportString((string)requestComboBox.SelectedValue);
                return ((int)model.Localization).ToString();
            }
            throw new NotImplementedException($"Не найден столбец {columnName}");
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

        public void RemoveAllControls()
        {
            filteredValuesComboBox.Dispose();
            conditionComboBox.Dispose();
            requestComboBox.Dispose();
            requestTextBox.Dispose();
            requestDigitTextBox.Dispose();
            requestDateTimePicker.Dispose();
            andOrComboBox.Dispose();
        }
    }
}