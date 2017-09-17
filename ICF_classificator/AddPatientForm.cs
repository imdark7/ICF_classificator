using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class AddPatientForm : Form
    {
        private readonly Form PForm;
        //todo: для рабочего приложения - раскомментить
        //private readonly SqlConnection _sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\Database1.mdf;Integrated Security=True");//TODO: Нужен абсолютный путь;
        private readonly SqlConnection _sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dark\Documents\GitHub\ICF_classificator\ICF_classificator\Database1.mdf;Integrated Security=True");//TODO: Нужен абсолютный путь;

        public AddPatientForm(Form ParentForm)
        {
            InitializeComponent();
            SetDoctors();
            PForm = ParentForm;
        }

        public async void SetDoctors()
        {
            var doctors = await SqlHelper.ReadAsync<Doctor>();
            DoctorComboBox.DataSource = doctors;
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
                        DoctorId = ((Doctor)DoctorComboBox.SelectedItem)?.Id
                    }
                });
                
                Close();
                ((MainForm)PForm).RefreshPatientCombobox();
            }
            else
            {
                WarningLabel.Show();
            }
        }
    }
}
