using System;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;
using ICF_classificator.Models.PatientDataModels;

namespace ICF_classificator
{
    public partial class AddPatientForm : Form
    {
        private readonly Form _pForm;
        private static Patient patient;

        public AddPatientForm(Form parentForm)
        {
            InitializeComponent();
            _pForm = parentForm;
        }

        private void CreatePatientButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                SqlHelper.TryInsert<Patient>(new []
                {
                    new Patient
                    {
                        LastName = PatientLastNameTextBox.Text,
                        FirstName = PatientFirstNameTextBox.Text,
                        SurName = PatientSurNameTextBox.Text,
                        Sex = MaleSexRadioButton.Checked ? PatientSex.Male : PatientSex.Female,
                        ParentName = ParentFIOTextBox.Text,
                        Address = PatientAddressTextBox.Text,
                        BirthDate = PatientBirthDatePicker.Value,
                        GestationAge = int.Parse(GestationAgeTextBox.Text)
                    }
                });
                
                Close();
                ((MainForm)_pForm).RefreshPatientCombobox();
            }
            else
            {
                WarningLabel.Show();
            }
        }

        private bool IsDataCorrect()
        {
            if (PatientLastNameTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.LastName).DisplayedName());
                return false;
            }
            if (PatientFirstNameTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.FirstName).DisplayedName());
                return false;
            }
            if (!MaleSexRadioButton.Checked && !FemaleSexRadioButton.Checked)
            {
                ShowErrorMessage(nameof(patient.Sex).DisplayedName());
                return false;
            }
            if (ParentFIOTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ParentName).DisplayedName());
                return false;
            }
            if (PatientAddressTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.Address).DisplayedName());
                return false;
            }
            if (PatientBirthDatePicker.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.BirthDate).DisplayedName());
                return false;
            }
            if (GestationAgeTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.GestationAge).DisplayedName());
                return false;
            }
            if (WeightNewbornTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.WeightNewborn).DisplayedName());
                return false;
            }
            if (HeightNewbornTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.HeightNewborn).DisplayedName());
                return false;
            }
            if (HeadSizeNewbornTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.HeadSizeNewborn).DisplayedName());
                return false;
            }
            if (ChestSizeNewbornTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ChestSizeNewborn).DisplayedName());
                return false;
            }
            if (ApgarTextBox1.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ApgarScale).DisplayedName());
                return false;
            }
            if (ApgarTextBox2.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ApgarScale).DisplayedName());
                return false;
            }
            if (ApgarTextBox3.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ApgarScale).DisplayedName());
                return false;
            }
            if (HospitalizationDatePicker.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.HospitalizationDate).DisplayedName());
                return false;
            }
            if (ALVYesRadioButton.Checked && ALVDutarionTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ALVDuration).DisplayedName());
                return false;
            }
            if (CPAPYesRadioButton.Checked && CPAPDurationTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.CPAPDuration).DisplayedName());
                return false;
            }
            if (CerebralIschemiaComboBox.SelectedIndex < 0)
            {
                ShowErrorMessage(nameof(patient.CerebralIschemia).DisplayedName());
                return false;
            }
            if (IVHDegreeComboBox.SelectedIndex < 0 && IVHLocalizationComboBox.SelectedIndex < 0)
            {
                ShowErrorMessage(nameof(patient.IVH).DisplayedName());
                return false;
            }
            if (ConclusiveSyndromeYesRadioButton.Checked && ConclusiveSyndromeDurationTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.ConvulsiveSyndromeDuration).DisplayedName());
                return false;
            }
            if (BirthDefectYesRadioButton.Checked && BirthDefectTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.BirthDefect).DisplayedName());
                return false;
            }
            if (SurgeryYesRadioButton.Checked && SurgeryTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.Surgery).DisplayedName());
                return false;
            }
            return true;
        }

        private void PatientFormOnlyIntegerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void ShowErrorMessage(string fieldName)
        {
            WarningLabel.Text = $@"Необходимо заполнить поле {fieldName}";
            WarningLabel.Show();
        }

        private void RadioButtonCheckedCharged(RadioButton yesRadioButton, TextBox textBox, Label label = null)
        {
            if (yesRadioButton.Checked)
            {
                textBox.Enabled = true;
                if (label != null) label.Enabled = true;
            }
            else
            {
                textBox.Enabled = false;
                textBox.Clear();
                if(label != null) label.Enabled = false;
            }
        }

        private void ALVYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton) sender), ALVDutarionTextBox, ALVDurationLabel);
        }

        private void CPAPYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton)sender), CPAPDurationTextBox, CPAPDurationLabel);
        }

        private void ConclusiveSyndromeYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton)sender), ConclusiveSyndromeDurationTextBox, ConclusiveSyndromeDurationLabel);
        }

        private void BirthDefectYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton)sender), BirthDefectTextBox);
        }

        private void SurgeryYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton)sender), SurgeryTextBox);
        }
    }
}
