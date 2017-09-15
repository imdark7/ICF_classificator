using System;
using System.Collections;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICF_classificator.Models;

namespace ICF_classificator.Extensions
{
    public static class SqlHelper
    {
        private static SqlConnection NewConnection()
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                AttachDBFilename = @"C:\Users\Dark\Documents\GitHub\ICF_classificator\ICF_classificator\Database1.mdf",
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                IntegratedSecurity = true
            };

            return new SqlConnection(connectionStringBuilder.ConnectionString);

    }

        public static async Task<ArrayList> ReadAsync<T>(string requestCondition = null)
        {
            var sqlConnection = NewConnection();
            await sqlConnection.OpenAsync();
            SqlDataReader reader = null;

            string table = null;
            var type = typeof(T);
            if(type == null) { throw new NullReferenceException();}
            if (type.IsEquivalentTo(typeof(Doctor))) { table = "Doctors"; }
            if (type.IsEquivalentTo(typeof(Patient))) { table = "Patients"; }
            if (type.IsEquivalentTo(typeof(Derangement))) { table = "Derangements"; }
            if (type.IsEquivalentTo(typeof(MedicalReport))) { table = "MedicalReport"; }
            if (type.IsEquivalentTo(typeof(MedicalReportItem))) { table = "MedicalReportItems"; }
            var command = requestCondition == null
                ? new SqlCommand($"SELECT * FROM [{table}]", sqlConnection)
                : new SqlCommand($"SELECT * FROM [{table}] WHERE {requestCondition}", sqlConnection);
            var list = new ArrayList();
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    if (type.IsEquivalentTo(typeof(Doctor)))
                    {
                        list.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3)));
                    }
                    if (type.IsEquivalentTo(typeof(Patient)))
                    {
                        list.Add(new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5)));
                    }
                    if (type.IsEquivalentTo(typeof(Derangement)))
                    {
                        list.Add(new Derangement(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3)));
                    }
                    if (type.IsEquivalentTo(typeof(MedicalReport)))
                    {
                        list.Add(new MedicalReport(reader.GetInt32(0), reader.GetInt32(1),
                            reader.GetDateTime(2), reader.GetString(3), reader.GetInt32(4)));
                    }
                    if (type.IsEquivalentTo(typeof(MedicalReportItem)))
                    {
                        list.Add(new MedicalReportItem(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                            (DerangementState) reader.GetInt32(3), reader.GetString(4)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
                sqlConnection.Close();
            }
            return list;
        }

        public static T[] Read<T>(string requestCondition = null)
        {
            var sqlConnection = NewConnection();
            sqlConnection.OpenAsync();
            SqlDataReader reader = null;

            string table = null;
            var type = typeof(T);
            if (type == null) { throw new NullReferenceException(); }
            if (type.IsEquivalentTo(typeof(Doctor))) { table = "Doctors"; }
            if (type.IsEquivalentTo(typeof(Patient))) { table = "Patients"; }
            if (type.IsEquivalentTo(typeof(Derangement))) { table = "Derangements"; }
            if (type.IsEquivalentTo(typeof(MedicalReport))) { table = "MedicalReport"; }
            if (type.IsEquivalentTo(typeof(MedicalReportItem))) { table = "MedicalReportItems"; }
            var command = requestCondition == null
                ? new SqlCommand($"SELECT * FROM [{table}]", sqlConnection)
                : new SqlCommand($"SELECT * FROM [{table}] WHERE {requestCondition}", sqlConnection);
            var list = new ArrayList();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (type.IsEquivalentTo(typeof(Doctor)))
                    {
                        list.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3)));
                    }
                    if (type.IsEquivalentTo(typeof(Patient)))
                    {
                        list.Add(new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5)));
                    }
                    if (type.IsEquivalentTo(typeof(Derangement)))
                    {
                        list.Add(new Derangement(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3)));
                    }
                    if (type.IsEquivalentTo(typeof(MedicalReport)))
                    {
                        list.Add(new MedicalReport(reader.GetInt32(0), reader.GetInt32(1),
                            reader.GetDateTime(2), reader.GetString(3), reader.GetInt32(4)));
                    }
                    if (type.IsEquivalentTo(typeof(MedicalReportItem)))
                    {
                        list.Add(new MedicalReportItem(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                            (DerangementState)reader.GetInt32(3), reader.GetString(4)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
                sqlConnection.Close();
            }
            return list.ToArray() as T[];
        }
    }
}
