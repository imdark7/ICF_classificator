using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class AddPatientForm : Form
    {
        //todo: для рабочего приложения - раскомментить
        //private readonly SqlConnection _sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\Database1.mdf;Integrated Security=True");//TODO: Нужен абсолютный путь;
        private readonly SqlConnection _sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dark\Documents\GitHub\ICF_classificator\ICF_classificator\Database1.mdf;Integrated Security=True");//TODO: Нужен абсолютный путь;

        public AddPatientForm()
        {
            InitializeComponent();
            SetDoctors();
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
                var command = new SqlCommand("INSERT INTO [Patients] (LastName,FirstName,SurName,BirthDate,DoctorId)" +
                                             "VALUES (@LastName, @FirstName, @SurName, @BirthDate, @DoctorId)", _sqlConnection);
                
                command.Parameters.AddWithValue("LastName", PatientLastNameTextBox.Text);
                command.Parameters.AddWithValue("FirstName", PatientFirstNameTextBox.Text);
                command.Parameters.AddWithValue("SurName", PatientSurNameTextBox.Text ?? "NULL");
                command.Parameters.AddWithValue("BirthDate", PatientBirthDatePicker.Value);
                command.Parameters.AddWithValue("DoctorId", ((Doctor)DoctorComboBox.SelectedItem)?.Id ?? (object) DBNull.Value);

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                Close();
            }
            else
            {
                WarningLabel.Show();
            }
        }
    }
}
