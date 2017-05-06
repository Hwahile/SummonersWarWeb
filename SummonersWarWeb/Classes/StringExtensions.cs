using System.Text.RegularExpressions;

namespace SummonersWarWeb.Classes.StringExtensions
{
    public static class StringExtensions
    {
        public static bool CouldBeBase64String(this string s)
        {
            return Regex.IsMatch(s, @"^[a-zA-Z0-9/+=]+$");
        }

        public static bool IsBase64String(this string s)
        {
            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+]+={0,2}$", RegexOptions.None);
        }

    }
}