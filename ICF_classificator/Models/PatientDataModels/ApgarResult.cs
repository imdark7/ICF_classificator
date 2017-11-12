namespace ICF_classificator.Models.PatientDataModels
{
    public class ApgarResult
    {
        public int AfterBirth;
        public int AfterOneMinute;
        public int AfterFiveMinute;

        public string GetReportString() => $"{AfterBirth} - {AfterOneMinute} - {AfterFiveMinute}";
    }
}