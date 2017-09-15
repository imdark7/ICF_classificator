namespace ICF_classificator.Models
{
    public class MedicalReportItem
    {
        public int Id;
        public int ReportId;
        public string DerangementCode;
        public DerangementState DerangementState;
        public string Commentary;

        public MedicalReportItem(int id, int reportId, string derangementCode, DerangementState derangementState, string commentary)
        {
            Id = id;
            ReportId = reportId;
            DerangementCode = derangementCode;
            DerangementState = derangementState;
            Commentary = commentary;
        }
    }
}