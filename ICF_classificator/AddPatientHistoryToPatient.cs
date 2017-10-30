using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class AddPatientHistoryToPatient : Form
    {
        private Patient patient;
        public AddPatientHistoryToPatient(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
            PatientNameLabel.Text = $@"№ Истории болезни по пациенту {patient}";
            PatientHistory.Text = patient.PatientHistory;
        }

        private void PatientHistoryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            var textBox = (TextBox) sender;
            AddPatientHistoryButton.Enabled = textBox.Text.Length != 0;
        }

        private void AddPatientHistoryButton_Click(object sender, System.EventArgs e)
        {
            PatientHistory.Text += (PatientHistory.Text.Length > 0 ? ", " : "") + PatientHistoryTextBox.Text;
            SaveButton.Show();
            CancelButton.Show();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            patient.PatientHistory = PatientHistory.Text;
            SqlHelper.TryUpdate<Patient>(new []{patient});
            Close();
        }
    }
}
