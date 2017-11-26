using System;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;
using ICF_classificator.Models.PatientDataModels;

namespace ICF_classificator
{
    public partial class PatientForm : Form
    {
        private readonly Form _pForm;
        private readonly Patient _patient;

        public PatientForm(Form parentForm, Patient patient = null)
        {
            InitializeComponent();
            _pForm = parentForm;
            CerebralIschemiaComboBox.SelectedIndex = 0;
            IVHDegreeComboBox.SelectedIndex = 0;
            PatientBirthDatePicker.Value = DateTime.Now;
            HospitalizationDatePicker.Value = DateTime.Now;
            if (patient != null)
            {
                _patient = patient;
                CreatePatientButton.Text = @"Редактировать";

                PatientLastNameTextBox.Text = patient.LastName;
                PatientFirstNameTextBox.Text = patient.FirstName;
                PatientSurNameTextBox.Text = patient.SurName;
                switch (patient.Sex)
                {
                    case PatientSex.Male:
                        MaleSexRadioButton.Checked = true;
                        break;
                    case PatientSex.Female:
                        FemaleSexRadioButton.Checked = true;
                        break;
                }
                ParentFIOTextBox.Text = patient.ParentName;
                PatientAddressTextBox.Text = patient.Address;
                PatientBirthDatePicker.Value = patient.BirthDate;
                GestationAgeTextBox.Text = patient.GestationAge.ToString();
                BirthWeightTextBox.Text = patient.BirthWeight.ToString();
                BirthHeightTextBox.Text = patient.BirthHeight.ToString();
                BirthHeadSizeTextBox.Text = patient.BirthHeadSize.ToString();
                BirthChestSizeTextBox.Text = patient.BirthChestSize.ToString();
                ApgarTextBox1.Text = patient.ApgarScale.AfterBirth.ToString();
                ApgarTextBox2.Text = patient.ApgarScale.AfterOneMinute.ToString();
                ApgarTextBox3.Text = patient.ApgarScale.AfterFiveMinute.ToString();
                switch (patient.HasDisability)
                {
                    case NoYesRadioButtonResult.Yes:
                        DisabilityYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        DisabilityNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.IsNotFirstHospitalization)
                {
                    case HospitalizationCount.First:
                        HospitalizationFirstTimeRadioButton.Checked = true;
                        break;
                    case HospitalizationCount.NotFirst:
                        HospitalizationNotFirstTimeRadioButton.Checked = true;
                        break;
                }
                HospitalizationDatePicker.Value = patient.HospitalizationDate;
                if (patient.ALVDuration > 0)
                {
                    ALVYesRadioButton.Checked = true;
                    ALVDutarionTextBox.Text = patient.ALVDuration.ToString();
                }
                if (patient.CPAPDuration > 0)
                {
                    CPAPYesRadioButton.Checked = true;
                    CPAPDurationTextBox.Text = patient.CPAPDuration.ToString();
                }
                CerebralIschemiaComboBox.SelectedIndex = (int) patient.CerebralIschemia;
                IVHDegreeComboBox.SelectedIndex = (int) patient.IVH.Degree;
                IVHLocalizationComboBox.SelectedIndex = (int) patient.IVH.Localization;
                switch (patient.Meningitis)
                {
                    case NoYesRadioButtonResult.Yes:
                        MeningitisYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        MeningitisNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.Encephalitis)
                {
                    case NoYesRadioButtonResult.Yes:
                        EncephalitisYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        EncephalitisNoRadioButton.Checked = true;
                        break;
                }
                if (patient.ConvulsiveSyndromeDuration > 0)
                {
                    ConvulsiveSyndromeYesRadioButton.Checked = true;
                    ConvulsiveSyndromeDurationTextBox.Text = patient.ConvulsiveSyndromeDuration.ToString();
                }
                switch (patient.Sepsis)
                {
                    case NoYesRadioButtonResult.Yes:
                        SepsisYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        SepsisNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.HDN)
                {
                    case NoYesRadioButtonResult.Yes:
                        HDNYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        HDNNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.VKDB)
                {
                    case NoYesRadioButtonResult.Yes:
                        VKDBYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        VKDBNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.Anemia)
                {
                    case NoYesRadioButtonResult.Yes:
                        AnemiaYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        AnemiaNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.Hyperbilirubinemia)
                {
                    case NoYesRadioButtonResult.Yes:
                        HyperbilirubinemiaYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        HyperbilirubinemiaNoRadioButton.Checked = true;
                        break;
                }
                switch (patient.UNEC)
                {
                    case NoYesRadioButtonResult.Yes:
                        UNECYesRadioButton.Checked = true;
                        break;
                    case NoYesRadioButtonResult.No:
                        UNECNoRadioButton.Checked = true;
                        break;
                }
                if (!string.IsNullOrEmpty(patient.BirthDefect))
                {
                    BirthDefectYesRadioButton.Checked = true;
                    BirthDefectTextBox.Text = patient.BirthDefect;
                }
                if (!string.IsNullOrEmpty(patient.Surgery))
                {
                    SurgeryYesRadioButton.Checked = true;
                    SurgeryTextBox.Text = patient.Surgery;
                }
                PatientHistoryTextBox.Text = patient.PatientHistory;
            }
        }

        private void CreatePatientButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                var patientModel = new Patient
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
                    HasDisability =
                        DisabilityNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    IsNotFirstHospitalization =
                        HospitalizationFirstTimeRadioButton.Checked
                            ? HospitalizationCount.First
                            : HospitalizationCount.NotFirst,
                    HospitalizationDate = HospitalizationDatePicker.Value,
                    ALVDuration =
                        ALVYesRadioButton.Checked && ALVDutarionTextBox.Text.Length > 0
                            ? int.Parse(ALVDutarionTextBox.Text)
                            : 0,
                    CPAPDuration =
                        CPAPYesRadioButton.Checked && CPAPDurationTextBox.Text.Length > 0
                            ? int.Parse(CPAPDurationTextBox.Text)
                            : 0,
                    CerebralIschemia = (CerebralIschemiaDegree) CerebralIschemiaComboBox.SelectedIndex,
                    IVH = new IVHModel
                    {
                        Degree = (IVHDegree) IVHDegreeComboBox.SelectedIndex,
                        Localization = (IVHLocalization)IVHLocalizationComboBox.SelectedIndex 
                    },
                    Meningitis =
                        MeningitisNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    Encephalitis =
                        EncephalitisNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    ConvulsiveSyndromeDuration =
                        ConvulsiveSyndromeYesRadioButton.Checked && ConvulsiveSyndromeDurationTextBox.Text.Length > 0
                            ? int.Parse(ConvulsiveSyndromeDurationTextBox.Text)
                            : 0,
                    Sepsis = SepsisNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    HDN = HDNNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    VKDB = VKDBNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    Anemia = AnemiaNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    Hyperbilirubinemia =
                        HyperbilirubinemiaNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    UNEC = UNECNoRadioButton.Checked ? NoYesRadioButtonResult.No : NoYesRadioButtonResult.Yes,
                    BirthDefect = BirthDefectTextBox.Text,
                    Surgery = SurgeryTextBox.Text,
                    PatientHistory = PatientHistoryTextBox.Text
                };
                if (_patient != null)
                {
                    patientModel.Id = _patient.Id;
                    SqlHelper.TryUpdate<Patient>(new object[] {patientModel});
                }
                else
                {
                    SqlHelper.TryInsert<Patient>(new object[] {patientModel});
                }
                
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
                ShowErrorMessage(nameof(_patient.LastName).DisplayedName());
                return false;
            }
            if (PatientFirstNameTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.FirstName).DisplayedName());
                return false;
            }
            if (!MaleSexRadioButton.Checked && !FemaleSexRadioButton.Checked)
            {
                ShowErrorMessage(nameof(_patient.Sex).DisplayedName());
                return false;
            }
            if (ParentFIOTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.ParentName).DisplayedName());
                return false;
            }
            if (PatientAddressTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.Address).DisplayedName());
                return false;
            }
            if (PatientBirthDatePicker.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.BirthDate).DisplayedName());
                return false;
            }
            if (GestationAgeTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.GestationAge).DisplayedName());
                return false;
            }
            if (BirthWeightTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.BirthWeight).DisplayedName());
                return false;
            }
            if (BirthHeightTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.BirthHeight).DisplayedName());
                return false;
            }
            if (BirthHeadSizeTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.BirthHeadSize).DisplayedName());
                return false;
            }
            if (BirthChestSizeTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.BirthChestSize).DisplayedName());
                return false;
            }
            if (ApgarTextBox1.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.ApgarScale).DisplayedName());
                return false;
            }
            if (ApgarTextBox2.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.ApgarScale).DisplayedName());
                return false;
            }
            if (ApgarTextBox3.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.ApgarScale).DisplayedName());
                return false;
            }
            if (HospitalizationDatePicker.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.HospitalizationDate).DisplayedName());
                return false;
            }
            if (ALVYesRadioButton.Checked && ALVDutarionTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.ALVDuration).DisplayedName());
                return false;
            }
            if (CPAPYesRadioButton.Checked && CPAPDurationTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.CPAPDuration).DisplayedName());
                return false;
            }
            if (CerebralIschemiaComboBox.SelectedIndex < 0)
            {
                ShowErrorMessage(nameof(_patient.CerebralIschemia).DisplayedName());
                return false;
            }
            if (IVHDegreeComboBox.SelectedIndex < 0 && IVHLocalizationComboBox.SelectedIndex < 0)
            {
                ShowErrorMessage(nameof(_patient.IVH).DisplayedName());
                return false;
            }
            if (ConvulsiveSyndromeYesRadioButton.Checked && ConvulsiveSyndromeDurationTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.ConvulsiveSyndromeDuration).DisplayedName());
                return false;
            }
            if (BirthDefectYesRadioButton.Checked && BirthDefectTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.BirthDefect).DisplayedName());
                return false;
            }
            if (SurgeryYesRadioButton.Checked && SurgeryTextBox.Text.Length > 0 == false)
            {
                ShowErrorMessage(nameof(_patient.Surgery).DisplayedName());
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
            IVHLocalizationComboBox.Enabled = IVHDegreeComboBox.SelectedIndex != 0;
        }
    }
}
