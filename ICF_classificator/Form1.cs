using ICF_classificator.Extensions;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class MainForm : Form
    {
        private int patientId;
        private int doctorId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshDoctorCombobox();
            RefreshPatientCombobox(true);

            RefreshListBoxData(listBox1, "LEN(Code) < 2");
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox2, $"ParentCode = '{((Derangement)((ListBoxExtension)sender).SelectedItem).Code}'");
            ClearListbox(listBox3, listBox4, listBox5, listBox6);
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox3, $"ParentCode = '{((Derangement)((ListBoxExtension)sender).SelectedItem).Code}'");
            ClearListbox(listBox4, listBox5, listBox6);
        }

        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox4, $"ParentCode = '{((Derangement)((ListBoxExtension)sender).SelectedItem).Code}'");
            ClearListbox(listBox5, listBox6);
        }

        private void listBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox5, $"ParentCode = '{((Derangement)((ListBoxExtension)sender).SelectedItem).Code}'");
            ClearListbox(listBox6);
        }

        private void listBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox6, $"ParentCode = '{((Derangement)((ListBoxExtension)sender).SelectedItem).Code}'");
        }

        private async void RefreshListBoxData(ListBoxExtension listbox, string requestCondition)
        {
            listbox.Items.Clear();
            var list = await SqlHelper.ReadAsync<Derangement>(requestCondition);
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    listbox.Items.Add(item);
                }
                listbox.Visible = true;
            }
            else
            {
                listbox.Visible = false;
            }
        }

        private static void ClearListbox(params ListBoxExtension[] listBoxes)
        {
            foreach (var listBox in listBoxes)
            {
                listBox.Items.Clear();
                listBox.Visible = false;
            }
        }

        private void пациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addPatientForm = new AddPatientForm(this);
            addPatientForm.Hide();
            addPatientForm.Show();
        }

        private void врачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addDoctorForm = new AddDoctorForm(this);
            addDoctorForm.Hide();
            addDoctorForm.Show();
        }

        private async void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportsListView.Items.Clear();
            reportsGroupBox.Visible = !(((ComboBox)sender).SelectedIndex < 0);
            if (patientComboBox.SelectedIndex < 0)
            {
                patientId = 0;
                return;
            }
            patientId = (patientComboBox.SelectedItem as Patient).Id;
            var reports = await SqlHelper.ReadAsync<MedicalReport>($"PatientId = {patientId}");
            foreach (MedicalReport report in reports)
            {
                var item = new ListViewItem(report.Date.ToShortDateString());
                item.SubItems.Add(report.Diagnosis);
                reportsListView.Items.Add(item);
            }
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorComboBox.SelectedIndex < 0)
            {
                doctorId = 0;
                reportsGroupBox.Visible = false;
                return;
            }
            doctorId = (doctorComboBox.SelectedItem as Doctor).Id;
        }

        private void createNewReport_Click(object sender, EventArgs e)
        {
            newReportGroupBox.Visible = true;
            reportItemGroupBox.Visible = true;
            ((Button) sender).Enabled = false;
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            var report = new MedicalReport
            {
                PatientId = patientId,
                Date = dateTimePicker1.Value,
                Diagnosis = commentReportTextBox.Text,
                DoctorId = doctorId
            };
            var reportId = SqlHelper.TryInsert<MedicalReport>(new[] {report})[0];
            var reportItems = new MedicalReportItem[newReportDataGridView.RowCount - 1];
            var i = 0;
            foreach (DataGridViewRow row in newReportDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    DerangementState state;
                    switch (row.Cells[2].Value as string)
                    {
                        case "Нарушено":
                            state = DerangementState.Deranged;
                            break;
                        case "Норма":
                            state = DerangementState.Normal;
                            break;
                        default:
                            state = DerangementState.Unknown;
                            break;
                    }
                    reportItems[i] = new MedicalReportItem
                    {
                        DerangementCode = row.Cells[0].Value as string,
                        ReportId = reportId,
                        DerangementState = state,
                        Commentary = row.Cells[3].Value as string
                    };
                    i++;
                }
            }
            SqlHelper.TryInsert<MedicalReportItem>(reportItems);

            RefreshReportsListView();
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var derangement = (((ListBoxExtension) sender).SelectedItem as Derangement);
            newReportDataGridView.Rows.Insert(0, derangement.Code, derangement.Name);
        }

        public async void RefreshPatientCombobox(bool unselect = false)
        {
            patientComboBox.DataSource = await SqlHelper.ReadAsync<Patient>();
            if (unselect)
            {
                patientComboBox.SelectedIndex = -1;
            }
        }

        public async void RefreshDoctorCombobox(bool unselect = false)
        {
            doctorComboBox.DataSource = await SqlHelper.ReadAsync<Doctor>();
            if (unselect)
            {
                doctorComboBox.SelectedIndex = -1;
            }
        }

        public async void RefreshReportsListView()
        {
            reportsListView.Items.Clear();
            var reports = await SqlHelper.ReadAsync<MedicalReport>($"PatientId = {patientId}");
            foreach (MedicalReport report in reports)
            {
                var item = new ListViewItem(report.Date.ToShortDateString());
                item.SubItems.Add(report.Diagnosis);
                reportsListView.Items.Add(item);
            }
            reportsListView.Sorting = SortOrder.Descending;
            reportsListView.Sort();
        }
    }
}
