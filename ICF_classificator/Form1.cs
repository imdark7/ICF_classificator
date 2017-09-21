using ICF_classificator.Extensions;
using System;
using System.Windows.Forms;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class MainForm : Form
    {
        private int patientId;
        private int doctorId;
        private int? reportId;

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

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportsListView.Items.Clear();
            reportsGroupBox.Visible = !(((ComboBox)sender).SelectedIndex < 0);
            if (patientComboBox.SelectedIndex < 0)
            {
                patientId = 0;
                return;
            }
            patientId = (patientComboBox.SelectedItem as Patient).Id;

            RefreshReportsListView();
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
            reportId = null;
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            if (((Button) sender).Text == @"Редактировать отчет")
            {
                dateLabel.Enabled = true;
                dateTimePicker1.Enabled = true;
                reportItemGroupBox.Enabled = true;
                commentReportTextBox.Enabled = true;
                newReportDataGridView.Enabled = true;
                saveReportButton.Text = @"Cохранить отчет";
                reportItemGroupBox.Visible = true;
            }
            else
            {
                int newReportId;
                var report = new MedicalReport
                {
                    PatientId = patientId,
                    Date = dateTimePicker1.Value,
                    Diagnosis = commentReportTextBox.Text,
                    DoctorId = doctorId
                };
                if (reportId != null)
                {
                    report.Id = reportId.Value;
                    SqlHelper.TryUpdate<MedicalReport>(new[] {report});
                    SqlHelper.Delete<MedicalReportItem>("ReportId", reportId.Value);
                    newReportId = reportId.Value;
                    reportId = null;
                }
                else
                {
                    newReportId = SqlHelper.TryInsert<MedicalReport>(new[] {report})[0];
                }
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
                            ReportId = newReportId,
                            DerangementState = state,
                            Commentary = row.Cells[3].Value as string
                        };
                        i++;
                    }
                }

                SqlHelper.TryInsert<MedicalReportItem>(reportItems);

                RefreshReportsListView();
            }
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
                var item = new ListViewItem(report.Id.ToString());
                item.SubItems.Add(report.Date.ToShortDateString());
                item.SubItems.Add(report.Diagnosis);
                reportsListView.Items.Add(item);
            }
            reportsListView.Sorting = SortOrder.Descending;
            reportsListView.Sort();
        }

        private void reportsListView_DoubleClick(object sender, EventArgs e)
        {
            if (((ListView) sender).SelectedIndices.Count == 0)
            {
                return;
            }
            var x = ((ListView) sender).SelectedItems[0];
            if (x.Text != null)
            {
                reportId = int.Parse(x.Text);
                newReportDataGridView.Rows.Clear();
                readReportDetails(reportId);
            }
        }

        private async void readReportDetails(int? reportId)
        {
            var report = (MedicalReport)(await SqlHelper.ReadAsync<MedicalReport>($"Id = {reportId}"))[0];
            newReportGroupBox.Text = $@"Отчет за {report.Date.ToShortDateString()}";
            dateTimePicker1.Value = report.Date;
            dateLabel.Enabled = false;
            dateTimePicker1.Enabled = false;
            reportItemGroupBox.Enabled = false;
            commentReportTextBox.Text = report.Diagnosis;
            commentReportTextBox.Enabled = false;

            var reportItems = await SqlHelper.ReadAsync<MedicalReportItem>($"ReportId = {reportId}");
            foreach (var item in reportItems)
            {
                var reportItem = (MedicalReportItem) item;
                var derangement = (Derangement)(await SqlHelper.ReadAsync<Derangement>($"[Code] = '{reportItem.DerangementCode}'"))[0];
                newReportDataGridView.Rows.Add(reportItem.DerangementCode, derangement.Name, reportItem.DerangementState.DisplayedName(), reportItem.Commentary);
            }
            newReportDataGridView.Enabled = false;
            saveReportButton.Text = @"Редактировать отчет";
            newReportGroupBox.Visible = true;
            reportItemGroupBox.Visible = false;
        }
    }
}
