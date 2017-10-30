using ICF_classificator.Extensions;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using ICF_classificator.Models;

namespace ICF_classificator
{
    public partial class MainForm : Form
    {
        private Patient patient;
        private long doctorId;
        private long? reportId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshDoctorCombobox();
            RefreshPatientCombobox();
            reportsGroupBox.Visible = false;

            RefreshListBoxData(listBox1, "length(Code) < 2");
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

        private void RefreshListBoxData(ListBoxExtension listbox, string requestCondition)
        {
            listbox.Items.Clear();
            var list = SqlHelper.Read<Derangement>(requestCondition);
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
            if (patientComboBox.SelectedIndex < 0)
            {
                patient = null;
                return;
            }
            patient = (patientComboBox.SelectedItem as Patient);
            if (doctorId > -1)
            {
                RefreshReportsListView();
            }
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorComboBox.SelectedIndex > -1)
            {
                doctorId = (doctorComboBox.SelectedItem as Doctor).Id;
                var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings.Remove("DoctorId");
                config.AppSettings.Settings.Add("DoctorId", $"{doctorId}");
                config.Save(ConfigurationSaveMode.Minimal);
            }
            if (patient?.Id != null)
            {
                RefreshReportsListView();
            }
        }

        private void createNewReport_Click(object sender, EventArgs e)
        {
            newReportGroupBox.Visible = true;
            reportItemGroupBox.Visible = true;
            reportId = null;
            saveReportButton.Text = @"Сохранить отчет";
            newReportGroupBox.Text = @"Новый отчет";
            newReportDataGridView.Rows.Clear();
            commentReportTextBox.Clear();
            dateTimePicker1.Value = DateTime.Now;
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
                saveReportButton.Text = @"Cохранить отредактированный отчет";
                reportItemGroupBox.Visible = true;
            }
            else
            {
                if (((Button) sender).Text == @"Сохранить отчет")
                {
                    saveReportButton.Text = @"Cохранить отредактированный отчет";
                }
                var report = new MedicalReport
                {
                    PatientId = patient.Id,
                    Date = dateTimePicker1.Value,
                    Diagnosis = commentReportTextBox.Text,
                    DoctorId = doctorId
                };
                if (reportId != null)
                {
                    report.Id = reportId.Value;
                    SqlHelper.TryUpdate<MedicalReport>(new[] {report});
                    SqlHelper.Delete<MedicalReportItem>("ReportId", reportId.Value);
                }
                else
                {
                    reportId = SqlHelper.TryInsert<MedicalReport>(new[] {report})[0];
                }
                var reportItems = new MedicalReportItem[newReportDataGridView.RowCount - 1];
                var i = 0;
                foreach (DataGridViewRow row in newReportDataGridView.Rows)
                {
                    if (row.Cells[0].Value == null) continue;
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
                        ReportId = (int) reportId,
                        DerangementState = state,
                        Commentary = row.Cells[3].Value as string
                    };
                    i++;
                }

                newReportGroupBox.Text = $@"Отчет за {report.Date.ToShortDateString()}";

                SqlHelper.TryInsert<MedicalReportItem>(reportItems);

                RefreshReportsListView();
            }
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var derangement = (((ListBoxExtension) sender).SelectedItem as Derangement);
            newReportDataGridView.Rows.Insert(0, derangement.Code, derangement.Name);
            newReportDataGridView.ClearSelection();
            newReportDataGridView.Rows[0].Selected = true;
        }

        public void RefreshPatientCombobox()
        {
            patientComboBox.DataSource = SqlHelper.Read<Patient>();
            patientComboBox.SelectedIndex = -1;
            patient = null;
        }

        public void RefreshDoctorCombobox()
        {
            var arrayList = SqlHelper.Read<Doctor>();
            doctorComboBox.DataSource = arrayList;

            var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (config.AppSettings.Settings.AllKeys.Contains("DoctorId"))
            {
                var id = long.Parse(config.AppSettings.Settings["DoctorId"].Value);
                var list = from Doctor doctor in arrayList select doctor;
                if (id > 0 && list.Any(doctor => doctor.Id == id))
                {
                    doctorComboBox.SelectedItem = list.First(doctor => doctor.Id == id);
                    doctorId = id;
                }
                else
                {
                    config.AppSettings.Settings.Remove("DoctorId");
                    config.Save(ConfigurationSaveMode.Minimal);
                    doctorComboBox.SelectedIndex = -1;
                    doctorId = -1;
                }
            }
            else
            {
                doctorComboBox.SelectedIndex = -1;
                doctorId = -1;
            }
        }

        public ContextMenuStrip GetReportsContextMenu()
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem {Text = @"Удалить отчет"});
            contextMenu.Items[0].Click += (sender, args) =>
            {
                var reportId = int.Parse(reportsListView.SelectedItems[0].Text);
                var reportDate = reportsListView.SelectedItems[0].SubItems[1].Text;
                var patientName = patientComboBox.SelectedItem.ToString();
                var dialog = MessageBox.Show(reportsListView, $@"Вы действительно хотите удалить отчет пациента {patientName} за {reportDate} ?", @"Удаление отчета", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (dialog == DialogResult.No)
                {
                    return;
                }
                if (dialog == DialogResult.Yes)
                {
                    SqlHelper.Delete<MedicalReport>("Id", reportId);
                    RefreshReportsListView();
                }
            };
            return contextMenu;
        }

        public void RefreshReportsListView()
        {
            reportsGroupBox.Visible = !(doctorComboBox.SelectedIndex < 0) && !(patientComboBox.SelectedIndex < 0);
            reportsListView.Items.Clear();
            var reports = SqlHelper.Read<MedicalReport>($"PatientId = {patient.Id}");
            foreach (MedicalReport report in reports)
            {
                var item = new ListViewItem(report.Id.ToString());
                item.SubItems.Add(report.Date.ToShortDateString());
                item.SubItems.Add(report.Diagnosis);
                var doctor = (Doctor)SqlHelper.Read<Doctor>($"Id = {report.DoctorId}")[0];
                item.SubItems.Add(doctor.ToShortString());
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
                reportId = long.Parse(x.Text);
                newReportDataGridView.Rows.Clear();
                readReportDetails(reportId);
            }
        }

        private void readReportDetails(long? reportId)
        {
            var report = (MedicalReport)(SqlHelper.Read<MedicalReport>($"Id = {reportId}"))[0];
            newReportGroupBox.Text = $@"Отчет за {report.Date.ToShortDateString()}";
            dateTimePicker1.Value = report.Date;
            dateLabel.Enabled = false;
            dateTimePicker1.Enabled = false;
            reportItemGroupBox.Enabled = false;
            commentReportTextBox.Text = report.Diagnosis;
            commentReportTextBox.Enabled = false;

            var reportItems = SqlHelper.Read<MedicalReportItem>($"ReportId = {reportId}");
            foreach (var item in reportItems)
            {
                var reportItem = (MedicalReportItem) item;
                var derangement = (Derangement)(SqlHelper.Read<Derangement>($"[Code] = '{reportItem.DerangementCode}'"))[0];
                newReportDataGridView.Rows.Add(reportItem.DerangementCode, derangement.Name, reportItem.DerangementState.DisplayedName(), reportItem.Commentary);
            }
            newReportDataGridView.Enabled = false;
            saveReportButton.Text = @"Редактировать отчет";
            newReportGroupBox.Visible = true;
            reportItemGroupBox.Visible = false;
        }

        private void reportsListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && reportsListView.SelectedItems.Count > 0)
            {
                GetReportsContextMenu().Show(reportsListView, e.Location);
            }
        }

        private void addCaseHistory_Click(object sender, EventArgs e)
        {
            new AddPatientHistoryToPatient(patient).Show();
        }
    }
}
