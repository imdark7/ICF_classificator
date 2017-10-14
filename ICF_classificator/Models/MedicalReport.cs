using System;

namespace ICF_classificator.Models
{
    public class MedicalReport
    {
        public long Id;
        public long PatientId;
        public DateTime Date;
        public string Diagnosis;
        public long DoctorId;

        public MedicalReport(long id, long patientId, DateTime date, string diagnosis, long doctorId)
        {
            Id = id;
            PatientId = patientId;
            Date = date;
            Diagnosis = diagnosis;
            DoctorId = doctorId;
        }

        public MedicalReport()
        {
            
        }
    }
}
