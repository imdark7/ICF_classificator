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
                age = $"{diff} д";
            }
            else if (diff < 365)
            {
                var month = (int) Math.Floor(diff / 30);
                var days = (int) Math.Floor(diff % 30);
                age = $"{month} м" + (days != 0 ? $", {days} д" : "");
            }
            else
            {
                var years = (int)Math.Floor(diff / 365);
                var month = (int)Math.Floor(diff % 365 / 30);
                age = $"{years} г" + (month != 0 ? $", {month} м" : "");
            }
            return $"{birthDate:dd.MM.yyyy} ({age})";
        }
    }
}