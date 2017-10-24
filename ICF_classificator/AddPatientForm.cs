using System;
using System.CodeDom;
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
            return
                PatientLastNameTextBox.Text.Length > 0 &&
                PatientFirstNameTextBox.Text.Length > 0 &&
                (MaleSexRadioButton.Checked || FemaleSexRadioButton.Checked);
        }

        private void PatientFormOnlyIntegerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
