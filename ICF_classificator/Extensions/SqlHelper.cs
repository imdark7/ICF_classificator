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

            var table = GetTableNameFor<T>();
            var type = typeof(T);
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
                        list.Add(new Doctor(
                            reader.GetInt32(0), 
                            reader.IsDBNull(1) ? null : reader.GetString(1),
                            reader.IsDBNull(2) ? null : reader.GetString(2),
                            reader.IsDBNull(3) ? null : reader.GetString(3)
                            ));
                    }
                    if (type.IsEquivalentTo(typeof(Patient)))
                    {
                        list.Add(new Patient(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? null : reader.GetString(1),
                            reader.IsDBNull(2) ? null : reader.GetString(2),
                            reader.IsDBNull(3) ? null : reader.GetString(3),
                            reader.GetDateTime(4),
                            reader.IsDBNull(5) ? -1 : reader.GetInt32(5)
                            ));
                    }
                    if (type.IsEquivalentTo(typeof(Derangement)))
                    {
                        list.Add(new Derangement(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.IsDBNull(2) ? null : reader.GetString(2),
                            reader.IsDBNull(3) ? null : reader.GetString(3)
                            ));
                    }
                    if (type.IsEquivalentTo(typeof(MedicalReport)))
                    {
                        list.Add(new MedicalReport(
                            reader.GetInt32(0), 
                            reader.GetInt32(1),
                            reader.GetDateTime(2),
                            reader.IsDBNull(3) ? null : reader.GetString(3), 
                            reader.GetInt32(4)
                            ));
                    }
                    if (type.IsEquivalentTo(typeof(MedicalReportItem)))
                    {
                        list.Add(new MedicalReportItem(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2),
                            (DerangementState)reader.GetInt16(3),
                            reader.IsDBNull(4) ? null : reader.GetString(4)
                            ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            return list;
        }

        //public static T[] Read<T>(string requestCondition = null)
        //{
        //    var sqlConnection = NewConnection();
        //    sqlConnection.OpenAsync();
        //    SqlDataReader reader = null;

        //    var table = GetTableNameFor<T>();
        //    var type = typeof(T);
        //    var command = requestCondition == null
        //        ? new SqlCommand($"SELECT * FROM [{table}]", sqlConnection)
        //        : new SqlCommand($"SELECT * FROM [{table}] WHERE {requestCondition}", sqlConnection);
        //    var list = new ArrayList();
        //    try
        //    {
        //        reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            if (type.IsEquivalentTo(typeof(Doctor)))
        //            {
        //                list.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
        //                    reader.GetString(3)));
        //            }
        //            if (type.IsEquivalentTo(typeof(Patient)))
        //            {
        //                list.Add(new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
        //                    reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5)));
        //            }
        //            if (type.IsEquivalentTo(typeof(Derangement)))
        //            {
        //                list.Add(new Derangement(reader.GetString(0), reader.GetString(1), reader.GetString(2),
        //                    reader.GetString(3)));
        //            }
        //            if (type.IsEquivalentTo(typeof(MedicalReport)))
        //            {
        //                list.Add(new MedicalReport(reader.GetInt32(0), reader.GetInt32(1),
        //                    reader.GetDateTime(2), reader.GetString(3), reader.GetInt32(4)));
        //            }
        //            if (type.IsEquivalentTo(typeof(MedicalReportItem)))
        //            {
        //                list.Add(new MedicalReportItem(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
        //                    (DerangementState)reader.GetInt16(3), reader.GetString(4)));
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        reader?.Close();
        //        sqlConnection.Close();
        //    }
        //    return list.ToArray() as T[];
        //}

        private static string GetTableNameFor<T>()
        {
            var type = typeof(T);
            if (type == null)
            {
                throw new NullReferenceException();
            }
            if (type.IsEquivalentTo(typeof(Doctor)))
            {
                return "Doctors";
            }
            if (type.IsEquivalentTo(typeof(Patient)))
            {
                return "Patients";
            }
            if (type.IsEquivalentTo(typeof(Derangement)))
            {
                return "ICFElements";
            }
            if (type.IsEquivalentTo(typeof(MedicalReport)))
            {
                return "MedicalReport";
            }
            if (type.IsEquivalentTo(typeof(MedicalReportItem)))
            {
                return "MedicalReportItems";
            }
            throw new Exception("Не удалось найти подходящую таблицу данных");
        }

        public static int[] TryInsert<T>(object[] objects)
        {
            var sqlConnection = NewConnection();
            sqlConnection.Open();
            var table = GetTableNameFor<T>();
            var type = typeof(T);
            var ids = new ArrayList();
            SqlCommand command = null;
            try
            {
                if (type.IsEquivalentTo(typeof(Doctor)))
                {
                    foreach (var doctor in (Doctor[]) objects)
                    {
                        command = new SqlCommand($"INSERT INTO [{table}] (LastName, FirstName, SurName)" +
                                                 "OUTPUT INSERTED.Id " +
                                                 "VALUES (@LastName, @FirstName, @SurName)", sqlConnection);
                        command.Parameters.AddWithValue("LastName", doctor.LastName);
                        command.Parameters.AddWithValue("FirstName", doctor.FirstName);
                        command.Parameters.AddWithValue("SurName", doctor.SurName ?? (object) DBNull.Value);

                        ids.Add((int)command.ExecuteScalar());
                    }
                }
                if (type.IsEquivalentTo(typeof(Patient)))
                {
                    foreach (var patient in (Patient[]) objects)
                    {
                        command =
                            new SqlCommand(
                                $"INSERT INTO [{table}] (LastName, FirstName, SurName, BirthDate, DoctorId)" +
                                 "OUTPUT INSERTED.Id " +
                                "VALUES (@LastName, @FirstName, @SurName, @BirthDate, @DoctorId)", sqlConnection);
                        command.Parameters.AddWithValue("LastName", patient.LastName);
                        command.Parameters.AddWithValue("FirstName", patient.FirstName);
                        command.Parameters.AddWithValue("SurName", patient.SurName ?? (object) DBNull.Value);
                        command.Parameters.AddWithValue("BirthDate", patient.BirthDate);
                        command.Parameters.AddWithValue("DoctorId", patient.DoctorId ?? (object) DBNull.Value);

                        ids.Add((int)command.ExecuteScalar());
                    }
                }
                if (type.IsEquivalentTo(typeof(Derangement)))
                {
                    throw new Exception("Попытка сменить данные в ICFElements");
                }
                if (type.IsEquivalentTo(typeof(MedicalReport)))
                {
                    foreach (var report in (MedicalReport[]) objects)
                    {
                        command = new SqlCommand(
                            $"INSERT INTO [{table}] (PatientId, Date, Diagnosis, DoctorId) " +
                            "OUTPUT INSERTED.Id " +
                            "VALUES (@PatientId, @Date, @Diagnosis, @DoctorId)",
                            sqlConnection);
                        command.Parameters.AddWithValue("PatientId", report.PatientId);
                        command.Parameters.AddWithValue("Date", report.Date);
                        command.Parameters.AddWithValue("Diagnosis", report.Diagnosis ?? (object) DBNull.Value);
                        command.Parameters.AddWithValue("DoctorId", report.DoctorId);

                        ids.Add((int)command.ExecuteScalar());
                    }
                }
                if (type.IsEquivalentTo(typeof(MedicalReportItem)))
                {
                    foreach (var reportItem in (MedicalReportItem[]) objects)
                    {
                        command =
                            new SqlCommand(
                                $"INSERT INTO [{table}] (ReportId, ICFElementCode, ICFElementState, Commentary)" +
                                "OUTPUT INSERTED.Id " +
                                "VALUES (@ReportId, @ICFElementCode, @ICFElementState, @Commentary)", sqlConnection);
                        command.Parameters.AddWithValue("ReportId", reportItem.ReportId);
                        command.Parameters.AddWithValue("ICFElementCode", reportItem.DerangementCode);
                        command.Parameters.AddWithValue("ICFElementState", reportItem.DerangementState);
                        command.Parameters.AddWithValue("Commentary", reportItem.Commentary ?? (object) DBNull.Value);

                        ids.Add((int)command.ExecuteScalar());
                    }
                }
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
            var array = new int[ids.Count];
            for (var i = 0; i < ids.Count; i++)
            {
                array[i] = (int)ids[i];
            }
            return array;
        }

        public static void TryUpdate<T>(object[] objects)
        {
            var sqlConnection = NewConnection();
            sqlConnection.Open();
            var table = GetTableNameFor<T>();
            var type = typeof(T);
            try
            {
                SqlCommand command = null;
                if (type.IsEquivalentTo(typeof(Doctor)))
                {
                    foreach (var doctor in (Doctor[])objects)
                    {
                        command = new SqlCommand($"UPDATE [{table}] " +
                                                 "SET [LastName] = @LastName, [FirstName] = @FirstName, [SurName] = @SurName " +
                                                 "WHERE [Id] = @Id", sqlConnection);
                        command.Parameters.AddWithValue("@LastName", doctor.LastName);
                        command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                        command.Parameters.AddWithValue("@SurName", doctor.SurName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Id", doctor.Id);

                        command.ExecuteNonQuery();
                    }
                }
                if (type.IsEquivalentTo(typeof(Patient)))
                {
                    foreach (var patient in (Patient[])objects)
                    {
                        command =
                            new SqlCommand(
                                $"UPDATE [{table}] " +
                                 "SET [LastName] = @LastName, [FirstName] = @FirstName, [SurName] = @SurName, " +
                                "[BirthDate] = @BirthDate, [DoctorId] = @DoctorId " +
                                "WHERE [Id] = @Id", sqlConnection);
                        command.Parameters.AddWithValue("@LastName", patient.LastName);
                        command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                        command.Parameters.AddWithValue("@SurName", patient.SurName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                        command.Parameters.AddWithValue("@DoctorId", patient.DoctorId ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Id", patient.Id);

                        command.ExecuteNonQuery();
                    }
                }
                if (type.IsEquivalentTo(typeof(Derangement)))
                {
                    throw new Exception("Попытка сменить данные в ICFElements");
                }
                if (type.IsEquivalentTo(typeof(MedicalReport)))
                {
                    foreach (var report in (MedicalReport[])objects)
                    {
                        command = new SqlCommand(
                            $"UPDATE [{table}] " +
                            "SET [PatientId] =  @PatientId, [Date] =  @Date, [Diagnosis] = @Diagnosis, [DoctorId] = @DoctorId " +
                            "WHERE [Id] = @Id", sqlConnection);
                        command.Parameters.AddWithValue("@PatientId", report.PatientId);
                        command.Parameters.AddWithValue("@Date", report.Date);
                        command.Parameters.AddWithValue("@Diagnosis", report.Diagnosis ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorId", report.DoctorId);
                        command.Parameters.AddWithValue("@Id", report.Id);

                        command.ExecuteNonQuery();
                    }
                }
                if (type.IsEquivalentTo(typeof(MedicalReportItem)))
                {
                    foreach (var reportItem in (MedicalReportItem[])objects)
                    {
                        command =
                            new SqlCommand(
                                $"UPDATE [{table}] " +
                                "SET [ReportId] = @ReportId, [ICFElementCode] = @ICFElementCode, " +
                                "[ICFElementState] = @ICFElementState, [Commentary] = @Commentary " +
                                "WHERE [Id] = @Id", sqlConnection);
                        command.Parameters.AddWithValue("ReportId", reportItem.ReportId);
                        command.Parameters.AddWithValue("ICFElementCode", reportItem.DerangementCode);
                        command.Parameters.AddWithValue("ICFElementState", reportItem.DerangementState);
                        command.Parameters.AddWithValue("Commentary", reportItem.Commentary ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Id", reportItem.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
        }

        public static void Delete<T>(string columnName, int id)
        {
            var sqlConnection = NewConnection();
            sqlConnection.Open();
            try
            {
                var table = GetTableNameFor<T>();
                var command = new SqlCommand($"DELETE FROM [{table}]" +
                                             $"WHERE [{columnName}] = '{id}'", sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
        }
    }
}
