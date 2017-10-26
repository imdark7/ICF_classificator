using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using ICF_classificator.Models;
using System.Data.SQLite;
using System.IO;
using ICF_classificator.Models.PatientDataModels;
using ICF_classificator.Properties;

namespace ICF_classificator.Extensions
{
    public static class SqlHelper
    {
        private static SQLiteConnection NewSqLiteConnection()
        {
            var stringBuilder = new SQLiteConnectionStringBuilder
            {
                DataSource = "database.sqlite3"
            };
            var connection = new SQLiteConnection(stringBuilder.ConnectionString);
            if (!File.Exists($"./{stringBuilder.DataSource}"))
            {
                SQLiteConnection.CreateFile(stringBuilder.DataSource);
                connection.CreateDb();
            }
            return connection;
        }

        private static void CreateDb(this SQLiteConnection connection)
        {
            try
            {
                connection.Open();
                var command = new SQLiteCommand(Resources.createDb, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                throw;
            }
        }

        public static ArrayList Read<T>(string requestCondition = null)
        {
            var sqlConnection = NewSqLiteConnection();
            sqlConnection.Open();
            SQLiteDataReader reader = null;

            var table = GetTableNameFor<T>();
            var type = typeof(T);
            var command = requestCondition == null 
                ? new SQLiteCommand($"SELECT * FROM [{table}]", sqlConnection)
                : new SQLiteCommand($"SELECT * FROM [{table}] WHERE {requestCondition}", sqlConnection);
            var list = new ArrayList();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
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
                        list.Add(new Patient
                        {
                            Id = reader.GetInt64(0),
                            LastName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            FirstName = reader.IsDBNull(2) ? null : reader.GetString(2),
                            SurName = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Sex = (PatientSex) reader.GetInt32(4),
                            ParentName = reader.GetString(5),
                            Address = reader.GetString(6),
                            BirthDate = reader.GetDateTime(7),
                            GestationAge = reader.GetInt32(8),
                            WeightNewborn = reader.GetInt32(9),
                            HeightNewborn = reader.GetInt32(10),
                            HeadSizeNewborn = reader.GetInt32(11),
                            ChestSizeNewborn = reader.GetInt32(12),
                            ApgarScale = new ApgarResult
                            {
                                AfterBirth = reader.GetInt32(13),
                                AfterOneMinute = reader.GetInt32(14),
                                AfterFiveMinute = reader.GetInt32(15)
                            },
                            Disability = (NoYesRadioButtonResult)reader.GetInt32(16),
                            Hospitalization = (HospitalizationCount)reader.GetInt32(17),
                            HospitalizationDate = reader.GetDateTime(18),
                            ALVDuration = reader.GetInt32(19),
                            CPAPDuration = reader.GetInt32(20),
                            CerebralIschemia = (CerebralIschemiaDegree)reader.GetInt32(21),
                            IVH = new IVHModel
                            {
                              Degree  = (IVHDegree)reader.GetInt32(22),
                              Localization = (IVHLocalization)reader.GetInt32(23)
                            },
                            Meningitis = (NoYesRadioButtonResult)reader.GetInt32(24),
                            Encephalitis = (NoYesRadioButtonResult)reader.GetInt32(25),
                            ConvulsiveSyndromeDuration = reader.GetInt32(26),
                            Sepsis = (NoYesRadioButtonResult)reader.GetInt32(27),
                            HDN = (NoYesRadioButtonResult)reader.GetInt32(28),
                            VKDB = (NoYesRadioButtonResult)reader.GetInt32(29),
                            SevereAnemia = (NoYesRadioButtonResult)reader.GetInt32(30),
                            Hyperbilirubinemia = (NoYesRadioButtonResult)reader.GetInt32(31),
                            UNEC = (NoYesRadioButtonResult)reader.GetInt32(32),
                            BirthDefect = reader.GetString(33),
                            Surgery = reader.GetString(34)
                        });
                        //reader.GetInt32(0),
                        //reader.IsDBNull(1) ? null : reader.GetString(1),
                        //reader.IsDBNull(2) ? null : reader.GetString(2),
                        //reader.IsDBNull(3) ? null : reader.GetString(3),
                        //reader.GetDateTime(4),
                        //reader.IsDBNull(5) ? -1 : reader.GetInt32(5),
                        //reader.IsDBNull(6) ? null : reader.GetString(6)
                        //));
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

        public static long[] TryInsert<T>(object[] objects)
        {
            var sqlConnection = NewSqLiteConnection();
            sqlConnection.Open();
            var table = GetTableNameFor<T>();
            var type = typeof(T);
            var ids = new ArrayList();
            try
            {
                SQLiteCommand command;
                if (type.IsEquivalentTo(typeof(Doctor)))
                {
                    foreach (var doctor in (Doctor[]) objects)
                    {
                        command = new SQLiteCommand($"INSERT INTO [{table}] (LastName, FirstName, SurName)" +
                                                 "VALUES (@LastName, @FirstName, @SurName)", sqlConnection);
                        command.Parameters.AddWithValue("@LastName", doctor.LastName);
                        command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                        command.Parameters.AddWithValue("@SurName", doctor.SurName ?? (object) DBNull.Value);
                        command.ExecuteScalar();
                        ids.Add(sqlConnection.LastInsertRowId);
                    }
                }
                if (type.IsEquivalentTo(typeof(Patient)))
                {
                    foreach (var patient in (Patient[]) objects)
                    {
                        command =
                            new SQLiteCommand(
                                $"INSERT INTO [{table}] (LastName, FirstName, SurName, BirthDate, Address)" +
                                "VALUES (@LastName, @FirstName, @SurName, @BirthDate, @Address)", sqlConnection);
                        command.Parameters.AddWithValue("@LastName", patient.LastName);
                        command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                        command.Parameters.AddWithValue("@SurName", patient.SurName ?? (object) DBNull.Value);
                        command.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                        command.Parameters.AddWithValue("@Address", patient.Address ?? (object) DBNull.Value);
                        command.ExecuteScalar();
                        ids.Add(sqlConnection.LastInsertRowId);
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
                        command = new SQLiteCommand(
                            $"INSERT INTO [{table}] (PatientId, Date, Diagnosis, DoctorId) " +
                            "VALUES (@PatientId, @Date, @Diagnosis, @DoctorId)", sqlConnection);
                        command.Parameters.AddWithValue("@PatientId", report.PatientId);
                        command.Parameters.AddWithValue("@Date", report.Date);
                        command.Parameters.AddWithValue("@Diagnosis", report.Diagnosis ?? (object) DBNull.Value);
                        command.Parameters.AddWithValue("@DoctorId", report.DoctorId);
                        command.ExecuteScalar();
                        ids.Add(sqlConnection.LastInsertRowId);
                    }
                }
                if (type.IsEquivalentTo(typeof(MedicalReportItem)))
                {
                    foreach (var reportItem in (MedicalReportItem[]) objects)
                    {
                        command =
                            new SQLiteCommand(
                                $"INSERT INTO [{table}] (ReportId, ICFElementCode, ICFElementState, Commentary)" +
                                "VALUES (@ReportId, @ICFElementCode, @ICFElementState, @Commentary)", sqlConnection);
                        command.Parameters.AddWithValue("@ReportId", reportItem.ReportId);
                        command.Parameters.AddWithValue("@ICFElementCode", reportItem.DerangementCode);
                        command.Parameters.AddWithValue("@ICFElementState", reportItem.DerangementState);
                        command.Parameters.AddWithValue("@Commentary", reportItem.Commentary ?? (object) DBNull.Value);
                        command.ExecuteScalar();
                        ids.Add(sqlConnection.LastInsertRowId);
                    }
                }
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
            var array = new long[ids.Count];
            for (var i = 0; i < ids.Count; i++)
            {
                array[i] = (long)ids[i];
            }
            return array;
        }

        public static void TryUpdate<T>(object[] objects)
        {
            var sqlConnection = NewSqLiteConnection();
            sqlConnection.Open();
            var table = GetTableNameFor<T>();
            var type = typeof(T);
            try
            {
                SQLiteCommand command;
                if (type.IsEquivalentTo(typeof(Doctor)))
                {
                    foreach (var doctor in (Doctor[])objects)
                    {
                        command = new SQLiteCommand($"UPDATE [{table}] " +
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
                            new SQLiteCommand(
                                $"UPDATE [{table}] " +
                                 "SET " +
                                "[LastName] = @LastName, " +
                                "[FirstName] = @FirstName, " +
                                "[SurName] = @SurName, " +
                                "[BirthDate] = @BirthDate " +
                                "WHERE [Id] = @Id", sqlConnection);
                        command.Parameters.AddWithValue("@LastName", patient.LastName);
                        command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                        command.Parameters.AddWithValue("@SurName", patient.SurName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                        command.Parameters.AddWithValue("@Id", patient.GetId());

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
                        command = new SQLiteCommand(
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
                            new SQLiteCommand(
                                $"UPDATE [{table}] " +
                                "SET [ReportId] = @ReportId, [ICFElementCode] = @ICFElementCode, " +
                                "[ICFElementState] = @ICFElementState, [Commentary] = @Commentary " +
                                "WHERE [Id] = @Id", sqlConnection);
                        command.Parameters.AddWithValue("@ReportId", reportItem.ReportId);
                        command.Parameters.AddWithValue("@ICFElementCode", reportItem.DerangementCode);
                        command.Parameters.AddWithValue("@ICFElementState", reportItem.DerangementState);
                        command.Parameters.AddWithValue("@Commentary", reportItem.Commentary ?? (object)DBNull.Value);
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

        public static void Delete<T>(string columnName, long id)
        {
            var sqlConnection = NewSqLiteConnection();
            sqlConnection.Open();
            try
            {
                var table = GetTableNameFor<T>();
                var command = new SQLiteCommand($"DELETE FROM [{table}]" +
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
