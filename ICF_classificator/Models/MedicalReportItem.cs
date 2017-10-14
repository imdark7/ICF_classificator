using System;

namespace ICF_classificator.Models
{
    public class MedicalReportItem
    {
        public long Id;
        public long ReportId;
        public string DerangementCode;
        public DerangementState DerangementState;
        public string Commentary;

        public MedicalReportItem(long id, long reportId, string derangementCode, DerangementState derangementState, string commentary)
        {
            Id = id;
            ReportId = reportId;
            DerangementCode = derangementCode;
            DerangementState = derangementState;
            Commentary = commentary;
        }

        public MedicalReportItem()
        {
        }
    }
}