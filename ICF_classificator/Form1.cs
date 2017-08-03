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
            var dict = await GetICFResponse("LEN(Code) < 2");
            for (var i = 0; i < dict.Count; i++) { listBox1.Items.Add(dict.ElementAt(i).Key + " " + dict.ElementAt(i).Value); }  
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox2.Visible = true;

        }

        /// <summary> 
                    
        /// 
        /// </summary>
        /// <param name="requestCondition">Условие в sql-запросе, то что идет после where</param>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, string>> GetICFResponse(string requestCondition)
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
