using ICF_classificator.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICF_classificator
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox1, "LEN(Code) < 2");
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox2, $"ParentCode = '{listBox1.SelectedItem.ToString().Split(' ')[0]}'");
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox3, $"ParentCode = '{listBox2.SelectedItem.ToString().Split(' ')[0]}'");
        }

        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox4, $"ParentCode = '{listBox3.SelectedItem.ToString().Split(' ')[0]}'");
        }

        private void listBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox5, $"ParentCode = '{listBox4.SelectedItem.ToString().Split(' ')[0]}'");
        }

        private void listBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshListBoxData(listBox6, $"ParentCode = '{listBox5.SelectedItem.ToString().Split(' ')[0]}'");
        }

        public async void RefreshListBoxData(ListBoxExtension listbox, string requestCondition)
        {
            listbox.Items.Clear();
            var dict = await GetICFResponseAsync(requestCondition);
            if (dict != null)
            {
                for (var i = 0; i < dict.Count; i++) { listbox.Items.Add(dict.ElementAt(i).Key + " " + dict.ElementAt(i).Value); }
                listbox.Visible = true;
            } else
            {
                listbox.Visible = false;
            }
        }
        /// <summary>        
        /// 
        /// </summary>
        /// <param name="requestCondition">Условие в sql-запросе, то что идет после where</param>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, string>> GetICFResponseAsync(string requestCondition)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dark\Documents\GitHub\ICF_classificator\ICF_classificator\Database1.mdf;Integrated Security=True");//TODO: Нужен абсолютный путь

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            var command = new SqlCommand($"SELECT [Code],[Name] FROM [ICFElements] WHERE {requestCondition}", sqlConnection);
            var dictionary = new Dictionary<string, string>();
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    dictionary.Add(sqlReader["Code"].ToString(), sqlReader["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlReader?.Close();
            }
            return dictionary;
        }
    }
}
