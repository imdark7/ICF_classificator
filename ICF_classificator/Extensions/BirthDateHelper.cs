using System;

namespace ICF_classificator.Extensions
{
    public static class BirthDateHelper
    {
        public static string GetReportString(this DateTime birthDate)
        {
            var diff = (double)(DateTime.Now - birthDate).Days;
            string age;
            if (diff < 30)
            {
                age = $"{diff} (дни)";
            }
            else if (diff / 30 < 365)
            {
                age = $"{Math.Floor(diff / 30)} (месяцы)";
            }
            else
            {
                var years = (int)Math.Floor(diff / 365);
                var month = (int)Math.Floor(diff % 365 / 30);
                age = month == 0 ? $"{years} (годы)" : $"{years} (годы), {month} (месяцы)";
            }
            return $"{birthDate:dd.MM.yyyy} ({age})";
        }
    }
}