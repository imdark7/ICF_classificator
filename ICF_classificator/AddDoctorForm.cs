using System;
using System.Windows.Forms;
using ICF_classificator.Extensions;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class AddDoctorForm : Form
    {
        private Form PForm;
        public AddDoctorForm(Form ParentForm)
        {
            InitializeComponent();
            PForm = ParentForm;
        }

        private void CreateDoctorButton_Click(object sender, EventArgs e)
        {
            if (DoctorLastNameTextBox.Text.Length > 0 && DoctorFirstNameTextBox.Text.Length > 0)
            {
                SqlHelper.TryInsert<Doctor>(new []
                {
                    new Doctor
                    {
                        LastName = DoctorLastNameTextBox.Text,
                        FirstName = DoctorFirstNameTextBox.Text,
                        SurName = DoctorSurNameTextBox.Text
                    }
                });

                ((MainForm)PForm)?.RefreshDoctorCombobox();
                Close();
            }
            else
            {
                WarningLabel.Show();
            }
        }
    }
}
