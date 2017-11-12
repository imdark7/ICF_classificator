namespace ICF_classificator.Extensions
{
    public static class DurationHelper
    {
        public static string GetReportString(this int value)
        {
            return value == 0 ? "Нет" : $"{value} (дни)";
        }
    }
}