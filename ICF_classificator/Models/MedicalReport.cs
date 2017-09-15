using System;

namespace ICF_classificator.Models
{
    public class MedicalReport
    {
        public int Id;
        public int PatientId;
        public DateTime Date;
        public string Diagnosis;
        public int DoctorId;

        public MedicalReport(int id, int patientId, DateTime date, string diagnosis, int doctorId)
        {
            Id = id;
            PatientId = patientId;
            Date = date;
            Diagnosis = diagnosis;
            DoctorId = doctorId;
        }
    }
}
