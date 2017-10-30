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
            CerebralIschemiaComboBox.SelectedIndex = 0;
            IVHDegreeComboBox.SelectedIndex = 0;
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
                        GestationAge = int.Parse(GestationAgeTextBox.Text),
                        BirthWeight = int.Parse(BirthWeightTextBox.Text),
                        BirthHeight = int.Parse(BirthHeightTextBox.Text),
                        BirthHeadSize = int.Parse(BirthHeadSizeTextBox.Text),
                        BirthChestSize = int.Parse(BirthChestSizeTextBox.Text),
                        ApgarScale = new ApgarResult
                        {
                            AfterBirth = int.Parse(ApgarTextBox1.Text),
                            AfterOneMinute = int.Parse(ApgarTextBox2.Text),
                            AfterFiveMinute = int.Parse(ApgarTextBox3.Text)
                        },
                        HasDisability = DisabilityNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        Hospitalization = HospitalizationFirstTimeRadioButton.Checked ? HospitalizationCount.First : HospitalizationCount.NotFirst,
                        HospitalizationDate = HospitalizationDatePicker.Value,
                        ALVDuration = ALVYesRadioButton.Checked && ALVDutarionTextBox.Text.Length > 0 ? int.Parse(ALVDutarionTextBox.Text) : 0,
                        CPAPDuration = CPAPYesRadioButton.Checked && CPAPDurationTextBox.Text.Length > 0 ? int.Parse(CPAPDurationTextBox.Text) : 0,
                        CerebralIschemia = (CerebralIschemiaDegree)CerebralIschemiaComboBox.SelectedIndex,
                        IVH = new IVHModel
                        {
                            Degree = (IVHDegree)IVHDegreeComboBox.SelectedIndex,
                            Localization = (IVHLocalization)IVHLocalizationComboBox.SelectedIndex
                        },
                        Meningitis = MeningitisNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        Encephalitis = EncephalitisNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        ConvulsiveSyndromeDuration = ConvulsiveSyndromeYesRadioButton.Checked && ConvulsiveSyndromeDurationTextBox.Text.Length > 0 ? int.Parse(ConvulsiveSyndromeDurationTextBox.Text) : 0,
                        Sepsis = SepsisNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        HDN = HDNNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        VKDB = VKDBNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        Anemia = AnemiaNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        Hyperbilirubinemia = HyperbilirubinemiaNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        UNEC = UNECNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                        BirthDefect = BirthDefectTextBox.Text,
                        Surgery = SurgeryTextBox.Text
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
            if (BirthWeightTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.BirthWeight).DisplayedName());
                return false;
            }
            if (BirthHeightTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.BirthHeight).DisplayedName());
                return false;
            }
            if (BirthHeadSizeTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.BirthHeadSize).DisplayedName());
                return false;
            }
            if (BirthChestSizeTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(patient.BirthChestSize).DisplayedName());
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
            if (ConvulsiveSyndromeYesRadioButton.Checked && ConvulsiveSyndromeDurationTextBox.Text.Length > 0 == false)
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
            RadioButtonCheckedCharged(((RadioButton)sender), ConvulsiveSyndromeDurationTextBox, ConclusiveSyndromeDurationLabel);
        }

        private void BirthDefectYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton)sender), BirthDefectTextBox);
        }

        private void SurgeryYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheckedCharged(((RadioButton)sender), SurgeryTextBox);
        }

        private void IVHDegreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IVHDegreeComboBox.SelectedIndex != 0)
            {
                IVHLocalizationComboBox.Enabled = true;
            }
            else
            {
                IVHLocalizationComboBox.Enabled = false;
            }
        }
    }
}
