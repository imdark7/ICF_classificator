using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICF_classificator
{
    public partial class AddDoctorForm : Form
    {
        private readonly SqlConnection _sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dark\Documents\GitHub\ICF_classificator\ICF_classificator\Database1.mdf;Integrated Security=True");//TODO: Нужен абсолютный путь;

        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void CreateDoctorButton_Click(object sender, EventArgs e)
        {
            if (DoctorLastNameTextBox.Text.Length > 0 && DoctorFirstNameTextBox.Text.Length > 0)
            {
                var command = new SqlCommand("INSERT INTO [Doctors] (LastName,FirstName,SurName)" +
                                             "VALUES (@LastName, @FirstName, @SurName)", _sqlConnection);

                command.Parameters.AddWithValue("LastName", DoctorLastNameTextBox.Text);
                command.Parameters.AddWithValue("FirstName", DoctorFirstNameTextBox.Text);
                command.Parameters.AddWithValue("SurName", DoctorSurNameTextBox.Text ?? "NULL");

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
