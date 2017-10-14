using System;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class AddPatientForm : Form
    {
        private readonly Form _pForm;

        public AddPatientForm(Form parentForm)
        {
            InitializeComponent();
            SetDoctors();
            _pForm = parentForm;
        }

        public void SetDoctors()
        {
            var doctors = SqlHelper.Read<Doctor>();
            DoctorComboBox.DataSource = doctors;
            DoctorComboBox.SelectedIndex = -1;
        }

        private void CreatePatientButton_Click(object sender, EventArgs e)
        {
            if (PatientLastNameTextBox.Text.Length > 0 && PatientFirstNameTextBox.Text.Length > 0)
            {
                SqlHelper.TryInsert<Patient>(new []
                {
                    new Patient
                    {
                        LastName = PatientLastNameTextBox.Text,
                        FirstName = PatientFirstNameTextBox.Text,
                        SurName = PatientSurNameTextBox.Text,
                        BirthDate = PatientBirthDatePicker.Value,
                        DoctorId = ((Doctor)DoctorComboBox.SelectedItem)?.Id,
                        Address = PatientAddressTextBox.Text
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
    }
}
